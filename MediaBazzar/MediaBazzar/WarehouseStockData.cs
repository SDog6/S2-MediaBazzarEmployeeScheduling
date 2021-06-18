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
    public class WarehouseStockData : DatabaseConnection, IDatabaseManager
    {

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(object obj)
        {
            Stock stock = (Stock)obj;
            try
            {
                // make sure in your table the id in auto-incremented
                string sql = "INSERT INTO stock (id, name,amount,price,brand) VALUES (@ID, @name,@amount,@price,@brand)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", stock.ID);
                cmd.Parameters.AddWithValue("@name", stock.Name);
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

        public void ReduceStockInWarehouse(int id,int amount)
        {
            try
            {
                // make sure in your table the id in auto-incremented
                string sql = "UPDATE stock SET amount = amount - @amount WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@amount", amount);


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
        public void Delete(object obj)
        {
            Stock stock = (Stock)obj;
            try
            {
                // make sure in your table the id in auto-incremented
                string sql = "DELETE FROM stock WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", stock.ID);


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
            List<Stock> stocks = new List<Stock>();

            try
            {
                string sql = "SELECT id, name,amount,price,brand,available FROM stock;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    stocks.Add(new Stock(dr[1].ToString(), Convert.ToInt32(dr[2]), Convert.ToInt32(dr[0]), Convert.ToInt32(dr[3]), dr[4].ToString(), Convert.ToInt32(dr[5])));
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
            return stocks;
        }

        public object SearchByStockID(int id)
        {
            List<Stock> stocks = new List<Stock>();

            try
            {
                string sql = "SELECT id, name,amount,price,brand, available FROM stock WHERE id = @id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    stocks.Add(new Stock(dr[1].ToString(), Convert.ToInt32(dr[2]), Convert.ToInt32(dr[0]), Convert.ToInt32(dr[3]), dr[4].ToString(), Convert.ToInt32(dr[5])));
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
            return stocks;
        }


        public object GetStockByID(int id)
        {
            Stock stock = null;

            try
            {
                string sql = "SELECT id, name,amount,price,brand, available FROM stock WHERE id = @id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    stock = new Stock(dr[1].ToString(), Convert.ToInt32(dr[2]), Convert.ToInt32(dr[0]), Convert.ToInt32(dr[3]), dr[4].ToString(), Convert.ToInt32(dr[5]));
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
            return stock;
        }

        public object SearchByStockBrand(string brand)
        {
            List<Stock> stocks = new List<Stock>();

            try
            {
                string sql = "SELECT id, name,amount,price,brand, available FROM stock WHERE brand = @brand;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@brand", brand);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    stocks.Add(new Stock(dr[1].ToString(), Convert.ToInt32(dr[2]), Convert.ToInt32(dr[0]), Convert.ToInt32(dr[3]), dr[4].ToString(), Convert.ToInt32(dr[5])));
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
            return stocks;
        }


        public void IncreaseStockInWarehouse(Stock a,int Amount)
        {
            try
            {
                // make sure in your table the id in auto-incremented
                string sql = "UPDATE stock SET amount = amount + @amount WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", a.ID);
                cmd.Parameters.AddWithValue("@amount", Amount);


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

        public void Discontinue(object obj)
        {
            Stock stock = (Stock)obj;
            try
            {
                // make sure in your table the id in auto-incremented
                string sql = "UPDATE stock SET available = false WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", stock.ID);


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
