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
        EmployeeManager em;
        public LogInForm()
        {
            InitializeComponent();
            em = new EmployeeManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Management f = new Management();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccountCreateForm f = new AccountCreateForm();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WarehouseManagement f = new WarehouseManagement();
            f.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {


                Employee LoginAttempt = em.GetEmployeeForLogin(tbLogInUsername.Text, tbLogInPassword.Text);
                if (LoginAttempt.Role == "Manager")
                {
                    Management f = new Management();
                    f.Show();
                }
                else if (LoginAttempt.Role == "Warehouse Manager")
                {
                    WarehouseManagement f = new WarehouseManagement();
                    f.Show();
                }
                else if (LoginAttempt == null)
                {
                    MessageBox.Show("Access Denied");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
