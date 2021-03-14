using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    class Account
    {

        private string username;
        private string password;
        private Employee employee;

        public Account(string username, Employee employee)
        {
            this.username = username;
            this.employee = employee;
            this.password = generatePassword();
        }

        public string getUsername()
        {
            return this.username;
        }

        public string getPassword()
        {
            return this.password;
        }

        public Employee login(string password)
        {
            if (this.password == password)
            {
                return employee;
            }
            return null;
        }

        private string generatePassword()
        {
            const string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int length = 10;
            string password = String.Empty;
            Random rdm = new Random();
            for (int i = length; i > 0; i--)
            {
                password += characters[rdm.Next(characters.Length)];
            }
            return password;
        }

        public bool changePassword(string oldPassword, string newPassword)
        {
            if (oldPassword == this.password)
            {
                this.password = newPassword;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{employee} with the username {username} Password {password}";
        }
    }
}
