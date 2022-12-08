using ensueno.Presentation.Login;
using ensueno.Presentation.Validations;
using ensueno.Sql.Stored_procedures;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ensueno.Presentation.Main
{
    public partial class Form_invoice : Form
    {
        private Form_invoice_history fh;
        private Form_invoice_report fr;
        private readonly Invoices invoices = new Invoices();
        private DataTable dt = new DataTable();
        private DataRow dr;
        readonly Values val = new Values();
        public static int client_id, employee_id, C_employeeid; 
        public static string client_name;
        

        public Form_invoice()
        {
            InitializeComponent();
            Apply_dark_mode();
            this.Select();
            Client_autocomplete();
           C_employeeid =int.Parse( Form_login.employee_id);
         }
        
        private void Apply_dark_mode()
        {
            if (Properties.Settings.Default.dark_mode)
            {
                this.BackColor = Color.FromArgb(31, 31, 31);
            }
            else
            {
                this.BackColor = Color.FromArgb(238, 238, 238);
            }
        }
        
        private void Button_history_Click(object sender, EventArgs e)
        {
            fh = new Form_invoice_history();
            fh.ShowDialog();
        }

        private void Button_report_Click(object sender, EventArgs e)
        {
            Program.Values.invoice_id = int.Parse(TextBox_invoice_id.Text);
            fr = new Form_invoice_report();
            fr.ShowDialog();
        }

        private void Form_invoice_Load(object sender, EventArgs e)
        {
            Read();
        }
        public void Last_id()
        {
            dr=invoices.Last_id();
            Program.Values.invoice_id = int.Parse(dr.ItemArray[0].ToString())+1;
            
        }

        private void Client_autocomplete()
        {
            try
            {
                dt = invoices.invoice_search_client();
                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "ID";
                comboBox1.DisplayMember = "Nombre Completo";

                AutoCompleteStringCollection lst = new AutoCompleteStringCollection();
                for(int i =0;i< dt.Rows.Count;i++)
                {
                    lst.Add(dt.Rows[i]["Nombre Completo"].ToString());
                }
                    comboBox1.AutoCompleteCustomSource = lst;
                //nO TIENE FUNCIONALIDAD POR LO QUE EL COMBOBOX NO PERMITE ESCRITURA
                //comboBox1.AutoCompleteMode =AutoCompleteMode.Suggest;
                //comboBox1.AutoCompleteSource=AutoCompleteSource.CustomSource;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox_client_id.Text = comboBox1.SelectedValue.ToString();
            }catch(Exception)
            {

            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_client_id.Text==string.Empty)
                {
                    val.empty_text(TextBox_client_id);
                    MessageBox.Show("Rellene los campos faltantes");
                }
                else
                {
                    client_name = comboBox1.Text;
                    employee_id = C_employeeid;
                    client_id = int.Parse(TextBox_client_id.Text);
                    Last_id();
                    Form_invoice_create form_Invoice_Create = new Form_invoice_create();
                    form_Invoice_Create.ShowDialog();
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_client_id.Text == string.Empty || TextBox_invoice_id.Text == string.Empty)
                {
                    val.empty_text(TextBox_invoice_id);
                    val.empty_text(TextBox_client_id);
                    MessageBox.Show("Rellene los campos faltantes");
                }
                else
                {
                    Program.Values.invoice_id= int.Parse(TextBox_invoice_id.Text);
                    employee_id = C_employeeid;
                    client_id = int.Parse(TextBox_client_id.Text);
                  if(invoices.Update(Program.Values.invoice_id, client_id))
                  {
                        MessageBox.Show("Se ha actualizado Correctamente");
                        Clear_textboxes();
                        Read();
                  }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar");
                        Clear_textboxes();
                        Read();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_invoice_id.Text==string.Empty)
                {
                    val.empty_text(TextBox_invoice_id);
                    MessageBox.Show("Rellene los campos faltantes");
                }
                else
                {
                    Program.Values.invoice_id = int.Parse(TextBox_invoice_id.Text);
                    if (invoices.Delete(Program.Values.invoice_id))
                    {
                        MessageBox.Show("Factura eliminada Correctamente");
                        Clear_textboxes();
                        Read();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar Factura");
                        Clear_textboxes();
                        Read();
                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBox_invoice_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numbers_only(TextBox_invoice_id, e);   
        }

        private void TextBox_client_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numbers_only(TextBox_client_id, e);
        }
        private void Clear_textboxes()
        {
            TextBox_invoice_id.Clear();
            TextBox_client_id.Clear();
            
        }
        private void DataGridView_invoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataGridView_invoices.Rows[e.RowIndex].Cells[0].Value.ToString() == string.Empty)
                {
                    Clear_textboxes();
                    MessageBox.Show("Elija una fila válida.");
                }
                else
                {
                    TextBox_invoice_id.Text = DataGridView_invoices.Rows[e.RowIndex].Cells[0].Value.ToString();
                    TextBox_client_id.Text = DataGridView_invoices.Rows[e.RowIndex].Cells[3].Value.ToString();
                    comboBox1.Text = DataGridView_invoices.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBox_invoice_id_TextChanged(object sender, EventArgs e)
        {

            if (TextBox_invoice_id.Text != string.Empty)
            {
                Button_Create.Enabled = false;
                Button_update.Enabled = true;
                Button_delete.Enabled = true;
                Button_report.Enabled = true;
            }
            else
            {
                Button_Create.Enabled = true;
                Button_update.Enabled = false;
                Button_delete.Enabled = false;
                Button_report.Enabled = false;
            }
        }
        private void Read()
        {
            dt=invoices.Read();
            DataGridView_invoices.DataSource = dt;
            DataGridView_invoices.Refresh();
        }
        
    }
}
