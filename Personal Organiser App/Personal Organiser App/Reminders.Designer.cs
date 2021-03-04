namespace Personal_Organiser_App
{
    partial class Reminders
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvReminders = new System.Windows.Forms.DataGridView();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeCcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListReminders = new System.Windows.Forms.Button();
            this.btnAddReminder = new System.Windows.Forms.Button();
            this.btnEditReminder = new System.Windows.Forms.Button();
            this.btnDeleteReminder = new System.Windows.Forms.Button();
            this.dtpDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dtpTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 27;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgvReminders
            // 
            this.dgvReminders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReminders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReminders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReminders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReminders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateColumn,
            this.timeCcolumn,
            this.typeColumn,
            this.summaryColumn,
            this.descriptionnColumn});
            this.dgvReminders.Location = new System.Drawing.Point(12, 67);
            this.dgvReminders.Name = "dgvReminders";
            this.dgvReminders.ReadOnly = true;
            this.dgvReminders.RowHeadersVisible = false;
            this.dgvReminders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReminders.Size = new System.Drawing.Size(460, 165);
            this.dgvReminders.TabIndex = 28;
            this.dgvReminders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReminders_CellClick);
            // 
            // dateColumn
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dateColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dateColumn.HeaderText = "Date";
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            this.dateColumn.Width = 55;
            // 
            // timeCcolumn
            // 
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            this.timeCcolumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.timeCcolumn.HeaderText = "Time";
            this.timeCcolumn.Name = "timeCcolumn";
            this.timeCcolumn.ReadOnly = true;
            this.timeCcolumn.Width = 55;
            // 
            // typeColumn
            // 
            this.typeColumn.HeaderText = "Type";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.ReadOnly = true;
            this.typeColumn.Width = 56;
            // 
            // summaryColumn
            // 
            this.summaryColumn.HeaderText = "Summary";
            this.summaryColumn.Name = "summaryColumn";
            this.summaryColumn.ReadOnly = true;
            this.summaryColumn.Width = 75;
            // 
            // descriptionnColumn
            // 
            this.descriptionnColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionnColumn.HeaderText = "Description";
            this.descriptionnColumn.Name = "descriptionnColumn";
            this.descriptionnColumn.ReadOnly = true;
            // 
            // btnListReminders
            // 
            this.btnListReminders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListReminders.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnListReminders.Location = new System.Drawing.Point(12, 444);
            this.btnListReminders.Name = "btnListReminders";
            this.btnListReminders.Size = new System.Drawing.Size(75, 38);
            this.btnListReminders.TabIndex = 29;
            this.btnListReminders.Text = "List Reminders";
            this.btnListReminders.UseVisualStyleBackColor = true;
            this.btnListReminders.Click += new System.EventHandler(this.btnListReminders_Click);
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReminder.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnAddReminder.Location = new System.Drawing.Point(140, 444);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(75, 38);
            this.btnAddReminder.TabIndex = 30;
            this.btnAddReminder.Text = "Add Reminder";
            this.btnAddReminder.UseVisualStyleBackColor = true;
            this.btnAddReminder.Click += new System.EventHandler(this.btnAddReminder_Click);
            // 
            // btnEditReminder
            // 
            this.btnEditReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditReminder.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnEditReminder.Location = new System.Drawing.Point(268, 444);
            this.btnEditReminder.Name = "btnEditReminder";
            this.btnEditReminder.Size = new System.Drawing.Size(75, 38);
            this.btnEditReminder.TabIndex = 31;
            this.btnEditReminder.Text = "Edit Reminder";
            this.btnEditReminder.UseVisualStyleBackColor = true;
            this.btnEditReminder.Click += new System.EventHandler(this.btnEditReminder_Click);
            // 
            // btnDeleteReminder
            // 
            this.btnDeleteReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteReminder.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnDeleteReminder.Location = new System.Drawing.Point(397, 444);
            this.btnDeleteReminder.Name = "btnDeleteReminder";
            this.btnDeleteReminder.Size = new System.Drawing.Size(75, 38);
            this.btnDeleteReminder.TabIndex = 32;
            this.btnDeleteReminder.Text = "Delete Reminder";
            this.btnDeleteReminder.UseVisualStyleBackColor = true;
            this.btnDeleteReminder.Click += new System.EventHandler(this.btnDeleteReminder_Click);
            // 
            // dtpDatePicker
            // 
            this.dtpDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatePicker.Location = new System.Drawing.Point(46, 244);
            this.dtpDatePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpDatePicker.Name = "dtpDatePicker";
            this.dtpDatePicker.Size = new System.Drawing.Size(86, 20);
            this.dtpDatePicker.TabIndex = 33;
            this.dtpDatePicker.Value = new System.DateTime(2020, 5, 4, 0, 0, 0, 0);
            // 
            // dtpTimePicker
            // 
            this.dtpTimePicker.CustomFormat = "HH:mm";
            this.dtpTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimePicker.Location = new System.Drawing.Point(46, 270);
            this.dtpTimePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpTimePicker.Name = "dtpTimePicker";
            this.dtpTimePicker.ShowUpDown = true;
            this.dtpTimePicker.Size = new System.Drawing.Size(52, 20);
            this.dtpTimePicker.TabIndex = 34;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Meeting",
            "Task"});
            this.cmbType.Location = new System.Drawing.Point(46, 296);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(61, 21);
            this.cmbType.TabIndex = 35;
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(223, 244);
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(232, 20);
            this.txtSummary.TabIndex = 36;
            this.txtSummary.TextChanged += new System.EventHandler(this.txtSummary_TextChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDate.Location = new System.Drawing.Point(12, 250);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 37;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(12, 276);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 38;
            this.lblTime.Text = "Time:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblType.Location = new System.Drawing.Point(12, 299);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 39;
            this.lblType.Text = "Type:";
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsReturn = true;
            this.txtDescription.Location = new System.Drawing.Point(223, 276);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(232, 143);
            this.txtDescription.TabIndex = 40;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSummary.Location = new System.Drawing.Point(164, 247);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(53, 13);
            this.lblSummary.TabIndex = 41;
            this.lblSummary.Text = "Summary:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescription.Location = new System.Drawing.Point(154, 279);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 42;
            this.lblDescription.Text = "Description:";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Reminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(484, 494);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.dtpTimePicker);
            this.Controls.Add(this.dtpDatePicker);
            this.Controls.Add(this.btnDeleteReminder);
            this.Controls.Add(this.btnEditReminder);
            this.Controls.Add(this.btnAddReminder);
            this.Controls.Add(this.btnListReminders);
            this.Controls.Add(this.dgvReminders);
            this.Controls.Add(this.btnReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Reminders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reminders_FormClosing);
            this.Load += new System.EventHandler(this.Reminders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvReminders;
        private System.Windows.Forms.Button btnListReminders;
        private System.Windows.Forms.Button btnAddReminder;
        private System.Windows.Forms.Button btnEditReminder;
        private System.Windows.Forms.Button btnDeleteReminder;
        private System.Windows.Forms.DateTimePicker dtpDatePicker;
        private System.Windows.Forms.DateTimePicker dtpTimePicker;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeCcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionnColumn;
        private System.Windows.Forms.Timer timer1;
    }
}