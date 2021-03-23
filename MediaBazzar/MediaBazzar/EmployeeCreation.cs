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
    public partial class EmployeeCreation : Form
    {
        EmployeeManager em;
        public EmployeeCreation(EmployeeManager em)
        {
            InitializeComponent();
            this.em = em;

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
                
                Employee newguy = new Employee(tbEname.Text, tbELastname.Text, tbEUsername.Text, tbEPassword.Text, Convert.ToInt32(tbEPhoneNumber.Text), tbAddress.Text, tbEmail.Text, tbCName.Text, Convert.ToInt32(tbCPhone.Text), tbDateOfBirth.Text, Convert.ToInt32(tbBSN.Text), tbEmployeeRole.Text);
                em.Add(newguy);
               
            }

        private void EmployeeCreation_Load(object sender, EventArgs e)
        {

        }

        private void tbEname_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

