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
    public partial class AdministrationForm : Form
    {
        Administration ad = new Administration();
        public AdministrationForm()
        {
            InitializeComponent();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Address address = new Address(tbEState.Text, tbECity.Text, tbEStreetName.Text, tbEStreetNr.Text);
                Address contactAddress = new Address(tbCstate.Text, tbECity.Text, tbCstreetname.Text, tbCstreetnr.Text);
                Person Contactperson = new Person(tbCName.Text, tbCLastname.Text, tbCPhoneNumber.Text, contactAddress, tbCEmail.Text);
                Contract contract = new Contract(DateTime.Now);
                Employee employee = new Employee(tbEname.Text, tbELastname.Text, tbEPhoneNumber.Text, address, tbEEmail.Text, Contactperson, tbYear.Text, tbEBSN.Text, contract);
                ad.AddEmployee(employee);
                Account account = new Account(tbUsername.Text, employee);
                ad.AddAccount(account);

            }
            catch (Exception)
            {
                MessageBox.Show("There was an Error");
            }

            lbScreen.Items.Clear();

            foreach (Account item in ad.GetAccounts())
            {
                lbScreen.Items.Add(item);
            }
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {

        }
    }
}
