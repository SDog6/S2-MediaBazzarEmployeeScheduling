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
    public partial class Management : Form
    {
        ShopStockManager stock;
        EmployeeManager EmployeeManager;
        DataTable stockTable;
        DataTable employeeTable;
        public Management()
        {
            InitializeComponent();
            stock = new ShopStockManager();
            EmployeeManager = new EmployeeManager();
            stockTable = new DataTable();
            employeeTable = new DataTable();
            prepareTables();
            ShowAllEmployees(true);
            radio_ID.Checked = true;
            rbManagementStockIDFilter.Checked = true;
            checkBox_active.CheckState = CheckState.Checked;      
            UpdateStockUI();
        }
        private void prepareTables()
        {
            //employee table
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
            //stock table
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Name";
            column.ReadOnly = true;
            stockTable.Columns.Add(column);
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Amount";
            column.ReadOnly = true;
            stockTable.Columns.Add(column);
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Price";
            column.ReadOnly = true;
            stockTable.Columns.Add(column);
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Available";
            column.ReadOnly = true;
            stockTable.Columns.Add(column);
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
            dataGrid_stocks.DataSource = bs;


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
        private void btnStockRemove_Click(object sender, EventArgs e)
        {

            /*if (lbManagementStock.SelectedIndex > -1)
            {
                Object s = lbManagementStock.SelectedItem;
                stock.Remove(s);
            }*/
            //dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

            Object s = (Object)dataGrid_stocks.CurrentRow.DataBoundItem;
            stock.Remove(s);
        }
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ShiftScheduling s = new ShiftScheduling();
            s.Show();
        }

        private void checkBox_active_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_active.Checked)
            {
                checkbox_fired.CheckState = CheckState.Unchecked;
            }
            filter();
        }

        private void radio_ID_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_ID.Checked)
            {
                txt_search.Visible = true;
                cb_allRoles.Visible = false;
                filter();
                txt_search.Text = String.Empty;
            }
        }

        private void radio_role_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_role.Checked)
            {
                txt_search.Visible = false;
                cb_allRoles.Visible = true;
                filter();
            }
        }

        private void radio_name_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_name.Checked)
            {
                txt_search.Visible = true;
                cb_allRoles.Visible = false;
                filter();
                txt_search.Text = String.Empty;
            }
        }
        private bool GetEmployeeStatus()
        {
            bool employeeStatus = false;
            if (checkBox_active.Checked)
            {
                employeeStatus = true;
            }
            return employeeStatus;
        }

        private void filter()
        {
            employeeTable.Rows.Clear();
            bool employeeStatus = GetEmployeeStatus();
            if (radio_role.Checked)
            {
                fillRoles();
                ShowAllEmployees(employeeStatus);
                if (cb_allRoles.SelectedIndex > -1)
                {
                    RoleSearch(cb_allRoles.SelectedIndex, employeeStatus);
                }
            }
            if (radio_ID.Checked)
            {
                IDSearch(employeeStatus);
            }
            else if (radio_name.Checked)
            {
                NameSearch(employeeStatus);
            }
        }


        private void IDSearch(bool employeeStatus)
        {
            string searchId = txt_search.Text;
            if (String.IsNullOrEmpty(searchId))
            {
                ShowAllEmployees(employeeStatus);
                return;
            }
            if (int.TryParse(searchId, out int ID))
            {
                foreach (Employee emp in EmployeeManager.Employees)
                {
                    if (emp.EmployeeID == ID && emp.Active == employeeStatus)
                    {
                        employeeTable.Rows.Add(emp.EmployeeID, $"{emp.PersonalInfo.FirstName} {emp.PersonalInfo.LastName}", emp.Role);
                        dataGrid_employees.DataSource = employeeTable;
                    }

                }
            }
        }

        private void NameSearch(bool employeeStatus)
        {
            string searchWord = txt_search.Text.ToLower();
            if (String.IsNullOrEmpty(searchWord))
            {
                ShowAllEmployees(employeeStatus);
                return;
            }
            foreach (Employee emp in EmployeeManager.Employees)
            {
                string firstName = emp.PersonalInfo.FirstName.ToLower();
                string lastName = emp.PersonalInfo.LastName.ToLower();
                if ((firstName.Contains(searchWord) || lastName.Contains(searchWord)) && emp.Active == employeeStatus)
                {
                    employeeTable.Rows.Add(emp.EmployeeID, $"{emp.PersonalInfo.FirstName} {emp.PersonalInfo.LastName}", emp.Role);
                    dataGrid_employees.DataSource = employeeTable;
                }
            }
        }

        private void fillRoles()
        {
            cb_allRoles.Items.Clear();
            foreach (Employee emp in EmployeeManager.Employees)
            {
                if (!cb_allRoles.Items.Contains(emp.Role))
                {
                    cb_allRoles.Items.Add(emp.Role);
                }
            }
        }
        private void RoleSearch(int index, bool employeeStatus)
        {
            employeeTable.Rows.Clear();
            foreach (Employee emp in EmployeeManager.Employees)
            {
                if (emp.Role == cb_allRoles.Items[index].ToString() && emp.Active == employeeStatus)
                {
                    employeeTable.Rows.Add(emp.EmployeeID, $"{emp.PersonalInfo.FirstName} {emp.PersonalInfo.LastName}", emp.Role);
                    dataGrid_employees.DataSource = employeeTable;
                }
            }
        }


        public void ShowAllEmployees(bool employeeStatus)
        {
            employeeTable.Rows.Clear();
            foreach (Employee emp in EmployeeManager.Employees)
            {
                if (emp.Active == employeeStatus)
                {
                    employeeTable.Rows.Add(emp.EmployeeID, $"{emp.PersonalInfo.FirstName} {emp.PersonalInfo.LastName}", emp.Role);
                    dataGrid_employees.DataSource = employeeTable;
                }
            }

        }

        private void cb_allRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void checkbox_fired_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_fired.Checked)
            {
                checkBox_active.CheckState = CheckState.Unchecked;
            }
            filter();
        }

        private void btnViewEmployeeInfo_Click_1(object sender, EventArgs e)
        {
            ShiftScheduling s = new ShiftScheduling();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShiftScheduling s = new ShiftScheduling();
            s.Show();
        }
        private void filterStock()
        {
            List<Stock> stocks = stock.allStocks;
            stockTable.Rows.Clear();
            if (rbManagementStockAmountFilter.Checked)
            {
                if (int.TryParse(tbManagementStockFilter.Text, out int amount))
                {
                    foreach (Stock s in stocks)
                    {
                        if (s.Amount == amount)
                        {
                            stockTable.Rows.Add(s.Name, s.Amount, s.Price, s.AvailableStr);
                            dataGrid_stocks.DataSource = stockTable;
                        }
                    }
                }
            }
            if (rbManagementStockBrandFilter.Checked)
            {
                foreach (Stock s in stocks)
                {
                    string searchedBrand = tbManagementStockFilter.Text.ToLower();
                    if (s.Brand.ToLower().Contains(searchedBrand))
                    {
                        stockTable.Rows.Add(s.Name, s.Amount, s.Price, s.AvailableStr);
                        dataGrid_stocks.DataSource = stockTable;
                    }
                }
            }
            if (rbManagementStockIDFilter.Checked)
            {
                if (int.TryParse(tbManagementStockFilter.Text, out int id))
                {
                    foreach (Stock s in stocks)
                    {
                        if (s.ID == id)
                        {
                            stockTable.Rows.Add(s.Name, s.Amount, s.Price, s.AvailableStr);
                            dataGrid_stocks.DataSource = stockTable;
                        }
                    }
                }
            }
        }
        public void showAllStock()
        {
            List<Stock> stocks = stock.allStocks;
            stockTable.Rows.Clear();
            foreach(Stock s in stocks)
            {
                stockTable.Rows.Add(s.Name, s.Amount, s.Price, s.AvailableStr);
                dataGrid_stocks.DataSource = stockTable;
            }
        }
        private void tbManagementStockFilter_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbManagementStockFilter.Text))
            {
                filterStock();
            }
        }

        private void rbManagementStockIDFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManagementStockIDFilter.Checked)
            {
                tbManagementStockFilter.Text = String.Empty;
                showAllStock();
            }
        }

        private void rbManagementStockBrandFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManagementStockBrandFilter.Checked)
            {
                tbManagementStockFilter.Text = String.Empty;
                showAllStock();
            }
        }

        private void rbManagementStockAmountFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManagementStockAmountFilter.Checked)
            {
                tbManagementStockFilter.Text = String.Empty;
                showAllStock();
            }
        }
    }
}
