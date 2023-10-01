using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantERP.Classes
{
    
    internal class StoreProduct
    {
        public int Id { get; set; }
        public string SKUString { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<StockItem> FoodMaterials { get; set; }
        public List<StockItem> PackagingMaterials { get; set; }
        public decimal SellPrice { get; set; }
        public decimal CostPrice { get; set; }

        public StoreProduct(int id, string sKUString, string title, string description, List<StockItem> foodMaterials, List<StockItem> packagingMaterials, decimal sellPrice, decimal costPrice)
        {
            Id = id;
            SKUString = sKUString;
            Title = title;
            Description = description;
            FoodMaterials = foodMaterials;
            PackagingMaterials = packagingMaterials;
            SellPrice = sellPrice;
            CostPrice = costPrice;
        }
    }
}
