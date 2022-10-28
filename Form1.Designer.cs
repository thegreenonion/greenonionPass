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
            this.cmbClose = new System.Windows.Forms.Button();
            this.txtPasswordName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPassVisibility = new System.Windows.Forms.Button();
            this.lstPassword = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPIN = new System.Windows.Forms.NumericUpDown();
            this.chkPIN = new System.Windows.Forms.CheckBox();
            this.cmbLock = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cobEncryption = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPIN)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLogin
            // 
            this.cmbLogin.Location = new System.Drawing.Point(567, 421);
            this.cmbLogin.Name = "cmbLogin";
            this.cmbLogin.Size = new System.Drawing.Size(217, 63);
            this.cmbLogin.TabIndex = 0;
            this.cmbLogin.Text = "Log in";
            this.cmbLogin.UseVisualStyleBackColor = true;
            this.cmbLogin.Click += new System.EventHandler(this.cmbLogin_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(539, 317);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(275, 22);
            this.txtLogin.TabIndex = 1;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(917, 317);
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
            this.lblCrypt.Location = new System.Drawing.Point(1025, 218);
            this.lblCrypt.Name = "lblCrypt";
            this.lblCrypt.Size = new System.Drawing.Size(0, 16);
            this.lblCrypt.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F);
            this.txtPass.Location = new System.Drawing.Point(144, 94);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '♦';
            this.txtPass.Size = new System.Drawing.Size(200, 15);
            this.txtPass.TabIndex = 5;
            this.txtPass.Visible = false;
            // 
            // cmbEncrypt
            // 
            this.cmbEncrypt.Location = new System.Drawing.Point(144, 189);
            this.cmbEncrypt.Name = "cmbEncrypt";
            this.cmbEncrypt.Size = new System.Drawing.Size(200, 30);
            this.cmbEncrypt.TabIndex = 6;
            this.cmbEncrypt.Text = "Encrypt password and save";
            this.cmbEncrypt.UseVisualStyleBackColor = true;
            this.cmbEncrypt.Visible = false;
            this.cmbEncrypt.Click += new System.EventHandler(this.cmbEncrypt_Click);
            // 
            // cmbClose
            // 
            this.cmbClose.BackColor = System.Drawing.Color.Red;
            this.cmbClose.Location = new System.Drawing.Point(1204, 587);
            this.cmbClose.Name = "cmbClose";
            this.cmbClose.Size = new System.Drawing.Size(129, 37);
            this.cmbClose.TabIndex = 8;
            this.cmbClose.Text = "Close";
            this.cmbClose.UseVisualStyleBackColor = false;
            this.cmbClose.Click += new System.EventHandler(this.cmbClose_Click);
            // 
            // txtPasswordName
            // 
            this.txtPasswordName.Location = new System.Drawing.Point(144, 31);
            this.txtPasswordName.Name = "txtPasswordName";
            this.txtPasswordName.Size = new System.Drawing.Size(200, 22);
            this.txtPasswordName.TabIndex = 9;
            this.txtPasswordName.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Password name";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            this.label2.Visible = false;
            // 
            // cmbPassVisibility
            // 
            this.cmbPassVisibility.Location = new System.Drawing.Point(376, 80);
            this.cmbPassVisibility.Name = "cmbPassVisibility";
            this.cmbPassVisibility.Size = new System.Drawing.Size(185, 36);
            this.cmbPassVisibility.TabIndex = 12;
            this.cmbPassVisibility.Text = "Make password visible";
            this.cmbPassVisibility.UseVisualStyleBackColor = true;
            this.cmbPassVisibility.Visible = false;
            this.cmbPassVisibility.Click += new System.EventHandler(this.cmbPassVisibility_Click);
            // 
            // lstPassword
            // 
            this.lstPassword.FormattingEnabled = true;
            this.lstPassword.ItemHeight = 16;
            this.lstPassword.Location = new System.Drawing.Point(567, 6);
            this.lstPassword.Name = "lstPassword";
            this.lstPassword.Size = new System.Drawing.Size(350, 276);
            this.lstPassword.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Masterpassword";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(525, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "PIN (optional for additional safety - must be used with Masterpassword - max 5 nu" +
    "mbers)";
            // 
            // nudPIN
            // 
            this.nudPIN.Location = new System.Drawing.Point(539, 366);
            this.nudPIN.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudPIN.Name = "nudPIN";
            this.nudPIN.Size = new System.Drawing.Size(120, 22);
            this.nudPIN.TabIndex = 16;
            // 
            // chkPIN
            // 
            this.chkPIN.AutoSize = true;
            this.chkPIN.Checked = true;
            this.chkPIN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPIN.Location = new System.Drawing.Point(395, 367);
            this.chkPIN.Name = "chkPIN";
            this.chkPIN.Size = new System.Drawing.Size(104, 20);
            this.chkPIN.TabIndex = 17;
            this.chkPIN.Text = "PIN enabled";
            this.chkPIN.UseVisualStyleBackColor = true;
            this.chkPIN.CheckedChanged += new System.EventHandler(this.chkPIN_CheckedChanged);
            // 
            // cmbLock
            // 
            this.cmbLock.BackColor = System.Drawing.Color.Lime;
            this.cmbLock.Location = new System.Drawing.Point(1000, 45);
            this.cmbLock.Name = "cmbLock";
            this.cmbLock.Size = new System.Drawing.Size(225, 51);
            this.cmbLock.TabIndex = 18;
            this.cmbLock.Text = "Lock and Clear";
            this.cmbLock.UseVisualStyleBackColor = false;
            this.cmbLock.Click += new System.EventHandler(this.cmbLock_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(150, 295);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(197, 37);
            this.cmdDelete.TabIndex = 19;
            this.cmdDelete.Text = "Delete selected password";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cobEncryption
            // 
            this.cobEncryption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobEncryption.FormattingEnabled = true;
            this.cobEncryption.Items.AddRange(new object[] {
            "Use ASCII-Shuffler encryption",
            "Use AES encryption"});
            this.cobEncryption.Location = new System.Drawing.Point(144, 143);
            this.cobEncryption.Name = "cobEncryption";
            this.cobEncryption.Size = new System.Drawing.Size(200, 24);
            this.cobEncryption.TabIndex = 24;
            this.cobEncryption.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 25;
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 636);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cobEncryption);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmbLock);
            this.Controls.Add(this.chkPIN);
            this.Controls.Add(this.nudPIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstPassword);
            this.Controls.Add(this.cmbPassVisibility);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasswordName);
            this.Controls.Add(this.cmbClose);
            this.Controls.Add(this.cmbEncrypt);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblCrypt);
            this.Controls.Add(this.lblRandom);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.cmbLogin);
            this.Name = "Form1";
            this.Text = "greenonionPass - PASSWORD MANAGER";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPIN)).EndInit();
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
        private System.Windows.Forms.Button cmbClose;
        private System.Windows.Forms.TextBox txtPasswordName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmbPassVisibility;
        private System.Windows.Forms.ListBox lstPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPIN;
        private System.Windows.Forms.CheckBox chkPIN;
        private System.Windows.Forms.Button cmbLock;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.ComboBox cobEncryption;
        private System.Windows.Forms.Label label5;
    }
}

