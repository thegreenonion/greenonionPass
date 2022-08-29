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
            this.lblCrypt = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cmbEncrypt = new System.Windows.Forms.Button();
            this.cmbClear = new System.Windows.Forms.Button();
            this.cmbClose = new System.Windows.Forms.Button();
            this.txtPasswordName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPassVisibility = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbLogin
            // 
            this.cmbLogin.Location = new System.Drawing.Point(567, 368);
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
            this.lblRandom.Location = new System.Drawing.Point(907, 136);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(0, 16);
            this.lblRandom.TabIndex = 3;
            // 
            // lblCrypt
            // 
            this.lblCrypt.AutoSize = true;
            this.lblCrypt.Location = new System.Drawing.Point(1143, 74);
            this.lblCrypt.Name = "lblCrypt";
            this.lblCrypt.Size = new System.Drawing.Size(0, 16);
            this.lblCrypt.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F);
            this.txtPass.Location = new System.Drawing.Point(147, 130);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '♦';
            this.txtPass.Size = new System.Drawing.Size(200, 15);
            this.txtPass.TabIndex = 5;
            this.txtPass.Visible = false;
            // 
            // cmbEncrypt
            // 
            this.cmbEncrypt.Location = new System.Drawing.Point(147, 192);
            this.cmbEncrypt.Name = "cmbEncrypt";
            this.cmbEncrypt.Size = new System.Drawing.Size(128, 30);
            this.cmbEncrypt.TabIndex = 6;
            this.cmbEncrypt.Text = "Encrypt";
            this.cmbEncrypt.UseVisualStyleBackColor = true;
            this.cmbEncrypt.Visible = false;
            this.cmbEncrypt.Click += new System.EventHandler(this.cmbEncrypt_Click);
            // 
            // cmbClear
            // 
            this.cmbClear.Location = new System.Drawing.Point(1112, 13);
            this.cmbClear.Name = "cmbClear";
            this.cmbClear.Size = new System.Drawing.Size(113, 28);
            this.cmbClear.TabIndex = 7;
            this.cmbClear.Text = "Clear";
            this.cmbClear.UseVisualStyleBackColor = true;
            this.cmbClear.Click += new System.EventHandler(this.cmbClear_Click);
            // 
            // cmbClose
            // 
            this.cmbClose.BackColor = System.Drawing.Color.Red;
            this.cmbClose.Location = new System.Drawing.Point(1096, 481);
            this.cmbClose.Name = "cmbClose";
            this.cmbClose.Size = new System.Drawing.Size(129, 37);
            this.cmbClose.TabIndex = 8;
            this.cmbClose.Text = "Close";
            this.cmbClose.UseVisualStyleBackColor = false;
            this.cmbClose.Click += new System.EventHandler(this.cmbClose_Click);
            // 
            // txtPasswordName
            // 
            this.txtPasswordName.Location = new System.Drawing.Point(147, 67);
            this.txtPasswordName.Name = "txtPasswordName";
            this.txtPasswordName.Size = new System.Drawing.Size(200, 22);
            this.txtPasswordName.TabIndex = 9;
            this.txtPasswordName.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Password name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // cmbPassVisibility
            // 
            this.cmbPassVisibility.Location = new System.Drawing.Point(369, 130);
            this.cmbPassVisibility.Name = "cmbPassVisibility";
            this.cmbPassVisibility.Size = new System.Drawing.Size(185, 36);
            this.cmbPassVisibility.TabIndex = 12;
            this.cmbPassVisibility.Text = "Make password visible";
            this.cmbPassVisibility.UseVisualStyleBackColor = true;
            this.cmbPassVisibility.Click += new System.EventHandler(this.cmbPassVisibility_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 530);
            this.Controls.Add(this.cmbPassVisibility);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasswordName);
            this.Controls.Add(this.cmbClose);
            this.Controls.Add(this.cmbClear);
            this.Controls.Add(this.cmbEncrypt);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblCrypt);
            this.Controls.Add(this.lblRandom);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.cmbLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmbLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Label lblCrypt;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button cmbEncrypt;
        private System.Windows.Forms.Button cmbClear;
        private System.Windows.Forms.Button cmbClose;
        private System.Windows.Forms.TextBox txtPasswordName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmbPassVisibility;
    }
}

