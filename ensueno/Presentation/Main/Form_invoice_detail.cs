﻿using System;
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
    public partial class Form_invoice_detail : Form
    {
        private Form_invoice_create fic;
        private Form_invoice fi;
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
    }
}
