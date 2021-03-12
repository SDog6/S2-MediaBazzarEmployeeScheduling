using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzarProect
{
    class Stock
    {
        private string name;
        private int amount;
        private int id;
        private double price;
        private string brand;

        public int ID
        {
            get { return this.id; }
        }

        public Stock(string name,int amount, int id,double price,string brand)
        {
            this.name = name;
            this.amount = amount;
            this.id = id;
            this.price = price;
            this.brand = brand;
        }

        public override string ToString()
        {
            return $"({this.brand}){this.name}:{amount}-{price}$[{this.id}]";
        }
    }
}
