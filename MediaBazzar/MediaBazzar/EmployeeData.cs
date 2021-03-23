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
    public class EmployeeData
    {

        public static MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local; Uid=dbi457108; Database=dbi457108; Pwd=NewPassword123");

        public void Delete(Object obj)
        {
            Employee em = (Employee)obj;
            try
            {
                string sql = "DELETE FROM employeetemp WHERE bsn = @bsn";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@bsn", em.BSN);


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
        
        public void Insert(object obj)
        {
            Employee person = (Employee)obj;
            try
            {
                // make sure in your table the id in auto-incremented
                string sql = "INSERT INTO employeetemp (firstname,lastname,username,password,phonenumber,address,email,contactpersonname,contactpersonphone,dateofbirth,bsn,role) VALUES (@firstname,@lastname,@username,@password,@phonenumber,@address,@email,@contactpersonname,@contactpersonphone,@dateofbirth,@bsn,@role)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@firstname", person.FirstName);
                cmd.Parameters.AddWithValue("@lastname", person.LastName);
                cmd.Parameters.AddWithValue("@username", person.Username);
                cmd.Parameters.AddWithValue("@password", person.Password);
                cmd.Parameters.AddWithValue("@phonenumber", person.PhoneNumber);
                cmd.Parameters.AddWithValue("@address", person.Address);
                cmd.Parameters.AddWithValue("@email", person.Email);
                cmd.Parameters.AddWithValue("@contactpersonname", person.ContactPersonName);
                cmd.Parameters.AddWithValue("@contactpersonphone", person.ContactPeronPhone);
                cmd.Parameters.AddWithValue("@dateofbirth", person.DateOfBirth);
                cmd.Parameters.AddWithValue("@bsn", person.BSN);
                cmd.Parameters.AddWithValue("@role", person.Role);




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

        public object ReadAll()
        {
            List<Employee> em = new List<Employee>();

            try
            {
                string sql = "SELECT firstname,lastname,username,password,phonenumber,address,email,contactpersonname,contactpersonphone,dateofbirth,bsn,role FROM employeetemp;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    em.Add(new Employee(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToInt32(dr[4]),dr[5].ToString(),dr[6].ToString(),dr[7].ToString(),Convert.ToInt32(dr[8]),dr[9].ToString(),Convert.ToInt32(dr[10]),dr[11].ToString()));
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
    }
}
