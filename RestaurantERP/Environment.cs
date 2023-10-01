using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantERP
{
    internal class Environment
    {
        public static string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=RisskovRismaskine;Integrated Security=True";

        public static string storeTable = "[dbo].[Store]"; // hvilke butikker har vi
        public static string stockpileTable = "[dbo].[Stockpile]"; // Hvilke lagere har vi
        public static string stockItemTable = "[dbo].[StockItem]"; // Hvilke ting har vi på lager
        public static string productsTable = "[dbo].[Product]"; // Hvilke produkter bliver solgt til kunder

        public static string storeStockpilesTable = "[dbo].[StoreStockpiles]"; // hvilke stockpiles har stores
        public static string stockpileStockItemsTable = "[dbo].[StockpileStockItems]"; // hvilke stockitems har stockpiles
        public static string productStockItemMaterialsTable = "[dbo].[ProductStockItemMaterial]"; // hvilke stockitems skal storeproducts bruge
        public static string storeProductsTable = "[dbo].[StoreProduct]"; // Hvilke butikker sælger hvilke varer.
    }
}
