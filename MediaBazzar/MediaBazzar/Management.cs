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
            UpdateStockUI();
            ShowAllEmployees();
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

        /*private void btnManagementEPFilter_Click(object sender, EventArgs e)
        {
            lbManagemendEmployees.Items.Clear();
            if (radio_ID.Checked)
            {
                int id = Convert.ToInt32(txt_search.Text);
                foreach (Employee item in Employees.GetAllPerID(id))
                {
                    lbManagemendEmployees.Items.Add(item);
                }
            }
            else if (radio_role.Checked)
            {
                string role = txt_search.Text;
                foreach (Employee item in Employees.GetAllPerRole(role))
                {
                    lbManagemendEmployees.Items.Add(item);
                }
            }
        }*/
        private void btnManagemntPersonUpdate_Click(object sender, EventArgs e)
        {
            if (lbManagemendEmployees.SelectedIndex > -1)
            {

            }
        }


        private void btnManagemendUpdate_Click(object sender, EventArgs e)
        {
            ShowAllEmployees();
            cb_allRoles.SelectedIndex = -1;
            txt_search.Text = String.Empty;
        }

        public void ShowAllEmployees()
        {
            lbManagemendEmployees.Items.Clear();
            foreach (Employee item in Employees.GetAllPerType())
            {
                lbManagemendEmployees.Items.Add(item);
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

        private void filter()
        {
            lbManagemendEmployees.Items.Clear();
            if (radio_ID.Checked)
            {
                IDSearch();
            }
            else if (radio_name.Checked)
            {
                NameSearch();
            }
        }

        private void IDSearch()
        {
            if (int.TryParse(txt_search.Text, out int ID))
            {
                foreach (Employee emp in Employees.GetAllPerType())
                {
                    if(emp.EmployeeID == ID)
                    {
                        lbManagemendEmployees.Items.Add(emp);
                    }
                        
                }
            }
        }

        private void NameSearch()
        {
            string searchWord = txt_search.Text.ToLower();
            foreach(Employee emp in Employees.GetAllPerType())
            {
                string firstName = emp.personalInfo.FirstName.ToLower();
                string lastName = emp.personalInfo.LastName.ToLower();
                if(firstName.Contains(searchWord) || lastName.Contains(searchWord))
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
        private void RoleSearch()
        {
            lbManagemendEmployees.Items.Clear();
            foreach (Employee emp in Employees.GetAllPerType())
            {
                if (emp.Role == cb_allRoles.SelectedItem.ToString())
                {
                    lbManagemendEmployees.Items.Add(emp);

                }
            }
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            lbManagemendEmployees.SelectedIndex = -1;
            if (String.IsNullOrEmpty(txt_search.Text))
            {
                ShowAllEmployees();
            }
            else
            {
                filter();
            }
        }

        private void radio_role_CheckedChanged(object sender, EventArgs e)
        {           
            if (radio_role.Checked)
            {
                fillRoles();
                ShowAllEmployees();
                txt_search.Visible = false;
                cb_allRoles.Visible = true;
            }
            else
            {
                cb_allRoles.SelectedIndex = -1;
            }
            txt_search.Text = String.Empty;
        }

        private void radio_ID_CheckedChanged(object sender, EventArgs e)
        {
            if(radio_ID.Checked)
            {
                ShowAllEmployees();
                txt_search.Visible = true;
                cb_allRoles.Visible = false;
            }
            txt_search.Text = String.Empty;
        }

        private void radio_name_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_name.Checked)
            {
                ShowAllEmployees();
                txt_search.Visible = true;
                cb_allRoles.Visible = false;
            }
            txt_search.Text = String.Empty;
            
        }

        private void cb_allRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_allRoles.SelectedIndex > -1)
            {
                RoleSearch();
            }
        }
    }
}
