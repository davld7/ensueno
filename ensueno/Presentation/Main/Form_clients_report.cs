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
    public partial class Form_clients_report : Form
    {
        public Form_clients_report()
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
        private void Form_clients_report_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet_ensueno.clients_read' Puede moverla o quitarla según sea necesario.
            this.clients_readTableAdapter.Fill(this.dataSet_ensueno.clients_read);
            this.reportViewer1.RefreshReport();
        }
    }
}
