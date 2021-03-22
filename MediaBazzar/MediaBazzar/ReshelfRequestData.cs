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
    class ReshelfRequestData : IDatabaseManager
    {

        public static MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local; Uid=dbi457108; Database=dbi457108; Pwd=NewPassword123");

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(object obj)
        {
            ReshelfRequest acc = (ReshelfRequest)obj;
            try
            {
                // make sure in your table the id in auto-incremented
                string sql = "INSERT INTO shopstock (StockID, StockName,StockAmount,Price,Brand) VALUES (@stockID, @stockname,@amount,@price,@brand)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@stockID", stock.ID);
                cmd.Parameters.AddWithValue("@stockname", stock.Name);
                cmd.Parameters.AddWithValue("@amount", stock.Amount);
                cmd.Parameters.AddWithValue("@price", stock.Price);
                cmd.Parameters.AddWithValue("@brand", stock.Brand);


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
            List<ReshelfRequest> Requests = new List<ReshelfRequest>();

            try
            {
                string sql = "SELECT StockID, StockName,StockAmount,Price,Brand FROM shopstock;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Requests.Add(new Stock(dr[1].ToString(), Convert.ToInt32(dr[2]), Convert.ToInt32(dr[0]), Convert.ToInt32(dr[3]), dr[4].ToString()));
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
            return Requests;
        }
    }
}
