namespace Personal_Organiser_App
{
    partial class User_Managment
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSetNewPassword = new System.Windows.Forms.Button();
            this.btnViewInformation = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.UserType});
            this.dgvUsers.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvUsers.Location = new System.Drawing.Point(28, 61);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(439, 420);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            this.dgvUsers.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvUsers_CurrentCellDirtyStateChanged);
            // 
            // UserName
            // 
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // UserType
            // 
            this.UserType.HeaderText = "User Type";
            this.UserType.Items.AddRange(new object[] {
            "Admin",
            "User",
            "Part-Time User"});
            this.UserType.Name = "UserType";
            this.UserType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSetNewPassword
            // 
            this.btnSetNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetNewPassword.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnSetNewPassword.Location = new System.Drawing.Point(354, 487);
            this.btnSetNewPassword.Name = "btnSetNewPassword";
            this.btnSetNewPassword.Size = new System.Drawing.Size(112, 23);
            this.btnSetNewPassword.TabIndex = 15;
            this.btnSetNewPassword.Text = "Set New Password";
            this.btnSetNewPassword.UseVisualStyleBackColor = true;
            this.btnSetNewPassword.Click += new System.EventHandler(this.btnSetNewPassword_Click);
            // 
            // btnViewInformation
            // 
            this.btnViewInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewInformation.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnViewInformation.Location = new System.Drawing.Point(191, 487);
            this.btnViewInformation.Name = "btnViewInformation";
            this.btnViewInformation.Size = new System.Drawing.Size(112, 23);
            this.btnViewInformation.TabIndex = 16;
            this.btnViewInformation.Text = "View Information";
            this.btnViewInformation.UseVisualStyleBackColor = true;
            this.btnViewInformation.Click += new System.EventHandler(this.btnViewInformation_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnSaveChanges.Location = new System.Drawing.Point(28, 487);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(112, 23);
            this.btnSaveChanges.TabIndex = 17;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnExport
            // 
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnExport.Location = new System.Drawing.Point(399, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(89, 23);
            this.btnExport.TabIndex = 18;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // User_Managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(500, 533);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnViewInformation);
            this.Controls.Add(this.btnSetNewPassword);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "User_Managment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_Managment_FormClosing);
            this.Load += new System.EventHandler(this.User_Managment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewComboBoxColumn UserType;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSetNewPassword;
        private System.Windows.Forms.Button btnViewInformation;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}