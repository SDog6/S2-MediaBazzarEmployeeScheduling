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
        WarehouseStock WarehouseStock;

        public WarehouseManagement()
        {
            InitializeComponent();
            WarehouseStock = new WarehouseStock();
            WarehouseStock.Add(new Stock("Nike", 30, 45, 60, "Nike"));
            WarehouseStock.Add(new Stock("Nike", 30, 55, 60, "Suka"));
        }

        private void btnWarehouseUpdate_Click(object sender, EventArgs e)
        {
            lbWarehouseStock.Items.Clear();
            foreach (Stock s in WarehouseStock.GetAllPerType())
            {
                lbWarehouseStock.Items.Add(s);
            }
        }

        private void btnWarehouseAddItem_Click(object sender, EventArgs e)
        {
            /*NewStock f = new NewStock(WarehouseStock);*/
            /*f.Show();*/
        }

        private void btnWarehouseSearch_Click(object sender, EventArgs e)
        {
            lbWarehouseStock.Items.Clear();
            if (rbWarehouseBrand.Checked)
            {
                string brand = tbWarehouseSearch.Text;
                foreach (Stock s in WarehouseStock.GetAllPerType())
                {
                    if (s.Brand == brand)
                    {
                        lbWarehouseStock.Items.Add(s);
                    }
                    else { }
                }
            }
            else if (rbWarehouseItemID.Checked)
            {
                int ID = Convert.ToInt32(tbWarehouseSearch.Text);
                foreach (Stock s in WarehouseStock.GetAllPerType())
                {
                    if(s.ID == ID)
                    {
                        lbWarehouseStock.Items.Add(s);
                    }
                    else { }
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
    }
}
