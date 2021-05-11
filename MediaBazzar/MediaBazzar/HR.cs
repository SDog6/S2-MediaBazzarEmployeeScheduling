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
        DataTable employeeTable;
        public HR()
        {
            InitializeComponent();
            Employees = new EmployeeManager();
            employeeTable = new DataTable();
            prepareTable();
            fillTable();
        }
        private void prepareTable()
        {
            DataColumn column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "id";
            column.ReadOnly = true;
            employeeTable.Columns.Add(column);
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "name";
            column.ReadOnly = true;
            employeeTable.Columns.Add(column);
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "role";
            column.ReadOnly = true;
            employeeTable.Columns.Add(column);
        }
        private void fillTable()
        {
            foreach (Employee emp in Employees.GetAllPerType())
            {
                employeeTable.Rows.Add(emp.EmployeeID, $"{emp.PersonalInfo.FirstName} {emp.PersonalInfo.LastName}", emp.Role);
            }
            dataGrid_employees.DataSource = employeeTable;
        }

        private void btnEmpDetails_Click(object sender, EventArgs e)
        {
            Employee emp = this.GetSelectedEmployee();
            ViewEmployeeData data = new ViewEmployeeData(emp);
            data.Show();
        }
        private Employee GetSelectedEmployee()
        {
            if(dataGrid_employees.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGrid_employees.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                Employee emp = Employees.GetEmployee(id);
                return emp;
            }
            return null;
        }

        private void firedEmployeeClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void btnFireEmp_Click(object sender, EventArgs e)
        {
            Employee emp = GetSelectedEmployee();
            if(emp != null)
            {
                EmployeeFiring fireForm = new EmployeeFiring(emp);
                fireForm.FormClosed += new FormClosedEventHandler(firedEmployeeClosed);
                fireForm.Show();
                this.Hide();
            }
        }
        private void btnEmpUpdate_Click(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmployeeCreation f = new EmployeeCreation(Employees);
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
