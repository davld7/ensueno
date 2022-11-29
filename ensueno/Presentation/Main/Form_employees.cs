using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ensueno.Sql.Stored_procedures;

namespace ensueno.Presentation.Main
{
    public partial class Form_employees : Form
    {
        private Employees employees;
        public Form_employees()
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
        private void Read()
        {
            employees = new Employees();
            DataGridView_employees.DataSource = employees.Read();
        }

        private void Form_employees_Load(object sender, EventArgs e)
        {
            Read();
            TextBox_id.Enabled = false;
            TextBox_search_name.Select();
        }

        private void Button_create_Click(object sender, EventArgs e)
        {
            employees = new Employees();
            if(employees.Create(TextBox_id_card.Text, TextBox_name.Text, TextBox_last_name.Text, TextBox_phone.Text, TextBox_address.Text, TextBox_user.Text, TextBox_password.Text, CheckBox_admin.Checked))
            {
                MessageBox.Show("Se ha creado el registro del empleado.");
                Clear_textboxes();
                Read();
            }
            else
            {
                MessageBox.Show("No se ha creado el registro del empleado.");
            }
        }


        private void Clear_textboxes()
        {
            TextBox_id.Text="";
            TextBox_id_card.Clear();
            TextBox_name.Clear();
            TextBox_last_name.Clear();
            TextBox_phone.Clear();
            TextBox_address.Clear();
            TextBox_user.Clear();
            TextBox_password.Clear();
            CheckBox_admin.Checked = false;
        }

        private void DataGridView_employees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataGridView_employees.Rows[e.RowIndex].Cells[0].Value.ToString() == string.Empty)
                {
                    Clear_textboxes();
                    MessageBox.Show("Elija una fila válida.");
                }
                else
                {
                    TextBox_id.Text = DataGridView_employees.Rows[e.RowIndex].Cells[0].Value.ToString();
                    TextBox_id_card.Text = DataGridView_employees.Rows[e.RowIndex].Cells[1].Value.ToString();
                    TextBox_name.Text = DataGridView_employees.Rows[e.RowIndex].Cells[2].Value.ToString();
                    TextBox_last_name.Text = DataGridView_employees.Rows[e.RowIndex].Cells[3].Value.ToString();
                    TextBox_phone.Text = DataGridView_employees.Rows[e.RowIndex].Cells[4].Value.ToString();
                    TextBox_address.Text = DataGridView_employees.Rows[e.RowIndex].Cells[5].Value.ToString();
                    TextBox_user.Text = DataGridView_employees.Rows[e.RowIndex].Cells[6].Value.ToString();
                    CheckBox_admin.Checked = bool.Parse(DataGridView_employees.Rows[e.RowIndex].Cells[7].Value.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
