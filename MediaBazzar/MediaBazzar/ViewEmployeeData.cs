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
    public partial class ViewEmployeeData : Form
    {
        Employee emp;
        public ViewEmployeeData(Employee emp)
        {
            InitializeComponent();
            this.emp = emp;
            try
            {
                tbEname.Text = emp.FirstName;
                tbELastname.Text = emp.LastName;
                tbEPhoneNumber.Text = emp.PhoneNumber;
                tbEEmail.Text = emp.Email;

                tbEState.Text = emp.Address.State;
                tbECity.Text = emp.Address.City;
                tbEStreetName.Text = emp.Address.Street;

                tbCName.Text = emp.ContactPerson.FirstName;
                tbCLastname.Text = emp.ContactPerson.LastName;
                tbCPhoneNumber.Text = emp.ContactPerson.PhoneNumber;
                tbCEmail.Text = emp.ContactPerson.Email;

                tbCstate.Text = emp.ContactPerson.Address.State;
                tbCCity.Text = emp.ContactPerson.Address.City;
                tbCstreetname.Text = emp.ContactPerson.Address.Street;

                tbErole.Text = emp.Role;
                tbCstreetnr.Text = emp.ContactPerson.Address.ApartmentNr;
                tbEStreetNr.Text = emp.Address.ApartmentNr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ViewEmployeeData_Load(object sender, EventArgs e)
        {

        }

    }
}
