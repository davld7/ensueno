namespace ensueno.Presentation.Main
{
    partial class Form_employees_report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_employees_report));
            this.employees_readBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_ensueno = new ensueno.Report.DataSet_ensueno();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.employeesreadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employees_readTableAdapter = new ensueno.Report.DataSet_ensuenoTableAdapters.employees_readTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employees_readBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ensueno)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesreadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employees_readBindingSource
            // 
            this.employees_readBindingSource.DataMember = "employees_read";
            this.employees_readBindingSource.DataSource = this.dataSet_ensueno;
            // 
            // dataSet_ensueno
            // 
            this.dataSet_ensueno.DataSetName = "DataSet_ensueno";
            this.dataSet_ensueno.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(850, 30);
            this.guna2Panel1.TabIndex = 35;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Gray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(793, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 7;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet_employees";
            reportDataSource1.Value = this.employees_readBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ensueno.Report.Report_employees.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 35);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(826, 453);
            this.reportViewer1.TabIndex = 36;
            // 
            // employeesreadBindingSource
            // 
            this.employeesreadBindingSource.DataMember = "employees_read";
            this.employeesreadBindingSource.DataSource = this.dataSet_ensueno;
            // 
            // employees_readTableAdapter
            // 
            this.employees_readTableAdapter.ClearBeforeFill = true;
            // 
            // Form_employees_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_employees_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Form_employees_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employees_readBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ensueno)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesreadBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Report.DataSet_ensueno dataSet_ensueno;
        private System.Windows.Forms.BindingSource employeesreadBindingSource;
        private Report.DataSet_ensuenoTableAdapters.employees_readTableAdapter employees_readTableAdapter;
        private System.Windows.Forms.BindingSource employees_readBindingSource;
    }
}