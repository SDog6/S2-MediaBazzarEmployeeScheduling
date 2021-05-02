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


            lblFire.Text = $"Please state the reason for firing {emp.PersonalInfo.FirstName}";
        }

        private void EmployeeFiring_Load(object sender, EventArgs e)
        {

        }
    }
}
