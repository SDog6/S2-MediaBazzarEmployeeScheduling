using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazzar
{
    public class Employee
    {
        private int ID;
        private Person personalInfo;
        private Person contactPerson;
        private DateTime dateOfBirth;
        private string BSN;
        private string role;
        private Contract contract;
        private Account account;
        private bool active;

        public string BSNp { get { return this.BSN; } set { this.BSN = value; } }
        public DateTime DateOfBirth { get { return this.dateOfBirth; } }
        public int EmployeeID { get { return this.ID; } set { this.ID = value; } }
        public string Role { get { return this.role; } }
        public Person PersonalInfo { get { return this.personalInfo; } }
        public Person ContactPerson { get { return this.contactPerson; } }
        public Contract Contract { get { return this.contract; } }
        public Account Account { get { return this.account; } }     
        public bool Active { get { return this.active; } }

        public Employee(int ID, Person personalInfo, Person contactPerson, DateTime dateOfBirth, string BSN, string role, Contract contract, Account account, bool active)
        {
            this.ID = ID;
            this.personalInfo = personalInfo;
            this.contactPerson = contactPerson;
            this.dateOfBirth = dateOfBirth;
            this.BSN = BSN;
            this.role = role;
            this.contract = contract;
            this.account = account;
        }
        public Employee(Person personalInfo, Person contactPerson, DateTime dateOfBirth, string BSN, string role, Contract contract,Account account, bool active)
        {
            this.personalInfo = personalInfo;
            this.contactPerson = contactPerson;
            this.dateOfBirth = dateOfBirth;
            this.BSN = BSN;
            this.role = role;
            this.contract = contract;
            this.account = account;
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
           return $"[{this.ID}] - {this.personalInfo.getName()} with BSN {this.BSNp} ";
        }

        public string GetAccountRelationInfo()
        {
            return $"[{this.BSNp}] - {this.personalInfo.getName()} with account {account}";
        }
    }
}
