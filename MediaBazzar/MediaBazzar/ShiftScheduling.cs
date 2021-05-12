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
        EmployeeManager Employees;



        public ShiftScheduling()
        {
            InitializeComponent();
            Employees = new EmployeeManager();
            Shifts = new ShiftSchedulingManager();
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
            UpdateEmployeesUI();
        }

        private void btnManagementShiftAssignEmployee_Click(object sender, EventArgs e)
        {
            if(lbManagementShiftEmployeesToAssign.SelectedIndex > -1)
            {
                Employee emp = (Employee)lbManagementShiftEmployeesToAssign.SelectedItem;
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
                    UpdateEmployeesUI();
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
            UpdateShiftEmployeeUI();
        }
    }
}
