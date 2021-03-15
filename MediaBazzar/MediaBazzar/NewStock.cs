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
        WarehouseStock passedManager;
        public NewStock(WarehouseStock passedManager)
        {
            InitializeComponent();
            this.passedManager = passedManager;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbNewStockName.Text;
            string brand = tbNewStockBrand.Text;
            int ID = Convert.ToInt32(tbNewStockID.Text);
            int Amount = Convert.ToInt32(tbNewStockAmount.Text);
            double price = Convert.ToDouble(tbNewStockPrice.Text);
            if(passedManager.Add(new Stock(name, Amount, ID, price, brand)))
            {
                MessageBox.Show("Sucessfully added stock");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
