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
        private ShopStock inventory;

        public ReshelfRequest(Stock lowstock,int amount)
        {
            this.lowstock = lowstock;
            this.amount = amount;
            inventory = new ShopStock();
        }

        public void ApproveReshelfRequest()
        {
            if(inventory.GetSpecificStock(lowstock.ID) == lowstock)
            {
                inventory.GetSpecificStock(lowstock.ID).Amount += amount;
            }
        }

        public override string ToString()
        {
            return $"{filedDate.ToShortDateString()}-{lowstock.Name}[{lowstock.ID}] is running low, there is a request for {amount} more";
        }
    }
}
