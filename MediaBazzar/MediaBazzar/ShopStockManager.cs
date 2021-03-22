﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazzar
{
    public class ShopStockManager : IManager
    {
        private List<Stock> ShopStocks;

        private ShopStockData data;

        public ShopStockData StockData { get { return this.data; } set { data = value; } }

        public ShopStockManager()
        {
            StockData = new ShopStockData();
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