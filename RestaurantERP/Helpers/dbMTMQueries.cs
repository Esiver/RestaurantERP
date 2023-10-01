using Microsoft.Data.SqlClient;
using RestaurantERP.Classes;
using RestaurantERP.Classes.mtmRelations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantERP.Helpers
{
    internal class dbMTMQueries
    {
        private static string connectionString = Environment.connectionString;
        private static string mtmStockpileStockitemsTable = Environment.stockpileStockItemsTable;

        public static int AddStockitemStockpileRelation(StockitemStockpileRelation stockitemStockpileRelation)
        {
            int modifiedId;
            int stockpileId = stockitemStockpileRelation.StockpileId;
            int stockitemId = stockitemStockpileRelation.StockitemId;

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"INSERT INTO {mtmStockpileStockitemsTable} (StockpileId, StockitemId) VALUES (@StockpileId, @StockitemId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StockpileId", stockpileId);
                command.Parameters.AddWithValue("@StockitemId", stockitemId);

                connection.Open();
                //command.ExecuteNonQuery();

                modifiedId = Convert.ToInt32(command.ExecuteScalar());
            }

            return modifiedId;
        }
    }
}
