namespace Personal_Organiser_App {
    partial class Salary {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblEducation = new System.Windows.Forms.Label();
            this.lblEnglishLanguage = new System.Windows.Forms.Label();
            this.lblManagerialDuty = new System.Windows.Forms.Label();
            this.lblOtherLanguages = new System.Windows.Forms.Label();
            this.txtOtherLanguages = new System.Windows.Forms.TextBox();
            this.lblFamilyStatus = new System.Windows.Forms.Label();
            this.cmbExperience = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbEducation = new System.Windows.Forms.ComboBox();
            this.cmbEnglishLanguage = new System.Windows.Forms.ComboBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMinimumSalary = new System.Windows.Forms.Label();
            this.chkMarried = new System.Windows.Forms.CheckBox();
            this.chkBabies = new System.Windows.Forms.CheckBox();
            this.chkTeens = new System.Windows.Forms.CheckBox();
            this.chkStudents = new System.Windows.Forms.CheckBox();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.cmbTeens = new System.Windows.Forms.ComboBox();
            this.cmbBabies = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtMinimumSalary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExperience.Location = new System.Drawing.Point(51, 55);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(102, 13);
            this.lblExperience.TabIndex = 0;
            this.lblExperience.Text = "Experience (Years): ";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCity.Location = new System.Drawing.Point(123, 95);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(30, 13);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City: ";
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEducation.Location = new System.Drawing.Point(58, 135);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(95, 13);
            this.lblEducation.TabIndex = 2;
            this.lblEducation.Text = "Higher Education: ";
            // 
            // lblEnglishLanguage
            // 
            this.lblEnglishLanguage.AutoSize = true;
            this.lblEnglishLanguage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEnglishLanguage.Location = new System.Drawing.Point(54, 173);
            this.lblEnglishLanguage.Name = "lblEnglishLanguage";
            this.lblEnglishLanguage.Size = new System.Drawing.Size(98, 13);
            this.lblEnglishLanguage.TabIndex = 3;
            this.lblEnglishLanguage.Text = "English Language: ";
            // 
            // lblManagerialDuty
            // 
            this.lblManagerialDuty.AutoSize = true;
            this.lblManagerialDuty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblManagerialDuty.Location = new System.Drawing.Point(63, 236);
            this.lblManagerialDuty.Name = "lblManagerialDuty";
            this.lblManagerialDuty.Size = new System.Drawing.Size(90, 13);
            this.lblManagerialDuty.TabIndex = 4;
            this.lblManagerialDuty.Text = "Managerial Duty: ";
            // 
            // lblOtherLanguages
            // 
            this.lblOtherLanguages.AutoSize = true;
            this.lblOtherLanguages.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOtherLanguages.Location = new System.Drawing.Point(22, 208);
            this.lblOtherLanguages.Name = "lblOtherLanguages";
            this.lblOtherLanguages.Size = new System.Drawing.Size(131, 13);
            this.lblOtherLanguages.TabIndex = 16;
            this.lblOtherLanguages.Text = "Other Known Languages: ";
            // 
            // txtOtherLanguages
            // 
            this.txtOtherLanguages.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtOtherLanguages.Location = new System.Drawing.Point(152, 205);
            this.txtOtherLanguages.MaxLength = 3;
            this.txtOtherLanguages.Name = "txtOtherLanguages";
            this.txtOtherLanguages.Size = new System.Drawing.Size(309, 20);
            this.txtOtherLanguages.TabIndex = 15;
            this.txtOtherLanguages.TextChanged += new System.EventHandler(this.cboEnglishLanguage_SelectedIndexChanged);
            this.txtOtherLanguages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLangs_KeyPress);
            // 
            // lblFamilyStatus
            // 
            this.lblFamilyStatus.AutoSize = true;
            this.lblFamilyStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFamilyStatus.Location = new System.Drawing.Point(81, 279);
            this.lblFamilyStatus.Name = "lblFamilyStatus";
            this.lblFamilyStatus.Size = new System.Drawing.Size(72, 13);
            this.lblFamilyStatus.TabIndex = 5;
            this.lblFamilyStatus.Text = "Family Status:";
            // 
            // cmbExperience
            // 
            this.cmbExperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExperience.FormattingEnabled = true;
            this.cmbExperience.Items.AddRange(new object[] {
            "0-2",
            "2-4",
            "5-9",
            "10-14",
            "15-20",
            "20+"});
            this.cmbExperience.Location = new System.Drawing.Point(153, 52);
            this.cmbExperience.Name = "cmbExperience";
            this.cmbExperience.Size = new System.Drawing.Size(308, 21);
            this.cmbExperience.TabIndex = 6;
            this.cmbExperience.SelectedIndexChanged += new System.EventHandler(this.cboExperience_SelectedIndexChanged);
            // 
            // cmbCity
            // 
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara ",
            "İzmir",
            "Kocaeli, Sakarya, Düzce, Bolu, Yalova",
            "Edirne, Kırklareli, Tekirdağ",
            "Trabzon, Ordu, Giresun, Rize, Artvin, Gümüşhane",
            "Bursa, Eskişehir, Bilecik",
            "Aydın, Denizli, Muğla",
            "Adana, Mersin",
            "Balıkesir, Çanakkale",
            "Antalya, Isparta, Burdur",
            "Other"});
            this.cmbCity.Location = new System.Drawing.Point(153, 92);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(308, 21);
            this.cmbCity.TabIndex = 7;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cboCity_SelectedIndexChanged);
            // 
            // cmbEducation
            // 
            this.cmbEducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEducation.FormattingEnabled = true;
            this.cmbEducation.Items.AddRange(new object[] {
            "None",
            "Master\'s degree related to the profession",
            "PhD related to the profession",
            "Associate professorship related to profession",
            "Master\'s degree not related to the profession",
            "PhD / associate profession not related to the profession"});
            this.cmbEducation.Location = new System.Drawing.Point(153, 132);
            this.cmbEducation.Name = "cmbEducation";
            this.cmbEducation.Size = new System.Drawing.Size(308, 21);
            this.cmbEducation.TabIndex = 8;
            this.cmbEducation.SelectedIndexChanged += new System.EventHandler(this.cboEducation_SelectedIndexChanged);
            // 
            // cmbEnglishLanguage
            // 
            this.cmbEnglishLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnglishLanguage.FormattingEnabled = true;
            this.cmbEnglishLanguage.Items.AddRange(new object[] {
            "None",
            "Documented English Knowledge",
            "School Graduation with English Education"});
            this.cmbEnglishLanguage.Location = new System.Drawing.Point(153, 170);
            this.cmbEnglishLanguage.Name = "cmbEnglishLanguage";
            this.cmbEnglishLanguage.Size = new System.Drawing.Size(308, 21);
            this.cmbEnglishLanguage.TabIndex = 9;
            this.cmbEnglishLanguage.SelectedIndexChanged += new System.EventHandler(this.cboEnglishLanguage_SelectedIndexChanged);
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Team Leader/Group or Technical Manager/Software Arch.",
            "Project manager",
            "Director / Projects Manager",
            "CTO / General Manager",
            "IT Manager (Maximum 5 IT personals)",
            "IT Manager (More than 5 IT personals)"});
            this.cmbRole.Location = new System.Drawing.Point(153, 236);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(308, 21);
            this.cmbRole.TabIndex = 10;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cboRole_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(222, 466);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblMinimumSalary
            // 
            this.lblMinimumSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMinimumSalary.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMinimumSalary.Location = new System.Drawing.Point(53, 394);
            this.lblMinimumSalary.Name = "lblMinimumSalary";
            this.lblMinimumSalary.Size = new System.Drawing.Size(138, 23);
            this.lblMinimumSalary.TabIndex = 17;
            this.lblMinimumSalary.Text = "Minimum Salary:";
            // 
            // chkMarried
            // 
            this.chkMarried.AutoSize = true;
            this.chkMarried.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkMarried.Location = new System.Drawing.Point(153, 279);
            this.chkMarried.Name = "chkMarried";
            this.chkMarried.Size = new System.Drawing.Size(168, 17);
            this.chkMarried.TabIndex = 18;
            this.chkMarried.Text = "Married (Spouse Unemployed)";
            this.chkMarried.UseVisualStyleBackColor = true;
            this.chkMarried.CheckStateChanged += new System.EventHandler(this.ChkFamily_CheckStateChanged);
            // 
            // chkBabies
            // 
            this.chkBabies.AutoSize = true;
            this.chkBabies.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkBabies.Location = new System.Drawing.Point(153, 302);
            this.chkBabies.Name = "chkBabies";
            this.chkBabies.Size = new System.Drawing.Size(133, 17);
            this.chkBabies.TabIndex = 19;
            this.chkBabies.Text = "Children (0-6 years old)";
            this.chkBabies.UseVisualStyleBackColor = true;
            this.chkBabies.CheckStateChanged += new System.EventHandler(this.ChkFamily_CheckStateChanged);
            // 
            // chkTeens
            // 
            this.chkTeens.AutoSize = true;
            this.chkTeens.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkTeens.Location = new System.Drawing.Point(153, 325);
            this.chkTeens.Name = "chkTeens";
            this.chkTeens.Size = new System.Drawing.Size(139, 17);
            this.chkTeens.TabIndex = 20;
            this.chkTeens.Text = "Children (7-18 years old)";
            this.chkTeens.UseVisualStyleBackColor = true;
            this.chkTeens.CheckStateChanged += new System.EventHandler(this.ChkFamily_CheckStateChanged);
            // 
            // chkStudents
            // 
            this.chkStudents.AutoSize = true;
            this.chkStudents.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chkStudents.Location = new System.Drawing.Point(153, 348);
            this.chkStudents.Name = "chkStudents";
            this.chkStudents.Size = new System.Drawing.Size(142, 17);
            this.chkStudents.TabIndex = 21;
            this.chkStudents.Text = "Children (18+ (Students))";
            this.chkStudents.UseVisualStyleBackColor = true;
            this.chkStudents.CheckStateChanged += new System.EventHandler(this.ChkFamily_CheckStateChanged);
            // 
            // cmbStudents
            // 
            this.cmbStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Items.AddRange(new object[] {
            "1",
            "2+"});
            this.cmbStudents.Location = new System.Drawing.Point(320, 346);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(39, 21);
            this.cmbStudents.TabIndex = 22;
            this.cmbStudents.TextChanged += new System.EventHandler(this.ChkFamily_CheckStateChanged);
            // 
            // cmbTeens
            // 
            this.cmbTeens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeens.FormattingEnabled = true;
            this.cmbTeens.Items.AddRange(new object[] {
            "1",
            "2+"});
            this.cmbTeens.Location = new System.Drawing.Point(320, 323);
            this.cmbTeens.Name = "cmbTeens";
            this.cmbTeens.Size = new System.Drawing.Size(39, 21);
            this.cmbTeens.TabIndex = 23;
            this.cmbTeens.TextChanged += new System.EventHandler(this.ChkFamily_CheckStateChanged);
            // 
            // cmbBabies
            // 
            this.cmbBabies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBabies.FormattingEnabled = true;
            this.cmbBabies.Items.AddRange(new object[] {
            "1",
            "2+"});
            this.cmbBabies.Location = new System.Drawing.Point(320, 298);
            this.cmbBabies.Name = "cmbBabies";
            this.cmbBabies.Size = new System.Drawing.Size(39, 21);
            this.cmbBabies.TabIndex = 24;
            this.cmbBabies.TextChanged += new System.EventHandler(this.ChkFamily_CheckStateChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 26;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtMinimumSalary
            // 
            this.txtMinimumSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMinimumSalary.Location = new System.Drawing.Point(182, 391);
            this.txtMinimumSalary.Name = "txtMinimumSalary";
            this.txtMinimumSalary.ReadOnly = true;
            this.txtMinimumSalary.Size = new System.Drawing.Size(279, 26);
            this.txtMinimumSalary.TabIndex = 39;
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(526, 533);
            this.Controls.Add(this.txtMinimumSalary);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.cmbBabies);
            this.Controls.Add(this.cmbTeens);
            this.Controls.Add(this.cmbStudents);
            this.Controls.Add(this.chkStudents);
            this.Controls.Add(this.chkTeens);
            this.Controls.Add(this.chkBabies);
            this.Controls.Add(this.chkMarried);
            this.Controls.Add(this.lblMinimumSalary);
            this.Controls.Add(this.lblOtherLanguages);
            this.Controls.Add(this.txtOtherLanguages);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.cmbEnglishLanguage);
            this.Controls.Add(this.cmbEducation);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.cmbExperience);
            this.Controls.Add(this.lblFamilyStatus);
            this.Controls.Add(this.lblManagerialDuty);
            this.Controls.Add(this.lblEnglishLanguage);
            this.Controls.Add(this.lblEducation);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblExperience);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Salary_FormClosing);
            this.Load += new System.EventHandler(this.Salary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.Label lblEnglishLanguage;
        private System.Windows.Forms.Label lblManagerialDuty;
        private System.Windows.Forms.Label lblFamilyStatus;
        private System.Windows.Forms.ComboBox cmbExperience;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ComboBox cmbEducation;
        private System.Windows.Forms.ComboBox cmbEnglishLanguage;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblOtherLanguages;
        private System.Windows.Forms.TextBox txtOtherLanguages;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMinimumSalary;
        private System.Windows.Forms.CheckBox chkMarried;
        private System.Windows.Forms.CheckBox chkBabies;
        private System.Windows.Forms.CheckBox chkTeens;
        private System.Windows.Forms.CheckBox chkStudents;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.ComboBox cmbTeens;
        private System.Windows.Forms.ComboBox cmbBabies;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtMinimumSalary;
    }
}