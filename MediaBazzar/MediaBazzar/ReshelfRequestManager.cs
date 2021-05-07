using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    class ReshelfRequestManager : IManager
    {
        private List<ReshelfRequest> Requests;

        private ReshelfRequestData data;

        public ReshelfRequestData RequestData { get { return this.data; } set { data = value; } }

        public ReshelfRequestManager()
        {
            RequestData = new ReshelfRequestData();
            loadDataFromDatabase();
        }


        private void loadDataFromDatabase()
        {
            Requests = new List<ReshelfRequest>();

            foreach (ReshelfRequest o in (List<ReshelfRequest>)RequestData.ReadAll())
            {
                Requests.Add((ReshelfRequest)o);
            }
        }
        public bool Add(object obj)
        {
            if (obj != null)
            {
                RequestData.Insert((ReshelfRequest)obj);
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

            foreach (ReshelfRequest item in Requests)
            {
                temp.Add(item);
            }
            return temp;
        }

        public object GetRequestByID(int id)
        {
            foreach (ReshelfRequest item in Requests)
            {
                if(item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }


        public bool CompleteRequest(ReshelfRequest a)
        {
            if(a.Complete == false)
            {
                RequestData.ReduceStockInWarehouse(a);
                RequestData.CompleteRequest(a);
                RequestData.IncreaseStockInShop(a);
                return true;
            }
            return false;
        }

        public bool Remove(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
