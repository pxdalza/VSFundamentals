namespace HospitalVSFundamentals.UI.Forms.Forms_MedicHistory
{
    partial class FrmReporteMedicHIstoryFinal
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet1Final = new HospitalVSFundamentals.UI.Forms.DataSet1Final();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new HospitalVSFundamentals.UI.Forms.DataSet1FinalTableAdapters.DataTable1TableAdapter();
            this.dataSet1FinalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.txtlas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1Final)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1FinalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HospitalVSFundamentals.UI.Forms.ReportPrincipal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 79);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(876, 516);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet1Final
            // 
            this.dataSet1Final.DataSetName = "DataSet1Final";
            this.dataSet1Final.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet1Final;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1FinalBindingSource
            // 
            this.dataSet1FinalBindingSource.DataSource = this.dataSet1Final;
            this.dataSet1FinalBindingSource.Position = 0;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(596, 24);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(105, 49);
            this.btnVisualizar.TabIndex = 1;
            this.btnVisualizar.Text = "&Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // txtlas
            // 
            this.txtlas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlas.Location = new System.Drawing.Point(237, 36);
            this.txtlas.Multiline = true;
            this.txtlas.Name = "txtlas";
            this.txtlas.Size = new System.Drawing.Size(136, 29);
            this.txtlas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresar Apellido:";
            // 
            // FrmReporteMedicHIstoryFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(900, 621);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlas);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteMedicHIstoryFinal";
            this.Text = "ReporHistorias Clinicas";
            this.Load += new System.EventHandler(this.FrmReporteMedicHIstoryFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1Final)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1FinalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSet1Final dataSet1Final;
        private DataSet1FinalTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.BindingSource dataSet1FinalBindingSource;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.TextBox txtlas;
        private System.Windows.Forms.Label label1;
    }
}