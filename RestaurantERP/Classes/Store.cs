using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantERP.Classes
{
    internal class Store
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Stockpile> Stockpiles { get; set; }
        public DateTime CreatedAt { get; set; }

        public Store(int id, string title, string description, List<Stockpile> stockpiles, DateTime createdAt)
        {
            Id = id;
            Title = title;
            Description = description;
            Stockpiles = stockpiles;
            CreatedAt = createdAt;
        }


    }
}
