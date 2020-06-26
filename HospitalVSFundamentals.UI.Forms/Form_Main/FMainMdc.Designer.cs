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
            this.SuspendLayout();
            // 
            // label1a
            // 
            this.label1a.AutoSize = true;
            this.label1a.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1a.Location = new System.Drawing.Point(-2, 118);
            this.label1a.Name = "label1a";
            this.label1a.Size = new System.Drawing.Size(790, 46);
            this.label1a.TabIndex = 0;
            this.label1a.Text = "ESTE ES EL FORMULARIO DE MEDICOS";
            // 
            // FMainMdc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1a);
            this.Name = "FMainMdc";
            this.Text = "FMainMdc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1a;
    }
}