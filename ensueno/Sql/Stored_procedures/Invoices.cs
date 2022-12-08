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
    internal class Invoices : Connection
    {
        private DataRow data_row;
        private SqlCommand command;
        private SqlDataAdapter data_adapter;
        private DataTable data_table;


        public DataTable invoice_search_client()
        {
            try
            {
                Connect();
                command = new SqlCommand($"execute invoice_search_client", Get_connection());
                data_adapter = new SqlDataAdapter(command);
                data_table = new DataTable();
                data_adapter.Fill(data_table);
                Disconnect();
                return data_table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { Disconnect(); }
        }
        public DataRow Last_id()
        {
            try
            {
                Connect();
                command = new SqlCommand($"SELECT max(invoice_id) as 'Valor ID' FROM INVOICE", Get_connection());
                data_adapter = new SqlDataAdapter(command);
                data_table = new DataTable();
                data_adapter.Fill(data_table);
                data_row = data_table.Rows[0];
                Disconnect();
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

        public bool Create(int Employee_id, int Client_id)
        {
            try
            {
                Connect();
                command = new SqlCommand($"execute invoice_create '{Employee_id}','{Client_id}'", Get_connection());
                command.ExecuteNonQuery();
                Disconnect();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
        public bool Update(int invoice_id, int Client_id)
        {
            try
            {
                Connect();
                command = new SqlCommand($"execute invoice_update '{invoice_id}','{Client_id}'",Get_connection());
                command.ExecuteNonQuery();
                Disconnect();
                return true;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally { Disconnect(); }
        }
        public bool Delete(int invoice_id)
        {
            try
            {
                Connect();
                command = new SqlCommand($"execute invoice_delete '{invoice_id}'", Get_connection());
                command.ExecuteNonQuery();
                Disconnect();
                return true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally { Disconnect(); }
        }
        public DataTable Read()
        {
            try
            {
                Connect();
                command = new SqlCommand($"execute invoice_Read", Get_connection());
                data_adapter = new SqlDataAdapter(command);
                data_table = new DataTable();
                data_adapter.Fill(data_table);
                Disconnect();
                return data_table;
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public DataTable Read_invoice_history()
        {
            try
            {
                Connect();
                command = new SqlCommand($"execute invoice_Read_history", Get_connection());
                data_adapter = new SqlDataAdapter(command);
                data_table = new DataTable();
                data_adapter.Fill(data_table);
                Disconnect();
                return data_table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool Restore(int invoice_id)
        {
            try
            {
                Connect();
                command = new SqlCommand($"execute invoice_active '{invoice_id}'", Get_connection());
                command.ExecuteNonQuery();
                Disconnect();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally { Disconnect(); }
        }
    }
}
