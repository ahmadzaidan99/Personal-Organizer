namespace Personal_Organiser_App
{
    partial class Set_New_Password
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
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSetNewPassword = new System.Windows.Forms.Label();
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.prgProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblSentEmail = new System.Windows.Forms.Label();
            this.pnlProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 23;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(138, 216);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '•';
            this.txtNewPassword.Size = new System.Drawing.Size(195, 20);
            this.txtNewPassword.TabIndex = 24;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNewPassword.Location = new System.Drawing.Point(135, 200);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(81, 13);
            this.lblNewPassword.TabIndex = 25;
            this.lblNewPassword.Text = "New Password:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnConfirm.Location = new System.Drawing.Point(138, 242);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 26);
            this.btnConfirm.TabIndex = 26;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnCancel.Location = new System.Drawing.Point(238, 242);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 26);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSetNewPassword
            // 
            this.lblSetNewPassword.AutoSize = true;
            this.lblSetNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblSetNewPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSetNewPassword.Location = new System.Drawing.Point(50, 94);
            this.lblSetNewPassword.Name = "lblSetNewPassword";
            this.lblSetNewPassword.Size = new System.Drawing.Size(212, 24);
            this.lblSetNewPassword.TabIndex = 29;
            this.lblSetNewPassword.Text = "Set New Password For: ";
            // 
            // pnlProgress
            // 
            this.pnlProgress.Controls.Add(this.lblSentEmail);
            this.pnlProgress.Controls.Add(this.lblProgress);
            this.pnlProgress.Controls.Add(this.prgProgressBar);
            this.pnlProgress.Location = new System.Drawing.Point(138, 296);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(200, 100);
            this.pnlProgress.TabIndex = 30;
            // 
            // prgProgressBar
            // 
            this.prgProgressBar.Location = new System.Drawing.Point(3, 36);
            this.prgProgressBar.Name = "prgProgressBar";
            this.prgProgressBar.Size = new System.Drawing.Size(192, 23);
            this.prgProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgProgressBar.TabIndex = 31;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProgress.Location = new System.Drawing.Point(3, 20);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(54, 13);
            this.lblProgress.TabIndex = 31;
            this.lblProgress.Text = "Progress: ";
            // 
            // lblSentEmail
            // 
            this.lblSentEmail.AutoSize = true;
            this.lblSentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSentEmail.Location = new System.Drawing.Point(28, 62);
            this.lblSentEmail.Name = "lblSentEmail";
            this.lblSentEmail.Size = new System.Drawing.Size(140, 13);
            this.lblSentEmail.TabIndex = 31;
            this.lblSentEmail.Text = "Email Sent Succesfully!";
            // 
            // Set_New_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(500, 533);
            this.Controls.Add(this.pnlProgress);
            this.Controls.Add(this.lblSetNewPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.btnReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Set_New_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set New Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Set_New_Password_FormClosing);
            this.Load += new System.EventHandler(this.Set_New_Password_Load);
            this.pnlProgress.ResumeLayout(false);
            this.pnlProgress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSetNewPassword;
        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.Label lblSentEmail;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar prgProgressBar;
    }
}