using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class Shift
    {
        private Employee emp;
        private string time;
        private string shifttype;

        public Employee Emp { get { return this.emp; } set { this.emp = value; } }
        public string Time { get { return this.time; } set { this.time = value; } }
        public String ShiftType { get { return this.shifttype; } set { this.shifttype = value; } }



        public Shift(Employee emp,string time,string shifttype)
        {
            this.emp = emp;
            this.time = time;
            this.shifttype = shifttype;
        }

        public override string ToString()
        {
            return $"{this.emp.FirstName} with id {emp.EmID} is scheduled for a {this.shifttype} shift on {this.time}";
        }
    }
}
