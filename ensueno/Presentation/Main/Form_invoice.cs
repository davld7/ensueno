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
        private readonly Invoices_Detail invoices_detail = new Invoices_Detail();
        private DataTable dt = new DataTable();
        private DataRow dr;
        readonly Values val = new Values();   

        public Form_invoice()
        {
            InitializeComponent();
            Apply_dark_mode();
            this.Select();
            Client_autocomplete();
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
            try
            {
                    Program.Values.invoice_id =0;
                    fh = new Form_invoice_history();
                    fh.ShowDialog();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_report_Click(object sender, EventArgs e)
        {
            try
            {
                //Program.Values.invoice_id = int.Parse(TextBox_invoice_id.Text);
                fr = new Form_invoice_report();
                fr.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_invoice_Load(object sender, EventArgs e)
        {
            Read();
            TextBox_client_id.Text = "";
        }
        public void Last_id(int client_id,string client_name)
        {
            dr=invoices.Last_id();
            if (dr.IsNull(0) == true)
            {
                Program.Values.invoice_id = 1;
                Program.Values.client_name=client_name;
                Program.Values.Client_id = client_id;
                Program.Values.Employee_id = int.Parse(Form_login.employee_id);
            }
            else
            {
                Program.Values.invoice_id = int.Parse(dr.ItemArray[0].ToString()) + 1;
                Program.Values.client_name = client_name;
                Program.Values.Client_id = client_id;
                Program.Values.Employee_id = int.Parse(Form_login.employee_id);
            }
        }

        private void Client_autocomplete()
        {
            try
            {
                dt = invoices.invoice_search_client();
                ComboBox1.DataSource = dt;
                ComboBox1.ValueMember = "ID";
                ComboBox1.DisplayMember = "Nombre Completo";

                AutoCompleteStringCollection lst = new AutoCompleteStringCollection();
                for(int i =0;i< dt.Rows.Count;i++)
                {
                    lst.Add(dt.Rows[i]["Nombre Completo"].ToString());
                }
                ComboBox1.AutoCompleteCustomSource = lst;
                ComboBox1.AutoCompleteMode =AutoCompleteMode.Suggest;
                ComboBox1.AutoCompleteSource=AutoCompleteSource.CustomSource;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void invoice_detail_list_delete(int invoice_id)
        {
            dt = invoices_detail.Read_By_Id(invoice_id);
            
            for(int i = 0;i<dt.Rows.Count;i++)
            {
                int product_id;
                product_id =int.Parse(dt.Rows[i][1].ToString());
                invoices_detail.Delete(invoice_id,product_id);
            }
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox_client_id.Text = ComboBox1.SelectedValue.ToString();
            }
            catch (Exception)
            {

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
                    
                  if(invoices.Update(Program.Values.invoice_id,int.Parse(TextBox_client_id.Text)))
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
                        invoice_detail_list_delete(Program.Values.invoice_id);
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
                    ComboBox1.Text = DataGridView_invoices.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_client_id.Text == string.Empty)
                {
                    val.empty_text(TextBox_client_id);
                    MessageBox.Show("Rellene los campos faltantes");
                }
                else
                {
                    Last_id(int.Parse(TextBox_client_id.Text),ComboBox1.Text);
                    Form_invoice_create form_Invoice_Create = new Form_invoice_create();
                    form_Invoice_Create.ShowDialog();
                }
            }
            catch (Exception ex)
            {
               
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
