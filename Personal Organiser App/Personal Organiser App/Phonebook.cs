using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Personal_Organiser_App
{
    public partial class Phonebook : Form
    {
        public Phonebook()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage myForm = new MainPage();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnListContacts_Click(object sender, EventArgs e)
        {
            dgvContacts.Rows.Clear();
            dgvContacts.Refresh();
            string phonebook = IO.ReadPhonebook(User.curr);
            if (phonebook == "FileNotFound") { return; }
            var values = phonebook.Split(',');
            for (int i = 0; i < values.Length-6; i += 7)
            {
                if (values[i + 5].Contains("##CO##"))
                {
                    values[i + 5] = values[i + 5].Replace("##CO##", ",");
                }
                if (values[i + 6].Contains("##CO##"))
                {
                    values[i + 6] = values[i + 6].Replace("##CO##", ",");
                }
                dgvContacts.Rows.Add(values[i + 1], values[i + 2], values[i + 3], values[i + 4], values[i + 5], values[i + 6]);
            }
            dgvContacts.Refresh();
        }

        private void btnCreateContact_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text) || !txtPhoneNo.MaskFull)
            {
                MessageBox.Show("Fill in all required fields!", "Required Fields Not Filled!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!EmailChecker(txtEmailAddress.Text))
            {
                    MessageBox.Show("Enter an Email address in the form username@company.com", "Invalid Email Address!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
            }
            else {
                string entry = "";
                if (txtAddress.Text.Contains(","))
                {
                    txtAddress.Text = txtAddress.Text.Replace(",", "##CO##");
                }
                if (txtDescription.Text.Contains(","))
                {
                    txtDescription.Text = txtDescription.Text.Replace(",", "##CO##");
                }
                entry = User.curr + "," + txtFirstName.Text + "," + txtSurname.Text + "," + txtPhoneNo.Text + "," +
                    txtEmailAddress.Text + "," + txtAddress.Text + "," + txtDescription.Text;
                if (!IO.IsDuplicateEntry(entry))
                {
                    IO.AddEntry(entry, "phonebook.csv");
                    Clear();
                    btnListContacts_Click(sender, e);
                }
                else
                {
                    if (txtAddress.Text.Contains("##CO##"))
                    {
                        txtAddress.Text = txtAddress.Text.Replace("##CO##", ",");
                    }
                    if (txtDescription.Text.Contains("##CO##"))
                    {
                        txtDescription.Text = txtDescription.Text.Replace("##CO##", ",");
                    }
                    if (MessageBox.Show("Contact already exists. Add anyway?", "Add Duplicate?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        IO.AddEntry(entry, "phonebook.csv");
                        Clear();
                        btnListContacts_Click(sender, e);
                    }
                }
            }
        }

        private void btnEditContact_Click(object sender, EventArgs e) {
            if (dgvContacts.SelectedRows.Count > 0) {
                int index = dgvContacts.SelectedRows[0].Index;
                IO.DeleteEntry(index, "phonebook.csv");
                btnCreateContact_Click(sender, e);
                btnListContacts_Click(sender, e);
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e) {
            if(dgvContacts.SelectedRows.Count > 0) {
                foreach (DataGridViewRow row in dgvContacts.SelectedRows)
                {
                    try
                    {
                        int index = dgvContacts.SelectedRows[0].Index;
                        dgvContacts.Rows.Remove(row);
                        IO.DeleteEntry(index, "phonebook.csv");
                    }
                    catch(Exception x)
                    {
                        MessageBox.Show(x.Message, "Deletion Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                btnListContacts_Click(sender, e);
            }
            else {
                MessageBox.Show("You have not selected any contacts. Select contacts to delete!", "Deletion Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static public bool EmailChecker(string emailAddress)
        {
            if (!string.IsNullOrWhiteSpace(emailAddress))
            {
                try
                {
                    System.Net.Mail.MailAddress m = new System.Net.Mail.MailAddress(emailAddress);
                    return true;
                }
                catch (FormatException)
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        string oldText = string.Empty;
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[A-Za-z ]+$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(txtFirstName.Text) == true)
            {
                oldText = txtFirstName.Text;
                txtFirstName.Text = oldText;
                txtFirstName.BackColor = System.Drawing.Color.FromArgb(128, 128, 128);
                txtFirstName.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                if (txtFirstName.Text.Length == 0)
                {
                    txtFirstName.BackColor = System.Drawing.Color.FromArgb(128,128,128);
                    txtFirstName.ForeColor = System.Drawing.Color.White;
                    oldText = txtFirstName.Text;
                }
                else
                {
                    txtFirstName.Text = oldText;
                    txtFirstName.BackColor = System.Drawing.Color.Red;
                    txtFirstName.ForeColor = System.Drawing.Color.White;
                }
            }
            txtFirstName.SelectionStart = txtFirstName.Text.Length;
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[A-Za-z ]+$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(txtSurname.Text) == true)
            {
                oldText = txtSurname.Text;
                txtSurname.Text = oldText;
                txtSurname.BackColor = System.Drawing.Color.FromArgb(128,128,128);
                txtSurname.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                if (txtSurname.Text.Length == 0)
                {
                    txtSurname.BackColor = System.Drawing.Color.FromArgb(128,128,128);
                    txtSurname.ForeColor = System.Drawing.Color.White;
                    oldText = txtSurname.Text;
                }
                else
                {
                    txtSurname.Text = oldText;
                    txtSurname.BackColor = System.Drawing.Color.Red;
                    txtSurname.ForeColor = System.Drawing.Color.White;
                }
            }
            txtSurname.SelectionStart = txtSurname.Text.Length;
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            txtFirstName.BackColor = System.Drawing.Color.FromArgb(128,128,128);
            txtFirstName.ForeColor = System.Drawing.Color.White;
            oldText = string.Empty;
        }

        private void txtSurname_Leave(object sender, EventArgs e)
        {
            txtSurname.BackColor = System.Drawing.Color.FromArgb(128,128,128);
            txtSurname.ForeColor = System.Drawing.Color.White;
            oldText = string.Empty;
        }
        private void dgvContacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtFirstName.Text = dgvContacts.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSurname.Text = dgvContacts.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPhoneNo.Text = dgvContacts.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmailAddress.Text = dgvContacts.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtAddress.Text = dgvContacts.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDescription.Text = dgvContacts.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception x)
            {
            }
        }
       
        private void Clear()
        {
            txtFirstName.Text = "";
            txtSurname.Text = "";
            txtPhoneNo.Text = "";
            txtEmailAddress.Text = "";
            txtAddress.Text = "";
            txtDescription.Text = "";
        }

        private void Phonebook_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the app?", "Exit App?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Phonebook_Load(object sender, EventArgs e)
        {
            Reminders myForm = new Reminders();
            myForm.Reminders_Load(sender, e);
            myForm.Hide();
        }
    }
}
