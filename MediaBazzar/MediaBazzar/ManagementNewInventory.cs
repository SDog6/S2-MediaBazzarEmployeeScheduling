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
        Management trick;
        public ManagementNewInventory(ShopStockManager Shop,Management trick)
        {
            InitializeComponent();
            Warehouse = new WarehouseStockManager();
            this.trick = trick;
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
                    Stock a = (Stock)Stock;
                    if(a.Amount < Convert.ToInt32(textBox1.Text))
                    {
                        MessageBox.Show("The warehouse doesn't have enough of that item!");
                    }
                    else
                    {
                        Shop.Add(Stock, Convert.ToInt32(textBox1.Text));
                        Warehouse.ReduceStock(a.ID, Convert.ToInt32(textBox1.Text));
                        MessageBox.Show("Successfully added item to shop inventory");
                        UpdateUI();
                    }
                   
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
            List<int> tempWareId = new List<int>();
            List<int> tempShopId = new List<int>();

            foreach (Stock item in Warehouse.GetAllPerType())
            {
                if(item.Available == 1)
                {
                    tempWareId.Add(item.ID);
                }
            }
            foreach (Stock item in Shop.GetAllPerType())
            {
                if (item.Available == 1)
                {
                    tempShopId.Add(item.ID);
                }
            }
            foreach (int item in tempWareId)
            {
                if (!tempShopId.Contains(item))
                {
                    lbWarehouseStock.Items.Add(Warehouse.GetStockByID(item));
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            trick.showAllStock();
            trick.Show();
            this.Close();
        }
    }
}
