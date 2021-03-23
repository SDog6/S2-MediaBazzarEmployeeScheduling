using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class Employee
    {
        private string firstname;
        private string lastname;
        private string username;
        private string password;
        private int phonenumber;
        private string address;
        private string email;
        private string contactpersonname;
        private int contactperonphone;
        private string dateofbirth;
        private int bsn;
        private string role;

     public string FirstName { get { return this.firstname; } set { firstname = value; } }
        public string LastName { get { return lastname; } set { lastname = value; } }
        public string Username { get { return username; }set { username = value;} }

        public string Password { get { return password; } set { password = value; } }
        public int PhoneNumber { get { return phonenumber; } set { phonenumber = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Email { get { return email; } set { email = value; }  }

        public string ContactPersonName { get { return contactpersonname; }set { contactpersonname = value; } }
        public int ContactPeronPhone { get { return contactperonphone; } set { contactperonphone = value; } }
        public string DateOfBirth { get { return dateofbirth; } set { dateofbirth = value; } }
        public int BSN { get { return bsn; } set { bsn = value; } }
        public string Role { get { return role; } set { role = value; } }


        public Employee(string firstname,string lastname,string username,string password,int phonenumber,string address,string email,string contactpersonname,int contactpersonphone,string dateofbirth,int bsn,string role)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.username = username;
            this.password = password;
            this.phonenumber = phonenumber;
            this.address = address;
            this.email = email;
            this.contactpersonname = contactpersonname;
            this.contactperonphone = contactpersonphone;
            this.dateofbirth = dateofbirth;
            this.bsn = bsn;
            this.role = role;
        }

        public override string ToString()
        {
            return $"{this.firstname} {this.lastname} with BSN {this.BSN} is a {this.role}";
        }


    }
}
