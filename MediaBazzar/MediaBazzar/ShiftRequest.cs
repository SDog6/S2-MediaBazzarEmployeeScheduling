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

        public DayOfWeek GetDayOfWeek()
        {
            switch (Time)
            {
                case "Monday":
                    {
                        return DayOfWeek.Monday;
                    }
                case "Tuesday":
                    {
                        return DayOfWeek.Tuesday;
                    }
                case "Wednesday":
                    {
                        return DayOfWeek.Wednesday;
                    }
                case "Thursday":
                    {
                        return DayOfWeek.Thursday;
                    }
                case "Friday":
                    {
                        return DayOfWeek.Friday;
                    }
                case "Saturday":
                    {
                        return DayOfWeek.Saturday;
                    }
                case "Sunday":
                    {
                        return DayOfWeek.Sunday;
                    }
                default:
                    {
                        return DayOfWeek.Monday;
                    }
            }
        }

        public int GetShiftType()
        {
            switch (ShiftType)
            {
                case "MorningShift":
                    {
                        return 1;
                    }
                case "EveningShift":
                    {
                        return 2;
                    }
                case "NightShift":
                    {
                        return 3;
                    }
                default:
                    {
                        return 0;
                    }
            }
        }
        public override string ToString()
        {
            return $"[{emp.EmployeeID}]{this.emp.PersonalInfo.FirstName} with workload {this.emp.Contract.CurWorkinghours}/{this.emp.Contract.Workinghours} is requesting a {this.shifttype}";
        }
    }
}
