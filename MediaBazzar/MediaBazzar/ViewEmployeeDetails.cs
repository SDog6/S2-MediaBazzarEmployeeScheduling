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
    public partial class ViewEmployeeDetails : Form
    {
        Employee e;
        public ViewEmployeeDetails(Employee e)
        {
            InitializeComponent();
            this.e = e;
            tbAddress.Text = e.Address;
            tbBSN.Text = e.BSN.ToString();
            tbCName.Text = e.ContactPersonName;
            tbCPhone.Text = e.ContactPeronPhone.ToString();
            tbDateOfBirth.Text = e.DateOfBirth;
            tbEmail.Text = e.DateOfBirth;
            tbEUsername.Text = e.Username;
            tbEPassword.Text = e.Password;
            tbEmployeeRole.Text = e.Role;
            tbEname.Text = e.FirstName;
            tbELastname.Text = e.LastName;
            tbEPhoneNumber.Text = e.PhoneNumber.ToString();
        }

        private void ViewEmployeeDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
