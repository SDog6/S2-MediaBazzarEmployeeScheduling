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
    public partial class editAccount : Form
    {
        Administration ad = new Administration();
        public editAccount()
        {
            InitializeComponent();
        }

        private void btnShowAllEmployees_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbUsername.Text != "")
                {
                    Account ac = (Account)lbEmployees.SelectedItem;
                    

                    if (ac != null)
                    {
                        ad.setAccount(ac, tbUsername.Text);
                      MessageBox.Show("Username sucesfully changed");
                        UpdateList();
                    }
                    else
                    {
                        MessageBox.Show("You did not select a employee yet!");
                    }

                }
                else
                {
                    MessageBox.Show("Username was not changed, You have to write a username in the textbox!");
                }
            }


            catch (Exception)
            {

                MessageBox.Show("There seems to be an error, Please try again!");
            }
        

            
           


        }
        private void UpdateList()
        {
            try
            {
                lbEmployees.Items.Clear();
                foreach (Account item in ad.GetAccounts())
                {
                    lbEmployees.Items.Add(item);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error something went wrong");
            }
            }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    }

