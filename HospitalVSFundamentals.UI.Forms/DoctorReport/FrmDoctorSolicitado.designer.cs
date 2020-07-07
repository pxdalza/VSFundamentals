namespace HospitalVSFundamentals.UI.Forms.doctor
{
    partial class FrmDoctorSolicitado
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
            this.usp_DoctorSolicitadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1DoctorSolicitado = new HospitalVSFundamentals.UI.Forms.doctor.DataSet1DoctorSolicitado();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usp_DoctorSolicitadoTableAdapter = new HospitalVSFundamentals.UI.Forms.doctor.DataSet1DoctorSolicitadoTableAdapters.usp_DoctorSolicitadoTableAdapter();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.uspDoctorSolicitadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usp_DoctorSolicitadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1DoctorSolicitado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspDoctorSolicitadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usp_DoctorSolicitadoBindingSource
            // 
            this.usp_DoctorSolicitadoBindingSource.DataMember = "usp_DoctorSolicitado";
            this.usp_DoctorSolicitadoBindingSource.DataSource = this.DataSet1DoctorSolicitado;
            // 
            // DataSet1DoctorSolicitado
            // 
            this.DataSet1DoctorSolicitado.DataSetName = "DataSet1DoctorSolicitado";
            this.DataSet1DoctorSolicitado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.usp_DoctorSolicitadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HospitalVSFundamentals.UI.Forms.doctor.RptDoctorSolicitado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 101);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 337);
            this.reportViewer1.TabIndex = 0;
            // 
            // usp_DoctorSolicitadoTableAdapter
            // 
            this.usp_DoctorSolicitadoTableAdapter.ClearBeforeFill = true;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(608, 40);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(105, 37);
            this.btnVisualizar.TabIndex = 2;
            this.btnVisualizar.Text = "&Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 23);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(424, 46);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(126, 23);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // uspDoctorSolicitadoBindingSource
            // 
            this.uspDoctorSolicitadoBindingSource.DataMember = "usp_DoctorSolicitado";
            this.uspDoctorSolicitadoBindingSource.DataSource = this.DataSet1DoctorSolicitado;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha Fin:";
            // 
            // FrmDoctorSolicitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmDoctorSolicitado";
            this.Text = "REPORTE DE DOCTOR MAS SOLICITADO";
            this.Load += new System.EventHandler(this.FrmDoctorSolicitado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usp_DoctorSolicitadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1DoctorSolicitado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspDoctorSolicitadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource usp_DoctorSolicitadoBindingSource;
        private DataSet1DoctorSolicitado DataSet1DoctorSolicitado;
        private DataSet1DoctorSolicitadoTableAdapters.usp_DoctorSolicitadoTableAdapter usp_DoctorSolicitadoTableAdapter;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.BindingSource uspDoctorSolicitadoBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}