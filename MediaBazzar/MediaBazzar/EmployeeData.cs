using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace MediaBazzar
{
    public class EmployeeData : DatabaseConnection, IDatabaseManager
    {

        public void Insert(object obj)
        {
            Employee employee = (Employee)obj;
            try
            {
                Person personalInfo = employee.PersonalInfo;
                Address personalAddress = personalInfo.Address;
                int addressId = insertAddress(personalAddress);
                int personalInfoId = insertPerson(personalInfo, addressId);

                Person contactPerson = employee.ContactPerson;
                Address contactAdress = contactPerson.Address;
                int contactAddressId = insertAddress(contactAdress);
                int contactPersonId = insertPerson(contactPerson, contactAddressId);

                Contract contract = employee.Contract;
                int contractId = insertContract(contract);

                Account account = employee.Account;
                int accountId = insertAccount(account);

                string sql = "INSERT INTO employee (personId, contactPersonId, dateOfBirth, BSN, role, contractId, accountId) VALUES (@personId, @contactPersonId, @dateOfBirth, @BSN, @role, @contractId, @accountId)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@personId", personalInfoId);
                cmd.Parameters.AddWithValue("@contactPersonId", contactPersonId);
                cmd.Parameters.AddWithValue("@dateOfBirth", employee.DateOfBirth);
                cmd.Parameters.AddWithValue("@BSN", employee.BSNp);
                cmd.Parameters.AddWithValue("@role", employee.Role);
                cmd.Parameters.AddWithValue("@contractId", contractId);
                cmd.Parameters.AddWithValue("@accountId", accountId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new FailedDatabaseInjectionException("employee");
            }
            finally
            {
                conn.Close();
            }
        }
        public object ReadAll()
        {
            List<Employee> employees = new List<Employee>();
            string query = "SELECT employee.id, employee.dateOfBirth, employee.BSN, employee.role, employee.status, person.firstName, person.lastName, person.phoneNumber, person.email, address.state, address.city, address.street, address.apartmentNr, contract.workingHours, contract.start, contract.end, contract.endReason, account.username, account.password,contract.currentWorkhours,contract.id FROM employee INNER JOIN person ON personId = person.id INNER JOIN address ON person.addressId = address.id INNER JOIN contract on contractId = contract.id INNER JOIN account ON accountId = account.id";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            try
            {
                conn.Open();
                adapter.Fill(table);
                conn.Close();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow row = table.Rows[i];
                    Employee emp = EmployeeObject(row);
                    employees.Add(emp);
                }
            }
            catch(Exception)
            {
                throw new FailedReadFromDBException("all employees");
            }
            return employees;
        }
        public Employee GetEmployee(int id)
        {
            Employee emp;
            string query = "SELECT employee.id, employee.dateOfBirth, employee.BSN, employee.role, employee.status, person.firstName, person.lastName, person.phoneNumber, person.email, address.state, address.city, address.street, address.apartmentNr, contract.workingHours, contract.start, contract.end, contract.endReason, account.username, account.password FROM employee INNER JOIN person ON personId = person.id INNER JOIN address ON person.addressId = address.id INNER JOIN contract on contractId = contract.id INNER JOIN account ON accountId = account.id";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            try
            {
                conn.Open();
                adapter.Fill(table);
                conn.Close();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow row = table.Rows[i];
                    emp = EmployeeObject(row);
                    return emp;
                }
            }
            catch (Exception)
            {
                throw new FailedReadFromDBException("all employees");
            }
            return null;
        }
        private Employee EmployeeObject(DataRow row)
        {
            int id = Convert.ToInt32(row[0]);
            DateTime dateOfBirth = Convert.ToDateTime(row[1]);
            string BSN = row[2].ToString();
            string role = row[3].ToString();
            bool status = Convert.ToBoolean(row[4]);

            object[] personInfo = {row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12]};
            Person personalInfo = PersonObject(personInfo);

            object[] contractInfo = {row[13], row[14], row[15], row[16],row[19],row[20]};
            Contract contract = contractObject(contractInfo);

            Account account = new Account(row[17].ToString(), row[18].ToString());

            Person contactPerson = getContactPerson(id);



            Employee emp = new Employee(id, personalInfo, contactPerson, dateOfBirth, BSN, role, contract, account, status);
            return emp;
        }
        private Person PersonObject(object[] personalInfo)
        {
            Address address = new Address(personalInfo[4].ToString(), personalInfo[5].ToString(), personalInfo[6].ToString(), personalInfo[7].ToString());
            Person person = new Person(personalInfo[0].ToString(), personalInfo[1].ToString(), personalInfo[2].ToString(), address, personalInfo[3].ToString());
            return person;
        }
        private Contract contractObject(object[] contractInfo)
        {
            Contract contract;
            if(contractInfo[2] is DBNull)
            {
                contract = new Contract(Convert.ToInt32(contractInfo[5]),Convert.ToInt32(contractInfo[0]), Convert.ToDateTime(contractInfo[1]),Convert.ToInt32(contractInfo[4]));
                return contract;
            }
            contract = new Contract(Convert.ToInt32(contractInfo[0]), Convert.ToDateTime(contractInfo[1]), Convert.ToDateTime(contractInfo[2]), contractInfo[3].ToString());
            return contract;
        }
        private int insertAddress(Address address)
        {
            string sql = "INSERT INTO address (state, city, street, apartmentNr) VALUES (@state, @city, @street, @apartmentNr);" + "SELECT LAST_INSERT_ID();";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@state", address.State);
            cmd.Parameters.AddWithValue("@city", address.City);
            cmd.Parameters.AddWithValue("@street", address.Street);
            cmd.Parameters.AddWithValue("@apartmentNr", address.ApartmentNr);
            int addressId = -1;
            try
            {
                conn.Open();
                addressId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
                throw new FailedDatabaseInjectionException("address");
            }
            finally
            {
                conn.Close();
            }
            return (int)addressId;

        }

        private int insertPerson(Person person, int addressId)
        {
            int personid = -1;
            string sql = "INSERT INTO person (firstName, lastName, phoneNumber, email, addressId) VALUES (@firstName, @lastName, @phoneNumber, @email, @addressId);" + "SELECT LAST_INSERT_ID();";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@firstName", person.FirstName);
            cmd.Parameters.AddWithValue("@lastName", person.LastName);
            cmd.Parameters.AddWithValue("@phoneNumber", person.PhoneNumber);
            cmd.Parameters.AddWithValue("@email", person.Email);
            cmd.Parameters.AddWithValue("@addressId", addressId);
            try
            {
                conn.Open();
                personid = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
                throw new FailedDatabaseInjectionException("person");
            }
            finally
            {
                conn.Close();
            }
            return personid;
        }
        private int insertContract(Contract contract)
        {
            int contractId = -1;
            string sql = "INSERT INTO contract (workingHours,start, end, endReason) VALUES(@workingHours,@start, @end, @endReason);" + "SELECT LAST_INSERT_ID();";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@start", contract.EmploymentStart.Date);
            if (contract.isTerminated())
            {
                cmd.Parameters.AddWithValue("@@workingHours", contract.Workinghours);
                cmd.Parameters.AddWithValue("@end", contract.EmploymentEnd);
                cmd.Parameters.AddWithValue("@endReason", contract.TerminationReason);
            }
            else
            {
                cmd.Parameters.AddWithValue("@@workingHours", contract.Workinghours);
                cmd.Parameters.AddWithValue("@end", null);
                cmd.Parameters.AddWithValue("@endReason", null);
            }
            try
            {
                conn.Open();
                contractId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
                throw new FailedDatabaseInjectionException("contract");
            }
            finally
            {
                conn.Close();
            }
            return contractId;
        }
        private int insertAccount(Account account)
        {
            int accountId = -1;
            string sql = "INSERT INTO account (username, password) VALUES (@username, @password);" + "SELECT LAST_INSERT_ID();";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", account.Username);
            cmd.Parameters.AddWithValue("@password", account.Password);
            try
            {
                conn.Open();
                accountId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
                throw new FailedDatabaseInjectionException("account");
            }
            finally
            {
                conn.Close();
            }
            return accountId;
        }
        public Employee loginAccount(string username)
        {
            Employee emp;
            string query = $"SELECT employee.id, employee.dateOfBirth, employee.BSN, employee.role, employee.status, person.firstName, person.lastName, person.phoneNumber, person.email, address.state, address.city, address.street, address.apartmentNr, contract.workingHours, contract.start, contract.end, contract.endReason, account.username, account.password,contract.currentWorkhours,contract.id FROM employee INNER JOIN person ON personId = person.id INNER JOIN address ON person.addressId = address.id INNER JOIN contract on contractId = contract.id INNER JOIN account ON accountId = account.id WHERE account.username = '{username}'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            try
            {
                conn.Open();
                adapter.Fill(table);
                conn.Close();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow row = table.Rows[i];
                    emp = EmployeeObject(row);
                    return emp;
                }
            }
            catch (Exception)
            {
                throw new FailedReadFromDBException("all employees");
            }
            return null;
        }
        private Person getContactPerson(int id)
        {
            string query = $"SELECT firstName, lastName, phoneNumber, email, state, city, street, apartmentNr FROM person INNER JOIN address ON addressId = address.id INNER JOIN employee ON employee.contactPersonId = person.id WHERE employee.id = {id}";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                object[] personInfo = { reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7] };
                Person contactPerson = PersonObject(personInfo);
                return contactPerson;
            }
            catch (Exception)
            {
                throw new FailedReadFromDBException("contact person");
            }
            finally
            {
                conn.Close();
            }
        }
        private void changeEmpStatus(int id)
        {
            string query = "UPDATE employee SET status = false WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new FailedDatabaseUpdateException();
            }
            finally
            {
                conn.Close();
            }
        }

        public void IncraseWork(int id)
        {
            string query = "UPDATE contract SET currentWorkhours = currentWorkhours + 5 WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new FailedDatabaseUpdateException();
            }
            finally
            {
                conn.Close();
            }
        }


        public void DecreaseWorkHours(int id)
        {
            string query = "UPDATE contract SET currentWorkhours = currentWorkhours - 5 WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new FailedDatabaseUpdateException();
            }
            finally
            {
                conn.Close();
            }
        }

        public void ClearWorkHours()
        {
            string query = "UPDATE contract SET currentWorkhours = 0";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new FailedDatabaseUpdateException();
            }
            finally
            {
                conn.Close();
            }
        }

        private void changeContractDetails(int id, Contract contract)
        {
            string query = "UPDATE contract INNER JOIN employee ON contract.id = employee.contractId SET contract.end = @endDate, contract.endReason = @endReason WHERE employee.id = @id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@endDate", contract.EmploymentEnd);
            cmd.Parameters.AddWithValue("@endReason", contract.TerminationReason);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new FailedDatabaseUpdateException();
            }
            finally
            {
                conn.Close();
            }
        }
        public void FireEmployee(Employee emp)
        {
            changeEmpStatus(emp.EmployeeID);
            changeContractDetails(emp.EmployeeID, emp.Contract);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
