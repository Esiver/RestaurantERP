using Microsoft.Data.SqlClient;
using RestaurantERP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantERP.Helpers
{
    internal class dbStockpileQueries
    {
        private static string connectionString = Environment.connectionString;
        private static string stockpileTable = Environment.stockpileTable;
        public static List<Stockpile> GetAllStockpiles()
        {
            List<Stockpile> stockpiles = new List<Stockpile>();
            
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string stockpileSqlQuery = $"SELECT * FROM {stockpileTable}";

                SqlCommand sqlCommand = new SqlCommand(stockpileSqlQuery, connection);
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int stockpileId = reader.GetInt32(0);
                        string stockpileTitle = reader.GetString(1);
                        string stockpileDescription = reader.GetString(2);
                        List<StockItem> stockItems = new List<StockItem>();

                        Stockpile stockpile = new Stockpile(stockpileId, stockpileTitle, stockpileDescription, stockItems);
                        stockpiles.Add(stockpile);
                    }
                }
            }


            return stockpiles;
        }

    }
}
