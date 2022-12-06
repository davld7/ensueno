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
    public partial class Form_invoice : Form
    {
        private Form_invoice_history fh;
        private Form_invoice_report fr;
        public Form_invoice()
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

        private void Button_history_Click(object sender, EventArgs e)
        {
            fh = new Form_invoice_history();
            fh.ShowDialog();
        }

        private void Button_report_Click(object sender, EventArgs e)
        {
            fr = new Form_invoice_report();
            fr.ShowDialog();
        }
    }
}
