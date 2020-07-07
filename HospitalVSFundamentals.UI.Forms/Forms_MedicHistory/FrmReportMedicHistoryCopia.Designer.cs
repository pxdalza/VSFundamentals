namespace HospitalVSFundamentals.UI.Forms.Forms_MedicHistory
{
    partial class FrmReportMedicHistoryCopia
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
            this.uspReporteMedicHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_HospitalVSFundamentalsDataSet = new HospitalVSFundamentals.UI.Forms.BD_HospitalVSFundamentalsDataSet();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataSetHistory = new HospitalVSFundamentals.UI.Forms.DataSetHistory();
            this.dataSetHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicHistoryTableAdapter = new HospitalVSFundamentals.UI.Forms.BD_HospitalVSFundamentalsDataSetTableAdapters.MedicHistoryTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSet1Final = new HospitalVSFundamentals.UI.Forms.DataSet1Final();
            this.dataSet1FinalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new HospitalVSFundamentals.UI.Forms.DataSet1FinalTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uspReporteMedicHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_HospitalVSFundamentalsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1Final)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1FinalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // uspReporteMedicHistoryBindingSource
            // 
            this.uspReporteMedicHistoryBindingSource.DataMember = "usp_ReporteMedicHistory";
            // 
            // medicHistoryBindingSource
            // 
            this.medicHistoryBindingSource.DataMember = "MedicHistory";
            this.medicHistoryBindingSource.DataSource = this.bD_HospitalVSFundamentalsDataSet;
            // 
            // bD_HospitalVSFundamentalsDataSet
            // 
            this.bD_HospitalVSFundamentalsDataSet.DataSetName = "BD_HospitalVSFundamentalsDataSet";
            this.bD_HospitalVSFundamentalsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dataSetHistory
            // 
            this.dataSetHistory.DataSetName = "DataSetHistory";
            this.dataSetHistory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetHistoryBindingSource
            // 
            this.dataSetHistoryBindingSource.DataSource = this.dataSetHistory;
            this.dataSetHistoryBindingSource.Position = 0;
            // 
            // medicHistoryTableAdapter
            // 
            this.medicHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataSet1Final
            // 
            this.dataSet1Final.DataSetName = "DataSet1Final";
            this.dataSet1Final.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1FinalBindingSource
            // 
            this.dataSet1FinalBindingSource.DataSource = this.dataSet1Final;
            this.dataSet1FinalBindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable1BindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HospitalVSFundamentals.UI.Forms.ReportPrincipal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(58, 101);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(537, 270);
            this.reportViewer1.TabIndex = 3;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.dataSet1Final;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.dataSet1FinalBindingSource;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportMedicHistoryCopia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 695);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmReportMedicHistoryCopia";
            this.Text = "FrmReportMedicHistoryCopia";
            this.Load += new System.EventHandler(this.FrmReportMedicHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uspReporteMedicHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_HospitalVSFundamentalsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1Final)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1FinalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.BindingSource dataSetHistoryBindingSource;
        private DataSetHistory dataSetHistory;
        private BD_HospitalVSFundamentalsDataSet bD_HospitalVSFundamentalsDataSet;
        private System.Windows.Forms.BindingSource medicHistoryBindingSource;
        private BD_HospitalVSFundamentalsDataSetTableAdapters.MedicHistoryTableAdapter medicHistoryTableAdapter;
        private System.Windows.Forms.BindingSource uspReporteMedicHistoryBindingSource;
  //      private BD_HospitalVSFundamentalsDataSet3 bD_HospitalVSFundamentalsDataSet3;
     //   private BD_HospitalVSFundamentalsDataSet3TableAdapters.usp_ReporteMedicHistoryTableAdapter usp_ReporteMedicHistoryTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dataSet1FinalBindingSource;
        private DataSet1Final dataSet1Final;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private DataSet1FinalTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    }
}