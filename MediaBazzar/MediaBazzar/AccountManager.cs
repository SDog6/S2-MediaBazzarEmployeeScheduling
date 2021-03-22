using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    class AccountManager : IManager
    {


        private List<Account> accdata;

        private AccountData data;

        public AccountData accountData { get { return this.data; } set { data = value; } }

        public AccountManager()
        {
            accountData = new AccountData();
            loadDataFromDatabase();
        }


        private void loadDataFromDatabase()
        {
           accdata = new List<Account>();

            foreach (Account o in (List<Account>)accountData.ReadAll())
            {
                accdata.Add((Account)o);
            }
        }
        public bool Add(object obj)
        {
            if (obj != null)
            {
                accountData.Insert((Stock)obj);
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

            foreach (Account item in accdata)
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
