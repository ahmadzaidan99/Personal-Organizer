namespace Personal_Organiser_App {
    partial class Notes {
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
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnCreateNote = new System.Windows.Forms.Button();
            this.btnEditNote = new System.Windows.Forms.Button();
            this.btnDeleteNote = new System.Windows.Forms.Button();
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            this.Notes_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnList = new System.Windows.Forms.Button();
            this.lblAllNotes = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(50, 221);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(406, 133);
            this.txtNote.TabIndex = 0;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNote.Location = new System.Drawing.Point(9, 224);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(33, 13);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "Note:";
            // 
            // btnCreateNote
            // 
            this.btnCreateNote.Location = new System.Drawing.Point(50, 384);
            this.btnCreateNote.Name = "btnCreateNote";
            this.btnCreateNote.Size = new System.Drawing.Size(405, 34);
            this.btnCreateNote.TabIndex = 2;
            this.btnCreateNote.Text = "Create Note";
            this.btnCreateNote.UseVisualStyleBackColor = true;
            this.btnCreateNote.Click += new System.EventHandler(this.btnCreateNote_Click);
            // 
            // btnEditNote
            // 
            this.btnEditNote.Location = new System.Drawing.Point(222, 451);
            this.btnEditNote.Name = "btnEditNote";
            this.btnEditNote.Size = new System.Drawing.Size(65, 34);
            this.btnEditNote.TabIndex = 4;
            this.btnEditNote.Text = "Edit Note";
            this.btnEditNote.UseVisualStyleBackColor = true;
            this.btnEditNote.Click += new System.EventHandler(this.btnEditNote_Click);
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.Location = new System.Drawing.Point(381, 451);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(75, 34);
            this.btnDeleteNote.TabIndex = 4;
            this.btnDeleteNote.Text = "Delete Note";
            this.btnDeleteNote.UseVisualStyleBackColor = true;
            this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
            // 
            // dgvNotes
            // 
            this.dgvNotes.AllowUserToAddRows = false;
            this.dgvNotes.AllowUserToDeleteRows = false;
            this.dgvNotes.AllowUserToResizeColumns = false;
            this.dgvNotes.AllowUserToResizeRows = false;
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Notes_Col,
            this.NoteNameCol});
            this.dgvNotes.Location = new System.Drawing.Point(49, 81);
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.ReadOnly = true;
            this.dgvNotes.RowHeadersVisible = false;
            this.dgvNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotes.Size = new System.Drawing.Size(407, 121);
            this.dgvNotes.TabIndex = 10;
            this.dgvNotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotes_CellClick);
            // 
            // Notes_Col
            // 
            this.Notes_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Notes_Col.HeaderText = "";
            this.Notes_Col.Name = "Notes_Col";
            this.Notes_Col.ReadOnly = true;
            this.Notes_Col.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Notes_Col.Visible = false;
            // 
            // NoteNameCol
            // 
            this.NoteNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NoteNameCol.HeaderText = "                                                           Notes";
            this.NoteNameCol.Name = "NoteNameCol";
            this.NoteNameCol.ReadOnly = true;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(50, 451);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(63, 34);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "List Notes";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // lblAllNotes
            // 
            this.lblAllNotes.AutoSize = true;
            this.lblAllNotes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAllNotes.Location = new System.Drawing.Point(47, 65);
            this.lblAllNotes.Name = "lblAllNotes";
            this.lblAllNotes.Size = new System.Drawing.Size(52, 13);
            this.lblAllNotes.TabIndex = 16;
            this.lblAllNotes.Text = "All Notes:";
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 17;
            this.btnReturn.Text = "Return Home";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(500, 533);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblAllNotes);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.dgvNotes);
            this.Controls.Add(this.btnDeleteNote);
            this.Controls.Add(this.btnEditNote);
            this.Controls.Add(this.btnCreateNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txtNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Notes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notes_FormClosing);
            this.Load += new System.EventHandler(this.Notes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnCreateNote;
        private System.Windows.Forms.Button btnEditNote;
        private System.Windows.Forms.Button btnDeleteNote;
        private System.Windows.Forms.DataGridView dgvNotes;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label lblAllNotes;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteNameCol;
    }
}