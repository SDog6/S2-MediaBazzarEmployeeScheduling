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
    public partial class ManagementReshelf : Form
    {
        ReshelfRequestManager requests;
        DataTable Requests;
        WarehouseStockManager WarehouseStock;
        public ManagementReshelf()
        {
            InitializeComponent();
            Requests = new DataTable();
            requests = new ReshelfRequestManager();
            WarehouseStock = new WarehouseStockManager();

            //stock table
            DataColumn column;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "ID";
            column.ReadOnly = true;
            Requests.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Amount needed";
            column.ReadOnly = true;
            Requests.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Amount in stock";
            column.ReadOnly = true;
            Requests.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Stock name";
            column.ReadOnly = true;
            Requests.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Requested on";
            column.ReadOnly = true;
            Requests.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Status";
            column.ReadOnly = true;
            Requests.Columns.Add(column);

            checkbox_unfnished.Checked = true;
            UpdateUI();
        }

        private void ManagementReshelf_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReshelfApprove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                ReshelfRequest r = (ReshelfRequest)requests.GetRequestByID(id);
                Stock currentlyInWarehouse = (Stock)WarehouseStock.GetStockByID(r.RequiredStock.ID);

                if (r.AmountNeeded <= currentlyInWarehouse.Amount)
                {
                    requests.CompleteRequest(r);
                    requests = new ReshelfRequestManager();
                    UpdateUI();
                    MessageBox.Show("Completed Request");
                }
                else
                {
                    MessageBox.Show("We don't have enough of that item to complete the request");

                }
            }
        }

        public void UpdateUI()
        {
            Requests.Rows.Clear();
            dataGridView1.Visible = true;
            if (checkBox_complete.Checked)
            {
                foreach (ReshelfRequest item in requests.GetAllPerType())
                    {
                        if (item.Complete == true)
                        {              
                                Stock currentlyInWarehouse = (Stock)WarehouseStock.GetStockByID(item.RequiredStock.ID);
                                Requests.Rows.Add(item.ID, item.AmountNeeded, currentlyInWarehouse.Amount, item.RequiredStock.Name, item.FilledDate.ToString("dd,MM,yy"), "Complete");
                                dataGridView1.DataSource = Requests;
                        }
                }
             
                        
            }    
            else if (checkbox_unfnished.Checked)
            {
                foreach (ReshelfRequest item in requests.GetAllPerType())
                {
                    if (item.Complete == false)
                    {
                            Stock currentlyInWarehouse = (Stock)WarehouseStock.GetStockByID(item.RequiredStock.ID);
                            Requests.Rows.Add(item.ID, item.AmountNeeded, currentlyInWarehouse.Amount, item.RequiredStock.Name, item.FilledDate.ToString("dd,MM,yy"), "Pending");
                            dataGridView1.DataSource = Requests;
                    }
                }
            }
        }

        private void checkBox_complete_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_complete.Checked)
            {
                checkbox_unfnished.CheckState = CheckState.Unchecked;
            }
            UpdateUI();
        }

        private void checkbox_unfnished_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_unfnished.Checked)
            {
                checkBox_complete.CheckState = CheckState.Unchecked;
            }
            UpdateUI();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            WarehouseManagement f = new WarehouseManagement();
            f.Show();
            this.Close();
        }
    }
}
