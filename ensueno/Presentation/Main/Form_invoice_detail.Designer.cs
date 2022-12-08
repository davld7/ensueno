namespace ensueno.Presentation.Main
{
    partial class Form_invoice_detail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Button_delete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Button_update = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Button_create = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Button_clear = new Guna.UI2.WinForms.Guna2CircleButton();
            this.TextBox_Precio = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_amount = new Guna.UI2.WinForms.Guna2TextBox();
            this.DataGridView_invoice_detail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Button_agregar_producto = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Button_invoice = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TextBox_id_producto = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_total = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_IVA = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label_Employee_Name = new System.Windows.Forms.Label();
            this.Label_client_name = new System.Windows.Forms.Label();
            this.TextBox_Sub_Total = new Guna.UI2.WinForms.Guna2TextBox();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.Label_Total_Venta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_invoice_detail)).BeginInit();
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
            this.Button_delete.Location = new System.Drawing.Point(653, 397);
            this.Button_delete.Name = "Button_delete";
            this.Button_delete.Size = new System.Drawing.Size(185, 35);
            this.Button_delete.TabIndex = 39;
            this.Button_delete.Text = "ELIMINAR";
            this.Button_delete.Click += new System.EventHandler(this.Button_delete_Click);
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
            this.Button_update.Location = new System.Drawing.Point(653, 356);
            this.Button_update.Name = "Button_update";
            this.Button_update.Size = new System.Drawing.Size(185, 35);
            this.Button_update.TabIndex = 38;
            this.Button_update.Text = "ACTUALIZAR";
            this.Button_update.Click += new System.EventHandler(this.Button_update_Click);
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
            this.Button_create.Location = new System.Drawing.Point(653, 315);
            this.Button_create.Name = "Button_create";
            this.Button_create.Size = new System.Drawing.Size(185, 35);
            this.Button_create.TabIndex = 37;
            this.Button_create.Text = "CREAR";
            this.Button_create.Click += new System.EventHandler(this.Button_create_Click);
            // 
            // Button_clear
            // 
            this.Button_clear.Animated = true;
            this.Button_clear.BackColor = System.Drawing.Color.Transparent;
            this.Button_clear.BorderColor = System.Drawing.Color.Crimson;
            this.Button_clear.BorderThickness = 2;
            this.Button_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_clear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Button_clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_clear.ForeColor = System.Drawing.Color.White;
            this.Button_clear.Image = global::ensueno.Properties.Resources.clean;
            this.Button_clear.ImageSize = new System.Drawing.Size(32, 32);
            this.Button_clear.Location = new System.Drawing.Point(510, 28);
            this.Button_clear.Name = "Button_clear";
            this.Button_clear.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Button_clear.Size = new System.Drawing.Size(50, 50);
            this.Button_clear.TabIndex = 36;
            this.Button_clear.UseTransparentBackground = true;
            // 
            // TextBox_Precio
            // 
            this.TextBox_Precio.Animated = true;
            this.TextBox_Precio.BorderColor = System.Drawing.Color.Crimson;
            this.TextBox_Precio.BorderRadius = 11;
            this.TextBox_Precio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Precio.DefaultText = "";
            this.TextBox_Precio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Precio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Precio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Precio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Precio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Precio.Font = new System.Drawing.Font("Britannic Bold", 11.25F);
            this.TextBox_Precio.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_Precio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Precio.Location = new System.Drawing.Point(653, 101);
            this.TextBox_Precio.MaxLength = 50;
            this.TextBox_Precio.Name = "TextBox_Precio";
            this.TextBox_Precio.PasswordChar = '\0';
            this.TextBox_Precio.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_Precio.PlaceholderText = "Precio";
            this.TextBox_Precio.SelectedText = "";
            this.TextBox_Precio.Size = new System.Drawing.Size(185, 25);
            this.TextBox_Precio.TabIndex = 32;
            this.TextBox_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Precio_KeyPress);
            // 
            // TextBox_amount
            // 
            this.TextBox_amount.Animated = true;
            this.TextBox_amount.BorderColor = System.Drawing.Color.Crimson;
            this.TextBox_amount.BorderRadius = 11;
            this.TextBox_amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_amount.DefaultText = "";
            this.TextBox_amount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_amount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_amount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_amount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_amount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_amount.Font = new System.Drawing.Font("Britannic Bold", 11.25F);
            this.TextBox_amount.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_amount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_amount.Location = new System.Drawing.Point(653, 132);
            this.TextBox_amount.MaxLength = 17;
            this.TextBox_amount.Name = "TextBox_amount";
            this.TextBox_amount.PasswordChar = '\0';
            this.TextBox_amount.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_amount.PlaceholderText = "Cantidad";
            this.TextBox_amount.SelectedText = "";
            this.TextBox_amount.Size = new System.Drawing.Size(185, 26);
            this.TextBox_amount.TabIndex = 31;
            this.TextBox_amount.TextChanged += new System.EventHandler(this.TextBox_amount_TextChanged);
            this.TextBox_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_amount_KeyPress);
            // 
            // DataGridView_invoice_detail
            // 
            this.DataGridView_invoice_detail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_invoice_detail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_invoice_detail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_invoice_detail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_invoice_detail.ColumnHeadersHeight = 22;
            this.DataGridView_invoice_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_invoice_detail.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_invoice_detail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.DataGridView_invoice_detail.Location = new System.Drawing.Point(12, 84);
            this.DataGridView_invoice_detail.Name = "DataGridView_invoice_detail";
            this.DataGridView_invoice_detail.ReadOnly = true;
            this.DataGridView_invoice_detail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_invoice_detail.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_invoice_detail.RowHeadersVisible = false;
            this.DataGridView_invoice_detail.Size = new System.Drawing.Size(630, 362);
            this.DataGridView_invoice_detail.TabIndex = 41;
            this.DataGridView_invoice_detail.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;
            this.DataGridView_invoice_detail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.DataGridView_invoice_detail.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_invoice_detail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView_invoice_detail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_invoice_detail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_invoice_detail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_invoice_detail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(184)))));
            this.DataGridView_invoice_detail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.DataGridView_invoice_detail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_invoice_detail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_invoice_detail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_invoice_detail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_invoice_detail.ThemeStyle.HeaderStyle.Height = 22;
            this.DataGridView_invoice_detail.ThemeStyle.ReadOnly = true;
            this.DataGridView_invoice_detail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            this.DataGridView_invoice_detail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_invoice_detail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_invoice_detail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView_invoice_detail.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView_invoice_detail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            this.DataGridView_invoice_detail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridView_invoice_detail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_invoice_detail_CellClick);
            // 
            // ComboBox1
            // 
            this.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ComboBox1.AutoRoundedCorners = true;
            this.ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox1.BorderColor = System.Drawing.Color.Crimson;
            this.ComboBox1.BorderRadius = 17;
            this.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox1.Font = new System.Drawing.Font("Britannic Bold", 11.25F);
            this.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox1.ItemHeight = 30;
            this.ComboBox1.Location = new System.Drawing.Point(582, 28);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(256, 36);
            this.ComboBox1.TabIndex = 42;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Button_agregar_producto
            // 
            this.Button_agregar_producto.Animated = true;
            this.Button_agregar_producto.AutoRoundedCorners = true;
            this.Button_agregar_producto.BorderRadius = 23;
            this.Button_agregar_producto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_agregar_producto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_agregar_producto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_agregar_producto.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_agregar_producto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_agregar_producto.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.Button_agregar_producto.ForeColor = System.Drawing.Color.White;
            this.Button_agregar_producto.IndicateFocus = true;
            this.Button_agregar_producto.Location = new System.Drawing.Point(653, 260);
            this.Button_agregar_producto.Name = "Button_agregar_producto";
            this.Button_agregar_producto.Size = new System.Drawing.Size(190, 49);
            this.Button_agregar_producto.TabIndex = 43;
            this.Button_agregar_producto.Text = "AGREGAR PRODUCTO";
            this.Button_agregar_producto.Click += new System.EventHandler(this.Button_agregar_producto_Click);
            // 
            // Button_invoice
            // 
            this.Button_invoice.Animated = true;
            this.Button_invoice.AutoRoundedCorners = true;
            this.Button_invoice.BorderRadius = 24;
            this.Button_invoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_invoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_invoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_invoice.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_invoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_invoice.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.Button_invoice.ForeColor = System.Drawing.Color.White;
            this.Button_invoice.IndicateFocus = true;
            this.Button_invoice.Location = new System.Drawing.Point(653, 438);
            this.Button_invoice.Name = "Button_invoice";
            this.Button_invoice.Size = new System.Drawing.Size(185, 50);
            this.Button_invoice.TabIndex = 45;
            this.Button_invoice.Text = "MOSTRAR FACTURAS";
            this.Button_invoice.Click += new System.EventHandler(this.Button_invoice_Click);
            // 
            // TextBox_id_producto
            // 
            this.TextBox_id_producto.Animated = true;
            this.TextBox_id_producto.BorderColor = System.Drawing.Color.Crimson;
            this.TextBox_id_producto.BorderRadius = 11;
            this.TextBox_id_producto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_id_producto.DefaultText = "";
            this.TextBox_id_producto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_id_producto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_id_producto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id_producto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id_producto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id_producto.Font = new System.Drawing.Font("Britannic Bold", 11.25F);
            this.TextBox_id_producto.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_id_producto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id_producto.Location = new System.Drawing.Point(653, 70);
            this.TextBox_id_producto.MaxLength = 50;
            this.TextBox_id_producto.Name = "TextBox_id_producto";
            this.TextBox_id_producto.PasswordChar = '\0';
            this.TextBox_id_producto.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_id_producto.PlaceholderText = "Id Producto";
            this.TextBox_id_producto.SelectedText = "";
            this.TextBox_id_producto.Size = new System.Drawing.Size(185, 25);
            this.TextBox_id_producto.TabIndex = 46;
            this.TextBox_id_producto.TextChanged += new System.EventHandler(this.TextBox1_id_producto_TextChanged);
            this.TextBox_id_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_id_producto_KeyPress);
            // 
            // TextBox_total
            // 
            this.TextBox_total.Animated = true;
            this.TextBox_total.BorderColor = System.Drawing.Color.Crimson;
            this.TextBox_total.BorderRadius = 11;
            this.TextBox_total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_total.DefaultText = "";
            this.TextBox_total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_total.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_total.Font = new System.Drawing.Font("Britannic Bold", 11.25F);
            this.TextBox_total.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_total.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_total.Location = new System.Drawing.Point(653, 228);
            this.TextBox_total.MaxLength = 17;
            this.TextBox_total.Name = "TextBox_total";
            this.TextBox_total.PasswordChar = '\0';
            this.TextBox_total.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_total.PlaceholderText = "Total Venta";
            this.TextBox_total.SelectedText = "";
            this.TextBox_total.Size = new System.Drawing.Size(185, 26);
            this.TextBox_total.TabIndex = 48;
            this.TextBox_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_total_KeyPress);
            // 
            // TextBox_IVA
            // 
            this.TextBox_IVA.Animated = true;
            this.TextBox_IVA.BorderColor = System.Drawing.Color.Crimson;
            this.TextBox_IVA.BorderRadius = 11;
            this.TextBox_IVA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_IVA.DefaultText = "";
            this.TextBox_IVA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_IVA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_IVA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_IVA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_IVA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_IVA.Font = new System.Drawing.Font("Britannic Bold", 11.25F);
            this.TextBox_IVA.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_IVA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_IVA.Location = new System.Drawing.Point(653, 196);
            this.TextBox_IVA.MaxLength = 17;
            this.TextBox_IVA.Name = "TextBox_IVA";
            this.TextBox_IVA.PasswordChar = '\0';
            this.TextBox_IVA.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_IVA.PlaceholderText = "IVA";
            this.TextBox_IVA.SelectedText = "";
            this.TextBox_IVA.Size = new System.Drawing.Size(185, 26);
            this.TextBox_IVA.TabIndex = 49;
            this.TextBox_IVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_IVA_KeyPress);
            // 
            // Label_Employee_Name
            // 
            this.Label_Employee_Name.AutoSize = true;
            this.Label_Employee_Name.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Employee_Name.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Label_Employee_Name.Location = new System.Drawing.Point(34, 28);
            this.Label_Employee_Name.Name = "Label_Employee_Name";
            this.Label_Employee_Name.Size = new System.Drawing.Size(119, 16);
            this.Label_Employee_Name.TabIndex = 50;
            this.Label_Employee_Name.Text = "Nombre Empleado";
            // 
            // Label_client_name
            // 
            this.Label_client_name.AutoSize = true;
            this.Label_client_name.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_client_name.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Label_client_name.Location = new System.Drawing.Point(236, 28);
            this.Label_client_name.Name = "Label_client_name";
            this.Label_client_name.Size = new System.Drawing.Size(102, 16);
            this.Label_client_name.TabIndex = 51;
            this.Label_client_name.Text = "Nombre Cliente";
            // 
            // TextBox_Sub_Total
            // 
            this.TextBox_Sub_Total.Animated = true;
            this.TextBox_Sub_Total.BorderColor = System.Drawing.Color.Crimson;
            this.TextBox_Sub_Total.BorderRadius = 11;
            this.TextBox_Sub_Total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Sub_Total.DefaultText = "";
            this.TextBox_Sub_Total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Sub_Total.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Sub_Total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Sub_Total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Sub_Total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Sub_Total.Font = new System.Drawing.Font("Britannic Bold", 11.25F);
            this.TextBox_Sub_Total.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_Sub_Total.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Sub_Total.Location = new System.Drawing.Point(653, 164);
            this.TextBox_Sub_Total.MaxLength = 17;
            this.TextBox_Sub_Total.Name = "TextBox_Sub_Total";
            this.TextBox_Sub_Total.PasswordChar = '\0';
            this.TextBox_Sub_Total.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_Sub_Total.PlaceholderText = "Sub Total";
            this.TextBox_Sub_Total.SelectedText = "";
            this.TextBox_Sub_Total.Size = new System.Drawing.Size(185, 26);
            this.TextBox_Sub_Total.TabIndex = 52;
            this.TextBox_Sub_Total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Sub_Total_KeyPress);
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LabelTotal.Location = new System.Drawing.Point(24, 462);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(92, 17);
            this.LabelTotal.TabIndex = 53;
            this.LabelTotal.Text = "Total :    C$";
            // 
            // Label_Total_Venta
            // 
            this.Label_Total_Venta.AutoSize = true;
            this.Label_Total_Venta.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Total_Venta.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Label_Total_Venta.Location = new System.Drawing.Point(110, 462);
            this.Label_Total_Venta.Name = "Label_Total_Venta";
            this.Label_Total_Venta.Size = new System.Drawing.Size(42, 17);
            this.Label_Total_Venta.TabIndex = 54;
            this.Label_Total_Venta.Text = "Total";
            // 
            // Form_invoice_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.Label_Total_Venta);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.TextBox_Sub_Total);
            this.Controls.Add(this.Label_client_name);
            this.Controls.Add(this.Label_Employee_Name);
            this.Controls.Add(this.TextBox_IVA);
            this.Controls.Add(this.TextBox_total);
            this.Controls.Add(this.TextBox_id_producto);
            this.Controls.Add(this.Button_invoice);
            this.Controls.Add(this.Button_agregar_producto);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.DataGridView_invoice_detail);
            this.Controls.Add(this.Button_delete);
            this.Controls.Add(this.Button_update);
            this.Controls.Add(this.Button_create);
            this.Controls.Add(this.Button_clear);
            this.Controls.Add(this.TextBox_Precio);
            this.Controls.Add(this.TextBox_amount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_invoice_detail";
            this.Text = "Form_invoice_detail";
            this.Load += new System.EventHandler(this.Form_invoice_detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_invoice_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientButton Button_delete;
        private Guna.UI2.WinForms.Guna2GradientButton Button_update;
        private Guna.UI2.WinForms.Guna2GradientButton Button_create;
        private Guna.UI2.WinForms.Guna2CircleButton Button_clear;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Precio;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_amount;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_invoice_detail;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox1;
        private Guna.UI2.WinForms.Guna2GradientButton Button_agregar_producto;
        private Guna.UI2.WinForms.Guna2GradientButton Button_invoice;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id_producto;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_IVA;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_total;
        private System.Windows.Forms.Label Label_client_name;
        private System.Windows.Forms.Label Label_Employee_Name;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Sub_Total;
        private System.Windows.Forms.Label Label_Total_Venta;
        private System.Windows.Forms.Label LabelTotal;
    }
}