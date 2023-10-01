using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantERP.Classes.mtmRelations
{
    internal class StockitemStockpileRelation
    {
        public int Id { get; set; }
        public int StockitemId { get; set; }
        public int StockpileId { get; set; }

        public StockitemStockpileRelation( int stockitemId, int stockpileId)
        {
            Id = 0;
            StockitemId = stockitemId;
            StockpileId = stockpileId;
        }
    }
}
