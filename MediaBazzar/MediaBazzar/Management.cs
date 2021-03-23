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
        EmployeeManager Employees;
        ShopStockManager ShopManager;
        public Management()
        {
            InitializeComponent();
            Employees = new EmployeeManager();
            ShopManager = new ShopStockManager();
            UpdateStockUI();
            UpdateEmployee();
        }

        private void btnManagementRestockRequest_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnManagementEPFilter_Click(object sender, EventArgs e)
        {
            
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


        private void btnManagementUpdate_Click(object sender, EventArgs e)
        {
            UpdateStockUI();
        }

        public void UpdateStockUI()
        {
            lbManagementStock.Items.Clear();
            foreach (Stock item in ShopManager.GetAllPerType())
            {
                lbManagementStock.Items.Add(item);
            }
        }

        private void btnManagemntPersonUpdate_Click_1(object sender, EventArgs e)
        {

        }

        private void btnManagementNewStock_Click(object sender, EventArgs e)
        {
            ManagementNewInventory a = new ManagementNewInventory(ShopManager);
            a.Show();
        }

        private void btnManagemendUpdate_Click(object sender, EventArgs e)
        {
            UpdateEmployee();
        }

        public void UpdateEmployee()
        {
            lbManagemendEmployees.Items.Clear();
            foreach (Employee item in Employees.GetAllPerType())
            {
                lbManagemendEmployees.Items.Add(item);
            }
        }

        private void btnStockRemove_Click(object sender, EventArgs e)
        {
            if(lbManagementStock.SelectedIndex > -1)
            {
                Object s = lbManagementStock.SelectedItem;
                ShopManager.Remove(s);
            }
        }

        private void btnManagementStockFilter_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lbManagemendEmployees.SelectedIndex > -1)
            {
                Object s = lbManagemendEmployees.SelectedItem;
                Employee selected = (Employee)s;
                ViewEmployeeDetails v = new ViewEmployeeDetails(selected);
                v.Show();

            }
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            if(lbManagemendEmployees.SelectedIndex > -1)
            {
                Object s = lbManagemendEmployees.SelectedItem;
                Employee emp = (Employee)s;
                Employees.Remove(emp);
            }
        }
    }
}
