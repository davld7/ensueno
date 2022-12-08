using ensueno.Presentation.Login;
using ensueno.Presentation.Validations;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ensueno.Presentation.Main
{
    public partial class Form_invoice_detail : Form
    {
        private readonly Invoices_Detail invoices_detail = new Invoices_Detail();
        private DataTable dt = new DataTable();
        readonly Values val = new Values();
        private Form_invoice_create fic;
        private Form_invoice fi;
        private int invoice_id;
        public Form_invoice_detail()
        {
            InitializeComponent();
            Apply_dark_mode();
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

        private void Button_create_Click(object sender, EventArgs e)
        {
            fic = new Form_invoice_create();
            fic.ShowDialog();
        }

        private void Button_invoice_Click(object sender, EventArgs e)
        {
            fi = new Form_invoice();
            fi.ShowDialog();
        }

        private void Form_invoice_detail_Load(object sender, EventArgs e)
        {
            Label_client_name.Text = Form_invoice_create.Client_name;
            Label_Employee_Name.Text = $"{Form_login.employee_name} {Form_login.employee_last_name}";
            invoice_id = Program.Values.invoice_id;
            Read_invoice_detail(invoice_id);
            Product_autocomplete();
        }
        private void Read_invoice_detail(int invoice_id)
        {
            dt=invoices_detail.Read_By_Id(invoice_id);
            DataGridView_invoice_detail.DataSource = dt;
            DataGridView_invoice_detail.Refresh();
        }
        private void Product_autocomplete()
        {
            try
            {
                dt = invoices_detail.Product_list();
                ComboBox1.DataSource = dt;
                ComboBox1.ValueMember = "Id_Producto";
                ComboBox1.DisplayMember = "Nombre";

                AutoCompleteStringCollection lst = new AutoCompleteStringCollection();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lst.Add(dt.Rows[i]["Nombre"].ToString());
                }
                ComboBox1.AutoCompleteCustomSource = lst;
                //nO TIENE FUNCIONALIDAD POR LO QUE EL COMBOBOX NO PERMITE ESCRITURA
                //comboBox1.AutoCompleteMode =AutoCompleteMode.Suggest;
                //comboBox1.AutoCompleteSource=AutoCompleteSource.CustomSource;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox_id_producto.Text = Convert.ToString(ComboBox1.SelectedValue.ToString());
        }
        private double price, amount, subtotal, iva,total ;

        private void TextBox_amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_amount.Text != string.Empty)
                {
                    Calculate();
                    TextBox_Sub_Total.Text = Convert.ToString(subtotal);
                    TextBox_IVA.Text = Convert.ToString(iva);
                    TextBox_total.Text = Convert.ToString(total);
                }
                else
                {
                    TextBox_Sub_Total.Clear();
                    TextBox_IVA.Clear();
                    TextBox_total.Clear();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_agregar_producto_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id_producto.Text == string.Empty || TextBox_amount.Text == string.Empty)
                {
                    val.empty_text(TextBox_id_producto);
                    val.empty_text(TextBox_amount);
                    MessageBox.Show("Estos Campos no pueden estar vacios");
                }
                else if (Stock_() < int.Parse(TextBox_amount.Text)) 
                {
                    Clear_textboxes();
                    MessageBox.Show("Stock Insuficiente para esta compra");
                }
                else if (invoices_detail.Create(Program.Values.invoice_id, int.Parse(TextBox_id_producto.Text), int.Parse(TextBox_amount.Text)))
                {
                    invoice_id = Program.Values.invoice_id;
                    Clear_textboxes();
                    Read_invoice_detail(invoice_id);
                    Invoice_Detail_total();
                    MessageBox.Show("Agregado Correctamente");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id_producto.Text == string.Empty || TextBox_amount.Text == string.Empty)
                {
                    val.empty_text(TextBox_id_producto);
                    val.empty_text(TextBox_amount);
                    MessageBox.Show("Estos Campos no pueden estar vacios");
                }
                else if (Stock < int.Parse(TextBox_amount.Text))
                {
                    Clear_textboxes();
                    MessageBox.Show("Stock Insuficiente para esta compra");
                }
                else if (invoices_detail.Update(Program.Values.invoice_id, int.Parse(TextBox_id_producto.Text), int.Parse(TextBox_amount.Text)))
                {
                    invoice_id = Program.Values.invoice_id;
                    Clear_textboxes();
                    Read_invoice_detail(invoice_id);
                    Invoice_Detail_total();
                    MessageBox.Show("Actualizado Correctamente");
                }
            }
            catch(Exception)
            {

            }
        }
        private void Button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_id_producto.Text == string.Empty)
                {
                    val.empty_text(TextBox_id_producto);
                    MessageBox.Show("Este campo no pueden estar vacios");
                }
                else if (invoices_detail.Delete(Program.Values.invoice_id, int.Parse(TextBox_id_producto.Text)))
                {
                    invoice_id = Program.Values.invoice_id;
                    Clear_textboxes();
                    Read_invoice_detail(invoice_id);
                    Invoice_Detail_total();
                    MessageBox.Show("Eliminado Correctamente");
                }
            }
            catch (Exception)
            {

            }
        }

        private void TextBox_id_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numbers_only(TextBox_id_producto,e);
        }

        private void TextBox_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.decimal_only(TextBox_Precio, e);
        }

        private void TextBox_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numbers_only(TextBox_amount, e);
        }

        private void TextBox_Sub_Total_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.decimal_only(TextBox_Sub_Total,e);
        }

        private void TextBox_IVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.decimal_only(TextBox_IVA,e);
        }

        private void TextBox_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.decimal_only(TextBox_total,e);
        }
        private void Clear_textboxes()
        {
            TextBox_id_producto.Clear();
            TextBox_Precio.Clear();
            TextBox_amount.Clear();
            TextBox_Sub_Total.Clear();
            TextBox_IVA.Clear();
            TextBox_total.Clear();
        }
        private void DataGridView_invoice_detail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataGridView_invoice_detail.Rows[e.RowIndex].Cells[0].Value.ToString() == string.Empty)
                {
                    Clear_textboxes();
                    MessageBox.Show("Elija una fila válida.");
                }
                else
                {
                    TextBox_id_producto.Text = DataGridView_invoice_detail.Rows[e.RowIndex].Cells[1].Value.ToString();
                    TextBox_Precio.Text = DataGridView_invoice_detail.Rows[e.RowIndex].Cells[3].Value.ToString();
                    TextBox_amount.Text = DataGridView_invoice_detail.Rows[e.RowIndex].Cells[4].Value.ToString();
                    TextBox_Sub_Total.Text= DataGridView_invoice_detail.Rows[e.RowIndex].Cells[5].Value.ToString();
                    TextBox_IVA.Text = DataGridView_invoice_detail.Rows[e.RowIndex].Cells[6].Value.ToString();
                    TextBox_total.Text = DataGridView_invoice_detail.Rows[e.RowIndex].Cells[7].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Calculate ()
        {
            try
            {
                price = Convert.ToDouble(TextBox_Precio.Text);
                amount = Convert.ToDouble(TextBox_amount.Text);
                subtotal = price * amount;
                iva = subtotal * 0.15;
                total = subtotal + iva;
            }catch(Exception)
            {

            }
        }
        private int Stock;
        private int Stock_()
        {
            try
            {
                if(TextBox_id_producto.Text!=string.Empty)
                {
                    dt = invoices_detail.Autocomplete_Product(int.Parse(TextBox_id_producto.Text));
                    int Stock = int.Parse(dt.Rows[0][2].ToString());
                    this.Stock = Stock;
                    return Stock;
                }
                else
                {
                    return 0;
                }
            }catch(Exception)
            {
                return 0;
            }
        }
         
        private void Autocomplete_Product()
        {
            try
            {
                if (TextBox_id_producto.Text != string.Empty)
                {
                    dt = invoices_detail.Autocomplete_Product(int.Parse(TextBox_id_producto.Text));
                    TextBox_Precio.Text = dt.Rows[0][3].ToString();
                }
                else
                {
                    TextBox_Precio.Text = string.Empty;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Invoice_Detail_total()
        {
            dt = invoices_detail.Total_invoice_detail(Program.Values.invoice_id);
            Label_Total_Venta.Text = dt.Rows[0][0].ToString();
        }
        private void TextBox1_id_producto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Autocomplete_Product();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
