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
    public class EmployeeData : IDatabaseManager
    {

        public static MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local; Uid=dbi457108; Database=dbi457108; Pwd=NewPassword123");

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
                    Employee emp = EmployeeObject(row);
                    employees.Add(emp);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("tuka grumna");
                MessageBox.Show(ex.Message);
            }
            return employees;
        }
        public Employee GetEmployee(int id)
        {
            Employee emp;
            string query = $"SELECT * FROM employee WHERE id = {id}";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            try
            {
                adapter.Fill(table);
                if(table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];
                    emp = EmployeeObject(row);
                    return emp;
                }        
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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

            object[] personInfo = {row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12] };
            Person personalInfo = PersonObject(personInfo);

            object[] contractInfo = {row[13], row[14], row[15], row[16]};
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
                contract = new Contract(Convert.ToInt32(contractInfo[0]), Convert.ToDateTime(contractInfo[1]));
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
            catch (Exception ex)
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
            catch (Exception ex)
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
            string sql = "INSERT INTO contract (start, end, endReason) VALUES(@start, @end, @endReason);" + "SELECT LAST_INSERT_ID();";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@start", contract.EmploymentStart.Date);
            if (contract.isTerminated())
            {
                cmd.Parameters.AddWithValue("@end", contract.EmploymentEnd);
                cmd.Parameters.AddWithValue("@endReason", contract.TerminationReason);
            }
            else
            {
                cmd.Parameters.AddWithValue("@end", null);
                cmd.Parameters.AddWithValue("@endReason", null);
            }
            try
            {
                conn.Open();
                contractId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
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
            catch (Exception ex)
            {
                throw new FailedDatabaseInjectionException("account");
            }
            finally
            {
                conn.Close();
            }
            return accountId;
        }
        public string getAccountLogInRole(string username, string password)
        {
            string sql = $"SELECT employee.role FROM account INNER JOIN employee ON account.id = employee.accountId WHERE account.username = @username AND account.password = @password";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string role = reader[0].ToString();
                return role;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
        public void FireEmployee(object obj)
        {
            Employee emp = (Employee)obj;
            try
            {
                // make sure in your table the id in auto-incremented
                string sql = "UPDATE employee SET status = false WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", emp.EmployeeID);


                conn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured! Try again.");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
