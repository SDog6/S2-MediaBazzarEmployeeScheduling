using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
   public class EmployeeManager
    {

        private List<Employee> Emps;

        private EmployeeData data;

        public EmployeeData EmpsData { get { return this.data; } set { data = value; } }

        public EmployeeManager()
        {
            EmpsData = new EmployeeData();
            loadDataFromDatabase();
        }

        public Employee  GetEmployeeForLogin(string username,string password)
        {
            foreach (Employee item in Emps)
            {
                if(item.Username == username && item.Password == password)
                {
                    return item;
                }
            }
            return null;
        }


        private void loadDataFromDatabase()
        {
            Emps = new List<Employee>();

            foreach (Employee o in (List<Employee>)EmpsData.ReadAll())
            {
                Emps.Add((Employee)o);
            }
        }
        public bool Add(object obj)
        {
            if (obj != null)
            {
                EmpsData.Insert((Employee)obj);
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

            foreach (Employee item in Emps)
            {
                temp.Add(item);
            }
            return temp;
        }

        public bool Remove(object obj)
        {
            if (obj != null)
            {
                EmpsData.Delete((Employee)obj);
                loadDataFromDatabase();
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
