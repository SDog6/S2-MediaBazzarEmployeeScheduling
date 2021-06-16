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
    class ShiftSchedulingRequestsData
    {

        public static MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local; Uid=dbi457108; Database=dbi457108; Pwd=NewPassword123");

        public object ReadAll()
        {
            List<ShiftRequest> shifts = new List<ShiftRequest>();
            EmployeeManager getemp = new EmployeeManager();

            try
            {
                string sql = "SELECT id,employee_id, Date,Type FROM shiftsrequests;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr[1]);
                    Employee gottenEmp = getemp.GetEmployee(id);
                    shifts.Add(new ShiftRequest(Convert.ToInt32(dr[0]), gottenEmp, dr[2].ToString(), dr[3].ToString()));
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
            List<ShiftRequest> shifts = new List<ShiftRequest>();
            EmployeeManager getemp = new EmployeeManager();

            try
            {
                string sql = "SELECT employee_id, Date,Type FROM shiftsrequests WHERE Type LIKE 'Morning%';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr[0]);
                    Employee gottenEmp = getemp.GetEmployee(id);
                    shifts.Add(new ShiftRequest(id,gottenEmp,dr[1].ToString(), dr[2].ToString()));
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
            List<ShiftRequest> shifts = new List<ShiftRequest>();
            EmployeeManager getemp = new EmployeeManager();

            try
            {
                string sql = "SELECT employee_id, Date,Type FROM shiftsrequests WHERE Type LIKE 'Afternoon%';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr[0]);
                    Employee gottenEmp = getemp.GetEmployee(id);
                    shifts.Add(new ShiftRequest(id,gottenEmp, dr[1].ToString(), dr[2].ToString()));
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
            List<ShiftRequest> shifts = new List<ShiftRequest>();
            EmployeeManager getemp = new EmployeeManager();

            try
            {
                string sql = "SELECT employee_id, Date,Type FROM shiftsrequests WHERE Type LIKE 'Night%';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr[0]);
                    Employee gottenEmp = getemp.GetEmployee(id);
                    shifts.Add(new ShiftRequest(id,gottenEmp, dr[1].ToString(), dr[2].ToString()));
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


        public object GetAllMondayShifts()
        {
            List<ShiftRequest> shifts = new List<ShiftRequest>();
            EmployeeManager getemp = new EmployeeManager();

            try
            {
                string sql = "SELECT employee_id, Date,Type FROM shiftsrequests WHERE Date LIKE 'Monday%';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr[0]);
                    Employee gottenEmp = getemp.GetEmployee(id);
                    shifts.Add(new ShiftRequest(id, gottenEmp, dr[1].ToString(), dr[2].ToString()));
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


        public object GetAllTuesdayShifts()
        {
            List<ShiftRequest> shifts = new List<ShiftRequest>();
            EmployeeManager getemp = new EmployeeManager();

            try
            {
                string sql = "SELECT employee_id, Date,Type FROM shiftsrequests WHERE Date LIKE 'Tuesday%';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr[0]);
                    Employee gottenEmp = getemp.GetEmployee(id);
                    shifts.Add(new ShiftRequest(id, gottenEmp, dr[1].ToString(), dr[2].ToString()));
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




        public object GetAllWednesdayShifts()
        {
            List<ShiftRequest> shifts = new List<ShiftRequest>();
            EmployeeManager getemp = new EmployeeManager();

            try
            {
                string sql = "SELECT employee_id, Date,Type FROM shiftsrequests WHERE Date LIKE 'Wednesday%';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr[0]);
                    Employee gottenEmp = getemp.GetEmployee(id);
                    shifts.Add(new ShiftRequest(id, gottenEmp, dr[1].ToString(), dr[2].ToString()));
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




        public object GetAllThursdayShifts()
        {
            List<ShiftRequest> shifts = new List<ShiftRequest>();
            EmployeeManager getemp = new EmployeeManager();

            try
            {
                string sql = "SELECT employee_id, Date,Type FROM shiftsrequests WHERE Date LIKE 'Thursday%';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr[0]);
                    Employee gottenEmp = getemp.GetEmployee(id);
                    shifts.Add(new ShiftRequest(id, gottenEmp, dr[1].ToString(), dr[2].ToString()));
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




        public object GetAllFridayShifts()
        {
            List<ShiftRequest> shifts = new List<ShiftRequest>();
            EmployeeManager getemp = new EmployeeManager();

            try
            {
                string sql = "SELECT employee_id, Date,Type FROM shiftsrequests WHERE Date LIKE 'Friday%';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr[0]);
                    Employee gottenEmp = getemp.GetEmployee(id);
                    shifts.Add(new ShiftRequest(id, gottenEmp, dr[1].ToString(), dr[2].ToString()));
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




        public object GetAllSaturdayShifts()
        {
            List<ShiftRequest> shifts = new List<ShiftRequest>();
            EmployeeManager getemp = new EmployeeManager();

            try
            {
                string sql = "SELECT employee_id, Date,Type FROM shiftsrequests WHERE Date LIKE 'Saturday%';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr[0]);
                    Employee gottenEmp = getemp.GetEmployee(id);
                    shifts.Add(new ShiftRequest(id, gottenEmp, dr[1].ToString(), dr[2].ToString()));
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




        public object GetAllSundayShifts()
        {
            List<ShiftRequest> shifts = new List<ShiftRequest>();
            EmployeeManager getemp = new EmployeeManager();

            try
            {
                string sql = "SELECT employee_id, Date,Type FROM shiftsrequests WHERE Date LIKE 'Sunday%';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr[0]);
                    Employee gottenEmp = getemp.GetEmployee(id);
                    shifts.Add(new ShiftRequest(id, gottenEmp, dr[1].ToString(), dr[2].ToString()));
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


        public object GetAllRequestsByDay(string day)
        {
            List<ShiftRequest> shifts = new List<ShiftRequest>();
            EmployeeManager getemp = new EmployeeManager();

            try
            {
                string sql = "SELECT employee_id, Date,Type FROM shiftsrequests WHERE Date LIKE @day;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@day", day);
                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr[0]);
                    Employee gottenEmp = getemp.GetEmployee(id);
                    shifts.Add(new ShiftRequest(id, gottenEmp, dr[1].ToString(), dr[2].ToString()));
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



        public void Delete(Object obj)
        {
            ShiftRequest s = (ShiftRequest)obj;
            try
            {
                string sql = "DELETE FROM shiftsrequests WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", s.ID);


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
