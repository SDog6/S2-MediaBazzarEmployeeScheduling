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
        ShopStock stock;
        Administration Employees;
        DateTime time;
        public Management()
        {
            InitializeComponent();
            time = DateTime.Now;
            stock = new ShopStock();
            stock.Add(new Stock("Jordans", 40, 343, 40, "Nike"));
            Employees = new Administration();
            Employees.AddEmployee(new Employee("Lee", "Johnson", "09808920203", new Address("Kenya", "Obama", "Sangerlaan", "28"), "Lee@gmail.com", new Person("John", "Lee", "03039393", new Address("Alabama", "Kanzas", "28 beach", "25"), "J@gmail.com"), "01.02.1998", "323242423", new Contract(time)));
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

        private void btnManagemntPersonUpdate_Click(object sender, EventArgs e)
        {
            if(lbManagemendEmployees.SelectedIndex > -1)
            {

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

        private void btnManagemendUpdate_Click(object sender, EventArgs e)
        {
            lbManagemendEmployees.Items.Clear();
            foreach (Employee item in Employees.GetAll())
            {
                lbManagemendEmployees.Items.Add(item);
            }
        }
    }
}
