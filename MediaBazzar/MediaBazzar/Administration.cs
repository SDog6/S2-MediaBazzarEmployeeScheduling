using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class Administration
    {

         public List<Account> accounts = new List<Account>();

        public Administration()
        {
            this.accounts = new List<Account>();
            accounts.Add(new Account("john", "0", new Employee((Role)1)));
            accounts.Add(new Account("peter", "0", new Employee((Role)2)));
            accounts.Add(new Account("bryan", "0", new Employee((Role)3)));
            accounts.Add(new Account("tommy", "0", new Employee((Role)4)));
            accounts.Add(new Account("arthur", "0", new Employee((Role)5)));
        }

        public void AddAccount(Account a)
        {
            accounts.Add(a);
        }


        public Account GetAccount(string username)
        {
            foreach (Account item in accounts)
            {
                if (username == item.getUsername())
                {
                    return item;
                }

            }
            return null;
        }

        public List<Account> GetAccounts()
        {
            return accounts;
        }

    }
}
