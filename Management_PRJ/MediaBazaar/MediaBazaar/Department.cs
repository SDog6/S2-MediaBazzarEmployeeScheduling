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
            this.Employees.Add(new Employee("Betty", "Metty", "1234567890", new Address("a", "b", "c"), "email"));
            this.Employees.Add(new Employee("Zack", "Archer", "6789012345", new Address("a", "b", "d"), "email_1"));
        }

        public void AddEmployee(string first_name, string second_name,string phone, string street, string city, string state, string email )
        {
            this.Employees.Add(new Employee(first_name, second_name, phone, new Address(street, city, state), email));
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
