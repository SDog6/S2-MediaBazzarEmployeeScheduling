using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    class ShopStock
    {

        private List<Stock> ShopStocks;

        public ShopStock()
        {
            ShopStocks = new List<Stock>();
        }
        public bool Add(object obj)
        {
            if (obj is Stock)
            {
                Stock b = (Stock)obj;
                foreach (Stock s in ShopStocks)
                {
                    if (s.ID == b.ID)
                    {
                        return false;
                    }
                }
                ShopStocks.Add((Stock)obj);
                return true;
            }
            return false;
        }

        public Stock GetSpecificStock(int id)
        {
            foreach (Stock s in ShopStocks)
            {
                if(id == s.ID)
                {
                    return s;
                }
            }
            return null;
        }

        public List<object> GetAllPerType()
        {
            List<object> temp = new List<object>();

            foreach (Stock item in ShopStocks)
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
