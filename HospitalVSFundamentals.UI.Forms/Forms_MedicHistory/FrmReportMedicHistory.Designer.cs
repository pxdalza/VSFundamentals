namespace HospitalVSFundamentals.UI.Forms.Forms_MedicHistory
{
    partial class FrmReportMedicHistory
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetHistory = new HospitalVSFundamentals.UI.Forms.DataSetHistory();
            this.dataSetHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_HospitalVSFundamentalsDataSet = new HospitalVSFundamentals.UI.Forms.BD_HospitalVSFundamentalsDataSet();
            this.medicHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicHistoryTableAdapter = new HospitalVSFundamentals.UI.Forms.BD_HospitalVSFundamentalsDataSetTableAdapters.MedicHistoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_HospitalVSFundamentalsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.medicHistoryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HospitalVSFundamentals.UI.Forms.ReportHistory.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(769, 695);
            this.reportViewer1.TabIndex = 0;
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
            // bD_HospitalVSFundamentalsDataSet
            // 
            this.bD_HospitalVSFundamentalsDataSet.DataSetName = "BD_HospitalVSFundamentalsDataSet";
            this.bD_HospitalVSFundamentalsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicHistoryBindingSource
            // 
            this.medicHistoryBindingSource.DataMember = "MedicHistory";
            this.medicHistoryBindingSource.DataSource = this.bD_HospitalVSFundamentalsDataSet;
            // 
            // medicHistoryTableAdapter
            // 
            this.medicHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportMedicHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 695);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportMedicHistory";
            this.Text = "FrmReportMedicHistory";
            this.Load += new System.EventHandler(this.FrmReportMedicHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_HospitalVSFundamentalsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetHistoryBindingSource;
        private DataSetHistory dataSetHistory;
        private BD_HospitalVSFundamentalsDataSet bD_HospitalVSFundamentalsDataSet;
        private System.Windows.Forms.BindingSource medicHistoryBindingSource;
        private BD_HospitalVSFundamentalsDataSetTableAdapters.MedicHistoryTableAdapter medicHistoryTableAdapter;
    }
}