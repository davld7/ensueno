﻿using ensueno.Sql.Stored_procedures;
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
    public partial class Form_invoice_create : Form
    {
        private Form_invoice_detail fid;

        public Form_invoice_create()
        {
            InitializeComponent();
            Apply_dark_mode();
            this.Select();
            Button_yes.Select();
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

        private void Button_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Button_yes_Click(object sender, EventArgs e)
        {
            try
            {
                Invoices invoices = new Invoices();
                invoices.Create(Program.Values.Employee_id, Program.Values.Client_id);
                MessageBox.Show("Factura Creada Correctamente");
                fid = new Form_invoice_detail();
                fid.ShowDialog();
                this.Close();
            }
            catch(Exception)
            {
            }
        }
    }
}
