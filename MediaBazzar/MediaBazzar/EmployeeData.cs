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

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(object obj)
        {
            Employee employee = (Employee)obj;
            try
            {
                Person personalInfo = employee.personalInfo;
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
            string sql = "SELECT id FROM employee";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            List<int> employeeIds = new List<int>();
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    employeeIds.Add(id);
                    /*int personId = Convert.ToInt32(reader[1]);
                    int contactPersonId = Convert.ToInt32(reader[2]);
                    DateTime dateOfBirth = Convert.ToDateTime(reader[3]);
                    string BSN = reader[4].ToString();
                    string role = reader[5].ToString();
                    int contractId = Convert.ToInt32(reader[6]);
                    int accountId = Convert.ToInt32(reader[7]);

                    Person person = getPerson(personId);
                    Person contactPerson = getPerson(contactPersonId);
                    Contract contract = getContract(contractId);
                    Account account = getAccount(accountId);

                    Employee employee = new Employee(id, person.FirstName, person.LastName, person.PhoneNumber, person.Address, person.Email, contactPerson, dateOfBirth, BSN, role, contract, account);
                    employees.Add(employee);*/
                }
                conn.Close();
                foreach(int id in employeeIds)
                {
                    Account account = getAccount(id);
                    Contract contract = getContract(id);
                    Person person = getPerson("personId",id);
                    Person contactPerson = getPerson("contactPersonId", id);

                    string query = $"SELECT dateOfBirth, BSN, role FROM employee WHERE id = {id}";
                    cmd = new MySqlCommand(query, conn);
                    conn.Open();

                    reader = cmd.ExecuteReader();
                    reader.Read();

                    DateTime dateOfBirth = Convert.ToDateTime(reader[0]);
                    string BSN = reader[1].ToString();
                    string role = reader[2].ToString();
                    Employee employee = new Employee(id, person.FirstName, person.LastName, person.PhoneNumber, person.Address, person.Email, contactPerson, dateOfBirth, BSN, role, contract, account);
                    employees.Add(employee);
                    conn.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new FailedReadFromDBException();
            }
            finally
            { 
                conn.Close();
            }
            
            return employees;
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
            catch(Exception ex)
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
            catch(Exception ex)
            {
                throw new FailedDatabaseInjectionException("account");
            }
            finally
            {
                conn.Close();
            }
            return accountId;
        }

        private Account getAccount(int employeeId)
        {
            string sql = $"SELECT account.username, account.password FROM employee INNER JOIN account ON employee.accountId = account.id WHERE employee.id = {employeeId}";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            try
            {
                adapter.Fill(table);
                string username = table.Rows[0][0].ToString();
                string password = table.Rows[0][1].ToString();
                Account account = new Account(username, password);
                return account;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public Account getAccountLogIn(string username)
        {
            string sql = $"SELECT password FROM account WHERE username = '@username'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", username);
          
            try
            {
                conn.Open();
                string password = cmd.ExecuteScalar().ToString();
                Account account = new Account(username,password);
                return account;
              
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
        //1TX9Y9fqIP

        public string getAccountLogInRole(string username)
        {
            string sql = $"SELECT employee.role FROM account INNER JOIN employee ON account.id = employee.accountId WHERE account.username = @username";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", username);
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


        private Contract getContract(int employeeId)
        {
            string sql = $"SELECT contract.start, contract.end, contract.endReason FROM employee INNER JOIN contract ON employee.contractId = contract.id WHERE employee.id = {employeeId}";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            try
            {
                adapter.Fill(table);
                DateTime startDate = Convert.ToDateTime(table.Rows[0][0]);
                Contract contract;
                if (table.Rows[0][1] is DBNull)
                {
                    contract = new Contract(startDate);
                }
                else
                {
                    DateTime endDate = Convert.ToDateTime(table.Rows[0][1]);
                    string terminationReason = table.Rows[0][2].ToString();
                    contract = new Contract(startDate, DateTime.Now, terminationReason);
                }
                return contract;
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
        private Person getPerson(string personType, int employeeId)
        {
            string sql = $"SELECT person.firstName, person.lastName, person.phoneNumber, person.email, person.addressId FROM employee INNER JOIN person ON employee.{personType} = person.id WHERE employee.id = {employeeId}";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            try
            {
                adapter.Fill(table);
                string firstName = table.Rows[0][0].ToString();
                string lastName = table.Rows[0][1].ToString();
                string phoneNumber = table.Rows[0][2].ToString();
                string email = table.Rows[0][3].ToString();
                int addressId = Convert.ToInt32(table.Rows[0][4]);
                Address address = getAddress(addressId);
                Person person = new Person(firstName, lastName, phoneNumber, address, email);
                return person;
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
        public Address getAddress(int addressId)
        {
            string sql = $"SELECT address.state, address.city, address.street, address.apartmentNr FROM address WHERE address.id = {addressId}";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            try
            {
                adapter.Fill(table);
                string state = table.Rows[0][0].ToString();
                string city = table.Rows[0][1].ToString();
                string street = table.Rows[0][2].ToString();
                string apartmentNr;
                if(table.Rows[0][3] == null)
                {
                    apartmentNr = String.Empty;
                }
                else
                {
                    apartmentNr = table.Rows[0][3].ToString();
                }    
                Address address = new Address(state, city, street, apartmentNr);
                return address;
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
    }
}
