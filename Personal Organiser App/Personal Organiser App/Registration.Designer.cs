﻿namespace Personal_Organiser_App
{
    partial class Registration
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
            this.lblNewUser = new System.Windows.Forms.Label();
            this.picUserIcon = new System.Windows.Forms.PictureBox();
            this.txtRegisterUsername = new System.Windows.Forms.TextBox();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblUsernsame = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewUser
            // 
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUser.ForeColor = System.Drawing.Color.White;
            this.lblNewUser.Location = new System.Drawing.Point(144, 98);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(190, 42);
            this.lblNewUser.TabIndex = 0;
            this.lblNewUser.Text = "New User";
            this.lblNewUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picUserIcon
            // 
            this.picUserIcon.Image = global::Personal_Organiser_App.Properties.Resources.user_icon;
            this.picUserIcon.Location = new System.Drawing.Point(177, 12);
            this.picUserIcon.Name = "picUserIcon";
            this.picUserIcon.Size = new System.Drawing.Size(129, 81);
            this.picUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserIcon.TabIndex = 1;
            this.picUserIcon.TabStop = false;
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.Location = new System.Drawing.Point(137, 231);
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Size = new System.Drawing.Size(213, 20);
            this.txtRegisterUsername.TabIndex = 0;
            this.txtRegisterUsername.TextChanged += new System.EventHandler(this.txtRegisterUsername_TextChanged);
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Location = new System.Drawing.Point(137, 303);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.PasswordChar = '•';
            this.txtRegisterPassword.Size = new System.Drawing.Size(213, 20);
            this.txtRegisterPassword.TabIndex = 1;
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnRegister.Location = new System.Drawing.Point(137, 386);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(98, 44);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblUsernsame
            // 
            this.lblUsernsame.AutoSize = true;
            this.lblUsernsame.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblUsernsame.Location = new System.Drawing.Point(76, 234);
            this.lblUsernsame.Name = "lblUsernsame";
            this.lblUsernsame.Size = new System.Drawing.Size(55, 13);
            this.lblUsernsame.TabIndex = 5;
            this.lblUsernsame.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblPassword.Location = new System.Drawing.Point(76, 306);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnCancel.Location = new System.Drawing.Point(253, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 44);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(500, 572);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsernsame);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.txtRegisterUsername);
            this.Controls.Add(this.lblNewUser);
            this.Controls.Add(this.picUserIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewUser;
        private System.Windows.Forms.PictureBox picUserIcon;
        private System.Windows.Forms.TextBox txtRegisterUsername;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblUsernsame;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnCancel;
    }
}