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
    class ShiftSchedulingData
    {

        public static MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local; Uid=dbi457108; Database=dbi457108; Pwd=NewPassword123");

        public void Add(object obj)
        {
            Shift shift = (Shift)obj;
            try
            {
                // make sure in your table the id in auto-incremented
                string sql = "INSERT INTO shifts (employee_id,Date,Type) VALUES (@employee_id,@Date,@Type)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@employee_id", shift.Emp.EmployeeID);
                cmd.Parameters.AddWithValue("@Date", shift.Time);
                cmd.Parameters.AddWithValue("@Type", shift.ShiftType);



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
            List<Shift> shifts = new List<Shift>();
            EmployeeManager getemp = new EmployeeManager();

            try
            {
                string sql = "SELECT id,employee_id, Date,Type FROM shifts;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr[1]);
                    Employee gottenEmp = getemp.GetEmployee(id);
                    shifts.Add(new Shift(Convert.ToInt32(dr[0]),gottenEmp, Convert.ToDateTime(dr[2]), dr[3].ToString()));
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
            return shifts;
        }

        public object GetAllMorningShifts()
        {
            List<Shift> shifts = new List<Shift>();
            EmployeeManager getemp = new EmployeeManager();

            try
            {
                string sql = "SELECT employee_id, Date,Type FROM shifts WHERE Type LIKE 'Morning%';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr[0]);
                    Employee gottenEmp = getemp.GetEmployee(id);
                    shifts.Add(new Shift(gottenEmp, Convert.ToDateTime(dr[1]), dr[2].ToString()));
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
            return shifts;
        }




        public object GetAllAfternoonShifts()
        {
            List<Shift> shifts = new List<Shift>();
            EmployeeManager getemp = new EmployeeManager();

            try
            {
                string sql = "SELECT employee_id, Date,Type FROM shifts WHERE Type LIKE 'Afternoon%';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr[0]);
                    Employee gottenEmp = getemp.GetEmployee(id);
                    shifts.Add(new Shift(gottenEmp, Convert.ToDateTime(dr[1]), dr[2].ToString()));
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
            return shifts;
        }


        public object GetAllEveningShifts()
        {
            List<Shift> shifts = new List<Shift>();
            EmployeeManager getemp = new EmployeeManager();

            try
            {
                string sql = "SELECT employee_id, Date,Type FROM shifts WHERE Type LIKE 'Night%';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr[0]);
                    Employee gottenEmp = getemp.GetEmployee(id);
                    shifts.Add(new Shift(gottenEmp, Convert.ToDateTime(dr[1]), dr[2].ToString()));
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
            return shifts;
        }


        public void Delete(int id)
        {
            try
            {
                string sql = "DELETE FROM shifts WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", id);


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
    }
}
