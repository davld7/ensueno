using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ensueno.Sql.Stored_procedures
{
    internal class Products:Connection
    {
        private SqlCommand command;
        private string query;
        private SqlDataAdapter data_adapter;
        private DataTable data_table;
        private SqlDataReader data_reader;
        private byte[] image;
        public DataTable Read()
        {

            try
            {
                Connect();
                command = new SqlCommand("exec products_read")
                {
                    Connection = Get_connection()
                };
                data_adapter = new SqlDataAdapter(command);
                data_table = new DataTable();
                data_adapter.Fill(data_table);
                return data_table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
        }
        public byte[] Read_image(int id)
        {
            try
            {
                Connect();
                query = $"exec product_read_image {id}";
                command = new SqlCommand(query)
                {
                    Connection = Get_connection()
                };                
                data_reader = command.ExecuteReader();
                data_reader.Read();
                image = (byte[])(data_reader[0]);
                data_reader.Close();
                return image;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool Create(string name, int stock, decimal unit_price, byte[] image)
        {
            try
            {
                Connect();
                query = $"exec product_create '{name}',{stock},@unit_price,@image";
                command = new SqlCommand(query)
                {
                    Connection = Get_connection()
                };
                command.Parameters.Add(new SqlParameter("@unit_price", unit_price));
                command.Parameters.Add(new SqlParameter("@image", image));
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
        public DataTable Validate_name(string name)
        {

            try
            {
                Connect();
                command = new SqlCommand($"exec products_validate_name '{name}'")
                {
                    Connection = Get_connection()
                };
                data_adapter = new SqlDataAdapter(command);
                data_table = new DataTable();
                data_adapter.Fill(data_table);
                return data_table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
        }
        public DataTable Validate_update_name(int id, string name)
        {

            try
            {
                Connect();
                command = new SqlCommand($"exec products_validate_update_name {id},'{name}'")
                {
                    Connection = Get_connection()
                };
                data_adapter = new SqlDataAdapter(command);
                data_table = new DataTable();
                data_adapter.Fill(data_table);
                return data_table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
        }
        public bool Update(int id, string name, int stock, decimal unit_price, byte[] image)
        {
            try
            {
                Connect();
                query = $"exec product_update {id},'{name}',{stock},@unit_price,@image";
                command = new SqlCommand(query)
                {
                    Connection = Get_connection()
                };
                command.Parameters.Add(new SqlParameter("@unit_price", unit_price));
                command.Parameters.Add(new SqlParameter("@image", image));
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
        public DataTable Read_by_name(string name)
        {

            try
            {
                Connect();
                command = new SqlCommand($"exec products_read_by_name '{name}'")
                {
                    Connection = Get_connection()
                };
                data_adapter = new SqlDataAdapter(command);
                data_table = new DataTable();
                data_adapter.Fill(data_table);
                return data_table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
        }
        public bool Delete(int id)
        {
            try
            {
                Connect();
                command = new SqlCommand($"exec product_deactivate {id}")
                {
                    Connection = Get_connection()
                };
                command.ExecuteNonQuery();                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
        public DataTable Read_history()
        {
            try
            {
                Connect();
                command = new SqlCommand("exec products_read_history")
                {
                    Connection = Get_connection()
                };
                data_adapter = new SqlDataAdapter(command);
                data_table = new DataTable();
                data_adapter.Fill(data_table);
                return data_table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
        }
        public bool Restore(int id)
        {
            try
            {
                Connect();
                command = new SqlCommand($"exec product_activate {id}")
                {
                    Connection = Get_connection()
                };
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
