using Microsoft.Data.SqlClient;
using RestaurantERP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantERP.Helpers
{
    internal class dbStockitemQueries
    {
        private static string connectionString = Environment.connectionString;

        private static string stockpileStockItemsTable = Environment.stockpileStockItemsTable;
        private static string stockItemTable = Environment.stockItemTable;

        private static string productStockItemMaterialsTable = Environment.productStockItemMaterialsTable;

        
        public static int AddStockitem(StockItem stockitem)
        {
            int modifiedId;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"INSERT INTO {stockItemTable} (SkuString, Title, Description, Origin, BuyPrice, Volume, SizeGram, LocationInStockpile, OriginDate, LastChange, ExpirationDate) VALUES (@SkuString, @Title, @Description, @Origin, @BuyPrice, @Volume, @SizeGram, @LocationInStockpile, @OriginDate, @LastChange, @ExpirationDate); SELECT SCOPE_IDENTITY();";
                SqlCommand command = new SqlCommand(query, connection); 

                command.Parameters.AddWithValue("@SkuString", stockitem.SKUString);
                command.Parameters.AddWithValue("@Title", stockitem.Title);
                command.Parameters.AddWithValue("@Description", stockitem.Description);
                command.Parameters.AddWithValue("@Origin", stockitem.Origin);
                command.Parameters.AddWithValue("@BuyPrice", stockitem.BuyPrice);
                command.Parameters.AddWithValue("@Volume", stockitem.Volume);
                command.Parameters.AddWithValue("@SizeGram", stockitem.SizeGram);
                command.Parameters.AddWithValue("@LocationInStockpile", stockitem.LocationInStockpile);
                command.Parameters.AddWithValue("@OriginDate", stockitem.OriginDate);
                command.Parameters.AddWithValue("@LastChange", stockitem.LastChange);
                command.Parameters.AddWithValue("@ExpirationDate", stockitem.ExpirationDate);
                
                connection.Open();
                //command.ExecuteNonQuery();

                modifiedId = Convert.ToInt32(command.ExecuteScalar());

                connection.Close();
            }
            return modifiedId;
        }

        public static List<StockItem> GetStockpileAllStockitems(Stockpile stockpile)
        {
            List<StockItem> stockItems = new List<StockItem> { };
            List<int> stockitemIds = new List<int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string mtmQuery = $"SELECT * FROM {stockpileStockItemsTable} WHERE StockpileId = {stockpile.Id}";
                SqlCommand mtmSqlCommand = new SqlCommand(mtmQuery, connection);
                connection.Open();
                SqlDataReader mtmReader = mtmSqlCommand.ExecuteReader();

                if (mtmReader.HasRows)
                {
                    while (mtmReader.Read())
                    {
                        int stockitemId = mtmReader.GetInt32(0);
                        stockitemIds.Add(stockitemId);
                    }
                }

                connection.Close();


                string stockitemsQuery = $"SELECT * FROM {stockItemTable} WHERE Id in {Helpers.dbQueryBuilder.listQueryFromIntList(stockitemIds)}";
                SqlCommand stockitemsSqlCommand = new SqlCommand(stockitemsQuery, connection);
                connection.Open();
                SqlDataReader stockitemReader = stockitemsSqlCommand.ExecuteReader();

                if (stockitemReader.HasRows)
                {
                    while (stockitemReader.Read())
                    {

                        int stockitemId = stockitemReader.GetInt32(0);
                        string stockitemSku = stockitemReader.GetString(1);
                        string stockitemTitle = stockitemReader.GetString(2);
                        string stockitemDescription = stockitemReader.GetString(3);
                        string stockitemOrigin = stockitemReader.GetString(4);
                        decimal stockitemBuyPrice = stockitemReader.GetDecimal(5);
                        int stockitemVolume = stockitemReader.GetInt32(6);
                        int stockitemSizeGram = stockitemReader.GetInt32(7);
                        string stockitemLocationInStockpile = stockitemReader.GetString(8);
                        DateTime stockitemOriginDate = stockitemReader.GetDateTime(9);
                        DateTime stockitemLastChange = stockitemReader.GetDateTime(10);
                        DateTime stockitemExpireDate = stockitemReader.GetDateTime(11);

                        StockItem stockItem = new StockItem(
                            stockitemId,
                            stockitemSku,
                            stockitemTitle,
                            stockitemDescription,
                            stockitemOrigin,
                            stockitemBuyPrice,
                            stockitemVolume,
                            stockitemSizeGram,
                            stockitemLocationInStockpile,
                            stockitemOriginDate,
                            stockitemLastChange,
                            stockitemExpireDate
                        );

                        stockItems.Add(stockItem);
                    }
                }
            }

            return stockItems;
        }

        public static List<StockItem> GetProductRequiredStockitems (List<StoreProduct> products)
        {
            List<int> productIds = new List<int>();
            products.ForEach(product => productIds.Add(product.Id));

            List<int> stockitemIds = GetStockItemIdsFromProductIds(productIds);
            List<StockItem> stockitems = GetProductStockItemMaterialsFromProductIds(stockitemIds);


            return stockitems;

        }

        public static List<int> GetStockItemIdsFromProductIds(List<int> productIds)
        {
            List<int> stockItemIds = new List<int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string mtmQuery = $"SELECT * FROM {productStockItemMaterialsTable} WHERE StoreProductId in {Helpers.dbQueryBuilder.listQueryFromIntList(productIds)}";
                SqlCommand mtmCommand = new SqlCommand(mtmQuery, connection);
                connection.Open();
                SqlDataReader mtmReader = mtmCommand.ExecuteReader();

                if (mtmReader.HasRows)
                {
                    while (mtmReader.Read())
                    {
                        int stockitemId = mtmReader.GetInt32(2);
                        stockItemIds.Add(stockitemId);
                    }
                }
            }

            return stockItemIds;
        }
        public static List<StockItem> GetProductStockItemMaterialsFromProductIds(List<int> stockitemIds)
        {
            List<StockItem> stockItems = new List<StockItem>();


            string stockItemsQuery;
            if (stockitemIds.Count > 0) {
                stockItemsQuery = $"SELECT * FROM {stockItemTable} WHERE Id IN {Helpers.dbQueryBuilder.listQueryFromIntList(stockitemIds)}";
            } else
            {
                stockItemsQuery = $"SELECT * FROM {stockItemTable}";
            }
                

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand stockitemSqlCommand = new SqlCommand(stockItemsQuery, connection);
                connection.Open();
                SqlDataReader stockitemReader = stockitemSqlCommand.ExecuteReader();

                if (stockitemReader.HasRows)
                {
                    while (stockitemReader.Read())
                    {
                        int stockitemId = stockitemReader.GetInt32(0);
                        string stockitemSku = stockitemReader.GetString(1);
                        string stockitemTitle = stockitemReader.GetString(2);
                        string stockitemDescription = stockitemReader.GetString(3);
                        string stockitemOrigin = stockitemReader.GetString(4);
                        decimal stockitemBuyPrice = stockitemReader.GetDecimal(5);
                        int stockitemVolume = stockitemReader.GetInt32(6);
                        int stockitemSizeGram = stockitemReader.GetInt32(7);
                        string stockitemLocationInStockpile = stockitemReader.GetString(8);
                        DateTime stockitemOriginDate = stockitemReader.GetDateTime(9);
                        DateTime stockitemLastChange = stockitemReader.GetDateTime(10);
                        DateTime stockitemExpireDate = stockitemReader.GetDateTime(11);

                        StockItem stockItem = new StockItem(
                            stockitemId,
                            stockitemSku,
                            stockitemTitle,
                            stockitemDescription,
                            stockitemOrigin,
                            stockitemBuyPrice,
                            stockitemVolume,
                            stockitemSizeGram,
                            stockitemLocationInStockpile,
                            stockitemOriginDate,
                            stockitemLastChange,
                            stockitemExpireDate
                        );

                        stockItems.Add(stockItem);

                    }
                }
                connection.Close();
            }

            return stockItems;
        }

        public static List<StockItem> GetAllStockItems()
        {
            List<StockItem> stockItems = new List<StockItem>();

            string sqlQuery = $"SELECT * FROM {stockItemTable}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader stockitemReader = sqlCommand.ExecuteReader();
                if (stockitemReader.HasRows)
                {
                    while (stockitemReader.Read())
                    {
                        int stockitemId = stockitemReader.GetInt32(0);
                        string stockitemSku = stockitemReader.GetString(1);
                        string stockitemTitle = stockitemReader.GetString(2);
                        string stockitemDescription = stockitemReader.GetString(3);
                        string stockitemOrigin = stockitemReader.GetString(4);
                        decimal stockitemBuyPrice = stockitemReader.GetDecimal(5);
                        int stockitemVolume = stockitemReader.GetInt32(6);
                        int stockitemSizeGram = stockitemReader.GetInt32(7);
                        string stockitemLocationInStockpile = stockitemReader.GetString(8);
                        DateTime stockitemOriginDate = stockitemReader.GetDateTime(9);
                        DateTime stockitemLastChange = stockitemReader.GetDateTime(10);
                        DateTime stockitemExpireDate = stockitemReader.GetDateTime(11);

                        StockItem stockItem = new StockItem(
                            stockitemId,
                            stockitemSku,
                            stockitemTitle,
                            stockitemDescription,
                            stockitemOrigin,
                            stockitemBuyPrice,
                            stockitemVolume,
                            stockitemSizeGram,
                            stockitemLocationInStockpile,
                            stockitemOriginDate,
                            stockitemLastChange,
                            stockitemExpireDate
                            );

                        stockItems.Add(stockItem);
                    }
                }
                connection.Close();

            }


            return stockItems;
        }

    }
}
