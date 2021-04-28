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
        EmployeeManager Employeess;
        DataTable EmployeeTable = new DataTable("all employees table");
        public HR()
        {
            InitializeComponent();
            Employeess = new EmployeeManager();
          
            DGVManagementEmployees.DataSource = Employeess.GetAllPerType();
            DGVManagementEmployees.Columns[1].Visible = false;
            DGVManagementEmployees.Rows[1].Visible = false;
            lbManagemendEmployees.Items.Clear();
            foreach (Employee item in Employeess.GetAllPerType())
            {
                lbManagemendEmployees.Items.Add(item);
                
            }
          
        }

        private void btnEmpDetails_Click(object sender, EventArgs e)
        {
            if (lbManagemendEmployees.SelectedIndex > -1)
            {
                Object s = lbManagemendEmployees.SelectedItem;
                Employee Selected = (Employee)s;
                ViewEmployeeData v = new ViewEmployeeData(Selected);
                v.Show();

            }
        }

        private void btnFireEmp_Click(object sender, EventArgs e)
        {
            Employee emp = (Employee)lbManagemendEmployees.SelectedItem;
            EmployeeFiring em = new EmployeeFiring(emp);
            em.Show();
        }

        private void btnEmpUpdate_Click(object sender, EventArgs e)
        {

        }

        private void Employees_Load(object sender, EventArgs e)
        {
           

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmployeeCreation f = new EmployeeCreation(Employeess);
            f.Show();
        }
    }
}
