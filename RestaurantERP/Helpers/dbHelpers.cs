using Microsoft.Data.SqlClient;
using RestaurantERP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantERP.Helpers
{
    internal class dbHelpers
    {
        private static string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=RisskovRismaskine;Integrated Security=True";

        // tables
        private static string storeTable = "[dbo].[Store]"; // hvilke butikker har vi
        private static string stockpileTable = "[dbo].[Stockpile]"; // Hvilke lagere har vi
        private static string stockItemTable = "[dbo].[StockItem]"; // Hvilke ting har vi på lager
        private static string productsTable = "[dbo].[Product]"; // Hvilke produkter bliver solgt til kunder

        //many to many tables
        private static string storeStockpilesTable = "[dbo].[StoreStockpiles]"; // hvilke stockpiles har stores
        private static string stockpileStockItemsTable = "[dbo].[StockpileStockItems]"; // hvilke stockitems har stockpiles
        private static string productStockItemMaterialsTable = "[dbo].[ProductStockItemMaterial]"; // hvilke stockitems skal storeproducts bruge
        private static string storeProductsTable = "[dbo].[StoreProduct]"; // Hvilke butikker sælger hvilke varer.
        
        
        public static List<Store> GetAllStores()
        {
            List<Store> stores = new List<Store>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"SELECT * FROM {storeTable}";
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int storeId = reader.GetInt32(0);
                        string storeTitle = reader.GetString(1);
                        string storeDescription = reader.GetString(2);
                        DateTime storeCreatedAt = reader.GetDateTime(3);
                        
                        // todo: stockpiles
                        List<Stockpile> stockpiles = new List<Stockpile>();

                        Store store = new Store(storeId, storeTitle, storeDescription, stockpiles,storeCreatedAt);
                        stores.Add(store);
                    }
                }
            }
            return stores;
        }


        

       
        public static List<int> GetProductStockItemMaterialsMtmIds(StoreProduct product)
        {
            List<int> stockitemIds = new List<int>();


            string mtmSqlQuery = $"SELECT * FROM {productStockItemMaterialsTable} WHERE productId = {product.Id}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand mtmSqlCommand = new SqlCommand(mtmSqlQuery, connection);
                connection.Open();
                SqlDataReader mtmReader = mtmSqlCommand.ExecuteReader();

                if (mtmReader.HasRows)
                {
                    while (mtmReader.Read())
                    {
                        int mtmStockitemId = mtmReader.GetInt32(2);

                        stockitemIds.Add(mtmStockitemId);
                    }
                }
            }

            return stockitemIds;
        }

        

        
        public static List<StockItem> GetStoreStockitems(Store store)
        {
            List<StockItem> stockItems = new List<StockItem>();

            using (SqlConnection connection = new SqlConnection(connectionString)) 
            { 
                //string 
                //SqlCommand sqlCommand = new SqlCommand(sq)

            }

            return stockItems;
        }
        //public static List<StockItem> GetStockpileStockItems(Stockpile stockpile) { }
        //public static List<Stockpile> GetStoreStockPile (Store store) { }
    }
}
