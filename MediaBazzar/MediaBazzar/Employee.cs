using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class Employee : Person
    {

        private Person contactPerson;
        private string dateOfBirth;
        private string BSN;
        private Contract contract;
        private Account account;

        public string BSNp { get { return this.BSN; } set { this.BSN = value; } }

       


        public Employee(string firstName, string lastName, string phoneNumber, Address address, string email, Person contactPerson, string dateOfBirth, string BSN, Contract contract) : base(firstName, lastName, phoneNumber, address, email)
        {
            this.contactPerson = contactPerson;
            this.dateOfBirth = dateOfBirth;
            this.BSN = BSN;
            this.contract = contract;
            this.account = null;
        }

        public string getContactInfo()
        {
            return $"{contactPerson}";
        }

        public void SetAccount(Account a)
        {
            this.account = a;
        }
        public Account GetAccount()
        {
            return this.account;
        }

        public void fireEmployee(DateTime dateFired, string reason)
        {
            contract.Terminate(dateFired, reason);
        }

        public bool isFired()
        {
            return contract.isTerminated();
        }
        public string GetInfo()
        {
            string inf = base.ToString();
            return inf;
        }

        public override string ToString()
        {
            return $"{this.getName()} with BSN {this.BSNp}";
        }

        public string GetAccountRelationInfo()
        {
            return $"[{this.BSNp}] - {this.getName()} with account {account}";
        }
    }
}
