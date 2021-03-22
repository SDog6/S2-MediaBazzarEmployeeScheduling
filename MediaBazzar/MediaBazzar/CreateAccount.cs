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
        DateTime time = DateTime.Now;
        
        public AccountCreateForm()
        {
            InitializeComponent();
          ad.AddEmployee(new Employee(2332,"Lee", "Johnson", "09808920203", new Address("Kenya", "Obama", "Sangerlaan", "28"), "Lee@gmail.com", new Person("John", "Lee", "03039393", new Address("Alabama", "Kanzas", "28 beach", "25"), "J@gmail.com"), "01.02.1998", "323242423", new Contract(time)));
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbUsername.Text != "")
                {
                    Employee employee = (Employee)lbEmployees.SelectedItem;
                    if (employee.GetAccount() != null)
                    {
                        employee.GetAccount().SetUsername(tbUsername.Text);
                    }
                    else
                    {
                        Account account = new Account(tbUsername.Text, employee);
                        ad.AddAccount(account);
                        employee.SetAccount(account);
                        if (employee != null)
                        {
                            lblInfo.Text = account.getUsername();
                        }
                        else
                        {
                            MessageBox.Show("You did not select a employee yet!");
                        }
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
            try
            {
                lbEmployees.Items.Clear();
                foreach (Employee item in Administration.employees)
                {
                    if(item.GetAccount() == null)
                    {
                        lbEmployees.Items.Add(item);
                    }
                }

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

