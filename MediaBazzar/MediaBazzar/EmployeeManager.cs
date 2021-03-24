using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class EmployeeManager : IManager
    {

        private List<Employee> Emps;

        private EmployeeData data;

        public EmployeeData EmpsData { get { return this.data; } set { data = value; } }

        public EmployeeManager()
        {
            EmpsData = new EmployeeData();
            loadDataFromDatabase();
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


        public List<object> GetAllPerID(int id)
        {
            List<object> temp = new List<object>();

            foreach (Employee item in (List<Employee>)EmpsData.ReadAllID(id))
            {
                temp.Add(item);
            }
            return temp;
        }

        public List<object> GetAllPerRole(string role)
        {
            List<object> temp = new List<object>();

            foreach (Employee item in (List<Employee>)EmpsData.ReadAllRoles(role))
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
