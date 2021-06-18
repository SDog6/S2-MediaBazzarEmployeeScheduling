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
    class ReshelfRequestData : DatabaseConnection, IDatabaseManager
    {


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
                string sql = "INSERT INTO restockrequests (stockid,amount,date) VALUES (@stockid,@amount,@date)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@stockid", acc.RequiredStock.ID);
                cmd.Parameters.AddWithValue("@amount", acc.AmountNeeded);
                cmd.Parameters.AddWithValue("@date", acc.FilledDate);

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


        public void ReduceStockInWarehouse(ReshelfRequest a)
        {
            try
            {
                // make sure in your table the id in auto-incremented
                string sql = "UPDATE stock SET amount = amount - @amount WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", a.RequiredStock.ID);
                cmd.Parameters.AddWithValue("@amount", a.AmountNeeded);


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


        public void IncreaseStockInShop(ReshelfRequest a)
        {
            try
            {
                string sql = "UPDATE shopstock SET amount = amount + @amount WHERE stockid = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", a.RequiredStock.ID);
                cmd.Parameters.AddWithValue("@amount", a.AmountNeeded);


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

        public void CompleteRequest(ReshelfRequest a)
        {
            try
            {
                // make sure in your table the id in auto-incremented
                string sql = "UPDATE restockrequests SET complete = true WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", a.ID);


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
            ShopStockData a = new ShopStockData();

            try
            {
                string sql = "SELECT * FROM restockrequests;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr[1]);
                    Stock b = (Stock)a.SearchForStockByID(id);
                    Requests.Add(new ReshelfRequest(b,Convert.ToDateTime(dr[3]) ,Convert.ToInt32(dr[2]),Convert.ToBoolean(dr[4]),Convert.ToInt32(dr[0])));
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
