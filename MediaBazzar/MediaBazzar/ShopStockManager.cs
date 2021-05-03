using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazzar
{
    public class ShopStockManager
    {
        private ShopStockData data;
        private List<Stock> ShopStocks;

        public List<Stock> allStocks { get { return this.ShopStocks; } }

        public ShopStockManager()
        {
            data = new ShopStockData();
            loadDataFromDatabase();
        }
        private void loadDataFromDatabase()
        {
            ShopStocks = (List<Stock>)data.ReadAll();
        }
        public bool Add(object obj, int amount)
        {
            if (obj != null)
            {
                data.Insert((Stock)obj, amount);
                loadDataFromDatabase();
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<object> GetAllRequestItems()
        {
            List<object> temp = new List<object>();

            foreach (Stock item in (List<Stock>)data.GetRequestItems())
            {
                temp.Add(item);
            }
            return temp;
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
            if (obj != null)
            {
                data.Delete((Stock)obj);
                loadDataFromDatabase();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
