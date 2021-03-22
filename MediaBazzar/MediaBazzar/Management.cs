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
        Administration Employees;
        DateTime time;
        public Management()
        {
            InitializeComponent();
            time = DateTime.Now;
            stock = new ShopStockManager();
            Employees = new Administration();
            Employees.AddEmployee(new Employee(234,"Lee", "Johnson", "09808920203", new Address("Kenya", "Obama", "Sangerlaan", "28"), "Lee@gmail.com", new Person("John", "Lee", "03039393", new Address("Alabama", "Kanzas", "28 beach", "25"), "J@gmail.com"), "01.02.1998", "323242423", new Contract(time)));
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

        }

        private void btnManagemntPersonCreation_Click(object sender, EventArgs e)
        {
            EmployeeCreation creation = new EmployeeCreation();
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
            lbManagemendEmployees.Items.Clear();
            foreach (Employee item in Employees.GetAll())
            {
                lbManagemendEmployees.Items.Add(item);
            }

        }

        private void btnManagementUpdate_Click(object sender, EventArgs e)
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
        {/*
            NewStock a = new NewStock(stock);
            a.Show();*/
        }
    }
}
