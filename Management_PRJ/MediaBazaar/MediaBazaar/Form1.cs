using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class Form1 : Form
    {
        private Manager Floor_manager;
        private List <Department> departments;
        public Form1()
        {
            InitializeComponent();
            this.Floor_manager = new Manager("Boby");
            this.departments = new List<Department>();
            cbxDepartment.Items.AddRange(this.Floor_manager.GetDepartments());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Employee[] employees;
            employees = this.Floor_manager.GetDepartment("Phone").GetEmployees();
            foreach(Employee a in employees)
            {
                listBox1.Items.Add(a.GetInfo());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //department.AddEmployee("name", "name", "phone", "street","city","state","email");
            panel_AddEmpl.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnPAddEmpl_Click(object sender, EventArgs e)
        {
            Floor_manager.GetDepartment("Phone").AddEmployee(tbxFname.Text, tbxSname.Text, tbxPhone.Text, tbxStreet.Text,tbxCity.Text,tbxState.Text,tbxEmail.Text);
            tbxFname.Clear();
            tbxSname.Clear(); 
            tbxPhone.Clear();
            tbxStreet.Clear(); 
            tbxCity.Clear(); 
            tbxState.Clear(); 
            tbxEmail.Clear();
            panel_AddEmpl.Visible = false;
        }
    }
}
