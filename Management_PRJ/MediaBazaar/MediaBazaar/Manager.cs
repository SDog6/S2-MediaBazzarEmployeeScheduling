using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class Manager
    {
        private string name;

        private List<Department> departments;

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

        public Manager(string name)
        {
            this.Name = name;
            this.departments = new List<Department>();
            this.departments.Add(new Department("Phone"));
        }

        public void AddDepartment(string name)
        {
            this.departments.Add(new Department(name));
        }

        public Department GetDepartment(string name)
        {
            foreach(Department d in this.departments)
            {
                if(d.Name == name)
                {
                    return d;
                }
            }
            return null;
        }
        public List <Department> GetDepartments()
        {
            return this.departments;
        }


    }
}
