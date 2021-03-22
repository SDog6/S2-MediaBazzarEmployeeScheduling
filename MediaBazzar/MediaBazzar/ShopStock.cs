using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazzar
{
    public class ShopStock
    {

        private List<Stock> ShopStocks;
        private StockDatabase StockData;


        public StockDatabase stockData { get { return this.StockData; } set { StockData = value; } }
        public ShopStock()
        {
            StockData = new StockDatabase();
            loadDataFromDatabase();
        }


        private void loadDataFromDatabase()
        {
            ShopStocks = new List<Stock>();

            foreach (Stock o in (List<Stock>)StockData.ReadAll())
            {
                ShopStocks.Add((Stock)o);
            }
        }

        public void Add(object obj)
        {
            try
            {
                StockData.Insert((Stock)obj);
                loadDataFromDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
