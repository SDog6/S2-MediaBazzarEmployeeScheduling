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
        private int price;
        private string brand;
        private int available;
        public int Available
        {
            set { available = value; }
            get { return this.available; }
        }

        public string AvailableStr
        {
            get { if (this.available == 1)
                {
                    return "Available";
                }
                else return "Unavailable";
            }
                
        }
        public int ID
        {
            get { return this.id; }
            set { id = value; }
        }

        public string Brand
        {
            get { return this.brand; }
            set { brand = value; }
        }

        public int Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }

        public int Price
        {
            get { return this.price; }
            set { price = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { name = value; }
        }

        public Stock(string name, int amount, int id, int price, string brand, int available)
        {
            this.name = name;
            this.amount = amount;
            this.id = id;
            this.price = price;
            this.brand = brand;
            this.available = available;
        }

        public override string ToString()
        {
            if(this.available == 1)
            return $"{this.name} of brand:'{this.brand}'. In stock currently:{amount}. Price: {price}$ - ID-[{this.id}] (Available)";
            else
            return $"{this.name} of brand:'{this.brand}'. In stock currently:{amount}. Price: {price}$ - ID-[{this.id}] (Unavailable)";

        }
    }
}
