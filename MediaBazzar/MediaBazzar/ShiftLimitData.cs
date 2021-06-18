using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazzar
{
    public class ShiftLimitData
    {
        public static MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local; Uid=dbi457108; Database=dbi457108; Pwd=NewPassword123");

        public void SetLimits(int[] limits)
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
                conn.Close();
            }
        }

        public int[] GetLimits()
        {
            string sql = "SELECT morning, evening, night FROM shiftlimits";
            List<int> limits = new List<int>();
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
                return limits.ToArray();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}
