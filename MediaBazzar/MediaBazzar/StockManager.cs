using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class StockManager : IManager
    {

        private List<Stock> Stocks;

        public StockManager()
        {
            Stocks = new List<Stock>();
        }
        public bool Add(object obj)
        {
            if (obj is Stock)
            {
                Stock b = (Stock)obj;
                foreach (Stock s in Stocks)
                {
                    if (s.ID == b.ID)
                    {
                        return false;
                    }
                }
                    Stocks.Add((Stock)obj);
                    return true;
            }
            return false;
        }

        public List<object> GetAllPerType()
        {
            List<object> temp = new List<object>();

            foreach (Stock item in Stocks)
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
