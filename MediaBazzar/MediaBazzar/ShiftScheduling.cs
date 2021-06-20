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
        ShiftConverter a = new ShiftConverter();
        EmployeeManager Employees;

        List<Shift> RemainingShifts;
        int[] counters = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        int[] limits =   { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5};

        public ShiftScheduling()
        {
            InitializeComponent();
            Employees = new EmployeeManager();
            Shifts = new ShiftSchedulingManager();
            Requests = new ShiftSchedulingRequestsManager();
            cbShiftType.SelectedIndex = 1;


            RemainingShifts = new List<Shift>();

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
            monthCalendar1.MinDate = Monday.AddDays(-7);
            monthCalendar1.MaxDate = Sunday;
            monthCalendar1.SelectionStart = Monday;

            UpdateShiftEmployeeUI();
            UpdateShiftRequests();
        }

        private void btnManagementShiftAssignEmployee_Click(object sender, EventArgs e)
        {
            if (lbManagementShiftEmployeesToAssign.SelectedIndex > -1)
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
                    UpdateShiftEmployeeUI();
                    UpdateShiftRequests();
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
            }/*
            foreach (Shift item in Shifts.GetAllMorningShifts())
            {
                if(item.Time == monthCalendar1.SelectionRange.Start.Date)
                {
                    lbMorningShifts.Items.Add(item);
                }
            }


            lbAfternoonshifts.Items.Clear();
            foreach (Shift item in Shifts.GetAllAfternoonShifts())
            {
                if (item.Time == monthCalendar1.SelectionRange.Start.Date)
                {
                    lbAfternoonshifts.Items.Add(item);
                }
            }


            lbEveningShifts.Items.Clear();
            foreach (Shift item in Shifts.GetAllEveningShifts())
            {
                if (item.Time == monthCalendar1.SelectionRange.Start.Date)
                {
                    lbEveningShifts.Items.Add(item);
                }
            }*/
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateShiftRequests();
            UpdateShiftEmployeeUI();
        }

        private bool AssignShift(Shift s)
        {
            int shift = (((int)s.Time.DayOfWeek + 6) % 7)*3;
            switch (s.ShiftType)
            {
                case "MorningShift":
                    {
                        shift += 1;
                        break;
                    }
                case "EveningShift":
                    {
                        shift += 2;
                        break;
                    }
                case "NightShift":
                    {
                        shift += 3;
                        break;
                    }
            }        
            if (counters[shift] + 1 <= limits[shift])
            {
                counters[shift]++;
                return true;
            }
            return false;
        }
        private void AutoSchedule()
        {
            List<Shift> temp = new List<Shift>();
            foreach (ShiftRequest item in Requests.GetAll())
            {
                Shift temp1 = a.RequestToShift(item);
                temp.Add(temp1);
            }

            foreach (Shift item in temp)
            {
    
                if (item.Emp.Workinghours + 5 < item.Emp.Contract.Workinghours)
                {
                    if (AssignShift(item))
                    {
                        Shifts.Add(item);
                        Employees.IncreaseWorkHours(item.Emp);
                    }
                    else
                    {
                        RemainingShifts.Add(item);
                    }
                }
            }

         
           
        }
        private void AssignRemaining()
        {
            if(RemainingShifts.Count < 1)
            {
                return;
            }
            for(int i = 0; i < 21; i++)
            {
                if (counters[i] < limits[i])
                {
                    try
                    {
                        Shifts.Add(RemainingShifts[0]);
                        RemainingShifts.RemoveAt(0);
                        counters[i]++;
                    }
                    catch(IndexOutOfRangeException)
                    {
                        return;
                    }                    
                }
            }
        }
        private void btnAuto_Click(object sender, EventArgs e)
        {
            AutoSchedule();
            AssignRemaining();
            UpdateShiftEmployeeUI();
            UpdateShiftRequests();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lbMorningShifts.SelectedIndex > -1)
            {
                Shift s = (Shift)lbMorningShifts.SelectedItem;
                Shifts.Remove(s);
                Employees.LowereWorkHours(s.Emp);
                UpdateShiftEmployeeUI();
                UpdateShiftRequests();
            }
            if (lbAfternoonshifts.SelectedIndex > -1)
            {
                Shift s = (Shift)lbAfternoonshifts.SelectedItem;
                Shifts.Remove(s);
                Employees.LowereWorkHours(s.Emp);
                UpdateShiftEmployeeUI();
                UpdateShiftRequests();
            }
            if (lbEveningShifts.SelectedIndex > -1)
            {
                Shift s = (Shift)lbEveningShifts.SelectedItem;
                Shifts.Remove(s);
                Employees.LowereWorkHours(s.Emp);
                UpdateShiftEmployeeUI();
                UpdateShiftRequests();
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

        private void btnLimit_Click(object sender, EventArgs e)
        {
            ShiftSchedulingLimits s = new ShiftSchedulingLimits();
            s.Show();
        }

        private void lbManagementShiftEmployeesToAssign_SelectedIndexChanged(object sender, EventArgs e)
        {

            ShiftRequest r = (ShiftRequest)lbManagementShiftEmployeesToAssign.SelectedItem;
            if (r.ShiftType == "EveningShift")
            {
                cbShiftType.SelectedIndex = 2;
            }
            else if (r.ShiftType == "MorningShift")
            {
                cbShiftType.SelectedIndex = 0;
            }
            else
            {
                cbShiftType.SelectedIndex = 1;
            }
        }
    }
}
