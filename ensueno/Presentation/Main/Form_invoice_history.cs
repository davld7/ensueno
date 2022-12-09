using ensueno.Sql.Stored_procedures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ensueno.Presentation.Main
{
    public partial class Form_invoice_history : Form
    {
        private readonly Invoices invoices = new Invoices();
        private readonly Invoices_Detail invoices_detail = new Invoices_Detail();
        private DataTable dt = new DataTable();
        public Form_invoice_history()
        {
            InitializeComponent();
            Apply_dark_mode();
            this.Select();
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

        private void DataGridView_invoice_history_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataGridView_invoice_history.Rows[e.RowIndex].Cells[0].Value.ToString() == string.Empty)
                {
                    Clear_textboxes();
                    MessageBox.Show("Elija una fila válida.");
                }
                else
                {
                    TextBox_id.Text =DataGridView_invoice_history.Rows[e.RowIndex].Cells[0].Value.ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void read_history()
        {
            DataTable dt = new DataTable();
            dt=invoices.Read_invoice_history();
            DataGridView_invoice_history.DataSource = dt;
            DataGridView_invoice_history.Refresh();

        }

        private void Clear_textboxes()
        {
            TextBox_id.Text = "";
        }

        private void Form_invoice_history_Load(object sender, EventArgs e)
        {
            read_history();
        }
        private void invoice_detail_list_restore(int invoice_id)
        {
            try
            {
                dt = invoices_detail.Read_history_by_id(invoice_id);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int product_id;
                    product_id = int.Parse(dt.Rows[i][1].ToString());
                    int units = int.Parse(dt.Rows[i][4].ToString());
                    string Product_name = dt.Rows[i][2].ToString();
                    if (Stock_(product_id) < 0 || Stock_(product_id) < units)
                    {
                        MessageBox.Show($"Stock insuficiente para restaurar\nel producto {Product_name} de esta factura");
                    }
                    else
                    {
                        invoices_detail.Restore(invoice_id, product_id);
                    }
                }
            }catch(Exception)
            {

            }
        }
        private int Stock_(int product_id)
        {
            try
            {
                if (product_id>0)
                {
                    dt = invoices_detail.Autocomplete_Product(product_id);
                    int Stock = int.Parse(dt.Rows[0][2].ToString());
                    return Stock;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private void Button_restore_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id.Text == string.Empty)
                {
                    MessageBox.Show("El campo id no puede estar vacio");
                }
                else
                {
                   if( invoices.Restore(int.Parse(TextBox_id.Text)))
                    {
                        invoice_detail_list_restore(int.Parse(TextBox_id.Text));
                        MessageBox.Show("Factura restaurada correctamente");
                        TextBox_id.Clear();
                        read_history();
                    }
                   else
                    {
                        MessageBox.Show("No se pudo restaurar este registro");
                        TextBox_id.Clear();
                        read_history();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBox_id_TextChanged(object sender, EventArgs e)
        {
            if (TextBox_id.Text != string.Empty)
            {
                Button_restore.Enabled = true;
            }
            else
            {
                Button_restore.Enabled = false;
            }
        }
    }
    
}
