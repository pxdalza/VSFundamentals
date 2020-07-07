namespace HospitalVSFundamentals.UI.Forms.doctor
{
    partial class FrmGraficoCita1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.DataSet1DoctorSolicitado = new HospitalVSFundamentals.UI.Forms.doctor.DataSet1DoctorSolicitado();
            this.usp_DoctorSolicitadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_DoctorSolicitadoTableAdapter = new HospitalVSFundamentals.UI.Forms.doctor.DataSet1DoctorSolicitadoTableAdapters.usp_DoctorSolicitadoTableAdapter();
            this.dataSet1DoctorSolicitadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1DoctorSolicitado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usp_DoctorSolicitadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1DoctorSolicitadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha Fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha Inicio:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(429, 43);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(126, 23);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 23);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(613, 37);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(105, 37);
            this.btnVisualizar.TabIndex = 7;
            this.btnVisualizar.Text = "&Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // DataSet1DoctorSolicitado
            // 
            this.DataSet1DoctorSolicitado.DataSetName = "DataSet1DoctorSolicitado";
            this.DataSet1DoctorSolicitado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usp_DoctorSolicitadoBindingSource
            // 
            this.usp_DoctorSolicitadoBindingSource.DataMember = "usp_DoctorSolicitado";
            this.usp_DoctorSolicitadoBindingSource.DataSource = this.DataSet1DoctorSolicitado;
            // 
            // usp_DoctorSolicitadoTableAdapter
            // 
            this.usp_DoctorSolicitadoTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1DoctorSolicitadoBindingSource
            // 
            this.dataSet1DoctorSolicitadoBindingSource.DataSource = this.DataSet1DoctorSolicitado;
            this.dataSet1DoctorSolicitadoBindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HospitalVSFundamentals.UI.Forms.doctor.RptGraficoCitasProgramadas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(28, 105);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(732, 246);
            this.reportViewer1.TabIndex = 12;
            // 
            // FrmGraficoCita1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnVisualizar);
            this.Name = "FrmGraficoCita1";
            this.Text = "FrmGraficoCita1";
            this.Load += new System.EventHandler(this.FrmGraficoCita1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1DoctorSolicitado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usp_DoctorSolicitadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1DoctorSolicitadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.BindingSource usp_DoctorSolicitadoBindingSource;
        private DataSet1DoctorSolicitado DataSet1DoctorSolicitado;
        private DataSet1DoctorSolicitadoTableAdapters.usp_DoctorSolicitadoTableAdapter usp_DoctorSolicitadoTableAdapter;
        private System.Windows.Forms.BindingSource dataSet1DoctorSolicitadoBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}