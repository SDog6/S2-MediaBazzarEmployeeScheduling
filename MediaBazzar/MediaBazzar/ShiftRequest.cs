using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class ShiftRequest
    {
        int id;
        private Employee emp;
        private string date;
        private string shifttype;

        public int ID { get { return this.id; } }
        public Employee Emp { get { return this.emp; } set { this.emp = value; } }
        public string Time { get { return this.date; } set { this.date = value; } }
        public String ShiftType { get { return this.shifttype; } set { this.shifttype = value; } }



        public ShiftRequest(Employee emp,string time,string shifttype)
        {
            this.emp = emp;
            this.Time = time;
            this.shifttype = shifttype;
        }

        public ShiftRequest(int id,Employee emp, string time, string shifttype)
        {
            this.id = id;
            this.emp = emp;
            this.Time = time;
            this.shifttype = shifttype;
        }

        public override string ToString()
        {
            return $"[{emp.EmployeeID}]{this.emp.PersonalInfo.FirstName} is requesting a shift for the {this.shifttype}";
        }
    }
}
