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
    public partial class AdministrationForm : Form
    {
        Administration ad = new Administration();
        AccountCreateForm createForm = new AccountCreateForm();
        public AdministrationForm()
        {
            InitializeComponent();
        }


        
            
    

        private void btnOpenCreateForm_Click(object sender, EventArgs e)
        {
            AccountCreateForm createForm = new AccountCreateForm();
            createForm.Show();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
                try
                {
                    if (tbEState.Text != "" && tbCCity.Text != "" && tbEStreetName.Text != "" && tbEStreetNr.Text != "" && tbCstate.Text != "" && tbCCity.Text != "" && tbCstreetname.Text != "" && tbCstreetnr.Text != "" && tbEname.Text != "" && tbELastname.Text != "" && tbEPhoneNumber.Text != "" && tbEEmail.Text != "" && tbYear.Text != "" && tbEBSN.Text != "")
                    {
                        Address address = new Address(tbEState.Text, tbECity.Text, tbEStreetName.Text, tbEStreetNr.Text);
                        Address contactAddress = new Address(tbCstate.Text, tbCCity.Text, tbCstreetname.Text, tbCstreetnr.Text);
                        Person Contactperson = new Person(tbCName.Text, tbCLastname.Text, tbCPhoneNumber.Text, contactAddress, tbCEmail.Text);
                        Contract contract = new Contract(DateTime.Now);
                        Employee employee = new Employee(tbEname.Text, tbELastname.Text, tbEPhoneNumber.Text, address, tbEEmail.Text, Contactperson, tbYear.Text, tbEBSN.Text, contract);
                        ad.AddEmployee(employee);
                        MessageBox.Show("The Employees Has succesfully been added!");
                        // Account account = new Account(tbUsername.Text, employee);
                        //ad.AddAccount(account);
                    }
                    else
                    {
                        MessageBox.Show("Make sure all the information is filled in before submitting !");
                    }


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
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {

        }
    }

