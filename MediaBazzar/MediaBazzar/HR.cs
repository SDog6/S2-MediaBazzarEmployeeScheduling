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
    public partial class HR : Form
    {
        EmployeeManager Employees;
        public HR()
        {
            InitializeComponent();
            Employees = new EmployeeManager();
        }

        private void btnViewAllEmployees_Click(object sender, EventArgs e)
        {
            Employees f = new Employees();
            f.Show();
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            EmployeeCreation f = new EmployeeCreation(Employees);
            f.Show();
        }
    }
}
