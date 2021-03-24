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

        private StockDatabase data;

        public StockDatabase StockData { get { return this.data; } set { data = value; } }

        public WarehouseStock()
        {
            StockData = new StockDatabase();
            loadDataFromDatabase();
        }


        private void loadDataFromDatabase()
        {
            WarehouseStocks = new List<Stock>();

            foreach (Stock o in (List<Stock>)StockData.ReadAll())
            {
                WarehouseStocks.Add((Stock)o);
            }
        }
        public bool Add(object obj)
        {
            if (obj != null)
            {
                StockData.Insert((Stock)obj);
                loadDataFromDatabase();
                return true;
            }
            else
            {
                return false;
            }
            

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
