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
    public class ShopStockData
    {

        public static MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local; Uid=dbi457108; Database=dbi457108; Pwd=NewPassword123");

        public void Insert(object obj, int amount)
        {
            Stock stock = (Stock)obj;
            try
            {

                string sql = "INSERT INTO shopstock (StockID,Amount) VALUES (@stockID,@amount)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@stockID", stock.ID);
                cmd.Parameters.AddWithValue("@amount", amount);



                conn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
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
        public object GetRequestItems()
        {
            List<Stock> stocks = new List<Stock>();

            try
            {
                string sql = "SELECT shopstock.StockID, stock.Name,shopstock.Amount,stock.Price,stock.Brand, stock.available FROM stock RIGHT JOIN shopstock ON shopstock.stockid =stock.id WHERE shopstock.stockid IS NULL;";
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
            catch (Exception)
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

        public object ReadAll()
        {
            List<Stock> stocks = new List<Stock>();
            try
            {
                string sql = "SELECT shopstock.StockID, stock.Name,shopstock.Amount,stock.Price,stock.Brand, stock.available FROM shopstock INNER JOIN stock ON shopstock.stockid =stock.id;";
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
            catch (Exception)
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

        public object SearchForStockByID(int id)
        {
            Stock acc = null;
            try
            {
                string sql = "SELECT shopstock.StockID, stock.Name,shopstock.Amount,stock.Price,stock.Brand, stock.available FROM shopstock INNER JOIN stock ON shopstock.stockid =stock.id WHERE shopstock.StockID = @shopstock.StockID ;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@@shopstock.StockID", id);

                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    acc = new Stock(dr[1].ToString(), Convert.ToInt32(dr[2]), Convert.ToInt32(dr[0]), Convert.ToInt32(dr[3]), dr[4].ToString(), Convert.ToInt32(dr[5]));

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
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
            return acc;
        }

        public void Delete(Object obj)
        {
            Stock stock = (Stock)obj;
            try
            {
                string sql = "DELETE FROM shopstock WHERE stockid = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", stock.ID);


                conn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
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
