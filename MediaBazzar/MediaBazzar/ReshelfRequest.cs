using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    class ReshelfRequest
    {
        private int id;
        private Stock lowstock;
        private DateTime filedDate;
        private int amount;
        private bool complete;
        private int shopId;


        public ReshelfRequest(Stock lowstock, DateTime filedDate, int amount, bool complete)
        {
            this.lowstock = lowstock;
            this.filedDate = filedDate;
            this.amount = amount;
            this.complete = complete;
        }

        public ReshelfRequest(Stock lowstock,DateTime filedDate,int amount,bool complete,int id)
        {
            this.lowstock = lowstock;
            this.filedDate = filedDate;
            this.amount = amount;
            this.id = id;
            this.complete = complete;
        }

        public Stock RequiredStock { get { return this.lowstock; }  }
        public DateTime FilledDate { get { return this.filedDate; } }
        public int AmountNeeded { get { return this.amount; } }
        public int ID{ get { return this.id; } }
        public bool Complete { get { return this.complete; } }



        public override string ToString()
        {
            return $"{filedDate}-{lowstock.Name}[{lowstock.ID}] is running low, there is a request for {amount} more";
        }
    }
}
