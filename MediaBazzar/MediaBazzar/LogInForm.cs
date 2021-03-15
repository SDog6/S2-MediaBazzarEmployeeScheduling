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
        Administration admin;
        public LogInForm()
        {
            InitializeComponent();
            admin = new Administration();
            admin.AddAccount(new Account("blq", "blq", new Employee(Role.Administrator)));
            fillListBox();

        }
        public void fillListBox()
        {
            List<Account> acc = admin.GetAccounts();
            foreach(Account a in acc)
            {
                listBox1.Items.Add(a);
            }
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
        public Account accountExists(string username)
        {
            return admin.GetAccount(username);
        }
        public Employee loginSuccessful(Account loginAcc,string password)
        {
            return loginAcc.login(password);
        }

        public Role roleCheck(Employee loginEmp)
        {
           return loginEmp.getRole();
        }

        public void roleForm(Role a)
        {
            if(a == Role.Administrator)
            {
                AccountCreateForm b = new AccountCreateForm();
                b.Show();
            }
            else if(a == Role.Manager)
            {
                MessageBox.Show("Login succesful");
                Management m = new Management();
                m.Show();
            }
            else if (a == Role.WarehouseManager)
            {
                MessageBox.Show("Login succesful");
                WarehouseManagement m = new WarehouseManagement();
                m.Show();
            }
            else if (a == Role.WarehouseWorker)
            {
                MessageBox.Show("Login succesful");
                WarehouseManagement m = new WarehouseManagement();
                m.Show();
            }
            else
            {
                MessageBox.Show("Access denied");
            }

        }
        public void loginSequence(string username, string password)
        {
            if (username != String.Empty && password != String.Empty)
            {
                Account loginAcc = accountExists(username);
                if (loginAcc != null)
                {
                    Employee loginEmp = loginSuccessful(loginAcc, password);
                    if (loginEmp != null)
                    {
                        Role role = roleCheck(loginEmp);

                        roleForm(role);


                    }
                }
                else
                {
                    MessageBox.Show("Account doesnt exist");
                }
            }
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            loginSequence(tbLogInUsername.Text, tbLogInPassword.Text);
        }
    }
}
