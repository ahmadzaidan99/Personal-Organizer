namespace Personal_Organiser_App
{
    partial class Phonebook
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
            this.txtPhoneNo = new System.Windows.Forms.MaskedTextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.Namecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surnamecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emailcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addresscol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descriptioncol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListContacts = new System.Windows.Forms.Button();
            this.btnCreateContact = new System.Windows.Forms.Button();
            this.btnEditContact = new System.Windows.Forms.Button();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.Gray;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.Info;
            this.txtFirstName.Location = new System.Drawing.Point(131, 59);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(220, 13);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.Gray;
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSurname.Location = new System.Drawing.Point(131, 86);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(220, 13);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.BackColor = System.Drawing.Color.Gray;
            this.txtEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailAddress.ForeColor = System.Drawing.SystemColors.Info;
            this.txtEmailAddress.Location = new System.Drawing.Point(131, 138);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(220, 13);
            this.txtEmailAddress.TabIndex = 3;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.BackColor = System.Drawing.Color.Gray;
            this.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNo.ForeColor = System.Drawing.SystemColors.Info;
            this.txtPhoneNo.Location = new System.Drawing.Point(131, 112);
            this.txtPhoneNo.Mask = "(999) 000 00 00";
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(220, 13);
            this.txtPhoneNo.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFirstName.Location = new System.Drawing.Point(40, 59);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(39, 13);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "Name*";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSurname.Location = new System.Drawing.Point(40, 86);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(53, 13);
            this.lblSurname.TabIndex = 8;
            this.lblSurname.Text = "Surname*";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPhoneNo.Location = new System.Drawing.Point(40, 112);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(59, 13);
            this.lblPhoneNo.TabIndex = 9;
            this.lblPhoneNo.Text = "Phone No*";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmailAddress.Location = new System.Drawing.Point(40, 138);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(32, 13);
            this.lblEmailAddress.TabIndex = 10;
            this.lblEmailAddress.Text = "Email";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDescription.Location = new System.Drawing.Point(40, 187);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAddress.Location = new System.Drawing.Point(40, 162);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Gray;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.ForeColor = System.Drawing.SystemColors.Info;
            this.txtDescription.Location = new System.Drawing.Point(131, 187);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(220, 13);
            this.txtDescription.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Gray;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.ForeColor = System.Drawing.SystemColors.Info;
            this.txtAddress.Location = new System.Drawing.Point(131, 162);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(220, 13);
            this.txtAddress.TabIndex = 4;
            // 
            // dgvContacts
            // 
            this.dgvContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvContacts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvContacts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Namecol,
            this.Surnamecol,
            this.PhoneNumcol,
            this.Emailcol,
            this.Addresscol,
            this.Descriptioncol});
            this.dgvContacts.Location = new System.Drawing.Point(12, 224);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.RowHeadersVisible = false;
            this.dgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContacts.Size = new System.Drawing.Size(476, 226);
            this.dgvContacts.TabIndex = 6;
            this.dgvContacts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContacts_CellClick);
            // 
            // Namecol
            // 
            this.Namecol.HeaderText = "Name";
            this.Namecol.Name = "Namecol";
            this.Namecol.ReadOnly = true;
            this.Namecol.Width = 60;
            // 
            // Surnamecol
            // 
            this.Surnamecol.HeaderText = "Surname";
            this.Surnamecol.Name = "Surnamecol";
            this.Surnamecol.ReadOnly = true;
            this.Surnamecol.Width = 74;
            // 
            // PhoneNumcol
            // 
            this.PhoneNumcol.HeaderText = "Phone-Number";
            this.PhoneNumcol.Name = "PhoneNumcol";
            this.PhoneNumcol.ReadOnly = true;
            this.PhoneNumcol.Width = 103;
            // 
            // Emailcol
            // 
            this.Emailcol.HeaderText = "Email";
            this.Emailcol.Name = "Emailcol";
            this.Emailcol.ReadOnly = true;
            this.Emailcol.Width = 57;
            // 
            // Addresscol
            // 
            this.Addresscol.HeaderText = "Address";
            this.Addresscol.Name = "Addresscol";
            this.Addresscol.ReadOnly = true;
            this.Addresscol.Width = 70;
            // 
            // Descriptioncol
            // 
            this.Descriptioncol.HeaderText = "Description";
            this.Descriptioncol.Name = "Descriptioncol";
            this.Descriptioncol.ReadOnly = true;
            this.Descriptioncol.Width = 85;
            // 
            // btnListContacts
            // 
            this.btnListContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListContacts.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnListContacts.Location = new System.Drawing.Point(25, 483);
            this.btnListContacts.Name = "btnListContacts";
            this.btnListContacts.Size = new System.Drawing.Size(75, 38);
            this.btnListContacts.TabIndex = 7;
            this.btnListContacts.Text = "List Contacts";
            this.btnListContacts.UseVisualStyleBackColor = true;
            this.btnListContacts.Click += new System.EventHandler(this.btnListContacts_Click);
            // 
            // btnCreateContact
            // 
            this.btnCreateContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateContact.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnCreateContact.Location = new System.Drawing.Point(147, 483);
            this.btnCreateContact.Name = "btnCreateContact";
            this.btnCreateContact.Size = new System.Drawing.Size(75, 38);
            this.btnCreateContact.TabIndex = 8;
            this.btnCreateContact.Text = "Create Contact";
            this.btnCreateContact.UseVisualStyleBackColor = true;
            this.btnCreateContact.Click += new System.EventHandler(this.btnCreateContact_Click);
            // 
            // btnEditContact
            // 
            this.btnEditContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditContact.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnEditContact.Location = new System.Drawing.Point(276, 483);
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Size = new System.Drawing.Size(75, 38);
            this.btnEditContact.TabIndex = 18;
            this.btnEditContact.Text = "Edit Contact";
            this.btnEditContact.UseVisualStyleBackColor = true;
            this.btnEditContact.Click += new System.EventHandler(this.btnEditContact_Click);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteContact.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnDeleteContact.Location = new System.Drawing.Point(398, 483);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(75, 38);
            this.btnDeleteContact.TabIndex = 19;
            this.btnDeleteContact.Text = "Delete Contact";
            this.btnDeleteContact.UseVisualStyleBackColor = true;
            this.btnDeleteContact.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(131, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "* required fields";
            // 
            // Phonebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(500, 533);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteContact);
            this.Controls.Add(this.btnEditContact);
            this.Controls.Add(this.btnCreateContact);
            this.Controls.Add(this.btnListContacts);
            this.Controls.Add(this.dgvContacts);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Phonebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phonebook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Phonebook_FormClosing);
            this.Load += new System.EventHandler(this.Phonebook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.MaskedTextBox txtPhoneNo;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surnamecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emailcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Addresscol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descriptioncol;
        private System.Windows.Forms.Button btnListContacts;
        private System.Windows.Forms.Button btnCreateContact;
        private System.Windows.Forms.Button btnEditContact;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.Label label2;
    }
}