using RestaurantERP.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantERP.UIFunctions
{
    public static class WindowHandlers
    {
        public static void openSalesWindow()
        {
            Console.WriteLine("open sales window");

            SalesWindow salesWindow = new SalesWindow();
            salesWindow.Show();
        }
        public static void closeSalesWindow()
        {
            // ....
        }

        public static void openStockitemsWindow()
        {
            StockitemsWindow stockitemsWindow = new StockitemsWindow();
            stockitemsWindow.Show();
        }
        public static void closeStockitemsWindow()
        {
            // ...
        }
    }


}
