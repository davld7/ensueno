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
            TextBox_search_name.Select();
        }
    }
}
