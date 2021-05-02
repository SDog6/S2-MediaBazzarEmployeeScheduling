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
            MessageBox.Show("kur");
            List<Employee> employees = new List<Employee>();
            string query = "SELECT * FROM employee";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            try
            {
                conn.Open();
                adapter.Fill(table);
                conn.Close();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    int id = Convert.ToInt32(table.Rows[i][0]);
                    int personId = Convert.ToInt32(table.Rows[i][1]);
                    int contactPersonId = Convert.ToInt32(table.Rows[i][2]);
                    DateTime dateOfBirth = Convert.ToDateTime(table.Rows[i][3]);
                    string BSN = table.Rows[i][4].ToString();
                    string role = table.Rows[i][5].ToString();
                    int contractId = Convert.ToInt32(table.Rows[i][6]);
                    int accountId = Convert.ToInt32(table.Rows[i][7]);
                    bool active = Convert.ToBoolean(table.Rows[i][8]);

                    Account account = getAccount(accountId);
                    Contract contract = getContract(contractId);
                    Person person = getPerson(personId);
                    Person contactPerson = getPerson(contactPersonId);

                    Employee employee = new Employee(id, person, contactPerson, dateOfBirth, BSN, role, contract, account, active);
                    employees.Add(employee);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new FailedReadFromDBException();
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

        private Account getAccount(int id)
        {
            string query = $"SELECT username, password FROM account WHERE id = {id}";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string username = reader[0].ToString();
                string password = reader[1].ToString();
                Account account = new Account(username, password);
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


        private Contract getContract(int id)
        {
            string query = $"SELECT workingHours, start, end, endReason FROM contract WHERE id = {id}";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int workingHours = Convert.ToInt32(reader[0]);
                DateTime startDate = Convert.ToDateTime(reader[1]);
                Contract contract;
                if (reader[2] is DBNull)
                {
                    contract = new Contract(startDate);
                }
                else
                {
                    DateTime endDate = Convert.ToDateTime(reader[2]);
                    string terminationReason = reader[3].ToString();
                    contract = new Contract(workingHours, startDate, endDate, terminationReason);
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
        private Person getPerson(int id)
        {
            string query = $"SELECT firstName, lastName, phoneNumber, email, addressId FROM person WHERE id = {id}";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string firstName = reader[0].ToString();
                string lastName = reader[1].ToString();
                string phoneNumber = reader[2].ToString();
                string email = reader[3].ToString();
                int addressId = Convert.ToInt32(reader[4]);
                conn.Close();
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
            string query = $"SELECT state, city, street, apartmentNr FROM address WHERE id = {addressId}";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string state = reader[0].ToString();
                string city = reader[1].ToString();
                string street = reader[2].ToString();
                string apartmentNr;
                if (reader[3] is DBNull)
                {
                    apartmentNr = String.Empty;
                }
                else
                {
                    apartmentNr = reader[3].ToString();
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


        public object ReadAllByID(int Id)
        {
            MessageBox.Show("kur");
            string query = "SELECT * FROM employee WHERE id = @id";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@id", Id);
            DataTable table = new DataTable();
            Employee employee = null;
            try
            {
                conn.Open();
                adapter.Fill(table);
                conn.Close();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    int id = Convert.ToInt32(table.Rows[i][0]);
                    int personId = Convert.ToInt32(table.Rows[i][1]);
                    int contactPersonId = Convert.ToInt32(table.Rows[i][2]);
                    DateTime dateOfBirth = Convert.ToDateTime(table.Rows[i][3]);
                    string BSN = table.Rows[i][4].ToString();
                    string role = table.Rows[i][5].ToString();
                    int contractId = Convert.ToInt32(table.Rows[i][6]);
                    int accountId = Convert.ToInt32(table.Rows[i][7]);
                    bool active = Convert.ToBoolean(table.Rows[i][8]);

                    Account account = getAccount(accountId);
                    Contract contract = getContract(contractId);
                    Person person = getPerson(personId);
                    Person contactPerson = getPerson(contactPersonId);

                    employee = new Employee(id, person, contactPerson, dateOfBirth, BSN, role, contract, account, active);
                    return employee;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new FailedReadFromDBException();
            }
            return employee;
        }


        public object ReadAllByRole(string Role)
        {
            MessageBox.Show("kur");
            List<Employee> employees = new List<Employee>();
            string query = "SELECT * FROM employee WHERE role = @role";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@role", Role);
            DataTable table = new DataTable();
            try
            {
                conn.Open();
                adapter.Fill(table);
                conn.Close();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    int id = Convert.ToInt32(table.Rows[i][0]);
                    int personId = Convert.ToInt32(table.Rows[i][1]);
                    int contactPersonId = Convert.ToInt32(table.Rows[i][2]);
                    DateTime dateOfBirth = Convert.ToDateTime(table.Rows[i][3]);
                    string BSN = table.Rows[i][4].ToString();
                    string role = table.Rows[i][5].ToString();
                    int contractId = Convert.ToInt32(table.Rows[i][6]);
                    int accountId = Convert.ToInt32(table.Rows[i][7]);
                    bool active = Convert.ToBoolean(table.Rows[i][8]);

                    Account account = getAccount(accountId);
                    Contract contract = getContract(contractId);
                    Person person = getPerson(personId);
                    Person contactPerson = getPerson(contactPersonId);

                    Employee employee = new Employee(id, person, contactPerson, dateOfBirth, BSN, role, contract, account, active);
                    employees.Add(employee);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new FailedReadFromDBException();
            }
            return employees;
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
            catch (Exception ex)
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
