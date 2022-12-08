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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_invoice_detail));
            this.Button_delete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Button_update = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Button_create = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Button_clear = new Guna.UI2.WinForms.Guna2CircleButton();
            this.TextBox_Precio = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_amount = new Guna.UI2.WinForms.Guna2TextBox();
            this.DataGridView_invoice_detail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Button_agregar_producto = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TextBox_product_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_total = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_IVA = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label_Employee_Name = new System.Windows.Forms.Label();
            this.Label_client_name = new System.Windows.Forms.Label();
            this.TextBox_Sub_Total = new Guna.UI2.WinForms.Guna2TextBox();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.Label_Total_Venta = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Button_history = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TextBox_invoice_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.Button_Restore = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Button_return = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_invoice_detail)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_delete
            // 
            this.Button_delete.Animated = true;
            this.Button_delete.AutoRoundedCorners = true;
            this.Button_delete.BorderRadius = 14;
            this.Button_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_delete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_delete.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.Button_delete.ForeColor = System.Drawing.Color.White;
            this.Button_delete.IndicateFocus = true;
            this.Button_delete.Location = new System.Drawing.Point(653, 419);
            this.Button_delete.Name = "Button_delete";
            this.Button_delete.Size = new System.Drawing.Size(185, 30);
            this.Button_delete.TabIndex = 39;
            this.Button_delete.Text = "ELIMINAR";
            this.Button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // Button_update
            // 
            this.Button_update.Animated = true;
            this.Button_update.AutoRoundedCorners = true;
            this.Button_update.BorderRadius = 14;
            this.Button_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_update.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_update.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.Button_update.ForeColor = System.Drawing.Color.White;
            this.Button_update.IndicateFocus = true;
            this.Button_update.Location = new System.Drawing.Point(653, 383);
            this.Button_update.Name = "Button_update";
            this.Button_update.Size = new System.Drawing.Size(185, 30);
            this.Button_update.TabIndex = 38;
            this.Button_update.Text = "ACTUALIZAR";
            this.Button_update.Click += new System.EventHandler(this.Button_update_Click);
            // 
            // Button_create
            // 
            this.Button_create.Animated = true;
            this.Button_create.AutoRoundedCorners = true;
            this.Button_create.BorderRadius = 14;
            this.Button_create.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_create.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_create.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_create.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_create.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_create.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_create.ForeColor = System.Drawing.Color.White;
            this.Button_create.IndicateFocus = true;
            this.Button_create.Location = new System.Drawing.Point(653, 347);
            this.Button_create.Name = "Button_create";
            this.Button_create.Size = new System.Drawing.Size(185, 30);
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
            this.Button_clear.Location = new System.Drawing.Point(592, 28);
            this.Button_clear.Name = "Button_clear";
            this.Button_clear.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Button_clear.Size = new System.Drawing.Size(50, 50);
            this.Button_clear.TabIndex = 36;
            this.Button_clear.UseTransparentBackground = true;
            this.Button_clear.Click += new System.EventHandler(this.Button_clear_Click);
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
            this.TextBox_Precio.Location = new System.Drawing.Point(653, 124);
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
            this.TextBox_amount.Location = new System.Drawing.Point(653, 155);
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
            this.DataGridView_invoice_detail.Location = new System.Drawing.Point(12, 93);
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
            this.DataGridView_invoice_detail.Size = new System.Drawing.Size(630, 353);
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
            this.Button_agregar_producto.Location = new System.Drawing.Point(653, 292);
            this.Button_agregar_producto.Name = "Button_agregar_producto";
            this.Button_agregar_producto.Size = new System.Drawing.Size(190, 49);
            this.Button_agregar_producto.TabIndex = 43;
            this.Button_agregar_producto.Text = "AGREGAR PRODUCTO";
            this.Button_agregar_producto.Click += new System.EventHandler(this.Button_agregar_producto_Click);
            // 
            // TextBox_product_id
            // 
            this.TextBox_product_id.Animated = true;
            this.TextBox_product_id.BorderColor = System.Drawing.Color.Crimson;
            this.TextBox_product_id.BorderRadius = 11;
            this.TextBox_product_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_product_id.DefaultText = "";
            this.TextBox_product_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_product_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_product_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_product_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_product_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_product_id.Font = new System.Drawing.Font("Britannic Bold", 11.25F);
            this.TextBox_product_id.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_product_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_product_id.Location = new System.Drawing.Point(653, 93);
            this.TextBox_product_id.MaxLength = 50;
            this.TextBox_product_id.Name = "TextBox_product_id";
            this.TextBox_product_id.PasswordChar = '\0';
            this.TextBox_product_id.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_product_id.PlaceholderText = "Id Producto";
            this.TextBox_product_id.SelectedText = "";
            this.TextBox_product_id.Size = new System.Drawing.Size(185, 25);
            this.TextBox_product_id.TabIndex = 46;
            this.TextBox_product_id.TextChanged += new System.EventHandler(this.TextBox1_id_producto_TextChanged);
            this.TextBox_product_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_id_producto_KeyPress);
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
            this.TextBox_total.Location = new System.Drawing.Point(653, 251);
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
            this.TextBox_IVA.Location = new System.Drawing.Point(653, 219);
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
            this.TextBox_Sub_Total.Location = new System.Drawing.Point(653, 187);
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
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(653, 66);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(185, 21);
            this.ComboBox1.TabIndex = 55;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged_1);
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(850, 25);
            this.guna2Panel1.TabIndex = 56;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Gray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(793, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 22);
            this.guna2ControlBox1.TabIndex = 7;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Button_history
            // 
            this.Button_history.Animated = true;
            this.Button_history.AutoRoundedCorners = true;
            this.Button_history.BorderRadius = 14;
            this.Button_history.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_history.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_history.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_history.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_history.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_history.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.Button_history.ForeColor = System.Drawing.Color.White;
            this.Button_history.IndicateFocus = true;
            this.Button_history.Location = new System.Drawing.Point(653, 455);
            this.Button_history.Name = "Button_history";
            this.Button_history.Size = new System.Drawing.Size(185, 30);
            this.Button_history.TabIndex = 57;
            this.Button_history.Text = "HISTORIAL";
            this.Button_history.Click += new System.EventHandler(this.Button_history_Click);
            // 
            // TextBox_invoice_id
            // 
            this.TextBox_invoice_id.Animated = true;
            this.TextBox_invoice_id.BorderColor = System.Drawing.Color.Crimson;
            this.TextBox_invoice_id.BorderRadius = 11;
            this.TextBox_invoice_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_invoice_id.DefaultText = "";
            this.TextBox_invoice_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_invoice_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_invoice_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_invoice_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_invoice_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_invoice_id.Font = new System.Drawing.Font("Britannic Bold", 11.25F);
            this.TextBox_invoice_id.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_invoice_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_invoice_id.Location = new System.Drawing.Point(653, 35);
            this.TextBox_invoice_id.MaxLength = 50;
            this.TextBox_invoice_id.Name = "TextBox_invoice_id";
            this.TextBox_invoice_id.PasswordChar = '\0';
            this.TextBox_invoice_id.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.TextBox_invoice_id.PlaceholderText = "Id Factura";
            this.TextBox_invoice_id.SelectedText = "";
            this.TextBox_invoice_id.Size = new System.Drawing.Size(185, 25);
            this.TextBox_invoice_id.TabIndex = 58;
            // 
            // Button_Restore
            // 
            this.Button_Restore.Animated = true;
            this.Button_Restore.AutoRoundedCorners = true;
            this.Button_Restore.BorderRadius = 14;
            this.Button_Restore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Restore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Restore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Restore.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Restore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Restore.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.Button_Restore.ForeColor = System.Drawing.Color.White;
            this.Button_Restore.IndicateFocus = true;
            this.Button_Restore.Location = new System.Drawing.Point(457, 455);
            this.Button_Restore.Name = "Button_Restore";
            this.Button_Restore.Size = new System.Drawing.Size(185, 30);
            this.Button_Restore.TabIndex = 59;
            this.Button_Restore.Text = "RESTAURAR";
            this.Button_Restore.Click += new System.EventHandler(this.Button_Restore_Click);
            // 
            // Button_return
            // 
            this.Button_return.Animated = true;
            this.Button_return.AutoRoundedCorners = true;
            this.Button_return.BorderRadius = 14;
            this.Button_return.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_return.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_return.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_return.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_return.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_return.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.Button_return.ForeColor = System.Drawing.Color.White;
            this.Button_return.IndicateFocus = true;
            this.Button_return.Location = new System.Drawing.Point(23, 56);
            this.Button_return.Name = "Button_return";
            this.Button_return.Size = new System.Drawing.Size(142, 30);
            this.Button_return.TabIndex = 60;
            this.Button_return.Text = "REGRESAR";
            this.Button_return.Click += new System.EventHandler(this.Button_return_Click);
            // 
            // Form_invoice_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.Button_return);
            this.Controls.Add(this.Button_Restore);
            this.Controls.Add(this.TextBox_invoice_id);
            this.Controls.Add(this.Button_history);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Label_Total_Venta);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.TextBox_Sub_Total);
            this.Controls.Add(this.Label_client_name);
            this.Controls.Add(this.Label_Employee_Name);
            this.Controls.Add(this.TextBox_IVA);
            this.Controls.Add(this.TextBox_total);
            this.Controls.Add(this.TextBox_product_id);
            this.Controls.Add(this.Button_agregar_producto);
            this.Controls.Add(this.DataGridView_invoice_detail);
            this.Controls.Add(this.Button_delete);
            this.Controls.Add(this.Button_update);
            this.Controls.Add(this.Button_create);
            this.Controls.Add(this.Button_clear);
            this.Controls.Add(this.TextBox_Precio);
            this.Controls.Add(this.TextBox_amount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_invoice_detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Detail";
            this.Load += new System.EventHandler(this.Form_invoice_detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_invoice_detail)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton Button_delete;
        private Guna.UI2.WinForms.Guna2GradientButton Button_update;
        private Guna.UI2.WinForms.Guna2GradientButton Button_create;
        private Guna.UI2.WinForms.Guna2CircleButton Button_clear;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Precio;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_amount;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_invoice_detail;
        private Guna.UI2.WinForms.Guna2GradientButton Button_agregar_producto;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_product_id;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_IVA;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_total;
        private System.Windows.Forms.Label Label_client_name;
        private System.Windows.Forms.Label Label_Employee_Name;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Sub_Total;
        private System.Windows.Forms.Label Label_Total_Venta;
        private System.Windows.Forms.Label LabelTotal;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ComboBox ComboBox1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2GradientButton Button_history;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_invoice_id;
        private Guna.UI2.WinForms.Guna2GradientButton Button_return;
        private Guna.UI2.WinForms.Guna2GradientButton Button_Restore;
    }
}