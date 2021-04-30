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

            UpdateShiftEmployeeUI();

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
        }

        private void lbManagementShiftEmployeesToAssign_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee emp = (Employee)lbManagementShiftEmployeesToAssign.SelectedItem;
            shiftcounter = 0;
            foreach (Shift item in Shifts.GetAllPerType())
            {
                if (item.Emp.EmployeeID == emp.EmployeeID && item.Time >= Monday)
                {
                    shiftcounter += 5;
                }
            }
            MessageBox.Show($"Hours already assigned: {shiftcounter.ToString()} / {emp.Contract.Workinghours}");
        }

        private void btnManagementShiftAssignEmployee_Click(object sender, EventArgs e)
        {


            Employee emp = (Employee)lbManagementShiftEmployeesToAssign.SelectedItem;
            DateTime time = monthCalendar1.SelectionRange.Start.Date;
            string shifttype = cbShiftType.SelectedItem.ToString();
            if (shiftcounter + 5 > emp.Contract.Workinghours)
            {
                MessageBox.Show("Employee is beeing overscheduled !");
            }
            else
            {
                Shift temp = new Shift(emp, time, shifttype);
                Shifts.Add(temp);
                UpdateShiftEmployeeUI();
            }

        }

        public void UpdateShiftEmployeeUI()
        {

            lbManagementShiftEmployeesToAssign.Items.Clear();
            foreach (Employee item in Employees.GetAllPerType())
            {
                lbManagementShiftEmployeesToAssign.Items.Add(item);
            }


            lbMorningShifts.Items.Clear();
            foreach (Shift item in Shifts.GetAllMorningShifts())
            {
                lbMorningShifts.Items.Add(item);
            }


            lbAfternoonshifts.Items.Clear();
            foreach (Shift item in Shifts.GetAllAfternoonShifts())
            {
                lbAfternoonshifts.Items.Add(item);
            }


            lbEveningShifts.Items.Clear();
            foreach (Shift item in Shifts.GetAllEveningShifts())
            {
                lbEveningShifts.Items.Add(item);
            }
        }
    }
}
