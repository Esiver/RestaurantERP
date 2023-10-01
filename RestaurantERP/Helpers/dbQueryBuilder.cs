using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantERP.Helpers
{
    internal class dbQueryBuilder
    {
        public static string listQueryFromIntList(List<int> list)
        {
            string query = "";
            query = "(" + string.Join(",", list) + ")";

            return query;
        }
    }
}
