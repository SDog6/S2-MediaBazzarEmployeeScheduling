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

        public List<Employee> Employees { get { return this.Emps; } }

        public EmployeeManager()
        {
            data = new EmployeeData();
            loadDataFromDatabase();
        }


        private void loadDataFromDatabase()
        {
            Emps = new List<Employee>();

            foreach (Employee emp in (List<Employee>)data.ReadAll())
            {
                Emps.Add(emp);
            }
        }
        public bool Add(object obj)
        {
            if (obj != null)
            {
                data.Insert((Employee)obj);
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


        public Employee GetEmp(int id)
        {
            Employee emp = data.GetEmployee(id);
            return emp;

        }

        public bool Fire(Object emp)
        {
            Employee em = (Employee)emp;
            if(em.Active == true)
            {
                data.FireEmployee(emp);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Remove(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
