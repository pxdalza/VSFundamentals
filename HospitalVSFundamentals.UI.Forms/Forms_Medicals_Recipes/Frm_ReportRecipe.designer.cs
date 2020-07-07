namespace HospitalVSFundamentals.UI.Forms.Forms_Medicals_Recipes
{
    partial class Frm_ReportRecipe
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Recipe_DetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RecipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Pacientes = new HospitalVSFundamentals.UI.Forms.Forms_Medicals_Recipes.Pacientes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new HospitalVSFundamentals.UI.Forms.Forms_Medicals_Recipes.PacientesTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Recipe_DetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // Recipe_DetailsBindingSource
            // 
            this.Recipe_DetailsBindingSource.DataSource = typeof(HospitalVSFundamentals.UI.Forms.Data.Recipe_Details);
            this.Recipe_DetailsBindingSource.CurrentChanged += new System.EventHandler(this.Recipe_DetailsBindingSource_CurrentChanged);
            // 
            // RecipesBindingSource
            // 
            this.RecipesBindingSource.DataSource = typeof(HospitalVSFundamentals.UI.Forms.Data.Recipes);
            this.RecipesBindingSource.CurrentChanged += new System.EventHandler(this.RecipesBindingSource_CurrentChanged);
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.Pacientes;
            // 
            // Pacientes
            // 
            this.Pacientes.DataSetName = "Pacientes";
            this.Pacientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSRecipeDetails";
            reportDataSource1.Value = this.Recipe_DetailsBindingSource;
            reportDataSource2.Name = "DSRecipeHead";
            reportDataSource2.Value = this.RecipesBindingSource;
            reportDataSource3.Name = "DSPatient";
            reportDataSource3.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HospitalVSFundamentals.UI.Forms.Forms_Medicals_Recipes.InformeDetails.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(804, 575);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // Frm_ReportRecipe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(804, 575);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_ReportRecipe";
            this.Text = "Frm_ReportRecipe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_ReportRecipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Recipe_DetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource Recipe_DetailsBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RecipesBindingSource;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private Pacientes Pacientes;
        private PacientesTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}