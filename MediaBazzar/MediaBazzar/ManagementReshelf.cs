﻿using System;
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
    public partial class ManagementReshelf : Form
    {
        Stock a;
        ReshelfRequestManager requests;
        DateTime time;
        public ManagementReshelf(Stock a)
        {
            InitializeComponent();
            this.a = a;
            lblStockName.Text = a.Name;
            requests = new ReshelfRequestManager();
        }

        private void ManagementReshelf_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReshelfApprove_Click(object sender, EventArgs e)
        {/*
            ReshelfRequest therequest = new ReshelfRequest(a, Convert.ToInt32(tbReshelfApprove.Text));
            requests.Add(therequest);
            MessageBox.Show(therequest.ToString());*/
        }
    }
}
