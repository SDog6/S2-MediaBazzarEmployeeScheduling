using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace MediaBazzar
{
    public partial class Employees : Form
    {
        EmployeeManager Employeess;
        MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local; Uid=dbi457108; Database=dbi457108; Pwd=NewPassword123");
        MySqlDataAdapter Da;
        DataTable EmployeeTable = new DataTable("all employees table");
        public Employees()
        {
            InitializeComponent();
            Employeess = new EmployeeManager();
          
            
          
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

        }

        private void btnEmpUpdate_Click(object sender, EventArgs e)
        {

        }

        private void Employees_Load(object sender, EventArgs e)
        {

            Da = new MySqlDataAdapter("SELECT employee.role, person.firstName, person.lastName, employee.contractId , person.phoneNumber, person.email FROM employee LEFT JOIN person on employee.personId = person.id", conn);
            Da.Fill(EmployeeTable);
            DGVManagementEmployees.DataSource = EmployeeTable;
            DGVManagementEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
