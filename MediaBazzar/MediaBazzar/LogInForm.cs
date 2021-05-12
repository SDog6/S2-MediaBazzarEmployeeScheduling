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
    public partial class LogInForm : Form
    {
        EmployeeManager Manager;
        public LogInForm()
        {
            InitializeComponent();
            Manager = new EmployeeManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Management f = new Management();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HR f = new HR();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WarehouseManagement f = new WarehouseManagement();
            f.Show();
        }

        private void loginByRole(Employee emp)
        {
            if (emp.Role == "Manager")
            {
                Management v = new Management();
                v.Show();
            }
            if (emp.Role == "Warehouse Manager")
            {
                WarehouseManagement f = new WarehouseManagement();
                f.Show();
            }
            if (emp.Role == "Human resources")
            {
                HR f = new HR();
                f.Show();
            }
     
        }
        private bool empty(string s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return true;
            }
            return false;
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = tbLogInUsername.Text;
            string password = tbLogInPassword.Text;
            if(!empty(username) && !empty(password))
            {
                Employee emp = Manager.tryLogin(username, password);
                if (emp != null)
                {
                    loginByRole(emp);
                    return;
                }
                MessageBox.Show("Access Denied");
                return;
            }
        }
    }
}
