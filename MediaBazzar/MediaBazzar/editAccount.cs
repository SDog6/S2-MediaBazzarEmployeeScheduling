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

