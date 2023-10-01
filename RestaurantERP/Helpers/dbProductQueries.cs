using Microsoft.Data.SqlClient;
using RestaurantERP.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantERP.Helpers
{
    internal class dbProductQueries
    {
        private static string connectionString = Environment.connectionString;
        private static string productsTable = Environment.productsTable;
        private static string storeProductsTable = Environment.storeProductsTable;

        public static List<StoreProduct> GetStoreProducts(Store store)
        {
            int storeId = store.Id;

            List<StoreProduct> storeProducts = new List<StoreProduct>();
            List<int> storeProductIds = new List<int>();



            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                // få fat i alle produkter der er linket til denne butik
                string mtmSqlQuery =
                    $"SELECT * FROM {storeProductsTable} WHERE StoreId = {storeId}";

                SqlCommand mtmSqlCommand = new SqlCommand(mtmSqlQuery, connection);
                connection.Open();
                SqlDataReader mtmReader = mtmSqlCommand.ExecuteReader();

                if (mtmReader.HasRows)
                {
                    while (mtmReader.Read())
                    {
                        int mtmProductId = mtmReader.GetInt32(2);
                        storeProductIds.Add(mtmProductId);
                    }
                }
                connection.Close();

                string productSqlQuery;
                if (storeProductIds.Count > 0)
                {
                    productSqlQuery = $"SELECT * FROM {productsTable} WHERE Id IN {Helpers.dbQueryBuilder.listQueryFromIntList(storeProductIds)}";
                } else
                {
                    productSqlQuery = $"SELECT * FROM {productsTable}";
                }
                
                SqlCommand productSqlCommand = new SqlCommand(productSqlQuery, connection);
                connection.Open();
                Debug.WriteLine(productSqlQuery, productSqlCommand.CommandType);
                SqlDataReader productReader = productSqlCommand.ExecuteReader();
                if (productReader.HasRows)
                {
                    while (productReader.Read())
                    {
                        int productId = productReader.GetInt32(0);
                        string productSku = productReader.GetString(1);
                        string productTitle = productReader.GetString(2);
                        string productDescription = productReader.GetString(3);
                        decimal productSellPrice = productReader.GetDecimal(4);
                        decimal productCostPrice = productReader.GetDecimal(5);
                        List<StockItem> foodStockitem = new List<StockItem>() { };
                        List<StockItem> packagingStockitem = new List<StockItem>() { };


                        StoreProduct storeProduct = new StoreProduct(productId, productSku, productTitle, productDescription, foodStockitem, packagingStockitem, productSellPrice, productCostPrice);
                        storeProducts.Add(storeProduct);
                    }
                }
            }



            return storeProducts;
        }
    }
}
