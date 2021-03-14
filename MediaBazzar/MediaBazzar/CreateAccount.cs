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
        Administration ad = new Administration();
        public AccountCreateForm()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbUsername.Text != "")
                {
                    Employee employee = (Employee)lbEmployees.SelectedItem;
                    Account account = new Account(tbUsername.Text, employee);
                    ad.AddAccount(account);
                    employee.SetAccount(account);


                    if (employee != null)
                    {
                        lblShowinfp.Text = account.ToString();
                    }
                    else
                    {
                        MessageBox.Show("You did not select a employee yet!");
                    }

                }
                else
                {
                    MessageBox.Show("You have to write a username to create an account");
                }
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
                lbEmployees.Items.Clear();
                foreach (Employee item in Administration.employees)
                {
                    lbEmployees.Items.Add(item);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("There seems to be an error Showing the employees!");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
 }

