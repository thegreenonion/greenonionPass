namespace Password_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbLogin = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblRandom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbLogin
            // 
            this.cmbLogin.Location = new System.Drawing.Point(575, 380);
            this.cmbLogin.Name = "cmbLogin";
            this.cmbLogin.Size = new System.Drawing.Size(217, 63);
            this.cmbLogin.TabIndex = 0;
            this.cmbLogin.Text = "Log in";
            this.cmbLogin.UseVisualStyleBackColor = true;
            this.cmbLogin.Click += new System.EventHandler(this.cmbLogin_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(538, 289);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(275, 22);
            this.txtLogin.TabIndex = 1;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(575, 332);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(0, 16);
            this.lblA.TabIndex = 2;
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(907, 332);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(0, 16);
            this.lblRandom.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 577);
            this.Controls.Add(this.lblRandom);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.cmbLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmbLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblRandom;
    }
}

