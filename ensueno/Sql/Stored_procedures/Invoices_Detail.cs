using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml.Linq;

namespace ensueno.Sql.Stored_procedures
{
    internal class Invoices_Detail : Connection
    {
        private SqlCommand command;
        private SqlDataAdapter data_adapter;
        private DataTable data_table;
        
        public DataTable Read_By_Id(int invoice_id)
        {
            try
            {
                Connect();
                command = new SqlCommand($"exec invoice_detail_read_by_id '{invoice_id}' ", Get_connection());
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
            finally 
            { 
                Disconnect();
            }
        }
        public DataTable Validate_units(int invoice_id, int product_id)
        {
            try
            {
                Connect();
                command = new SqlCommand($"exec Validate_Units '{invoice_id}','{product_id}' ", Get_connection());
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
            finally
            {
                Disconnect();
            }

        }
        public DataTable Product_list()
        {
            try
            {
                Connect();
                command = new SqlCommand($"exec invoce_detail_product_list", Get_connection());
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
            finally
            { 
                Disconnect(); 
            }
        }
        public DataTable Autocomplete_Product(int Id_product)
        {
            try
            {
                Connect();
                command = new SqlCommand($"exec invoice_detail_search_product '{Id_product}' ", Get_connection());
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
            finally
            {
                Disconnect();
            }
        }

        public DataTable Read_history_by_id(int invoice_id)
        {
            try
            {
                Connect();
                command = new SqlCommand($"exec invoice_detail_read_history_by_Id '{invoice_id}' ", Get_connection());
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
            finally 
            { 
                Disconnect();
            }
        }
   
        public bool Create(int invoice_id,int product_id,int units)
            {
            try
            {
                Connect();
                command = new SqlCommand($"exec invoice_detail_create '{invoice_id}','{product_id}','{units}'", Get_connection());
                command.ExecuteNonQuery();
                Disconnect();
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
        public bool Update(int invoice_id, int product_id,int units)
        {
            try
            {
                Connect();
                command = new SqlCommand($"exec invoice_detail_update '{invoice_id}','{product_id}','{units}'", Get_connection());
                command.ExecuteNonQuery();
                Disconnect();
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
        public bool Delete(int invoice_id,int product_id)
        {
            try
            {
                Connect();
                command = new SqlCommand($"exec invoice_detail_delete '{invoice_id}','{product_id}'", Get_connection());
                command.ExecuteNonQuery();
                Disconnect();
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
        }public bool Restore(int invoice_id,int product_id)
        {
            try
            {
                Connect();
                command = new SqlCommand($"exec invoice_detail_restore '{invoice_id}','{product_id}'", Get_connection());
                command.ExecuteNonQuery();
                Disconnect();
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
        public DataTable Total_invoice_detail(int invoice_id)
        {
            try
            {
                Connect();
                command = new SqlCommand($"exec invoice_detail_total '{invoice_id}'", Get_connection());
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
            finally
            {
                Disconnect();
            }
        }
        public DataTable Validate_Product_invoice_detail_id(int invoice_id,int product_id)
        {
            try
            {
                Connect();
                command = new SqlCommand($"exec val_exist_product_invoice_detail_by_id '{invoice_id}','{product_id}' ", Get_connection());
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
            finally
            {
                Disconnect();
            }
        }
    }
}
