using ensueno.Presentation.Login;
using ensueno.Presentation.Validations;
using ensueno.Sql.Stored_procedures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            Label_client_name.Text = Program.Values.client_name;
            Label_Employee_Name.Text = Program.Values.employee_name;
            invoice_id = Program.Values.invoice_id;
            TextBox_invoice_id.Text = Convert.ToString(Program.Values.invoice_id);
            Read_invoice_detail(invoice_id);
            Product_autocomplete();
            TextBox_product_id.Text = "";
            Button_Restore.Visible = false;
            Button_return.Visible = false;
            Invoice_Detail_total();
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
                ComboBox1.AutoCompleteMode =AutoCompleteMode.Suggest;
                ComboBox1.AutoCompleteSource=AutoCompleteSource.CustomSource;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                TextBox_product_id.Text = ComboBox1.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox_product_id.Text = Convert.ToString(ComboBox1.SelectedValue.ToString());
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
                if (TextBox_product_id.Text == string.Empty || TextBox_amount.Text == string.Empty)
                {
                    val.empty_text(TextBox_product_id);
                    val.empty_text(TextBox_amount);
                    MessageBox.Show("Estos Campos no pueden estar vacios");
                }
                else if (Validate_product_invoice_detail(Program.Values.invoice_id, int.Parse(TextBox_product_id.Text)) == true)
                {
                    Clear_textboxes();
                    MessageBox.Show("Este producto ya esta registrado en esta facturs\nVerifique en detalle o historial");
                }
                else if (Stock_() < int.Parse(TextBox_amount.Text)) 
                {
                    Clear_textboxes();
                    MessageBox.Show("Stock Insuficiente para esta compra");
                }
                else if (invoices_detail.Create(Program.Values.invoice_id, int.Parse(TextBox_product_id.Text), int.Parse(TextBox_amount.Text)))
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
                if (TextBox_product_id.Text == string.Empty || TextBox_amount.Text == string.Empty)
                {
                    val.empty_text(TextBox_product_id);
                    val.empty_text(TextBox_amount);
                    MessageBox.Show("Estos Campos no pueden estar vacios");
                }
                else if (Validate_units(Program.Values.invoice_id,int.Parse(TextBox_product_id.Text),int.Parse(TextBox_amount.Text))<0)
                {
                    Clear_textboxes();
                    MessageBox.Show("Stock Insuficiente para esta compra");
                }
                else if (invoices_detail.Update(Program.Values.invoice_id, int.Parse(TextBox_product_id.Text), int.Parse(TextBox_amount.Text)))
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
                if (TextBox_product_id.Text == string.Empty)
                {
                    val.empty_text(TextBox_product_id);
                    MessageBox.Show("Este campo no pueden estar vacios");
                }
                else if (invoices_detail.Delete(Program.Values.invoice_id, int.Parse(TextBox_product_id.Text)))
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
            val.numbers_only(TextBox_product_id,e);
        }

        private void TextBox_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.decimal_only(TextBox_Precio, e);
        }

        private void TextBox_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.number(TextBox_amount, e);
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
            TextBox_invoice_id.Clear();
            TextBox_product_id.Clear();
            TextBox_Precio.Clear();
            TextBox_amount.Clear();
            TextBox_Sub_Total.Clear();
            TextBox_IVA.Clear();
            TextBox_total.Clear();
            TextBox_invoice_id.Text =Convert.ToString(Program.Values.invoice_id);
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
                    TextBox_product_id.Text = DataGridView_invoice_detail.Rows[e.RowIndex].Cells[1].Value.ToString();
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
        private bool Read_history_by_invoice_id(int invoice_id)
        {
            try
            {
                if (invoice_id == 0)
                {
                    return false;
                }
                else
                {
                    dt = invoices_detail.Read_history_by_id(invoice_id);
                    DataGridView_invoice_detail.DataSource = dt;
                    DataGridView_invoice_detail.Refresh();
                    return true;
                }
            }catch(Exception)
            {
                return false;
            }
        }
        private void Button_history_Click(object sender, EventArgs e)
        {
            try
            {

               if(TextBox_invoice_id.Text==string.Empty)
                {
                    val.empty_text(TextBox_invoice_id);
                    MessageBox.Show("Este campo no puede estar vacio");
                }
               else if (Read_history_by_invoice_id(Program.Values.invoice_id)==true)
                {
                    Button_agregar_producto.Visible = false;
                    Button_create.Visible = false;
                    Button_update.Visible = false;
                    Button_delete.Visible = false;
                    Button_history.Visible = false;
                    Button_Restore.Visible = true;
                    Button_return.Visible = true;
                    ComboBox1.Visible = false;
                    Clear_textboxes();
                    TextBox_search_product_Invoice_d.Visible = false;
                    LabelTotal.Visible = false;
                    Label_Total_Venta.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int Stock;

        private void Button_clear_Click(object sender, EventArgs e)
        {
            Clear_textboxes();
        }

        private void Button_return_Click(object sender, EventArgs e)
        {
            Read_invoice_detail(Program.Values.invoice_id);
            Button_agregar_producto.Visible = true;
            Button_create.Visible = true;
            Button_update.Visible = true;
            Button_delete.Visible = true;
            Button_history.Visible = true;
            Button_Restore.Visible = false;
            Button_return.Visible = false;
            ComboBox1.Visible = true;
            Clear_textboxes();
            TextBox_search_product_Invoice_d.Visible = true;
            Invoice_Detail_total();
            LabelTotal.Visible = true;
            Label_Total_Venta.Visible = true;
        }

        private void Button_Restore_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_invoice_id.Text == string.Empty || TextBox_product_id.Text == string.Empty)
                {
                    val.empty_text(TextBox_invoice_id);
                    val.empty_text(TextBox_product_id);
                    val.empty_text(TextBox_amount);
                    MessageBox.Show("Estos campos no pueden estar vacios");
                }
                else if(Stock_()<0 ||Stock_()<int.Parse(TextBox_amount.Text))
                {
                    MessageBox.Show("Stock insuficiente para restaurar\npara relizar esta restauracion");
                }
                else if (invoices_detail.Restore(Program.Values.invoice_id, int.Parse(TextBox_product_id.Text)))
                {
                    Read_history_by_invoice_id(Program.Values.invoice_id);
                    MessageBox.Show("Restaurado correctamente");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool Validate_product_invoice_detail(int invoice_id, int product_id)
        {
            try
            { 
                if (invoice_id == 0 || product_id == 0)
                {
                    return false;
                }
                else
                {
                    dt=invoices_detail.Validate_Product_invoice_detail_id(invoice_id, product_id);
                    if(dt.Rows.Count>0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }catch(Exception )
            {
                return false;
            }
        }
        private int Stock_()
        {
            try
            {
                if(TextBox_product_id.Text!=string.Empty)
                {
                    dt = invoices_detail.Autocomplete_Product(int.Parse(TextBox_product_id.Text));
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

        private void TextBox_search_product_Invoice_d_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Search_by_letters(TextBox_search_product_Invoice_d, e);
        }

        private void TextBox_search_product_Invoice_d_TextChanged(object sender, EventArgs e)
        {
            DataGridView_invoice_detail.DataSource = invoices_detail.Search_invoice_detail_product(Program.Values.invoice_id, TextBox_search_product_Invoice_d.Text);
        }

        private void Autocomplete_Product()
        {
            try
            {
                if (TextBox_product_id.Text != string.Empty)
                {
                    dt = invoices_detail.Autocomplete_Product(int.Parse(TextBox_product_id.Text));
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
        private int Validate_units(int invoice_id,int product_id, int amount)
        {
            try
            {
                dt = invoices_detail.Validate_units(invoice_id, product_id);
                int total = int.Parse(dt.Rows[0][0].ToString());
                int new_stock;
                if (dt.Rows.Count > 0)
                {
                    if (amount > total)
                    {
                        new_stock = Stock_() - (amount - total);
                        return new_stock;
                    }
                    else
                    {
                        new_stock = Stock_() + (total - amount);
                        return new_stock;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception) { return 0; }
        }
    }
}
