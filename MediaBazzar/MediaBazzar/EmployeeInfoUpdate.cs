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
    public partial class EmployeeInfoUpdate : Form
    {
        Employee passed;
        public EmployeeInfoUpdate(Employee passed)
        {
            InitializeComponent();
            this.passed = passed;
        }

        private void EmployeeInfoUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
