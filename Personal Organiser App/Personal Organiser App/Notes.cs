using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Organiser_App {
    public partial class Notes : Form {
        public Notes() {
            InitializeComponent();
            txtNote.ScrollBars = ScrollBars.Vertical;
        }
        private void btnCreateNote_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtNote.Text)) {
               if(MessageBox.Show("The note is empty! Save anyway?", "Empty Note",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }
            string[] str = txtNote.Lines;
            txtNote.Text = "";
            foreach (string strTemp in str)
            {
                if (strTemp.Trim().Length != 0)
                    txtNote.Text += strTemp + "\r\n";
                if (strTemp.Trim().Length == 0)
                    txtNote.Text += "##NL##";
            }
            try {
                txtNote.Text.Remove(txtNote.Text.Length - 4, 4);
            }
            catch (System.ArgumentOutOfRangeException) {
                return;
            }
            if ( txtNote.Text.Contains(","))
            {
                txtNote.Text =  txtNote.Text.Replace(",", "##CO##");
            }
            string note = User.curr + "," +  txtNote.Text;
            string noteName = string.Empty;
            string newTxt = string.Empty;
            if (note.Contains(Environment.NewLine))
            {
                string[] splitTxt = note.Split(Environment.NewLine.ToCharArray());
                foreach (string s in splitTxt)
                {
                    if (s != string.Empty)
                    {
                        newTxt += string.Format("{0}{1}", s, "##NL##");
                    }
                }
                    noteName = newTxt.Substring(2, newTxt.IndexOf("##NL##") - 2);
            }
            else { 
                newTxt = note;
                noteName =  txtNote.Text;
            }
                
            newTxt += "," + noteName;
            IO.AddEntry(newTxt, "notes.csv");
            txtNote.Text = "";
            btnList_Click(sender, e);            
        }

        private void btnDeleteNote_Click(object sender, EventArgs e) {
            if (dgvNotes.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvNotes.SelectedRows)
                {
                    try
                    {
                        int index = dgvNotes.SelectedRows[0].Index;
                        dgvNotes.Rows.Remove(row);
                        IO.DeleteEntry(index, "notes.csv");
                        txtNote.Text = "";
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message, "Deletion Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                btnList_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No note selected!","No Selected Note!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    
        private void btnList_Click(object sender, EventArgs e) {
            dgvNotes.Rows.Clear();
            dgvNotes.Refresh();
            string notes = IO.ReadNotes(User.curr);
            if ( notes == "FileNotFound") { return; }
            var values = notes.Split(',');
            for (int i = 0; i < values.Length - 2; i += 3)
            {
                if (values[i + 1].Contains("##NL##"))
                {
                    values[i+1]=values[i + 1].Replace("##NL##", Environment.NewLine);
                }
                if (values[i + 1].Contains("##CO##"))
                {
                    values[i + 1] = values[i + 1].Replace("##CO##", ",");
                }
                if (values[i + 2].Contains("##CO##"))
                {
                    values[i + 2] = values[i + 2].Replace("##CO##", ",");
                }
                dgvNotes.Rows.Add(values[i + 1],values[i+2]);
            }
            dgvNotes.Refresh();
        }

        private void btnEditNote_Click(object sender, EventArgs e) {
            if (dgvNotes.SelectedRows.Count > 0)
            {
                int index = dgvNotes.SelectedRows[0].Index;
                IO.DeleteEntry(index, "notes.csv");
                btnCreateNote_Click(sender, e);
                btnList_Click(sender, e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CancelEventArgs cancelEventArgs = new CancelEventArgs();
            OnClosing(sender, cancelEventArgs);
        }

        private void OnClosing(object sender, CancelEventArgs cancelEventArgs)
        {
            DialogResult result = MessageBox.Show("Are you sure want to exit the app?", "Exit App?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                cancelEventArgs.Cancel = true;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage myForm = new MainPage();
            myForm.ShowDialog();
            this.Close();
        }

        private void dgvNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNote.Text = dgvNotes.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Notes_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the app?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Notes_Load(object sender, EventArgs e)
        {
            Reminders myForm = new Reminders();
            myForm.Reminders_Load(sender, e);
            myForm.Hide();
        }
    }
}
