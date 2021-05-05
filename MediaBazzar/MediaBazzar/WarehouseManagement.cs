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
    
        private void btnWarehouseAddItem_Click(object sender, EventArgs e)
        {
            NewStock f = new NewStock(WarehouseStock);
            f.Show();
        }

        private void btnWarehouseSearch_Click(object sender, EventArgs e)
        {
            lbWarehouseStock.Items.Clear();
            if (rbWarehouseBrand.Checked)
            {
                string brand = tbWarehouseSearch.Text;
                foreach (Stock s in WarehouseStock.SearchByBrand(brand))
                {
                    lbWarehouseStock.Items.Add(s);
                }
            }
            else if (rbWarehouseItemID.Checked)
            {
                int ID = Convert.ToInt32(tbWarehouseSearch.Text);
                foreach (Stock s in WarehouseStock.SearchByID(ID))
                {

                    lbWarehouseStock.Items.Add(s);

                }
            }
        }

        private void btnWarehouseResupply_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > -1)
            {
                Stock selected = (Stock)dataGridView1.CurrentRow.DataBoundItem;
                selected.Resupply(Convert.ToInt32(tbWarehouseResupply.Text));
            }
            if (lbWarehouseStock.SelectedIndex > -1)
            {
                Stock selected = (Stock)lbWarehouseStock.SelectedItem;
                selected.Resupply(Convert.ToInt32(tbWarehouseResupply.Text));
            }

            UpdateUI();
        }

        public void UpdateUI()
        {
            List<object> dstock = WarehouseStock.GetAllPerType();
            BindingSource bs = new BindingSource();
            bs.DataSource = dstock;
            dataGridView1.DataSource = bs;
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            
        }

        private void WarehouseManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            //Object s = lbWarehouseStock.SelectedItem;
            //WarehouseStock.Remove(s);
            //UpdateUI();
        }

        private void lbWarehouseStock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            NewStock f = new NewStock(WarehouseStock);
            f.Show();
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
    }
}
