using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class Department
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

        public Employee GetEmployee(string BSN)
        {
            foreach(Employee e in this.Employees)
            {
                if(e.BSNp == BSN)
                {
                    return e;
                }
            }
            return null;
        }
        public Employee[] GetEmployees()
        {
            return this.Employees.ToArray();
        }
    }
}
