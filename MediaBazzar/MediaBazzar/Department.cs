using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    class Department
    {

        private string name;

        List<Employee> Employees;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == "")
                { this.name = "Unknown"; }
                else
                { this.name = value; }
            }
        }


        public Department(string name)
        {
            this.Name = name;
            this.Employees = new List<Employee>();
        }

        public void AddEmployee(string first_name, string second_name, string phone, string street, string city, string state, string email)
        {

        }
        public Employee GetEmployee(string BSN)
        {
            foreach (Employee e in this.Employees)
            {
                if (e.BSNp == BSN)
                {
                    return e;
                }
            }
            return null;
        }
        public List<Employee> GetEmployees()
        {
            return this.Employees;
        }
    }
}
