namespace HospitalVSFundamentals.UI.Forms
{
    partial class FMain
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
            this.gbPanel = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnusers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.gbPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPanel
            // 
            this.gbPanel.BackColor = System.Drawing.Color.Transparent;
            this.gbPanel.Controls.Add(this.button3);
            this.gbPanel.Controls.Add(this.button2);
            this.gbPanel.Controls.Add(this.btnusers);
            this.gbPanel.Location = new System.Drawing.Point(27, 23);
            this.gbPanel.Name = "gbPanel";
            this.gbPanel.Size = new System.Drawing.Size(479, 643);
            this.gbPanel.TabIndex = 0;
            this.gbPanel.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(344, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 136);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 136);
            this.button2.TabIndex = 4;
            this.button2.Text = "Gestion de especialidades";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnusers
            // 
            this.btnusers.Image = global::HospitalVSFundamentals.UI.Forms.Properties.Resources.icon_user_24px;
            this.btnusers.Location = new System.Drawing.Point(29, 42);
            this.btnusers.Name = "btnusers";
            this.btnusers.Size = new System.Drawing.Size(100, 136);
            this.btnusers.TabIndex = 3;
            this.btnusers.Text = "Gestion Usuarios";
            this.btnusers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnusers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnusers.UseVisualStyleBackColor = true;
            this.btnusers.Click += new System.EventHandler(this.btnusers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalVSFundamentals.UI.Forms.Properties.Resources.icon_user;
            this.pictureBox1.Location = new System.Drawing.Point(859, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(583, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido";
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(610, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(231, 23);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Carlos Andrade";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.BackColor = System.Drawing.Color.Transparent;
            this.lblDNI.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(610, 100);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(231, 23);
            this.lblDNI.TabIndex = 4;
            this.lblDNI.Text = "DNI: 77729838";
            // 
            // lblRol
            // 
            this.lblRol.BackColor = System.Drawing.Color.Transparent;
            this.lblRol.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(657, 129);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(184, 23);
            this.lblRol.TabIndex = 5;
            this.lblRol.Text = "Rol: ADM";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HospitalVSFundamentals.UI.Forms.Properties.Resources.back_main;
            this.ClientSize = new System.Drawing.Size(999, 688);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbPanel);
            this.Name = "FMain";
            this.Text = "FMain";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.gbPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnusers;
    }
}