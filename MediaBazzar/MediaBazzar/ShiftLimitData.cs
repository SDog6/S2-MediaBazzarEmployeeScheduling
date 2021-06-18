using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazzar
{
    public class ShiftLimitData : DatabaseConnection
    {

        public ShiftLimitData()
        {

        }
        public void SetLimits(List<decimal> limits)
        {
            string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            try
            {
                int cnt = 0;
                foreach(string day in days)
                {
                    string sql = "UPDATE shiftlimits SET morning = @morning, evening = @evening, night = @night WHERE day = @day";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@morning", limits[cnt]);
                    cnt++;
                    cmd.Parameters.AddWithValue("@evening", limits[cnt]);
                    cnt++;
                    cmd.Parameters.AddWithValue("@night", limits[cnt]);
                    cnt++;
                    cmd.Parameters.AddWithValue("@day", day);

                    conn.Close();
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public List<decimal> GetLimits()
        {
            string sql = "SELECT morning, evening, night FROM shiftlimits";
            List<decimal> limits = new List<decimal>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    limits.Add(Convert.ToInt32(dr[0]));
                    limits.Add(Convert.ToInt32(dr[1]));
                    limits.Add(Convert.ToInt32(dr[2]));
                }
                return limits;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return null;
        }
    }
}
