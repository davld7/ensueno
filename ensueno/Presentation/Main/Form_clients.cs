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
    public partial class Form_clients : Form
    {
        private readonly Clients clients = new Clients();
        private Form_clients_history fh;
        public Form_clients()
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

        private void Form_clients_Load(object sender, EventArgs e)
        {
            Read();
            TextBox_id.Enabled = false;
            Button_update.Enabled = false;
            Button_delete.Enabled = false;
            TextBox_read_by_name.Select();
        }
        private void Read()
        {
            DataGridView_clients.DataSource = clients.Read();
        }
        private void Clear_textboxes()
        {
            TextBox_id.Text = "";
            TextBox_id_card.Clear();
            TextBox_name.Clear();
            TextBox_last_name.Clear();
            TextBox_phone.Clear();
            TextBox_address.Clear();
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            Clear_textboxes();
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

        private void Button_create_Click(object sender, EventArgs e)
        {
            try
            {
                //validar si la cédula existe en empleados.
                DataTable employees_validate_id_card = clients.Employees_validate_id_card(TextBox_id_card.Text);
                //validar si la cédula existe en clientes.
                DataTable clients_validate_id_card = clients.Validate_id_card(TextBox_id_card.Text);
                if (employees_validate_id_card.Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe la cédula en empleados.");
                    Clear_textboxes();
                }
                else if (clients_validate_id_card.Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe la cédula en clientes.");
                    Clear_textboxes();
                }
                else if (clients.Create(TextBox_id_card.Text, TextBox_name.Text, TextBox_last_name.Text, TextBox_phone.Text, TextBox_address.Text))
                {
                    MessageBox.Show("Se ha creado el registro del cliente.");
                    Clear_textboxes();
                    Read();
                }
                else
                {
                    MessageBox.Show("No se ha creado el registro del cliente.");
                    Clear_textboxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView_clients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataGridView_clients.Rows[e.RowIndex].Cells[0].Value.ToString() == string.Empty)
                {
                    Clear_textboxes();
                    MessageBox.Show("Elija una fila válida.");
                }
                else
                {
                    TextBox_id.Text = DataGridView_clients.Rows[e.RowIndex].Cells[0].Value.ToString();
                    TextBox_id_card.Text = DataGridView_clients.Rows[e.RowIndex].Cells[1].Value.ToString();
                    TextBox_name.Text = DataGridView_clients.Rows[e.RowIndex].Cells[2].Value.ToString();
                    TextBox_last_name.Text = DataGridView_clients.Rows[e.RowIndex].Cells[3].Value.ToString();
                    TextBox_phone.Text = DataGridView_clients.Rows[e.RowIndex].Cells[4].Value.ToString();
                    TextBox_address.Text = DataGridView_clients.Rows[e.RowIndex].Cells[5].Value.ToString();                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBox_read_by_name_TextChanged(object sender, EventArgs e)
        {
            DataGridView_clients.DataSource = clients.Read_by_name(TextBox_read_by_name.Text);
        }

        private void TextBox_read_by_last_name_TextChanged(object sender, EventArgs e)
        {
            DataGridView_clients.DataSource = clients.Read_by_last_name(TextBox_read_by_last_name.Text);
        }

        private void Button_update_Click(object sender, EventArgs e)
        {
            try
            {
                //validar si la cédula existe en empleados.
                DataTable employees_validate_id_card = clients.Employees_validate_id_card(TextBox_id_card.Text);
                //validar si existe en clientes y si es el mismo cliente, así poder actualizar.
                DataTable validate_update_id_card = clients.Validate_update_id_card(int.Parse(TextBox_id.Text), TextBox_id_card.Text);
                if (employees_validate_id_card.Rows.Count > 0)
                {
                    MessageBox.Show("Ya existe la cédula en empleados.");
                    Clear_textboxes();
                }
                else if (validate_update_id_card.Rows.Count > 0 && clients.Update(int.Parse(TextBox_id.Text), TextBox_id_card.Text, TextBox_name.Text, TextBox_last_name.Text, TextBox_phone.Text, TextBox_address.Text))
                {
                    MessageBox.Show("Se ha actualizado el registro del cliente.");
                    Clear_textboxes();
                    Read();
                }
                else if (clients.Update(int.Parse(TextBox_id.Text), TextBox_id_card.Text, TextBox_name.Text, TextBox_last_name.Text, TextBox_phone.Text, TextBox_address.Text))
                {
                    MessageBox.Show("Se ha actualizado el registro del cliente.");
                    Clear_textboxes();
                    Read();
                }
                else
                {
                    MessageBox.Show("No se ha actualizado el registro del cliente.");
                    Clear_textboxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (clients.Delete(int.Parse(TextBox_id.Text)))
                {
                    MessageBox.Show("Se ha borrado el registro del cliente.");
                    Clear_textboxes();
                    Read();
                }
                else
                {
                    MessageBox.Show("No se ha borrado el registro del cliente.");
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
            fh = new Form_clients_history();
            fh.ShowDialog();
            Read();
        }
    }
}
