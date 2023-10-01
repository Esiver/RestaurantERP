using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantERP.Classes
{
    internal class StockItem
    {
        public int Id { get; set; }
        public string SKUString { get ; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Origin { get; set; }
        public decimal BuyPrice { get; set; }
        public int Volume { get; set; }
        public int SizeGram { get; set; }
        public string LocationInStockpile { get; set; }
        public DateTime OriginDate { get; set; }
        public DateTime LastChange { get; set; }
        public DateTime ExpirationDate { get; set; }

        public StockItem(int id, string sKUString, string title, string description, string origin, decimal buyPrice, int volume, int sizeGram, string locationInStockpile, DateTime originDate, DateTime lastChange, DateTime expirationDate)
        {
            Id = id;
            SKUString = sKUString;
            Title = title;
            Description = description;
            Origin = origin;
            BuyPrice = buyPrice;
            Volume = volume;
            SizeGram = sizeGram;
            LocationInStockpile = locationInStockpile;
            OriginDate = originDate;
            LastChange = lastChange;
            ExpirationDate = expirationDate;
        }
    }
}
