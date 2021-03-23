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
    public partial class AccountCreateForm : Form
    {
        DateTime time = DateTime.Now;
        
        public AccountCreateForm()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {

            }


            catch (Exception)
            {

                MessageBox.Show("There seems to be an error, Please try again!");
            }
        }

        private void btnShowAllEmployees_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                MessageBox.Show("There seems to be an error Showing the employees!");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               

            }
            catch (Exception)
            {
                MessageBox.Show("There seems to be an error Showing the employees!");

            }

        }

        private void btnOpenEditor_Click(object sender, EventArgs e)
        {
            editAccount editForm = new editAccount();
            editForm.Show();
        }
    }
 }

