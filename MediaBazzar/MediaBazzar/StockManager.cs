using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    class StockManager : IManager
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
                Stocks.Add((Stock)obj);
                return true;
            }
            return false;
        }

        public List<object> GetAllPerType(Type type)
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
