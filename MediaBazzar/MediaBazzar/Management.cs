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
    public partial class Management : Form
    {
        ShopStockManager stock;
        EmployeeManager Employees;
        ShiftSchedulingManager Shifts;
        public Management()
        {
            InitializeComponent();
            stock = new ShopStockManager();
            Employees = new EmployeeManager();
            Shifts = new ShiftSchedulingManager();
            rbManagementID.Checked = true;
            rbManagementStockIDFilter.Checked = true;
            cbShiftType.SelectedIndex = 1;
            UpdateStockUI();
            UpdateEmployeeUI();
            UpdateShiftEmployeeUI();
        }

        private void btnManagementRestockRequest_Click(object sender, EventArgs e)
        {
            if(lbManagementStock.SelectedIndex > -1)
            {
                Stock a = (Stock)lbManagementStock.SelectedItem;
                ManagementReshelf m = new ManagementReshelf(a);
                m.Show();
            }
            
        }

        private void btnManagementEPFilter_Click(object sender, EventArgs e)
        {
            lbManagemendEmployees.Items.Clear();
            if (rbManagementID.Checked)
            {
                int id = Convert.ToInt32(tbManagementEPFilter.Text);
                foreach (Employee item in Employees.GetAllPerID(id))
                {
                    lbManagemendEmployees.Items.Add(item);
                } 
            }
            else if (rbManagementRole.Checked)
            {
                string role = tbManagementEPFilter.Text;
                foreach (Employee item in Employees.GetAllPerRole(role))
                {
                    lbManagemendEmployees.Items.Add(item);
                }
            }
        }

        private void btnManagemntPersonCreation_Click(object sender, EventArgs e)
        {
            EmployeeCreation creation = new EmployeeCreation(Employees);
            creation.Show();
        }

        private void btnManagemntPersonUpdate_Click(object sender, EventArgs e)
        {
            if(lbManagemendEmployees.SelectedIndex > -1)
            {

            }
        }


        private void btnManagemendUpdate_Click(object sender, EventArgs e)
        {
            UpdateEmployeeUI();
        }

        public void UpdateEmployeeUI()
        {
            lbManagemendEmployees.Items.Clear();
            foreach (Employee item in Employees.GetAllPerType())
            {
                lbManagemendEmployees.Items.Add(item);
            }

        }

        public void UpdateShiftEmployeeUI()
        {

            lbManagementShiftEmployeesToAssign.Items.Clear();
            foreach (Employee item in Employees.GetAllPerType())
            {
                lbManagementShiftEmployeesToAssign.Items.Add(item);
            }


            lbManagementShiftEmployeesAssigned.Items.Clear();
            foreach (Shift item in Shifts.GetAllPerType())
            {
                lbManagementShiftEmployeesAssigned.Items.Add(item);
            }

        }
        private void btnManagementStockUpdate_Click(object sender, EventArgs e)
        {
            lbManagementStock.Items.Clear();
            foreach (Stock item in stock.GetAllPerType())
            {
                lbManagementStock.Items.Add(item);
            }
        }

        private void btnManagemntPersonUpdate_Click_1(object sender, EventArgs e)
        {

        }

        private void btnManagementNewStock_Click(object sender, EventArgs e)
        {
            ManagementNewInventory a = new ManagementNewInventory(stock);
            a.Show();
        }

        private void btnManagementStockUpdate_Click_1(object sender, EventArgs e)
        {
            UpdateStockUI();
        }
        public void UpdateStockUI()
        {
            lbManagementStock.Items.Clear();
            foreach (Stock item in stock.GetAllPerType())
            {
                lbManagementStock.Items.Add(item);
            }
        }

        private void btnViewEmployeeInfo_Click(object sender, EventArgs e)
        {
            if(lbManagemendEmployees.SelectedIndex > -1) 
            {
                Object s = lbManagemendEmployees.SelectedItem;
                Employee Selected = (Employee)s;
                ViewEmployeeData v = new ViewEmployeeData(Selected);
                v.Show();
            
            }
        }

        private void btnStockRemove_Click(object sender, EventArgs e)
        {

            if (lbManagementStock.SelectedIndex > -1)
            {
                Object s = lbManagementStock.SelectedItem;
                stock.Remove(s);
            }
        }

        private void btnManagementStockFilter_Click(object sender, EventArgs e)
        {
            lbManagementStock.Items.Clear();
            if (rbManagementStockIDFilter.Checked)
            {
                int id = Convert.ToInt32(tbManagementStockFilter.Text);
                foreach (Stock item in stock.GetAllPerID(id))
                {
                    lbManagementStock.Items.Add(item);
                }
            }
            else if (rbManagementStockBrandFilter.Checked)
            {
                string brand = tbManagementStockFilter.Text;
                foreach (Stock item in stock.GetAllPerBrand(brand))
                {
                    lbManagementStock.Items.Add(item);
                }
            }
            else if (rbManagementStockAmountFilter.Checked)
            {

                int amount = Convert.ToInt32(tbManagementStockFilter.Text);
                foreach (Stock item in stock.GetAllPerAmount(amount))
                {
                    lbManagementStock.Items.Add(item);
                }
            }
        }

        private void btnManagementShiftAssignEmployee_Click(object sender, EventArgs e)
        {
            Employee emp = (Employee)lbManagementShiftEmployeesToAssign.SelectedItem;
            string time = monthCalendar1.SelectionRange.Start.ToShortDateString();
            string shifttype = cbShiftType.SelectedItem.ToString();

            Shift temp = new Shift(emp, time, shifttype);
            Shifts.Add(temp);
            UpdateShiftEmployeeUI();
        }

        private void btnShiftsUpdate_Click(object sender, EventArgs e)
        {
            UpdateShiftEmployeeUI();
        }

        private void lbManagementShiftEmployeesAssigned_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
