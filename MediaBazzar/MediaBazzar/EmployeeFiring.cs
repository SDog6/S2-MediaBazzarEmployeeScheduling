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
    public partial class EmployeeFiring : Form
    {
        EmployeeManager Manager;
        Employee emp;
        public EmployeeFiring(Employee emp)
        {
            InitializeComponent();
            Manager = new EmployeeManager();
            this.emp = emp;
            lblName.Text = $"Name: {emp.PersonalInfo.FirstName} {emp.PersonalInfo.LastName}";
            lblAddress.Text = $"Address: {emp.PersonalInfo.Address}";
            lblRole.Text = $"Role: {emp.Role}";
            lblConInf.Text = $"Contract information: {emp.Contract.EmploymentStart}";
            lblWorkHrs.Text = $"Working hours: {emp.Contract.Workinghours}";
            lblFire.Text = $"Please state the reason for firing {emp.PersonalInfo.FirstName}";
        }

        private void EmployeeFiring_Load(object sender, EventArgs e)
        {

        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbFire.Text))
            {
                Manager.FireEmployee(emp, tbFire.Text);
                MessageBox.Show("Employee moved to non-active status");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
