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
        public void checkEmpty(List<string> strings)
        {
            foreach(string s in strings)
            {
                if(String.IsNullOrEmpty(s))
                {
                    throw new EmptyTextBoxException();
                }
            }
        }
        public Employee createEmployee()
        {
            List<string> textboxes = new List<string>()
            {
                tbEname.Text,
                tbELastname.Text,
                tbEPhoneNumber.Text,
                tbEEmail.Text,

                tbEState.Text,
                tbECity.Text,
                tbEStreetName.Text,

                tbCName.Text,
                tbCLastname.Text,
                tbCPhoneNumber.Text,
                tbCEmail.Text,

                tbCstate.Text,
                tbCCity.Text,
                tbCstreetname.Text,

                tbEBSN.Text,
                tbErole.Text,
                tbUsername.Text
            };
            try
            {
                checkEmpty(textboxes);
                
                
                string personalState = textboxes[4];
                string personalCity = textboxes[5];
                string personalStreetName = textboxes[6];
                string personalStreetNr = tbEStreetNr.Text;
                Address personalAddress =  new Address(personalState, personalCity, personalStreetName, personalStreetNr);

                string contactState = textboxes[11];
                string contactCity = textboxes[12];
                string contactStreetName = textboxes[13];
                string contactStreetNr = tbCstreetnr.Text;
                Address contactAddress = new Address(contactState, contactCity, contactStreetName, contactStreetNr);

                string contactFirstName = textboxes[7];
                string contactLastname = textboxes[8];
                string contactPhoneNumber = textboxes[9];
                string contactEmail = textboxes[10];
                Person contactPerson = new Person(contactFirstName, contactLastname, contactPhoneNumber, contactAddress, contactEmail);

                Contract contract = new Contract(DateTime.Now);

                string username = textboxes[16];
                Account account = new Account(username);
                DateTime dateOfBirth = date_dateOfBirth.Value;

                string firstName = textboxes[0];
                string lastName = textboxes[1];
                string phoneNumber = textboxes[2];
                string email = textboxes[3];

                string BSN = textboxes[14];
                string role = textboxes[15];
                Employee employee = new Employee(firstName, lastName, phoneNumber, personalAddress, email, contactPerson, dateOfBirth, BSN, role, contract, account);
                return employee;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;            
        }
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            Employee employee = createEmployee();
            if(employee != null)
            {
                try
                {
                    database.Insert(employee);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EmployeeCreation_Load(object sender, EventArgs e)
        {

        }
    }
}

