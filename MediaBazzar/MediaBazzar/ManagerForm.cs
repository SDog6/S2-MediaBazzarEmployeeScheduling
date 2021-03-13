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
    public partial class ManagerForm : Form
    {
        private Manager manager;

        public ManagerForm()
        {
            InitializeComponent();
            this.manager = new Manager("Boby");
            foreach (Department d in this.manager.GetDepartments())
            {
                cbxDepartment.Items.Add(d.Name);
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Employee> employees;
            employees = this.manager.GetDepartment(cbxDepartment.Text).GetEmployees();
            foreach (Employee a in employees)
            {
                listBox1.Items.Add(a.GetInfo());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            panel_AddEmpl.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnPAddEmpl_Click(object sender, EventArgs e)
        {
            manager.GetDepartment(cbxDepartment.Text).AddEmployee(tbxFname.Text, tbxSname.Text, tbxPhone.Text, tbxStreet.Text, tbxCity.Text, tbxState.Text, tbxEmail.Text);
            tbxFname.Clear();
            tbxSname.Clear();
            tbxPhone.Clear();
            tbxStreet.Clear();
            tbxCity.Clear();
            tbxState.Clear();
            tbxEmail.Clear();
            panel_AddEmpl.Visible = false;
        }

        private void btnAddDep_Click(object sender, EventArgs e)
        {
            panelAddDep.Visible = true;
        }

        private void btnPAddDep_Click(object sender, EventArgs e)
        {
            this.manager.AddDepartment(textBox1.Text);
            textBox1.Clear();
            panelAddDep.Visible = false;
            cbxDepartment.Items.Clear();
            foreach (Department d in this.manager.GetDepartments())
            {
                cbxDepartment.Items.Add(d.Name);
            }
        }
    }
}
