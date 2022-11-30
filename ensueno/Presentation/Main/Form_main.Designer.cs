namespace ensueno.Presentation.Main
{
    partial class Form_main
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.Slide_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Separator_slide_panel = new Guna.UI2.WinForms.Guna2Separator();
            this.Button_employees = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Transition_slide_panel = new Guna.UI2.WinForms.Guna2Transition();
            this.Container_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Button_show = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Button_hide = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Label_user_role = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Slide_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // Slide_panel
            // 
            this.Slide_panel.Controls.Add(this.Separator_slide_panel);
            this.Slide_panel.Controls.Add(this.Button_employees);
            this.Transition_slide_panel.SetDecoration(this.Slide_panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Slide_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Slide_panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Slide_panel.Location = new System.Drawing.Point(0, 0);
            this.Slide_panel.Name = "Slide_panel";
            this.Slide_panel.Size = new System.Drawing.Size(50, 570);
            this.Slide_panel.TabIndex = 0;
            // 
            // Separator_slide_panel
            // 
            this.Separator_slide_panel.BackColor = System.Drawing.Color.Transparent;
            this.Transition_slide_panel.SetDecoration(this.Separator_slide_panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Separator_slide_panel.FillColor = System.Drawing.Color.Gray;
            this.Separator_slide_panel.FillThickness = 2;
            this.Separator_slide_panel.Location = new System.Drawing.Point(0, 79);
            this.Separator_slide_panel.Name = "Separator_slide_panel";
            this.Separator_slide_panel.Size = new System.Drawing.Size(175, 10);
            this.Separator_slide_panel.TabIndex = 9;
            // 
            // Button_employees
            // 
            this.Button_employees.Animated = true;
            this.Button_employees.CustomImages.Image = global::ensueno.Properties.Resources.employees;
            this.Button_employees.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button_employees.CustomImages.ImageSize = new System.Drawing.Size(32, 32);
            this.Transition_slide_panel.SetDecoration(this.Button_employees, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Button_employees.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_employees.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_employees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_employees.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_employees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_employees.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.Button_employees.ForeColor = System.Drawing.Color.White;
            this.Button_employees.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Button_employees.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.Button_employees.IndicateFocus = true;
            this.Button_employees.Location = new System.Drawing.Point(0, 29);
            this.Button_employees.Name = "Button_employees";
            this.Button_employees.Size = new System.Drawing.Size(175, 45);
            this.Button_employees.TabIndex = 4;
            this.Button_employees.Text = "EMPLEADOS";
            this.Button_employees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Button_employees.Click += new System.EventHandler(this.Button_employees_Click);
            // 
            // Transition_slide_panel
            // 
            this.Transition_slide_panel.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizBlind;
            this.Transition_slide_panel.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Transition_slide_panel.DefaultAnimation = animation1;
            // 
            // Container_panel
            // 
            this.Container_panel.BackColor = System.Drawing.Color.Transparent;
            this.Transition_slide_panel.SetDecoration(this.Container_panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Container_panel.Location = new System.Drawing.Point(56, 56);
            this.Container_panel.Name = "Container_panel";
            this.Container_panel.Size = new System.Drawing.Size(850, 500);
            this.Container_panel.TabIndex = 11;
            // 
            // Button_show
            // 
            this.Button_show.Animated = true;
            this.Button_show.BackColor = System.Drawing.Color.Transparent;
            this.Transition_slide_panel.SetDecoration(this.Button_show, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Button_show.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_show.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_show.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_show.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_show.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Button_show.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_show.ForeColor = System.Drawing.Color.White;
            this.Button_show.Image = global::ensueno.Properties.Resources.right_arrow;
            this.Button_show.ImageSize = new System.Drawing.Size(48, 48);
            this.Button_show.Location = new System.Drawing.Point(56, 59);
            this.Button_show.Name = "Button_show";
            this.Button_show.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Button_show.Size = new System.Drawing.Size(50, 50);
            this.Button_show.TabIndex = 8;
            this.Button_show.UseTransparentBackground = true;
            this.Button_show.Click += new System.EventHandler(this.Button_show_Click);
            // 
            // Button_hide
            // 
            this.Button_hide.Animated = true;
            this.Button_hide.BackColor = System.Drawing.Color.Transparent;
            this.Transition_slide_panel.SetDecoration(this.Button_hide, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Button_hide.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_hide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_hide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_hide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_hide.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Button_hide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_hide.ForeColor = System.Drawing.Color.White;
            this.Button_hide.Image = global::ensueno.Properties.Resources.left_arrow;
            this.Button_hide.ImageSize = new System.Drawing.Size(48, 48);
            this.Button_hide.Location = new System.Drawing.Point(181, 59);
            this.Button_hide.Name = "Button_hide";
            this.Button_hide.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Button_hide.Size = new System.Drawing.Size(50, 50);
            this.Button_hide.TabIndex = 9;
            this.Button_hide.UseTransparentBackground = true;
            this.Button_hide.Visible = false;
            this.Button_hide.Click += new System.EventHandler(this.Button_hide_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Transition_slide_panel.SetDecoration(this.guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Gray;
            this.guna2ControlBox2.Location = new System.Drawing.Point(809, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 12;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.Transition_slide_panel.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Gray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(860, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 13;
            // 
            // Label_user_role
            // 
            this.Label_user_role.AutoSize = true;
            this.Transition_slide_panel.SetDecoration(this.Label_user_role, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Label_user_role.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_user_role.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Label_user_role.Location = new System.Drawing.Point(267, 8);
            this.Label_user_role.Name = "Label_user_role";
            this.Label_user_role.Size = new System.Drawing.Size(132, 21);
            this.Label_user_role.TabIndex = 14;
            this.Label_user_role.Text = "Rol de usuario";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 570);
            this.Controls.Add(this.Label_user_role);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.Button_hide);
            this.Controls.Add(this.Button_show);
            this.Controls.Add(this.Slide_panel);
            this.Controls.Add(this.Container_panel);
            this.Transition_slide_panel.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_main_FormClosed);
            this.Slide_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel Slide_panel;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2GradientButton Button_employees;
        private Guna.UI2.WinForms.Guna2CircleButton Button_show;
        private Guna.UI2.WinForms.Guna2Separator Separator_slide_panel;
        private Guna.UI2.WinForms.Guna2Transition Transition_slide_panel;
        private Guna.UI2.WinForms.Guna2CircleButton Button_hide;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel Container_panel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label Label_user_role;
    }
}