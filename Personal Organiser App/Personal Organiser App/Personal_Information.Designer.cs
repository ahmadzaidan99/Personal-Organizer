namespace Personal_Organiser_App
{
    partial class Personal_Information
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnEditPic = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.picPhotoID = new System.Windows.Forms.PictureBox();
            this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblMinimumSalary = new System.Windows.Forms.Label();
            this.txtMinimumSalary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPhotoID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(246, 100);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(203, 20);
            this.txtFirstName.TabIndex = 23;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Personal_Information_KeyDown);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(246, 153);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(203, 20);
            this.txtSurname.TabIndex = 24;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            this.txtSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Personal_Information_KeyDown);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(246, 259);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(203, 20);
            this.txtEmailAddress.TabIndex = 26;
            this.txtEmailAddress.TextChanged += new System.EventHandler(this.txtEmailAddress_TextChanged);
            this.txtEmailAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Personal_Information_KeyDown);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(246, 312);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(203, 20);
            this.txtAddress.TabIndex = 27;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Personal_Information_KeyDown);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFirstName.Location = new System.Drawing.Point(243, 84);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(35, 13);
            this.lblFirstName.TabIndex = 29;
            this.lblFirstName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSurname.Location = new System.Drawing.Point(243, 137);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 30;
            this.lblSurname.Text = "Surname";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPhoneNumber.Location = new System.Drawing.Point(243, 190);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 31;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmailAddress.Location = new System.Drawing.Point(243, 243);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(73, 13);
            this.lblEmailAddress.TabIndex = 32;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAddress.Location = new System.Drawing.Point(243, 296);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 33;
            this.lblAddress.Text = "Address";
            // 
            // btnEditPic
            // 
            this.btnEditPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPic.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnEditPic.Location = new System.Drawing.Point(23, 284);
            this.btnEditPic.Name = "btnEditPic";
            this.btnEditPic.Size = new System.Drawing.Size(75, 23);
            this.btnEditPic.TabIndex = 34;
            this.btnEditPic.Text = "Edit";
            this.btnEditPic.UseVisualStyleBackColor = true;
            this.btnEditPic.Click += new System.EventHandler(this.btnEditPic_Click);
            this.btnEditPic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Personal_Information_KeyDown);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnChangePassword.Location = new System.Drawing.Point(352, 401);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(102, 39);
            this.btnChangePassword.TabIndex = 35;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            this.btnChangePassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Personal_Information_KeyDown);
            // 
            // picPhotoID
            // 
            this.picPhotoID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPhotoID.Location = new System.Drawing.Point(23, 84);
            this.picPhotoID.Name = "picPhotoID";
            this.picPhotoID.Size = new System.Drawing.Size(145, 194);
            this.picPhotoID.TabIndex = 28;
            this.picPhotoID.TabStop = false;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(246, 206);
            this.txtPhoneNumber.Mask = "(999) 000 00 00";
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(203, 20);
            this.txtPhoneNumber.TabIndex = 25;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            this.txtPhoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Personal_Information_KeyDown);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnSaveChanges.Location = new System.Drawing.Point(246, 401);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(100, 39);
            this.btnSaveChanges.TabIndex = 37;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            this.btnSaveChanges.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Personal_Information_KeyDown);
            // 
            // lblMinimumSalary
            // 
            this.lblMinimumSalary.AutoSize = true;
            this.lblMinimumSalary.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMinimumSalary.Location = new System.Drawing.Point(247, 344);
            this.lblMinimumSalary.Name = "lblMinimumSalary";
            this.lblMinimumSalary.Size = new System.Drawing.Size(80, 13);
            this.lblMinimumSalary.TabIndex = 39;
            this.lblMinimumSalary.Text = "Minimum Salary";
            // 
            // txtMinimumSalary
            // 
            this.txtMinimumSalary.Location = new System.Drawing.Point(246, 360);
            this.txtMinimumSalary.Name = "txtMinimumSalary";
            this.txtMinimumSalary.ReadOnly = true;
            this.txtMinimumSalary.Size = new System.Drawing.Size(203, 20);
            this.txtMinimumSalary.TabIndex = 38;
            // 
            // Personal_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(500, 533);
            this.Controls.Add(this.lblMinimumSalary);
            this.Controls.Add(this.txtMinimumSalary);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnEditPic);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.picPhotoID);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Personal_Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Personal_Information_FormClosing);
            this.Load += new System.EventHandler(this.Personal_Information_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Personal_Information_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picPhotoID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.PictureBox picPhotoID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnEditPic;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.MaskedTextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblMinimumSalary;
        private System.Windows.Forms.TextBox txtMinimumSalary;
    }
}