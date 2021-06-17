using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazzar
{
    public partial class ShiftScheduling : Form
    {
        DateTime Monday;
        DateTime Sunday;
        int shiftcounter;
        ShiftSchedulingManager Shifts;
        ShiftSchedulingRequestsManager Requests;
        EmployeeManager Employees;



        public ShiftScheduling()
        {
            InitializeComponent();
            Employees = new EmployeeManager();
            Shifts = new ShiftSchedulingManager();
            Requests = new ShiftSchedulingRequestsManager();
            cbShiftType.SelectedIndex = 1;


            DateTime today = DateTime.Now;

            int daysuntillmonday = DayOfWeek.Monday - today.DayOfWeek;
            daysuntillmonday += 7;

            if (daysuntillmonday > 0)
            {
                Monday = today.AddDays(daysuntillmonday);
                Sunday = Monday.AddDays(6);
            }
            else
            {
                Monday = today;
                Sunday = today.AddDays(6);
            }
            monthCalendar1.MinDate = Monday;
            monthCalendar1.MaxDate = Sunday;
            monthCalendar1.SelectionStart = Monday;

            UpdateShiftEmployeeUI();
            UpdateShiftRequests();
        }

        private void btnManagementShiftAssignEmployee_Click(object sender, EventArgs e)
        {
            if(lbManagementShiftEmployeesToAssign.SelectedIndex > -1)
            {
                ShiftRequest r = (ShiftRequest)lbManagementShiftEmployeesToAssign.SelectedItem;
                //Employee emp = (Employee)lbManagementShiftEmployeesToAssign.SelectedItem;
                Employee emp = r.Emp;
                DateTime time = monthCalendar1.SelectionRange.Start.Date;
                string shifttype = cbShiftType.SelectedItem.ToString();
                if (emp.Workinghours + 5 > emp.Contract.Workinghours)
                {
                    MessageBox.Show("Employee is beeing overscheduled !");
                }
                else
                {
                    shiftcounter += 5;
                    Shift temp = new Shift(emp, time, shifttype);
                    Shifts.Add(temp);
                    Employees.IncreaseWorkHours(emp);
                    UpdateShiftRequests();
                    UpdateShiftEmployeeUI();
                }
            }

          

        }

        public void UpdateEmployeesUI()
        {
            foreach (Employee emp in Employees.GetAllPerType())
            {
                emp.Workinghours = 0;
                foreach (Shift item in Shifts.GetAllPerType())
                {
                    if (item.Emp.EmployeeID == emp.EmployeeID && item.Time >= Monday)
                    {
                        emp.Workinghours += 5;
                    }
                }
            }
           


            lbManagementShiftEmployeesToAssign.Items.Clear();
            foreach (Employee item in Employees.GetAllPerType())
            {
                lbManagementShiftEmployeesToAssign.Items.Add(item);
            }
        }


        public void UpdateShiftRequests()
        {
            DateTime time = monthCalendar1.SelectionRange.Start.Date;
            lbManagementShiftEmployeesToAssign.Items.Clear();
            foreach (ShiftRequest items in Requests.GetAllRequestsByDay(time.DayOfWeek.ToString()))
            {
                lbManagementShiftEmployeesToAssign.Items.Add(items);
            }
        }


        public void UpdateShiftEmployeeUI()
        {

            lbMorningShifts.Items.Clear();
            lbAfternoonshifts.Items.Clear();
            lbEveningShifts.Items.Clear();
            DateTime time = monthCalendar1.SelectionRange.Start.Date;
            foreach (Shift item in Shifts.GetAllPerType())
            {
                if (item.Time == time && item.ShiftType == "Morning (7AM-2PM)")
                {
                    lbMorningShifts.Items.Add(item);
                }
                else if (item.Time == time && item.ShiftType == "Afternoon (1PM-6PM)")
                {
                    lbAfternoonshifts.Items.Add(item);
                }
                else if (item.Time == time && item.ShiftType == "Night (5PM-10PM)")
                {
                    lbEveningShifts.Items.Add(item);
                }
            }

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateShiftRequests();
            UpdateShiftEmployeeUI();


        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            int Monday = 0;
            int Tuesday = 0;
            int Wednesday = 0;
            int Thursday = 0;
            int Friday = 0;
            int Saturday = 0;
            int Sunday = 0;

            int MondayLimit = 2;
            int TuesdayLimit = 2;
            int WednesdayLimit = 2;
            int ThursdayLimit = 2;
            int FridayLimit = 5;
            int SaturdayLimit = 5;
            int SundayLimit = 5;

            foreach (Shift item in Requests.GetAll())
            {
                if(item.Emp.Workinghours + 5 < item.Emp.Contract.Workinghours && Monday++ <= MondayLimit && Tuesday++ <= TuesdayLimit && Wednesday++ <= WednesdayLimit && Thursday++ <= ThursdayLimit && Friday++ <= FridayLimit && Saturday++ <= SaturdayLimit && Sunday++ <= SundayLimit)
                {
                    switch(item.Time.DayOfWeek)
                    {
                        case DayOfWeek.Monday:
                           Monday++;
                            break;
                        case DayOfWeek.Tuesday:
                            Tuesday++;
                            break;
                        case DayOfWeek.Wednesday:
                            Wednesday++;
                            break;
                        case DayOfWeek.Thursday:
                            Thursday++;
                            break;
                        case DayOfWeek.Friday:
                            Friday++;
                            break;
                        case DayOfWeek.Saturday:
                            Saturday++;
                            break;
                        case DayOfWeek.Sunday:
                            Sunday++;
                            break;

                    }
                    Shifts.Add(item);
                }
            }
        }

        private void lbManagementShiftEmployeesToAssign_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShiftRequest r = (ShiftRequest)lbManagementShiftEmployeesToAssign.SelectedItem;
            if(r.ShiftType == "EveningShift")
            {
                cbShiftType.SelectedIndex = 2;
            }
            else if(r.ShiftType == "MorningShift")
            {
                cbShiftType.SelectedIndex = 0;
            }
            else
            {
                cbShiftType.SelectedIndex = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lbMorningShifts.SelectedIndex > -1)
            {
                Shift s = (Shift)lbMorningShifts.SelectedItem;
                Shifts.Remove(s);
                Employees.LowereWorkHours(s.Emp);
                lbMorningShifts.Items.Clear();
                UpdateShiftEmployeeUI();
                UpdateShiftRequests();
            }
            else if (lbAfternoonshifts.SelectedIndex > -1)
            {
                Shift s = (Shift)lbAfternoonshifts.SelectedItem;
                Shifts.Remove(s);
                Employees.LowereWorkHours(s.Emp);
                lbAfternoonshifts.Items.Clear();
                UpdateShiftEmployeeUI();
                UpdateShiftRequests();
            }
            else if (lbEveningShifts.SelectedIndex > -1)
            {
                Shift s = (Shift)lbEveningShifts.SelectedItem;
                Shifts.Remove(s);
                Employees.LowereWorkHours(s.Emp);
                lbEveningShifts.Items.Clear();
                UpdateShiftEmployeeUI();
                UpdateShiftRequests();
            }

        }
    }
}
