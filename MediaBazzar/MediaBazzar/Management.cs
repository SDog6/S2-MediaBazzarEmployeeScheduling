﻿using System;
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
    public partial class Management : Form
    {
        ShopStockManager stock;
        EmployeeManager Employees;
        ShiftSchedulingManager Shifts;
        DateTime Monday;
        DateTime Sunday;
        int shiftcounter;
        MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local; Uid=dbi457108; Database=dbi457108; Pwd=NewPassword123");
        MySqlDataAdapter Da;
        DataTable EmployeeTable = new DataTable("all employees table");
        public Management()
        {
            InitializeComponent();
            stock = new ShopStockManager();
            Employees = new EmployeeManager();
            Shifts = new ShiftSchedulingManager();
            rbManagementID.Checked = true;
            rbManagementStockIDFilter.Checked = true;
            UpdateStockUI();
            UpdateEmployeeUI();
          
        }

        private void btnManagementRestockRequest_Click(object sender, EventArgs e)
        {
           /* if(lbManagementStock.SelectedIndex > -1)
            {
                Stock a = (Stock)lbManagementStock.SelectedItem;
                ManagementReshelf m = new ManagementReshelf(a);
                m.Show();
            }
            */
        }

        private void btnManagementEPFilter_Click(object sender, EventArgs e)
        {
            lbManagemendEmployees.Items.Clear();
            if (rbManagementID.Checked)
            {
                int id = Convert.ToInt32(tbManagementEPFilter.Text);
                foreach (Employee item in Employees.GetAllPerID(id))
                {
                    lbManagemendEmployees.Items.Add(item);
                } 
            }
            else if (rbManagementRole.Checked)
            {
                string role = tbManagementEPFilter.Text;
                foreach (Employee item in Employees.GetAllPerRole(role))
                {
                    lbManagemendEmployees.Items.Add(item);
                }
            }
        }

        private void btnManagemntPersonCreation_Click(object sender, EventArgs e)
        {
            EmployeeCreation creation = new EmployeeCreation(Employees);
            creation.Show();
        }

        private void btnManagemntPersonUpdate_Click(object sender, EventArgs e)
        {
            if(lbManagemendEmployees.SelectedIndex > -1)
            {

            }
        }


        private void btnManagemendUpdate_Click(object sender, EventArgs e)
        {
            UpdateEmployeeUI();
        }

        public void UpdateEmployeeUI()
        {
            lbManagemendEmployees.Items.Clear();
            foreach (Employee item in Employees.GetAllPerType())
            {
                lbManagemendEmployees.Items.Add(item);
            }

        }

        private void btnManagementStockUpdate_Click(object sender, EventArgs e)
        {
            /*lbManagementStock.Items.Clear();
            foreach (Stock item in stock.GetAllPerType())
            {
                lbManagementStock.Items.Add(item);
            }*/
        }

        private void btnManagemntPersonUpdate_Click_1(object sender, EventArgs e)
        {

        }

        private void btnManagementNewStock_Click(object sender, EventArgs e)
        {
            ManagementNewInventory a = new ManagementNewInventory(stock);
            a.Show();
        }

        private void btnManagementStockUpdate_Click_1(object sender, EventArgs e)
        {
            UpdateStockUI();
        }
        public void UpdateStockUI()
        {
            List<object> dstock = stock.GetAllPerType();
            BindingSource bs = new BindingSource();
            bs.DataSource = dstock;
            dataGridView1.DataSource = bs;


            /*lbManagementStock.Items.Clear();
            foreach (Stock item in stock.GetAllPerType())
            {
                lbManagementStock.Items.Add(item);
            }*/
            //dataGridView1.Rows.Clear();
            //dataGridView1.DataSource = stock;
            //dataGridView1.ColumnCount = 5;
            //dataGridView1.Columns[0].Name = "ID";
            //dataGridView1.Columns[1].Name = "Name";
            //dataGridView1.Columns[2].Name = "Amount";
            //dataGridView1.Columns[3].Name = "Price";
            //dataGridView1.Columns[4].Name = "Availability";
            //string[] row = new string[4];




            //    foreach (Stock item in stock.GetAllPerType())
            //    {
            //        dataGridView1.Rows.Add(item.ID, item.Name, item.Amount, item.Price, item.AvailableStr);   
            //    }
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    if (row.Cells[3].Value != "Available")
            //    {
            //        row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
            //    }
            //    else
            //    {
            //        row.DefaultCellStyle.BackColor = Color.LightGray;
            //    }
            //}

        }

        private void btnViewEmployeeInfo_Click(object sender, EventArgs e)
        {
            if(lbManagemendEmployees.SelectedIndex > -1) 
            {
                Object s = lbManagemendEmployees.SelectedItem;
                Employee Selected = (Employee)s;
                ViewEmployeeData v = new ViewEmployeeData(Selected);
                v.Show();
            
            }
        }

        private void btnStockRemove_Click(object sender, EventArgs e)
        {

            /*if (lbManagementStock.SelectedIndex > -1)
            {
                Object s = lbManagementStock.SelectedItem;
                stock.Remove(s);
            }*/
            //dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

            Object s = (Object)dataGridView1.CurrentRow.DataBoundItem; 
            stock.Remove(s);
        }

        private void btnManagementStockFilter_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (rbManagementStockIDFilter.Checked)
            {
                int id = Convert.ToInt32(tbManagementStockFilter.Text);
                foreach (Stock item in stock.GetAllPerID(id))
                {
                    dataGridView1.Rows.Add(item.Name, item.Amount, item.Price, item.AvailableStr);
                }
            }
            else if (rbManagementStockBrandFilter.Checked)
            {
                string brand = tbManagementStockFilter.Text;
                foreach (Stock item in stock.GetAllPerBrand(brand))
                {
                    dataGridView1.Rows.Add(item.Name, item.Amount, item.Price, item.AvailableStr);
                }
            }
            else if (rbManagementStockAmountFilter.Checked)
            {

                int amount = Convert.ToInt32(tbManagementStockFilter.Text);
                foreach (Stock item in stock.GetAllPerAmount(amount))
                {
                    dataGridView1.Rows.Add(item.Name, item.Amount, item.Price, item.AvailableStr);
                }
            }
        }


        private void lbManagementShiftEmployeesAssigned_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Management_Load(object sender, EventArgs e)
        {
            Da = new MySqlDataAdapter("SELECT employee.role, person.firstName, person.lastName FROM employee LEFT JOIN person on employee.personId = person.id", conn);
            Da.Fill(EmployeeTable);
            DgvManagemendEmployees.DataSource = EmployeeTable;
            DgvManagemendEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ShiftScheduling s = new ShiftScheduling();
            s.Show();
        }
    }
}
