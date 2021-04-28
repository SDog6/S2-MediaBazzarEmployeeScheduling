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
        public Management()
        {
            InitializeComponent();
            stock = new ShopStockManager();
            Employees = new EmployeeManager();
            radio_ID.Checked = true;
            rbManagementStockIDFilter.Checked = true;
            checkBox_active.CheckState = CheckState.Checked;
            UpdateStockUI();
            ShowAllEmployees(true);
        }

        private void btnManagementRestockRequest_Click(object sender, EventArgs e)
        {
            if (lbManagementStock.SelectedIndex > -1)
            {
                Stock a = (Stock)lbManagementStock.SelectedItem;
                ManagementReshelf m = new ManagementReshelf(a);
                m.Show();
            }

        }
        private void btnManagemendUpdate_Click(object sender, EventArgs e)
        {
            bool employeeStatus = GetEmployeeStatus();
            ShowAllEmployees(employeeStatus);
            cb_allRoles.SelectedIndex = -1;
            txt_search.Text = String.Empty;
        }
        public void ShowAllEmployees(bool employeeStatus)
        {
            lbManagemendEmployees.Items.Clear();
            foreach (Employee item in Employees.GetAllPerType())
            {
                if(item.Active == employeeStatus)
                {
                    lbManagemendEmployees.Items.Add(item);
                }            
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
            if (lbManagemendEmployees.SelectedIndex > -1)
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
        private bool GetEmployeeStatus()
        {
            bool employeeStatus = false;
            if (checkBox_active.Checked)
            {
                employeeStatus = true;
            }
            return employeeStatus;
        }
        private void filter()
        {
            lbManagemendEmployees.Items.Clear();
            bool employeeStatus = GetEmployeeStatus();
            if (radio_role.Checked)
            {
                fillRoles();
                ShowAllEmployees(employeeStatus);
                if(cb_allRoles.SelectedIndex > -1)
                {
                    RoleSearch(cb_allRoles.SelectedIndex, employeeStatus);
                }
            }
            if (radio_ID.Checked)
            {
                IDSearch(employeeStatus);
            }
            else if (radio_name.Checked)
            {
                NameSearch(employeeStatus);
            }
        }

        private void IDSearch(bool employeeStatus)
        {
            string searchId = txt_search.Text;
            if(String.IsNullOrEmpty(searchId))
            {
                ShowAllEmployees(employeeStatus);
                return;
            }
            if (int.TryParse(searchId, out int ID))
            {
                foreach (Employee emp in Employees.GetAllPerType())
                {
                    if(emp.EmployeeID == ID && emp.Active == employeeStatus)
                    {
                        lbManagemendEmployees.Items.Add(emp);
                    }
                        
                }
            }
        }

        private void NameSearch(bool employeeStatus)
        {
            string searchWord = txt_search.Text.ToLower();
            if (String.IsNullOrEmpty(searchWord))
            {
                ShowAllEmployees(employeeStatus);
                return;
            }
            foreach(Employee emp in Employees.GetAllPerType())
            {
                string firstName = emp.PersonalInfo.FirstName.ToLower();
                string lastName = emp.PersonalInfo.LastName.ToLower();
                if((firstName.Contains(searchWord) || lastName.Contains(searchWord)) && emp.Active == employeeStatus)
                {
                    lbManagemendEmployees.Items.Add(emp);
                }
            }
        }

        private void fillRoles()
        {
            cb_allRoles.Items.Clear();
            foreach(Employee emp in Employees.GetAllPerType())
            {
                if (!cb_allRoles.Items.Contains(emp.Role))
                {
                    cb_allRoles.Items.Add(emp.Role);
                }
            }
        }
        private void RoleSearch(int index, bool employeeStatus)
        {
            lbManagemendEmployees.Items.Clear();
            foreach (Employee emp in Employees.GetAllPerType())
            {
                if (emp.Role == cb_allRoles.Items[index].ToString() && emp.Active == employeeStatus)
                {
                    lbManagemendEmployees.Items.Add(emp);
                }
            }
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void radio_role_CheckedChanged(object sender, EventArgs e)
        {           
            if (radio_role.Checked)
            {
                txt_search.Visible = false;
                cb_allRoles.Visible = true;
                filter();
            }
        }
        private void radio_ID_CheckedChanged(object sender, EventArgs e)
        {
            if(radio_ID.Checked)
            {
                txt_search.Visible = true;
                cb_allRoles.Visible = false;
                filter();
                txt_search.Text = String.Empty;
            }         
        }
        private void radio_name_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_name.Checked)
            {
                txt_search.Visible = true;
                cb_allRoles.Visible = false;
                filter();
                txt_search.Text = String.Empty;
            }    
        }

        private void cb_allRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void checkBox_active_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_active.Checked)
            {
                checkbox_fired.CheckState = CheckState.Unchecked;
            }
            filter();       
        }
        private void checkbox_fired_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_fired.Checked)
            {
                checkBox_active.CheckState = CheckState.Unchecked;
            }
            filter();
        }
    }
}
