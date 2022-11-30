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
        public DataTable Read_history()
        {

            try
            {
                Connect();
                command = new SqlCommand("exec employees_read_history")
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
                command = new SqlCommand($"exec employee_read_by_user @employee_user={user}")
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

        public bool Create(string id_card, string name, string last_name, string phone, string address, string user, string password, bool admin)
        {
            try
            {
                Connect();
                command = new SqlCommand($"exec employee_create @employee_id_card='{id_card}', @employee_name='{name}', @employee_last_name='{last_name}', @employee_phone='{phone}', @employee_address='{address}', @employee_user='{user}', @employee_admin={admin}")
                {
                    Connection = Get_connection()
                };
                command.ExecuteNonQuery();
                command = new SqlCommand($"create login {user} with password = '{password}'")
                {
                    Connection = Get_connection()
                };
                command.ExecuteNonQuery();
                command = new SqlCommand($"exec [sys].[sp_addsrvrolemember] {user}, 'sysadmin'")
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

        public bool Update(int id, string id_card, string name, string last_name, string phone, string address, string user, string password, bool admin, string old_user)
        {
            try
            {
                if (old_user == Properties.Settings.Default.active_user)
                {
                    MessageBox.Show("No puedes actualizar tu registro usando tus credenciales en la conexión actual.");
                    return false;
                }
                else
                {
                    Connect();
                    command = new SqlCommand($"drop login {old_user}")
                    {
                        Connection = Get_connection()
                    };
                    command.ExecuteNonQuery();
                    command = new SqlCommand($"create login {user} with password = '{password}'")
                    {
                        Connection = Get_connection()
                    };
                    command.ExecuteNonQuery();
                    command = new SqlCommand($"exec [sys].[sp_addsrvrolemember] {user}, 'sysadmin'")
                    {
                        Connection = Get_connection()
                    };
                    command.ExecuteNonQuery();
                    command = new SqlCommand($"exec employee_update @employee_id={id}, @employee_id_card='{id_card}', @employee_name='{name}', @employee_last_name='{last_name}', @employee_phone='{phone}', @employee_address='{address}', @employee_user='{user}', @employee_admin={admin}")
                    {
                        Connection = Get_connection()
                    };
                    command.ExecuteNonQuery();
                    return true;
                }
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
        public bool Delete(int id, string old_user)
        {
            try
            {
                if (old_user == Properties.Settings.Default.active_user)
                {
                    MessageBox.Show("No puedes eliminar tu registro usando tus credenciales en la conexión actual.");
                    return false;
                }
                else
                {
                    Connect();
                    command = new SqlCommand($"exec employee_deactivate {id}")
                    {
                        Connection = Get_connection()
                    };
                    command.ExecuteNonQuery();
                    command = new SqlCommand($"drop login {old_user}")
                    {
                        Connection = Get_connection()
                    };
                    command.ExecuteNonQuery();
                    return true;
                }
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
        public bool Restore(int id, string user, string password)
        {
            try
            {
                Connect();
                command = new SqlCommand($"create login {user} with password = '{password}'")
                {
                    Connection = Get_connection()
                };
                command.ExecuteNonQuery();
                command = new SqlCommand($"exec [sys].[sp_addsrvrolemember] {user}, 'sysadmin'")
                {
                    Connection = Get_connection()
                };
                command.ExecuteNonQuery();
                command = new SqlCommand($"exec employee_activate @employee_id={id}")
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
