using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class WarehouseStock : IManager
    {

        private List<Stock> WarehouseStocks;

        public WarehouseStock()
        {
            WarehouseStocks = new List<Stock>();
        }
        public bool Add(object obj)
        {
            if (obj is Stock)
            {
                Stock b = (Stock)obj;
                foreach (Stock s in WarehouseStocks)
                {
                    if (s.ID == b.ID)
                    {
                        return false;
                    }
                }
                    WarehouseStocks.Add((Stock)obj);
                    return true;
            }
            return false;
        }

        public List<object> GetAllPerType()
        {
            List<object> temp = new List<object>();

            foreach (Stock item in WarehouseStocks)
            {
                temp.Add(item);
            }
            return temp;
        }

        public bool Remove(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
