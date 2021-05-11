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
    public partial class WarehouseManagement : Form
    {
        WarehouseStockManager WarehouseStock;

        public WarehouseManagement()
        {
            InitializeComponent();
            WarehouseStock = new WarehouseStockManager();
            UpdateUI();
            rbWarehouseItemID.Checked = true;
        }

        private void btnWarehouseUpdate_Click(object sender, EventArgs e)
        {
            UpdateUI();
        }

        //private void btnWarehouseSearch_Click(object sender, EventArgs e)
        //{
        //    dataGridView1.Rows.Clear();
        //    if (rbWarehouseBrand.Checked)
        //    {
        //        string brand = tbWarehouseSearch.Text;
        //        foreach (Stock s in WarehouseStock.SearchByBrand(brand))
        //        {
        //            dataGridView1.Rows.Add(s);
        //        }
        //    }
        //    else if (rbWarehouseItemID.Checked)
        //    {
        //        int ID = Convert.ToInt32(tbWarehouseSearch.Text);
        //        foreach (Stock s in WarehouseStock.SearchByID(ID))
        //        {

        //            dataGridView1.Rows.Add(s);

        //        }
        //    }
        //}

        private void btnWarehouseResupply_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > -1)
            {
                Stock selected = (Stock)dataGridView1.CurrentRow.DataBoundItem;
                WarehouseStock.IncreaseStock(selected, Convert.ToInt32(tbWarehouseResupply.Text));
            }
            WarehouseStock = new WarehouseStockManager();
            UpdateUI();
        }

        public void UpdateUI()
        {
            List<object> dstock = WarehouseStock.GetAllPerType();
            BindingSource bs = new BindingSource();
            bs.DataSource = dstock;
            dataGridView1.DataSource = bs;
        }
        //private void btnRemove_Click(object sender, EventArgs e)
        //{
            
        //}

        //private void WarehouseManagement_Load(object sender, EventArgs e)
        //{

        //}

        //private void btnRemove_Click_1(object sender, EventArgs e)
        //{
        //    //Object s = lbWarehouseStock.SelectedItem;
        //    //WarehouseStock.Remove(s);
        //    //UpdateUI();
        //}

        //private void lbWarehouseStock_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            NewStock f = new NewStock(WarehouseStock,this);
            f.Show();
            this.Hide();
        }

        private void btnDiscontinue_Click(object sender, EventArgs e)
        {
            //Object s = lbWarehouseStock.SelectedItem;
            //WarehouseStock.Remove(s);
            if (dataGridView1.SelectedRows.Count > -1)
            {
                Stock selected = (Stock)dataGridView1.CurrentRow.DataBoundItem;
                WarehouseStock.Unavailable(selected);
            }

            UpdateUI();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            ManagementReshelf a = new ManagementReshelf();
            a.Show();
            this.Close();
        }
    }
}
