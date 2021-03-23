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
            if(lbWarehouseStock.SelectedIndex > -1)
            {
                Stock selected = (Stock)lbWarehouseStock.SelectedItem;
                selected.Resupply(Convert.ToInt32(tbWarehouseResupply.Text));
            }
        }

        public void UpdateUI()
        {
            lbWarehouseStock.Items.Clear();
            foreach (Stock s in WarehouseStock.GetAllPerType())
            {
                lbWarehouseStock.Items.Add(s);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            Object s = lbWarehouseStock.SelectedItem;
            WarehouseStock.Remove(s);
            UpdateUI();
        }

        private void WarehouseManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
