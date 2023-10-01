using RestaurantERP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantERP.Helpers
{
    internal class ObjectHelpers
    {
        

        public static List<int> GetProductIds(List<StoreProduct> products)
        {
            List<int> ids = new List<int>();
            foreach (StoreProduct product in products) { ids.Add(product.Id); }
            return ids;
        }
        public static List<int> GetStockitemIds(List<StockItem> stockItems)
        {
            List<int> ids = new List<int>();
            foreach (StockItem item in stockItems) { ids.Add(item.Id); }
            return ids;
        }
    }
}
