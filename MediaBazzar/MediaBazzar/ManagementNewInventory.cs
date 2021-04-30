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
    public partial class ManagementNewInventory : Form
    {
        WarehouseStockManager Warehouse;
        ShopStockManager Shop;
        public ManagementNewInventory(ShopStockManager Shop)
        {
            InitializeComponent();
            Warehouse = new WarehouseStockManager();
            this.Shop = Shop;
            UpdateUI();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {


                if (lbWarehouseStock.SelectedIndex > -1)
                {
                    Object Stock = lbWarehouseStock.SelectedItem;
                    Shop.Add(Stock, Convert.ToInt32(textBox1.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateUI()
        {
            lbWarehouseStock.Items.Clear();
            foreach (Stock item in Warehouse.GetAllPerType())
            {
                lbWarehouseStock.Items.Add(item);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbWarehouseStock_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
