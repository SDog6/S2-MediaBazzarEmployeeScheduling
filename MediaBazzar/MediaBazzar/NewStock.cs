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
        public NewStock(WarehouseStockManager stock)
        {
            InitializeComponent();
            this.stock = stock;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
