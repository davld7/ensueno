﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ensueno.Presentation.Main;
using ensueno.Sql.Stored_procedures;
using ensueno.Sql;

namespace ensueno.Presentation.Login
{
    public partial class Form_login : Form
    {
        private Form_database fd;
        private Form_welcome fw;
        private Form_login_error fl;
        private Form_main fm;
        private Builder builder;
        private Employees employees;
        private DataRow data_row;
        public Form_login()
        {
            InitializeComponent();
            Apply_dark_mode();
            Switch_dark_mode.Checked = Properties.Settings.Default.dark_mode;
            TextBox_user.Select();
        }
        private void Form_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
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
            fd = new Form_database();
            fd.ShowDialog();
        }
        private void Button_login_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            builder = new Builder();
            builder.Build(TextBox_user.Text, TextBox_password.Text);
            employees = new Employees();
            if (employees.Connect())
            {
                data_row = employees.Read_by_user(TextBox_user.Text);
                Clear_textboxes();
                employees.Disconnect();
                string employee_name = data_row.ItemArray[2].ToString();
                string employee_last_name = data_row.ItemArray[3].ToString();
                Show_form_welcome(employee_name, employee_last_name);
                Properties.Settings.Default.admin = bool.Parse(data_row.ItemArray[7].ToString());
                Show_form_main();
            }
            else
            {
                Clear_textboxes();
                fl = new Form_login_error();
                fl.ShowDialog();
            }
        }
        private void Clear_textboxes()
        {
            TextBox_user.Clear();
            TextBox_password.Clear();
        }
        private void Show_form_welcome(string employee_name, string employee_last_name)
        {
            fw = new Form_welcome();
            fw.Welcome(employee_name, employee_last_name);
            fw.ShowDialog();
        }

        private void Show_form_main()
        {
            fm = new Form_main();
            fm.ShowDialog();
        }

    }
}
