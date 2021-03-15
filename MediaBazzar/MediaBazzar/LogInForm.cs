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

        public int roleCheck(Employee loginEmp)
        {
           return (int)loginEmp.getRole();
        }

        public void roleForm(int role)
        {
            switch(role)
            {
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
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
                    if(loginEmp != null)
                    {
                        int role = roleCheck(loginEmp);
                        if(role != 5)
                        {
                            MessageBox.Show("Login succesful");
                            roleForm(role);
                        }
                        else
                        {
                            MessageBox.Show("Access denied");
                        }
                    }
                    else
                    {
                        MessageBox.Show("wrong password");
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

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
