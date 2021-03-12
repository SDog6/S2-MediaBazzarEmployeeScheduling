using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzarProect
{
    class WarehouseManager
    {
        WarehouseManager m;
        StockManager s;
        public StockManager GetStockManager { get { return s; } }
    }
}
