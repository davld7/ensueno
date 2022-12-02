using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ensueno.Sql.Stored_procedures;
using System.Data.SqlClient;

namespace ensueno.Presentation.Main
{
    public partial class Form_products : Form
    {
        private string image_location;
        private byte[] image;
        private readonly Products products = new Products();
        private MemoryStream memory_stream;
        private Form_products_history fh;
        public Form_products()
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

        private void Button_add_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog file_dialog = new OpenFileDialog
            {
                Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*"
            };
            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                image_location = file_dialog.FileName.ToString();
                PictureBox_product.ImageLocation = image_location;
            }
        }

        private void Button_create_Click(object sender, EventArgs e)
        {
            try
            {                
                //Convertir imagen a byte[].
                FileStream file_stream = new FileStream(image_location, FileMode.Open, FileAccess.Read);
                BinaryReader bynary_reader = new BinaryReader(file_stream);
                image = bynary_reader.ReadBytes((int)file_stream.Length);
                //validar si el nombre existe en productos.
                DataTable products_validate_name = products.Validate_name(TextBox_name.Text);
                if (products_validate_name.Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe el nombre en productos.");
                    Clear_textboxes();
                }                
                else if(products.Create(TextBox_name.Text, int.Parse(TextBox_stock.Text), decimal.Parse(TextBox_unit_price.Text), image))
                {
                    MessageBox.Show("Se ha creado el registro del producto.");
                    Clear_textboxes();
                    Read();
                }
                else
                {
                    MessageBox.Show("No se ha creado el registro del producto.");
                    Clear_textboxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Agregue una imagen.");
                MessageBox.Show(ex.Message);                
            }
        }
        private void Clear_textboxes()
        {
            TextBox_id.Text = "";
            TextBox_name.Clear();
            TextBox_stock.Clear();
            TextBox_unit_price.Clear();
            PictureBox_product.Image = null;
        }
        private void Button_clear_Click(object sender, EventArgs e)
        {
            Clear_textboxes();
        }
        private void Form_products_Load(object sender, EventArgs e)
        {
            Read();
            TextBox_id.Enabled = false;
            Button_update.Enabled = false;
            Button_delete.Enabled = false;
            PictureBox_product.Image = null;
            TextBox_read_by_name.Select();
        }
        private void Read()
        {
            DataGridView_products.DataSource = products.Read();
        }

        private void DataGridView_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataGridView_products.Rows[e.RowIndex].Cells[0].Value.ToString() == string.Empty)
                {
                    Clear_textboxes();
                    MessageBox.Show("Elija una fila válida.");
                }
                else
                {
                    TextBox_id.Text = DataGridView_products.Rows[e.RowIndex].Cells[0].Value.ToString();                   
                    TextBox_name.Text = DataGridView_products.Rows[e.RowIndex].Cells[1].Value.ToString();
                    TextBox_stock.Text = DataGridView_products.Rows[e.RowIndex].Cells[2].Value.ToString();
                    TextBox_unit_price.Text = DataGridView_products.Rows[e.RowIndex].Cells[3].Value.ToString();
                    Read_image();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Read_image()
        {
            image = products.Read_image(int.Parse(TextBox_id.Text));
            memory_stream = new MemoryStream(image);
            PictureBox_product.Image = Image.FromStream(memory_stream);
        }
        private void TextBox_id_TextChanged(object sender, EventArgs e)
        {
            if (TextBox_id.Text != string.Empty)
            {
                Button_create.Enabled = false;
                Button_update.Enabled = true;
                Button_delete.Enabled = true;
            }
            else
            {
                Button_create.Enabled = true;
                Button_update.Enabled = false;
                Button_delete.Enabled = false;
            }
        }

        private void Button_update_Click(object sender, EventArgs e)
        {
            try
            {
                //Convertir imagen a byte[].
                FileStream file_stream = new FileStream(image_location, FileMode.Open, FileAccess.Read);
                BinaryReader bynary_reader = new BinaryReader(file_stream);
                image = bynary_reader.ReadBytes((int)file_stream.Length);
                //validar si el nombre existe en productos y si es el mismo producto, así poder actualizar.
                DataTable validate_update_name = products.Validate_update_name(int.Parse(TextBox_id.Text), TextBox_name.Text);
                if (validate_update_name.Rows.Count > 0 && products.Update(int.Parse(TextBox_id.Text), TextBox_name.Text, int.Parse(TextBox_stock.Text), decimal.Parse(TextBox_unit_price.Text),image))
                {
                    MessageBox.Show("Se ha actualizado el registro del producto.");
                    Clear_textboxes();
                    Read();
                }
                else if (products.Update(int.Parse(TextBox_id.Text), TextBox_name.Text, int.Parse(TextBox_stock.Text), decimal.Parse(TextBox_unit_price.Text), image))
                {
                    MessageBox.Show("Se ha actualizado el registro del producto.");
                    Clear_textboxes();
                    Read();
                }
                else
                {
                    MessageBox.Show("No se ha actualizado el registro del producto.");
                    Clear_textboxes();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Agregue una imagen.");
                MessageBox.Show(ex.Message);
            }

        }

        private void TextBox_read_by_name_TextChanged(object sender, EventArgs e)
        {
            DataGridView_products.DataSource = products.Read_by_name(TextBox_read_by_name.Text);
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (products.Delete(int.Parse(TextBox_id.Text)))
                {
                    MessageBox.Show("Se ha borrado el registro del producto.");
                    Clear_textboxes();
                    Read();
                }
                else
                {
                    MessageBox.Show("No se ha borrado el registro del producto.");
                    Clear_textboxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_history_Click(object sender, EventArgs e)
        {
            fh = new Form_products_history();
            fh.ShowDialog();
            Read();
        }
    }
}
