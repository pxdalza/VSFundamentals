namespace HospitalVSFundamentals.UI.Forms.Form_Main
{
    partial class FMainMdc
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
            this.label1a = new System.Windows.Forms.Label();
            this.btnMedicHistory = new System.Windows.Forms.Button();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReporteDoctor = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1a
            // 
            this.label1a.AutoSize = true;
            this.label1a.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1a.Location = new System.Drawing.Point(57, 20);
            this.label1a.Name = "label1a";
            this.label1a.Size = new System.Drawing.Size(676, 39);
            this.label1a.TabIndex = 0;
            this.label1a.Text = "ESTE ES EL FORMULARIO DE MEDICOS";
            // 
            // btnMedicHistory
            // 
            this.btnMedicHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicHistory.Image = global::HospitalVSFundamentals.UI.Forms.Properties.Resources.historya;
            this.btnMedicHistory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMedicHistory.Location = new System.Drawing.Point(530, 100);
            this.btnMedicHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnMedicHistory.Name = "btnMedicHistory";
            this.btnMedicHistory.Size = new System.Drawing.Size(133, 126);
            this.btnMedicHistory.TabIndex = 7;
            this.btnMedicHistory.Text = "Medic History";
            this.btnMedicHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMedicHistory.UseVisualStyleBackColor = true;
            this.btnMedicHistory.Click += new System.EventHandler(this.btnMedicHistory_Click);
            // 
            // lblRol
            // 
            this.lblRol.BackColor = System.Drawing.Color.Transparent;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(127, 213);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(245, 28);
            this.lblRol.TabIndex = 11;
            // 
            // lblDNI
            // 
            this.lblDNI.BackColor = System.Drawing.Color.Transparent;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(64, 177);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(308, 28);
            this.lblDNI.TabIndex = 10;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(64, 141);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(308, 28);
            this.lblNombre.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 58);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bienvenido";
            // 
            // btnReporteDoctor
            // 
            this.btnReporteDoctor.Location = new System.Drawing.Point(530, 267);
            this.btnReporteDoctor.Name = "btnReporteDoctor";
            this.btnReporteDoctor.Size = new System.Drawing.Size(133, 94);
            this.btnReporteDoctor.TabIndex = 12;
            this.btnReporteDoctor.Text = "Reporte Doctor por Especialidad";
            this.btnReporteDoctor.UseVisualStyleBackColor = true;
            this.btnReporteDoctor.Click += new System.EventHandler(this.btnReporteDoctor_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Location = new System.Drawing.Point(530, 409);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(133, 85);
            this.btnGrafico.TabIndex = 13;
            this.btnGrafico.Text = "Reporte Gráfico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // FMainMdc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 634);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.btnReporteDoctor);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMedicHistory);
            this.Controls.Add(this.label1a);
            this.Name = "FMainMdc";
            this.Text = "FMainMdc";
            this.Load += new System.EventHandler(this.FMainMdc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1a;
        private System.Windows.Forms.Button btnMedicHistory;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReporteDoctor;
        private System.Windows.Forms.Button btnGrafico;
    }
}