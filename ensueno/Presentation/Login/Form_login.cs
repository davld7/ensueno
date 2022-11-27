using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ensueno.Presentation.Login
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
            Apply_dark_mode();
            Switch_dark_mode.Checked = Properties.Settings.Default.dark_mode;
            TextBox_user.Select();
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
        private void Button_dark_mode_Click(object sender, EventArgs e)
        {
            Switch_dark_mode.Checked = !Switch_dark_mode.Checked;
            Properties.Settings.Default.dark_mode = Switch_dark_mode.Checked;
            Apply_dark_mode();
        }
        private void Switch_dark_mode_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.dark_mode = Switch_dark_mode.Checked;
            Apply_dark_mode();
        }
        private void Form_login_BackColorChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void Button_database_Click(object sender, EventArgs e)
        {
            Form_database fd = new Form_database();
            fd.ShowDialog();
        }
        private void Form_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

    }
}
