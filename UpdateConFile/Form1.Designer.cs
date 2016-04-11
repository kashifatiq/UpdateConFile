namespace UpdateConFile
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnReadMasterFolder = new System.Windows.Forms.Button();
            this.txtMasterFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            this.txtFileToSearch = new System.Windows.Forms.TextBox();
            this.btnReadFolder = new System.Windows.Forms.Button();
            this.MozartTampleteWUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MozartTampleteIntegrated = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkReadOnlyTopFolder = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.createmozart = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FolderPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DbServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Database = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntegratedSecurity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnePlaceCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MozartCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConTimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReadMasterFolder
            // 
            this.btnReadMasterFolder.Location = new System.Drawing.Point(692, 41);
            this.btnReadMasterFolder.Name = "btnReadMasterFolder";
            this.btnReadMasterFolder.Size = new System.Drawing.Size(78, 23);
            this.btnReadMasterFolder.TabIndex = 0;
            this.btnReadMasterFolder.Text = "Browse";
            this.btnReadMasterFolder.UseVisualStyleBackColor = true;
            this.btnReadMasterFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMasterFolder
            // 
            this.txtMasterFolder.Location = new System.Drawing.Point(76, 41);
            this.txtMasterFolder.Name = "txtMasterFolder";
            this.txtMasterFolder.Size = new System.Drawing.Size(610, 20);
            this.txtMasterFolder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder Path :";
            // 
            // dgResults
            // 
            this.dgResults.AllowUserToAddRows = false;
            this.dgResults.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.createmozart,
            this.sno,
            this.FolderPath,
            this.DbServer,
            this.Database,
            this.UserID,
            this.Password,
            this.IntegratedSecurity,
            this.OnePlaceCon,
            this.MozartCon,
            this.FileName,
            this.ConTimeOut,
            this.Error});
            this.dgResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgResults.Location = new System.Drawing.Point(3, 16);
            this.dgResults.Name = "dgResults";
            this.dgResults.RowHeadersWidth = 20;
            this.dgResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgResults.Size = new System.Drawing.Size(1291, 521);
            this.dgResults.TabIndex = 3;
            this.dgResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResults_CellContentClick);
            // 
            // lblError
            // 
            this.lblError.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(3, 16);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(1291, 20);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "label2";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFileToSearch
            // 
            this.txtFileToSearch.Location = new System.Drawing.Point(1105, 40);
            this.txtFileToSearch.Name = "txtFileToSearch";
            this.txtFileToSearch.ReadOnly = true;
            this.txtFileToSearch.Size = new System.Drawing.Size(145, 20);
            this.txtFileToSearch.TabIndex = 5;
            this.txtFileToSearch.Text = "DbConnection.config";
            // 
            // btnReadFolder
            // 
            this.btnReadFolder.Location = new System.Drawing.Point(776, 41);
            this.btnReadFolder.Name = "btnReadFolder";
            this.btnReadFolder.Size = new System.Drawing.Size(86, 23);
            this.btnReadFolder.TabIndex = 6;
            this.btnReadFolder.Text = "Search File";
            this.btnReadFolder.UseVisualStyleBackColor = true;
            this.btnReadFolder.Click += new System.EventHandler(this.btnReadFolder_Click);
            // 
            // MozartTampleteWUser
            // 
            this.MozartTampleteWUser.Location = new System.Drawing.Point(10, 86);
            this.MozartTampleteWUser.Multiline = true;
            this.MozartTampleteWUser.Name = "MozartTampleteWUser";
            this.MozartTampleteWUser.ReadOnly = true;
            this.MozartTampleteWUser.Size = new System.Drawing.Size(1245, 34);
            this.MozartTampleteWUser.TabIndex = 7;
            this.MozartTampleteWUser.Text = resources.GetString("MozartTampleteWUser.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mozart Template with user name password";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.MozartTampleteIntegrated);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkReadOnlyTopFolder);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMasterFolder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnReadMasterFolder);
            this.groupBox1.Controls.Add(this.MozartTampleteWUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnReadFolder);
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Controls.Add(this.txtFileToSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1297, 183);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // MozartTampleteIntegrated
            // 
            this.MozartTampleteIntegrated.Location = new System.Drawing.Point(10, 139);
            this.MozartTampleteIntegrated.Multiline = true;
            this.MozartTampleteIntegrated.Name = "MozartTampleteIntegrated";
            this.MozartTampleteIntegrated.ReadOnly = true;
            this.MozartTampleteIntegrated.Size = new System.Drawing.Size(1245, 34);
            this.MozartTampleteIntegrated.TabIndex = 12;
            this.MozartTampleteIntegrated.Text = resources.GetString("MozartTampleteIntegrated.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mozart Template without user name password";
            // 
            // chkReadOnlyTopFolder
            // 
            this.chkReadOnlyTopFolder.AutoSize = true;
            this.chkReadOnlyTopFolder.Checked = true;
            this.chkReadOnlyTopFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReadOnlyTopFolder.Location = new System.Drawing.Point(870, 43);
            this.chkReadOnlyTopFolder.Name = "chkReadOnlyTopFolder";
            this.chkReadOnlyTopFolder.Size = new System.Drawing.Size(126, 17);
            this.chkReadOnlyTopFolder.TabIndex = 10;
            this.chkReadOnlyTopFolder.Text = "Read only top folders";
            this.chkReadOnlyTopFolder.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1025, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "File to search :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgResults);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1297, 540);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // createmozart
            // 
            this.createmozart.DataPropertyName = "sn";
            this.createmozart.HeaderText = "Create Mozart Con";
            this.createmozart.Name = "createmozart";
            this.createmozart.Text = "Create Mozart Con";
            this.createmozart.ToolTipText = "Create Mozart Con";
            this.createmozart.Width = 120;
            // 
            // sno
            // 
            this.sno.DataPropertyName = "sno";
            this.sno.HeaderText = "S.N";
            this.sno.Name = "sno";
            this.sno.ReadOnly = true;
            this.sno.Width = 30;
            // 
            // FolderPath
            // 
            this.FolderPath.DataPropertyName = "FolderPath";
            this.FolderPath.HeaderText = "Folder Path";
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.ReadOnly = true;
            // 
            // DbServer
            // 
            this.DbServer.DataPropertyName = "DbServer";
            this.DbServer.HeaderText = "Db Server";
            this.DbServer.Name = "DbServer";
            this.DbServer.ReadOnly = true;
            // 
            // Database
            // 
            this.Database.DataPropertyName = "Database";
            this.Database.HeaderText = "Database Name";
            this.Database.Name = "Database";
            this.Database.ReadOnly = true;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "User ID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // IntegratedSecurity
            // 
            this.IntegratedSecurity.DataPropertyName = "IntegratedSecurity";
            this.IntegratedSecurity.HeaderText = "Integrated Security";
            this.IntegratedSecurity.Name = "IntegratedSecurity";
            this.IntegratedSecurity.ReadOnly = true;
            // 
            // OnePlaceCon
            // 
            this.OnePlaceCon.DataPropertyName = "OnePlaceCon";
            this.OnePlaceCon.HeaderText = "OnePlace Con";
            this.OnePlaceCon.Name = "OnePlaceCon";
            this.OnePlaceCon.ReadOnly = true;
            // 
            // MozartCon
            // 
            this.MozartCon.DataPropertyName = "MozartCon";
            this.MozartCon.HeaderText = "Mozart Con";
            this.MozartCon.Name = "MozartCon";
            this.MozartCon.ReadOnly = true;
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // ConTimeOut
            // 
            this.ConTimeOut.DataPropertyName = "ConTimeOut";
            this.ConTimeOut.HeaderText = "Con Time Out";
            this.ConTimeOut.Name = "ConTimeOut";
            // 
            // Error
            // 
            this.Error.DataPropertyName = "Error";
            this.Error.HeaderText = "Error";
            this.Error.Name = "Error";
            this.Error.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 723);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Avizia Update db config file";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadMasterFolder;
        private System.Windows.Forms.TextBox txtMasterFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtFileToSearch;
        private System.Windows.Forms.Button btnReadFolder;
        private System.Windows.Forms.TextBox MozartTampleteWUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkReadOnlyTopFolder;
        private System.Windows.Forms.TextBox MozartTampleteIntegrated;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewButtonColumn createmozart;
        private System.Windows.Forms.DataGridViewTextBoxColumn sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn FolderPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn DbServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Database;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntegratedSecurity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnePlaceCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MozartCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConTimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Error;
    }
}

