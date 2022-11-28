using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ensueno.Sql.Stored_procedures
{
    internal class Employees : Connection
    {
        private SqlCommand command;
        private SqlDataAdapter data_adapter;
        private DataTable data_table;
        private DataRow data_row;
        public DataTable Read()
        {

            try
            {
                Connect();
                command = new SqlCommand("exec employees_read")
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

        public DataRow Read_by_user(string user)
        {
            try
            {
                Connect();
                command = new SqlCommand($"exec employee_read_by_user @employee_user='" + user + "'")
                {
                    Connection = Get_connection()
                };
                data_table = new DataTable();
                data_adapter = new SqlDataAdapter(command);
                data_adapter.Fill(data_table);
                data_row = data_table.Rows[0];
                return data_row;
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
    }
}
