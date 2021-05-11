using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class Shift
    {
        int id;
        private Employee emp;
        private DateTime date;
        private string shifttype;

        public int ID { get { return this.id; } }
        public Employee Emp { get { return this.emp; } set { this.emp = value; } }
        public DateTime Time { get { return this.date; } set { this.date = value; } }
        public String ShiftType { get { return this.shifttype; } set { this.shifttype = value; } }



        public Shift(Employee emp,DateTime time,string shifttype)
        {
            this.emp = emp;
            this.Time = time;
            this.shifttype = shifttype;
        }

        public Shift(int id,Employee emp, DateTime time, string shifttype)
        {
            this.id = id;
            this.emp = emp;
            this.Time = time;
            this.shifttype = shifttype;
        }

        public override string ToString()
        {
            return $"{this.emp.PersonalInfo.FirstName} with id {emp.EmployeeID} is scheduled for a {this.shifttype} shift on {this.date.ToString("yyyy-MM-dd")}";
        }
    }
}
