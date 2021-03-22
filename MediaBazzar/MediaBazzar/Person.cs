using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class Person
    {

        private string firstName;
        private string lastName;
        private string phoneNumber;
        private Address address;
        private string email;

        public Person(string firstName, string lastName, string phoneNumber, Address address, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.email = email;
        }

        public string getName()
        {
            return $"{lastName}, {firstName}";
        }
        public string getPhoneNumber()
        {
            return this.phoneNumber;
        }
        public string getAddress()
        {
            return this.address.ToString();
        }
        public string getEmail()
        {
            return this.email;
        }

        public void setEmail(string newEmail)
        {
            this.email = newEmail;
        }

        public void setPhoneNumber(string newPhoneNumber)
        {
            this.phoneNumber = newPhoneNumber;
        }

        public void setAddress(Address newAddress)
        {
            this.address = newAddress;
        }

        public override string ToString()
        {
            return $"{getName()} | {phoneNumber}, {email} | {address}";
        }
    }
}
