namespace DataTransfer
{
    partial class frmDataTransfer
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
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.lblTableName = new System.Windows.Forms.Label();
            this.groupSource = new System.Windows.Forms.GroupBox();
            this.lblSDatabase = new System.Windows.Forms.Label();
            this.txtSDatabase = new System.Windows.Forms.TextBox();
            this.chkSAuthentication = new System.Windows.Forms.CheckBox();
            this.txtSPassword = new System.Windows.Forms.TextBox();
            this.lblSPassword = new System.Windows.Forms.Label();
            this.txtSLogin = new System.Windows.Forms.TextBox();
            this.lblSLogin = new System.Windows.Forms.Label();
            this.txtSServerName = new System.Windows.Forms.TextBox();
            this.lblSServerName = new System.Windows.Forms.Label();
            this.groupDestination = new System.Windows.Forms.GroupBox();
            this.lblDDatabase = new System.Windows.Forms.Label();
            this.chkDAuthentication = new System.Windows.Forms.CheckBox();
            this.txtDDatabase = new System.Windows.Forms.TextBox();
            this.txtDPassword = new System.Windows.Forms.TextBox();
            this.lblDPassword = new System.Windows.Forms.Label();
            this.txtDLogin = new System.Windows.Forms.TextBox();
            this.lblDLogin = new System.Windows.Forms.Label();
            this.txtDServerName = new System.Windows.Forms.TextBox();
            this.lblDServerName = new System.Windows.Forms.Label();
            this.groupTransfer = new System.Windows.Forms.GroupBox();
            this.chkWithTable = new System.Windows.Forms.CheckBox();
            this.rbtnSP = new System.Windows.Forms.RadioButton();
            this.rbtnTable = new System.Windows.Forms.RadioButton();
            this.groupSource.SuspendLayout();
            this.groupDestination.SuspendLayout();
            this.groupTransfer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(334, 45);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(75, 23);
            this.btnTransfer.TabIndex = 0;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(182, 19);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(227, 20);
            this.txtTableName.TabIndex = 1;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Location = new System.Drawing.Point(111, 22);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(65, 13);
            this.lblTableName.TabIndex = 2;
            this.lblTableName.Text = "Table Name";
            // 
            // groupSource
            // 
            this.groupSource.Controls.Add(this.lblSDatabase);
            this.groupSource.Controls.Add(this.txtSDatabase);
            this.groupSource.Controls.Add(this.chkSAuthentication);
            this.groupSource.Controls.Add(this.txtSPassword);
            this.groupSource.Controls.Add(this.lblSPassword);
            this.groupSource.Controls.Add(this.txtSLogin);
            this.groupSource.Controls.Add(this.lblSLogin);
            this.groupSource.Controls.Add(this.txtSServerName);
            this.groupSource.Controls.Add(this.lblSServerName);
            this.groupSource.Location = new System.Drawing.Point(12, 12);
            this.groupSource.Name = "groupSource";
            this.groupSource.Size = new System.Drawing.Size(375, 146);
            this.groupSource.TabIndex = 3;
            this.groupSource.TabStop = false;
            this.groupSource.Text = "Source Information";
            // 
            // lblSDatabase
            // 
            this.lblSDatabase.AutoSize = true;
            this.lblSDatabase.Location = new System.Drawing.Point(17, 96);
            this.lblSDatabase.Name = "lblSDatabase";
            this.lblSDatabase.Size = new System.Drawing.Size(53, 13);
            this.lblSDatabase.TabIndex = 8;
            this.lblSDatabase.Text = "Database";
            // 
            // txtSDatabase
            // 
            this.txtSDatabase.Location = new System.Drawing.Point(92, 93);
            this.txtSDatabase.Name = "txtSDatabase";
            this.txtSDatabase.Size = new System.Drawing.Size(266, 20);
            this.txtSDatabase.TabIndex = 7;
            // 
            // chkSAuthentication
            // 
            this.chkSAuthentication.AutoSize = true;
            this.chkSAuthentication.Checked = true;
            this.chkSAuthentication.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSAuthentication.Location = new System.Drawing.Point(92, 119);
            this.chkSAuthentication.Name = "chkSAuthentication";
            this.chkSAuthentication.Size = new System.Drawing.Size(163, 17);
            this.chkSAuthentication.TabIndex = 6;
            this.chkSAuthentication.Text = "Is SQL Server Authentication";
            this.chkSAuthentication.UseVisualStyleBackColor = true;
            // 
            // txtSPassword
            // 
            this.txtSPassword.Location = new System.Drawing.Point(92, 67);
            this.txtSPassword.Name = "txtSPassword";
            this.txtSPassword.Size = new System.Drawing.Size(266, 20);
            this.txtSPassword.TabIndex = 5;
            // 
            // lblSPassword
            // 
            this.lblSPassword.AutoSize = true;
            this.lblSPassword.Location = new System.Drawing.Point(17, 70);
            this.lblSPassword.Name = "lblSPassword";
            this.lblSPassword.Size = new System.Drawing.Size(53, 13);
            this.lblSPassword.TabIndex = 4;
            this.lblSPassword.Text = "Password";
            // 
            // txtSLogin
            // 
            this.txtSLogin.Location = new System.Drawing.Point(92, 43);
            this.txtSLogin.Name = "txtSLogin";
            this.txtSLogin.Size = new System.Drawing.Size(266, 20);
            this.txtSLogin.TabIndex = 3;
            // 
            // lblSLogin
            // 
            this.lblSLogin.AutoSize = true;
            this.lblSLogin.Location = new System.Drawing.Point(17, 46);
            this.lblSLogin.Name = "lblSLogin";
            this.lblSLogin.Size = new System.Drawing.Size(33, 13);
            this.lblSLogin.TabIndex = 2;
            this.lblSLogin.Text = "Login";
            // 
            // txtSServerName
            // 
            this.txtSServerName.Location = new System.Drawing.Point(92, 19);
            this.txtSServerName.Name = "txtSServerName";
            this.txtSServerName.Size = new System.Drawing.Size(266, 20);
            this.txtSServerName.TabIndex = 1;
            // 
            // lblSServerName
            // 
            this.lblSServerName.AutoSize = true;
            this.lblSServerName.Location = new System.Drawing.Point(17, 22);
            this.lblSServerName.Name = "lblSServerName";
            this.lblSServerName.Size = new System.Drawing.Size(69, 13);
            this.lblSServerName.TabIndex = 0;
            this.lblSServerName.Text = "Server Name";
            // 
            // groupDestination
            // 
            this.groupDestination.Controls.Add(this.lblDDatabase);
            this.groupDestination.Controls.Add(this.chkDAuthentication);
            this.groupDestination.Controls.Add(this.txtDDatabase);
            this.groupDestination.Controls.Add(this.txtDPassword);
            this.groupDestination.Controls.Add(this.lblDPassword);
            this.groupDestination.Controls.Add(this.txtDLogin);
            this.groupDestination.Controls.Add(this.lblDLogin);
            this.groupDestination.Controls.Add(this.txtDServerName);
            this.groupDestination.Controls.Add(this.lblDServerName);
            this.groupDestination.Location = new System.Drawing.Point(403, 12);
            this.groupDestination.Name = "groupDestination";
            this.groupDestination.Size = new System.Drawing.Size(375, 146);
            this.groupDestination.TabIndex = 4;
            this.groupDestination.TabStop = false;
            this.groupDestination.Text = "Destination Information";
            // 
            // lblDDatabase
            // 
            this.lblDDatabase.AutoSize = true;
            this.lblDDatabase.Location = new System.Drawing.Point(22, 92);
            this.lblDDatabase.Name = "lblDDatabase";
            this.lblDDatabase.Size = new System.Drawing.Size(53, 13);
            this.lblDDatabase.TabIndex = 10;
            this.lblDDatabase.Text = "Database";
            // 
            // chkDAuthentication
            // 
            this.chkDAuthentication.AutoSize = true;
            this.chkDAuthentication.Checked = true;
            this.chkDAuthentication.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDAuthentication.Location = new System.Drawing.Point(97, 119);
            this.chkDAuthentication.Name = "chkDAuthentication";
            this.chkDAuthentication.Size = new System.Drawing.Size(163, 17);
            this.chkDAuthentication.TabIndex = 13;
            this.chkDAuthentication.Text = "Is SQL Server Authentication";
            this.chkDAuthentication.UseVisualStyleBackColor = true;
            // 
            // txtDDatabase
            // 
            this.txtDDatabase.Location = new System.Drawing.Point(97, 89);
            this.txtDDatabase.Name = "txtDDatabase";
            this.txtDDatabase.Size = new System.Drawing.Size(266, 20);
            this.txtDDatabase.TabIndex = 9;
            // 
            // txtDPassword
            // 
            this.txtDPassword.Location = new System.Drawing.Point(97, 63);
            this.txtDPassword.Name = "txtDPassword";
            this.txtDPassword.Size = new System.Drawing.Size(266, 20);
            this.txtDPassword.TabIndex = 12;
            // 
            // lblDPassword
            // 
            this.lblDPassword.AutoSize = true;
            this.lblDPassword.Location = new System.Drawing.Point(22, 66);
            this.lblDPassword.Name = "lblDPassword";
            this.lblDPassword.Size = new System.Drawing.Size(53, 13);
            this.lblDPassword.TabIndex = 11;
            this.lblDPassword.Text = "Password";
            // 
            // txtDLogin
            // 
            this.txtDLogin.Location = new System.Drawing.Point(97, 39);
            this.txtDLogin.Name = "txtDLogin";
            this.txtDLogin.Size = new System.Drawing.Size(266, 20);
            this.txtDLogin.TabIndex = 10;
            // 
            // lblDLogin
            // 
            this.lblDLogin.AutoSize = true;
            this.lblDLogin.Location = new System.Drawing.Point(22, 42);
            this.lblDLogin.Name = "lblDLogin";
            this.lblDLogin.Size = new System.Drawing.Size(33, 13);
            this.lblDLogin.TabIndex = 9;
            this.lblDLogin.Text = "Login";
            // 
            // txtDServerName
            // 
            this.txtDServerName.Location = new System.Drawing.Point(97, 15);
            this.txtDServerName.Name = "txtDServerName";
            this.txtDServerName.Size = new System.Drawing.Size(266, 20);
            this.txtDServerName.TabIndex = 8;
            // 
            // lblDServerName
            // 
            this.lblDServerName.AutoSize = true;
            this.lblDServerName.Location = new System.Drawing.Point(22, 18);
            this.lblDServerName.Name = "lblDServerName";
            this.lblDServerName.Size = new System.Drawing.Size(69, 13);
            this.lblDServerName.TabIndex = 7;
            this.lblDServerName.Text = "Server Name";
            // 
            // groupTransfer
            // 
            this.groupTransfer.Controls.Add(this.chkWithTable);
            this.groupTransfer.Controls.Add(this.rbtnSP);
            this.groupTransfer.Controls.Add(this.rbtnTable);
            this.groupTransfer.Controls.Add(this.txtTableName);
            this.groupTransfer.Controls.Add(this.btnTransfer);
            this.groupTransfer.Controls.Add(this.lblTableName);
            this.groupTransfer.Location = new System.Drawing.Point(188, 174);
            this.groupTransfer.Name = "groupTransfer";
            this.groupTransfer.Size = new System.Drawing.Size(415, 75);
            this.groupTransfer.TabIndex = 5;
            this.groupTransfer.TabStop = false;
            this.groupTransfer.Text = "Transfer Information";
            // 
            // chkWithTable
            // 
            this.chkWithTable.AutoSize = true;
            this.chkWithTable.Location = new System.Drawing.Point(182, 45);
            this.chkWithTable.Name = "chkWithTable";
            this.chkWithTable.Size = new System.Drawing.Size(108, 17);
            this.chkWithTable.TabIndex = 7;
            this.chkWithTable.Text = "With Table Script";
            this.chkWithTable.UseVisualStyleBackColor = true;
            // 
            // rbtnSP
            // 
            this.rbtnSP.AutoSize = true;
            this.rbtnSP.Location = new System.Drawing.Point(20, 45);
            this.rbtnSP.Name = "rbtnSP";
            this.rbtnSP.Size = new System.Drawing.Size(39, 17);
            this.rbtnSP.TabIndex = 6;
            this.rbtnSP.TabStop = true;
            this.rbtnSP.Text = "SP";
            this.rbtnSP.UseVisualStyleBackColor = true;
            this.rbtnSP.Click += new System.EventHandler(this.rbtnSP_Click);
            // 
            // rbtnTable
            // 
            this.rbtnTable.AutoSize = true;
            this.rbtnTable.Checked = true;
            this.rbtnTable.Location = new System.Drawing.Point(20, 20);
            this.rbtnTable.Name = "rbtnTable";
            this.rbtnTable.Size = new System.Drawing.Size(52, 17);
            this.rbtnTable.TabIndex = 5;
            this.rbtnTable.TabStop = true;
            this.rbtnTable.Text = "Table";
            this.rbtnTable.UseVisualStyleBackColor = true;
            this.rbtnTable.Click += new System.EventHandler(this.rbtnTable_Click);
            // 
            // frmDataTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 261);
            this.Controls.Add(this.groupTransfer);
            this.Controls.Add(this.groupDestination);
            this.Controls.Add(this.groupSource);
            this.Name = "frmDataTransfer";
            this.Text = "Data Transfer";
            this.Load += new System.EventHandler(this.frmDataTransfer_Load);
            this.groupSource.ResumeLayout(false);
            this.groupSource.PerformLayout();
            this.groupDestination.ResumeLayout(false);
            this.groupDestination.PerformLayout();
            this.groupTransfer.ResumeLayout(false);
            this.groupTransfer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.GroupBox groupSource;
        private System.Windows.Forms.GroupBox groupDestination;
        private System.Windows.Forms.TextBox txtSLogin;
        private System.Windows.Forms.Label lblSLogin;
        private System.Windows.Forms.TextBox txtSServerName;
        private System.Windows.Forms.Label lblSServerName;
        private System.Windows.Forms.TextBox txtSPassword;
        private System.Windows.Forms.Label lblSPassword;
        private System.Windows.Forms.CheckBox chkSAuthentication;
        private System.Windows.Forms.CheckBox chkDAuthentication;
        private System.Windows.Forms.TextBox txtDPassword;
        private System.Windows.Forms.Label lblDPassword;
        private System.Windows.Forms.TextBox txtDLogin;
        private System.Windows.Forms.Label lblDLogin;
        private System.Windows.Forms.TextBox txtDServerName;
        private System.Windows.Forms.Label lblDServerName;
        private System.Windows.Forms.GroupBox groupTransfer;
        private System.Windows.Forms.Label lblSDatabase;
        private System.Windows.Forms.TextBox txtSDatabase;
        private System.Windows.Forms.Label lblDDatabase;
        private System.Windows.Forms.TextBox txtDDatabase;
        private System.Windows.Forms.RadioButton rbtnSP;
        private System.Windows.Forms.RadioButton rbtnTable;
        private System.Windows.Forms.CheckBox chkWithTable;
    }
}

