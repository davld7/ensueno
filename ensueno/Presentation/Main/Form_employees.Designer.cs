﻿namespace ensueno.Presentation.Main
{
    partial class Form_employees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView_employees = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_id_card = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_last_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_user = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.CheckBox_admin = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Button_create = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Button_update = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Button_delete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TextBox_search_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_search_last_name = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_employees)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(49, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "Empleados";
            // 
            // DataGridView_employees
            // 
            this.DataGridView_employees.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_employees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridView_employees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_employees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridView_employees.ColumnHeadersHeight = 22;
            this.DataGridView_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_employees.DefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridView_employees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.DataGridView_employees.Location = new System.Drawing.Point(13, 83);
            this.DataGridView_employees.Name = "DataGridView_employees";
            this.DataGridView_employees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_employees.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridView_employees.RowHeadersVisible = false;
            this.DataGridView_employees.Size = new System.Drawing.Size(630, 400);
            this.DataGridView_employees.TabIndex = 13;
            this.DataGridView_employees.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;
            this.DataGridView_employees.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.DataGridView_employees.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_employees.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView_employees.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_employees.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_employees.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_employees.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.DataGridView_employees.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.DataGridView_employees.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_employees.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_employees.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_employees.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_employees.ThemeStyle.HeaderStyle.Height = 22;
            this.DataGridView_employees.ThemeStyle.ReadOnly = false;
            this.DataGridView_employees.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            this.DataGridView_employees.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_employees.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_employees.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView_employees.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView_employees.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            this.DataGridView_employees.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // TextBox_id
            // 
            this.TextBox_id.Animated = true;
            this.TextBox_id.BorderColor = System.Drawing.Color.Crimson;
            this.TextBox_id.BorderRadius = 11;
            this.TextBox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_id.DefaultText = "";
            this.TextBox_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.Font = new System.Drawing.Font("Britannic Bold", 11.25F);
            this.TextBox_id.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.Location = new System.Drawing.Point(647, 12);
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.PasswordChar = '\0';
            this.TextBox_id.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_id.PlaceholderText = "ID";
            this.TextBox_id.SelectedText = "";
            this.TextBox_id.Size = new System.Drawing.Size(200, 35);
            this.TextBox_id.TabIndex = 14;
            // 
            // TextBox_id_card
            // 
            this.TextBox_id_card.Animated = true;
            this.TextBox_id_card.BorderColor = System.Drawing.Color.Crimson;
            this.TextBox_id_card.BorderRadius = 11;
            this.TextBox_id_card.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_id_card.DefaultText = "";
            this.TextBox_id_card.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_id_card.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_id_card.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id_card.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id_card.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id_card.Font = new System.Drawing.Font("Britannic Bold", 11.25F);
            this.TextBox_id_card.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_id_card.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id_card.Location = new System.Drawing.Point(647, 53);
            this.TextBox_id_card.Name = "TextBox_id_card";
            this.TextBox_id_card.PasswordChar = '\0';
            this.TextBox_id_card.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_id_card.PlaceholderText = "Cédula";
            this.TextBox_id_card.SelectedText = "";
            this.TextBox_id_card.Size = new System.Drawing.Size(200, 35);
            this.TextBox_id_card.TabIndex = 2;
            // 
            // TextBox_name
            // 
            this.TextBox_name.Animated = true;
            this.TextBox_name.BorderColor = System.Drawing.Color.Crimson;
            this.TextBox_name.BorderRadius = 11;
            this.TextBox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_name.DefaultText = "";
            this.TextBox_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.Font = new System.Drawing.Font("Britannic Bold", 11.25F);
            this.TextBox_name.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.Location = new System.Drawing.Point(647, 94);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.PasswordChar = '\0';
            this.TextBox_name.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_name.PlaceholderText = "Nombre";
            this.TextBox_name.SelectedText = "";
            this.TextBox_name.Size = new System.Drawing.Size(200, 35);
            this.TextBox_name.TabIndex = 3;
            // 
            // TextBox_last_name
            // 
            this.TextBox_last_name.Animated = true;
            this.TextBox_last_name.BorderColor = System.Drawing.Color.Crimson;
            this.TextBox_last_name.BorderRadius = 11;
            this.TextBox_last_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_last_name.DefaultText = "";
            this.TextBox_last_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_last_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_last_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_last_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_last_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_last_name.Font = new System.Drawing.Font("Britannic Bold", 11.25F);
            this.TextBox_last_name.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_last_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_last_name.Location = new System.Drawing.Point(647, 135);
            this.TextBox_last_name.Name = "TextBox_last_name";
            this.TextBox_last_name.PasswordChar = '\0';
            this.TextBox_last_name.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_last_name.PlaceholderText = "Apellido";
            this.TextBox_last_name.SelectedText = "";
            this.TextBox_last_name.Size = new System.Drawing.Size(200, 35);
            this.TextBox_last_name.TabIndex = 4;
            // 
            // TextBox_phone
            // 
            this.TextBox_phone.Animated = true;
            this.TextBox_phone.BorderColor = System.Drawing.Color.Crimson;
            this.TextBox_phone.BorderRadius = 11;
            this.TextBox_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_phone.DefaultText = "";
            this.TextBox_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_phone.Font = new System.Drawing.Font("Britannic Bold", 11.25F);
            this.TextBox_phone.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_phone.Location = new System.Drawing.Point(647, 176);
            this.TextBox_phone.Name = "TextBox_phone";
            this.TextBox_phone.PasswordChar = '\0';
            this.TextBox_phone.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_phone.PlaceholderText = "Teléfono";
            this.TextBox_phone.SelectedText = "";
            this.TextBox_phone.Size = new System.Drawing.Size(200, 35);
            this.TextBox_phone.TabIndex = 5;
            // 
            // TextBox_address
            // 
            this.TextBox_address.Animated = true;
            this.TextBox_address.BorderColor = System.Drawing.Color.Crimson;
            this.TextBox_address.BorderRadius = 11;
            this.TextBox_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_address.DefaultText = "";
            this.TextBox_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_address.Font = new System.Drawing.Font("Britannic Bold", 11.25F);
            this.TextBox_address.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_address.Location = new System.Drawing.Point(647, 217);
            this.TextBox_address.Name = "TextBox_address";
            this.TextBox_address.PasswordChar = '\0';
            this.TextBox_address.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_address.PlaceholderText = "Dirección";
            this.TextBox_address.SelectedText = "";
            this.TextBox_address.Size = new System.Drawing.Size(200, 35);
            this.TextBox_address.TabIndex = 6;
            // 
            // TextBox_user
            // 
            this.TextBox_user.Animated = true;
            this.TextBox_user.BorderColor = System.Drawing.Color.Crimson;
            this.TextBox_user.BorderRadius = 11;
            this.TextBox_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_user.DefaultText = "";
            this.TextBox_user.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_user.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_user.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_user.Font = new System.Drawing.Font("Britannic Bold", 11.25F);
            this.TextBox_user.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_user.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_user.Location = new System.Drawing.Point(647, 258);
            this.TextBox_user.Name = "TextBox_user";
            this.TextBox_user.PasswordChar = '\0';
            this.TextBox_user.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_user.PlaceholderText = "Usuario";
            this.TextBox_user.SelectedText = "";
            this.TextBox_user.Size = new System.Drawing.Size(200, 35);
            this.TextBox_user.TabIndex = 7;
            // 
            // TextBox_password
            // 
            this.TextBox_password.Animated = true;
            this.TextBox_password.BorderColor = System.Drawing.Color.Crimson;
            this.TextBox_password.BorderRadius = 11;
            this.TextBox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_password.DefaultText = "";
            this.TextBox_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_password.Font = new System.Drawing.Font("Britannic Bold", 11.25F);
            this.TextBox_password.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_password.Location = new System.Drawing.Point(647, 299);
            this.TextBox_password.Name = "TextBox_password";
            this.TextBox_password.PasswordChar = '\0';
            this.TextBox_password.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_password.PlaceholderText = "Contraseña";
            this.TextBox_password.SelectedText = "";
            this.TextBox_password.Size = new System.Drawing.Size(200, 35);
            this.TextBox_password.TabIndex = 8;
            // 
            // CheckBox_admin
            // 
            this.CheckBox_admin.AutoSize = true;
            this.CheckBox_admin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBox_admin.CheckedState.BorderRadius = 0;
            this.CheckBox_admin.CheckedState.BorderThickness = 0;
            this.CheckBox_admin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckBox_admin.Font = new System.Drawing.Font("Britannic Bold", 11.25F);
            this.CheckBox_admin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.CheckBox_admin.Location = new System.Drawing.Point(687, 340);
            this.CheckBox_admin.Name = "CheckBox_admin";
            this.CheckBox_admin.Size = new System.Drawing.Size(118, 20);
            this.CheckBox_admin.TabIndex = 9;
            this.CheckBox_admin.Text = "Administrador";
            this.CheckBox_admin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckBox_admin.UncheckedState.BorderRadius = 0;
            this.CheckBox_admin.UncheckedState.BorderThickness = 0;
            this.CheckBox_admin.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // Button_create
            // 
            this.Button_create.Animated = true;
            this.Button_create.AutoRoundedCorners = true;
            this.Button_create.BorderRadius = 16;
            this.Button_create.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_create.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_create.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_create.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_create.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_create.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_create.ForeColor = System.Drawing.Color.White;
            this.Button_create.IndicateFocus = true;
            this.Button_create.Location = new System.Drawing.Point(647, 366);
            this.Button_create.Name = "Button_create";
            this.Button_create.Size = new System.Drawing.Size(200, 35);
            this.Button_create.TabIndex = 10;
            this.Button_create.Text = "CREAR";
            // 
            // Button_update
            // 
            this.Button_update.Animated = true;
            this.Button_update.AutoRoundedCorners = true;
            this.Button_update.BorderRadius = 16;
            this.Button_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_update.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_update.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.Button_update.ForeColor = System.Drawing.Color.White;
            this.Button_update.IndicateFocus = true;
            this.Button_update.Location = new System.Drawing.Point(647, 407);
            this.Button_update.Name = "Button_update";
            this.Button_update.Size = new System.Drawing.Size(200, 35);
            this.Button_update.TabIndex = 11;
            this.Button_update.Text = "ACTUALIZAR";
            // 
            // Button_delete
            // 
            this.Button_delete.Animated = true;
            this.Button_delete.AutoRoundedCorners = true;
            this.Button_delete.BorderRadius = 16;
            this.Button_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_delete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_delete.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.Button_delete.ForeColor = System.Drawing.Color.White;
            this.Button_delete.IndicateFocus = true;
            this.Button_delete.Location = new System.Drawing.Point(647, 448);
            this.Button_delete.Name = "Button_delete";
            this.Button_delete.Size = new System.Drawing.Size(200, 35);
            this.Button_delete.TabIndex = 12;
            this.Button_delete.Text = "ELIMINAR";
            // 
            // TextBox_search_name
            // 
            this.TextBox_search_name.Animated = true;
            this.TextBox_search_name.BorderColor = System.Drawing.Color.Crimson;
            this.TextBox_search_name.BorderRadius = 11;
            this.TextBox_search_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_search_name.DefaultText = "";
            this.TextBox_search_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_search_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_search_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_search_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_search_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_search_name.Font = new System.Drawing.Font("Britannic Bold", 11.25F);
            this.TextBox_search_name.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_search_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_search_name.Location = new System.Drawing.Point(221, 42);
            this.TextBox_search_name.Name = "TextBox_search_name";
            this.TextBox_search_name.PasswordChar = '\0';
            this.TextBox_search_name.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_search_name.PlaceholderText = "Buscar por Nombre";
            this.TextBox_search_name.SelectedText = "";
            this.TextBox_search_name.Size = new System.Drawing.Size(200, 35);
            this.TextBox_search_name.TabIndex = 0;
            // 
            // TextBox_search_last_name
            // 
            this.TextBox_search_last_name.Animated = true;
            this.TextBox_search_last_name.BorderColor = System.Drawing.Color.Crimson;
            this.TextBox_search_last_name.BorderRadius = 11;
            this.TextBox_search_last_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_search_last_name.DefaultText = "";
            this.TextBox_search_last_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_search_last_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_search_last_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_search_last_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_search_last_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_search_last_name.Font = new System.Drawing.Font("Britannic Bold", 11.25F);
            this.TextBox_search_last_name.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_search_last_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_search_last_name.Location = new System.Drawing.Point(427, 42);
            this.TextBox_search_last_name.Name = "TextBox_search_last_name";
            this.TextBox_search_last_name.PasswordChar = '\0';
            this.TextBox_search_last_name.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_search_last_name.PlaceholderText = "Buscar por Apellido";
            this.TextBox_search_last_name.SelectedText = "";
            this.TextBox_search_last_name.Size = new System.Drawing.Size(200, 35);
            this.TextBox_search_last_name.TabIndex = 1;
            // 
            // Form_employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.TextBox_search_last_name);
            this.Controls.Add(this.TextBox_search_name);
            this.Controls.Add(this.Button_delete);
            this.Controls.Add(this.Button_update);
            this.Controls.Add(this.Button_create);
            this.Controls.Add(this.CheckBox_admin);
            this.Controls.Add(this.TextBox_password);
            this.Controls.Add(this.TextBox_user);
            this.Controls.Add(this.TextBox_address);
            this.Controls.Add(this.TextBox_phone);
            this.Controls.Add(this.TextBox_last_name);
            this.Controls.Add(this.TextBox_name);
            this.Controls.Add(this.TextBox_id_card);
            this.Controls.Add(this.TextBox_id);
            this.Controls.Add(this.DataGridView_employees);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_employees";
            this.Text = "Form_employees";
            this.Load += new System.EventHandler(this.Form_employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_employees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_employees;
        private Guna.UI2.WinForms.Guna2CheckBox CheckBox_admin;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_password;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_user;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_address;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_phone;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_last_name;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id_card;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private Guna.UI2.WinForms.Guna2GradientButton Button_delete;
        private Guna.UI2.WinForms.Guna2GradientButton Button_update;
        private Guna.UI2.WinForms.Guna2GradientButton Button_create;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_search_last_name;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_search_name;
    }
}