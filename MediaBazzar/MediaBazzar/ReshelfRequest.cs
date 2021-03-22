using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    class ReshelfRequest
    {
        private Stock lowstock;
        private DateTime filedDate = DateTime.Now;
        private int amount;

        public ReshelfRequest(Stock lowstock,int amount)
        {
            this.lowstock = lowstock;
            this.amount = amount;
        }

        public override string ToString()
        {
            return $"{filedDate}-{lowstock.Name}[{lowstock.ID}] is running low, there is a request for {amount} more";
        }
    }
}
