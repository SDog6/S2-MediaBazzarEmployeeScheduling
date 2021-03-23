using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class Account
    {

        private string username;
        private string password;

        public string Username { get { return this.username; } }
        public string Password { get { return this.password; } }
        public Account(string username)
        {
            this.username = username;
            this.password = generatePassword();
        }

        
        public string getUsername()
        {
            return this.username;
        }

        public void SetUsername(string username)
        {
            this.username = username;

        }

        public string getPassword()
        {
            return this.password;
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
            return $"Username {username} Password {password}";
        }
    }
}
