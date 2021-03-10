using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class Employee
    {
        private Person employeeInfo;
        private Person contactPerson;

        private DateTime dateOfBirth;
        private string BSN;

        private Contract contract;

        public Employee(Person employeeInfo, Person contactPerson, DateTime dateOfBirth, string BSN, Contract contract)
        {
            this.employeeInfo = employeeInfo;
            this.contactPerson = contactPerson;
            this.dateOfBirth = dateOfBirth;
            this.BSN = BSN;
            this.contract = contract;
        }

        public string getEmployeeInfo()
        {
            return $"{employeeInfo}";
        }

        public string getContactInfo()
        {
            return $"{contactPerson}";
        }

        public void fireEmployee(DateTime dateFired, string reason)
        {
            contract.Terminate(dateFired, reason);
        }

        public bool isFired()
        {
            return contract.isTerminated();
        }
    }
}
