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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Management f = new Management();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccountCreateForm f = new AccountCreateForm();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WarehouseManagement f = new WarehouseManagement();
            f.Show();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
