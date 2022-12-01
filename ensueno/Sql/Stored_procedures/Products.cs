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
        public SqlDataReader Read_image(int id)
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
                return data_reader;
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
    }
}
