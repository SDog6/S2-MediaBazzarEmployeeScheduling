using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace MediaBazzar
{
    class EmployeeData : IDatabaseManager
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
            List<Employee> em = new List<Employee>();

            try
            {
                string sql = "SELECT StockID, StockName,StockAmount,Price,Brand FROM shopstock;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //em.Add(new Employee(dr[1].ToString(), Convert.ToInt32(dr[2]), Convert.ToInt32(dr[0]), Convert.ToInt32(dr[3]), dr[4].ToString()));
                }

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
            return em;
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
            MessageBox.Show(addressId.ToString());
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
            MessageBox.Show(personid.ToString());
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
            MessageBox.Show(contractId.ToString());
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
            MessageBox.Show(accountId.ToString());
            return accountId;
        }
    }
}
