namespace HospitalVSFundamentals.UI.Forms
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.gbPanel = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.llOlvidoContrasenia = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.gbPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPanel
            // 
            this.gbPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gbPanel.BackColor = System.Drawing.Color.Transparent;
            this.gbPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbPanel.Controls.Add(this.label3);
            this.gbPanel.Controls.Add(this.pictureBox1);
            this.gbPanel.Controls.Add(this.llOlvidoContrasenia);
            this.gbPanel.Controls.Add(this.label2);
            this.gbPanel.Controls.Add(this.label1);
            this.gbPanel.Controls.Add(this.btnIngresar);
            this.gbPanel.Controls.Add(this.txtPassword);
            this.gbPanel.Controls.Add(this.txtUsername);
            this.gbPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbPanel.Location = new System.Drawing.Point(204, 81);
            this.gbPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPanel.Name = "gbPanel";
            this.gbPanel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPanel.Size = new System.Drawing.Size(968, 512);
            this.gbPanel.TabIndex = 1;
            this.gbPanel.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(365, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Panel Administrativo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(440, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // llOlvidoContrasenia
            // 
            this.llOlvidoContrasenia.ActiveLinkColor = System.Drawing.Color.Black;
            this.llOlvidoContrasenia.AutoSize = true;
            this.llOlvidoContrasenia.LinkColor = System.Drawing.Color.Black;
            this.llOlvidoContrasenia.Location = new System.Drawing.Point(436, 294);
            this.llOlvidoContrasenia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llOlvidoContrasenia.Name = "llOlvidoContrasenia";
            this.llOlvidoContrasenia.Size = new System.Drawing.Size(153, 17);
            this.llOlvidoContrasenia.TabIndex = 12;
            this.llOlvidoContrasenia.TabStop = true;
            this.llOlvidoContrasenia.Text = "Olvido su contrasenia?";
            this.llOlvidoContrasenia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llOlvidoContrasenia_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contrasenia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Usuername: ";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(371, 336);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(295, 28);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(371, 250);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(293, 22);
            this.txtPassword.TabIndex = 8;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(371, 197);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(293, 22);
            this.txtUsername.TabIndex = 7;
            // 
            // FLogin
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1361, 732);
            this.Controls.Add(this.gbPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FLogin";
            this.Text = "FLogin";
            this.gbPanel.ResumeLayout(false);
            this.gbPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel llOlvidoContrasenia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
    }
}