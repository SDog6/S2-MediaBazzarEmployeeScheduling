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
    public partial class EmployeeCreation : Form
    {
        EmployeeData database;
        public EmployeeCreation()
        {
            InitializeComponent();
            database = new EmployeeData();
        }
        private void btnOpenCreateForm_Click(object sender, EventArgs e)
        {
            AccountCreateForm createForm = new AccountCreateForm();
            createForm.Show();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {


            //Address address = new Address(tbEState.Text, tbECity.Text, tbEStreetName.Text, tbEStreetNr.Text);
            //Address contactAddress = new Address(tbCstate.Text, tbCCity.Text, tbCstreetname.Text, tbCstreetnr.Text);
            //Person Contactperson = new Person(tbCName.Text, tbCLastname.Text, tbCPhoneNumber.Text, contactAddress, tbCEmail.Text);
            //Contract contract = new Contract(DateTime.Now);
            //Employee employee = new Employee(Convert.ToInt32(textBox1.Text),tbEname.Text, tbELastname.Text, tbEPhoneNumber.Text, address, tbEEmail.Text, Contactperson, tbYear.Text, tbEBSN.Text, contract);
            Address ad = new Address("0", "0", "0", "0");
            Address cAd = new Address("0", "0", "0", "1");
            Person contactPerson = new Person("a", "a", "a", cAd, "a");
            Contract contract = new Contract(DateTime.Now);
            Account acc = new Account("hasan");
            Employee employee = new Employee("b", "b", "b", ad, "b", contactPerson, DateTime.Now, "b", "b", contract, acc);
            database.Insert(employee);
            // Account account = new Account(tbUsername.Text, employee);
            //ad.AddAccount(account);


        }

        private void EmployeeCreation_Load(object sender, EventArgs e)
        {

        }
    }
}

