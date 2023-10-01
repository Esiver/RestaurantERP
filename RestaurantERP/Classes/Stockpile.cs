using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantERP.Classes
{
    internal class Stockpile
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<StockItem> Stockitems { get; set; }

        public Stockpile(int id, string title, string description, List<StockItem> stockitems)
        {
            Id = id;
            Title = title;
            Description = description;
            Stockitems = stockitems;

        }
    }
}
