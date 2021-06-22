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
    public partial class NewStock : Form
    {
        WarehouseStockManager stock;
        WarehouseManagement trick;
        public NewStock(WarehouseStockManager stock,WarehouseManagement trick)
        {
            InitializeComponent();
            this.stock = stock;
            this.trick = trick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbNewStockName.Text;
            string brand = tbNewStockBrand.Text;
            int ID = Convert.ToInt32(tbNewStockID.Text);
            int Amount = Convert.ToInt32(tbNewStockAmount.Text);
            int price = Convert.ToInt32(tbNewStockPrice.Text);
            int available = 1;
            try
            {
                stock.Add(new Stock(name, Amount, ID, price, brand, available));
                MessageBox.Show("Added item to warehouse inventory");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            trick.UpdateUI();
            trick.Show();
            this.Close();
        }
    }
}
