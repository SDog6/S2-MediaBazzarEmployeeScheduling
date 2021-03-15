using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class Stock
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

        public string Brand
        {
            get { return this.brand; }
        }

        public int Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }
        public string Name
        {
            get { return this.name; }
        }

        public Stock(string name, int amount, int id, double price, string brand)
        {
            this.name = name;
            this.amount = amount;
            this.id = id;
            this.price = price;
            this.brand = brand;
        }

        public void Resupply(int number)
        {
            this.Amount += number;
        }

        public override string ToString()
        {
            return $"{this.name} of brand:'{this.brand}'. In stock currently:{amount}. Price: {price}$ - [{this.id}] ID";
        }
    }
}
