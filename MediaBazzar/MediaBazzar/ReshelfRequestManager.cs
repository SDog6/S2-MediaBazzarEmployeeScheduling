using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    class ReshelfRequestManager : IManager
    {
        private List<ReshelfRequest> requests;

        public ReshelfRequestManager()
        {
            this.requests = new List<ReshelfRequest>();
        }
        public bool Add(object obj)
        {
            if (obj is ReshelfRequest)
            {
                ReshelfRequest r = (ReshelfRequest)obj;
                requests.Add((ReshelfRequest)obj);
                return true;
            }
            return false;
        }

        public List<object> GetAllPerType()
        {
            List<object> temp = new List<object>();

            foreach (ReshelfRequest item in requests)
            {
                temp.Add(item);
            }
            return temp;
        }

        public bool Remove(object obj)
        {
            if(obj is ReshelfRequest)
            {
                this.GetAllPerType().Remove(obj);
                return true;
            }
            return false;
        }
    }
}
