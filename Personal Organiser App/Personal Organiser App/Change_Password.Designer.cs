namespace Personal_Organiser_App
{
    partial class Change_Password
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.btnSaveNewPassword = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(129, 286);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.PasswordChar = '•';
            this.txtConfirmNewPassword.ReadOnly = true;
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(213, 20);
            this.txtConfirmNewPassword.TabIndex = 3;
            this.txtConfirmNewPassword.TextChanged += new System.EventHandler(this.txtConfirmNewPassword_TextChanged);
            this.txtConfirmNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Change_Password_KeyDown);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(129, 232);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '•';
            this.txtNewPassword.ReadOnly = true;
            this.txtNewPassword.Size = new System.Drawing.Size(213, 20);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            this.txtNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Change_Password_KeyDown);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtCurrentPassword.Location = new System.Drawing.Point(129, 178);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '•';
            this.txtCurrentPassword.Size = new System.Drawing.Size(213, 20);
            this.txtCurrentPassword.TabIndex = 1;
            this.txtCurrentPassword.TextChanged += new System.EventHandler(this.txtCurrentPassword_TextChanged);
            this.txtCurrentPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Change_Password_KeyDown);
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCurrentPassword.Location = new System.Drawing.Point(129, 162);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(93, 13);
            this.lblCurrentPassword.TabIndex = 30;
            this.lblCurrentPassword.Text = "Current Password:";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNewPassword.Location = new System.Drawing.Point(129, 216);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(81, 13);
            this.lblNewPassword.TabIndex = 31;
            this.lblNewPassword.Text = "New Password:";
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(129, 270);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(119, 13);
            this.lblConfirmNewPassword.TabIndex = 32;
            this.lblConfirmNewPassword.Text = "Confirm New Password:";
            // 
            // btnSaveNewPassword
            // 
            this.btnSaveNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNewPassword.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnSaveNewPassword.Location = new System.Drawing.Point(129, 336);
            this.btnSaveNewPassword.Name = "btnSaveNewPassword";
            this.btnSaveNewPassword.Size = new System.Drawing.Size(93, 23);
            this.btnSaveNewPassword.TabIndex = 4;
            this.btnSaveNewPassword.Text = "Save";
            this.btnSaveNewPassword.UseVisualStyleBackColor = true;
            this.btnSaveNewPassword.Click += new System.EventHandler(this.btnSaveNewPassword_Click);
            this.btnSaveNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Change_Password_KeyDown);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnCancel.Location = new System.Drawing.Point(250, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Change_Password_KeyDown);
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(500, 533);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveNewPassword);
            this.Controls.Add(this.lblConfirmNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtConfirmNewPassword);
            this.Controls.Add(this.btnReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Change_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change_Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Change_Password_FormClosing);
            this.Load += new System.EventHandler(this.Change_Password_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Change_Password_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.Button btnSaveNewPassword;
        private System.Windows.Forms.Button btnCancel;
    }
}