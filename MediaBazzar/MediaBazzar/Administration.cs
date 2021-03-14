using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    class Administration
    {

      public static  List<Account> accounts = new List<Account>();
         public static List<Employee> employees = new List<Employee>();


        public void AddAccount(Account a)
        {
            accounts.Add(a);
        }
        public void AddEmployee(Employee e)
        {
            employees.Add(e);
        }

        public Employee GetEmployee(string email)
        {
            foreach (Employee item in employees)
            {
                if (item.getEmail() == email)
                {
                    return item;
                }
            }
            return null;
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
        public static List<Employee> GetEmployees()
        {
            return employees;
        }

        public List<Account> GetAccounts()
        {
            return accounts;
        }

    }
}
