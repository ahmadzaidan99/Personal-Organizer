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

namespace Personal_Organiser_App
{
    public partial class Reminders : Form
    {
        string oldSummaryText = string.Empty;

        public Reminders()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage myForm = new MainPage();
            myForm.ShowDialog();
        }

        public void Reminders_Load(object sender, EventArgs e)
        {
            dtpDatePicker.Value = DateTime.Now;
            dtpTimePicker.Value = DateTime.Now;
            cmbType.SelectedIndex = 0;
            timer1 = new System.Windows.Forms.Timer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            timer1.Start();
            btnListReminders_Click(sender, e);
        }

        private void Clear()
        {
            txtSummary.Clear();
            txtDescription.Clear();
            cmbType.SelectedIndex = 0;
            dtpDatePicker.Value = DateTime.Now;
            dtpTimePicker.Value = DateTime.Now;
        }
        private void txtSummary_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[A-Za-z ]+$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(txtSummary.Text) == true || string.IsNullOrEmpty(txtSummary.Text)){
                oldSummaryText = txtSummary.Text;
                txtSummary.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.txtSummary.Text);
                txtSummary.Select(txtSummary.Text.Length, 0);
            }
            else
            {
                txtSummary.Text = oldSummaryText;
                txtSummary.Select(txtSummary.Text.Length, 0);
            }
        }

        private void dgvReminders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dtpDatePicker.Value = Convert.ToDateTime(dgvReminders.Rows[e.RowIndex].Cells[0].Value.ToString());
                dtpTimePicker.Value = Convert.ToDateTime(dgvReminders.Rows[e.RowIndex].Cells[1].Value.ToString());
                txtSummary.Text = dgvReminders.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDescription.Text = dgvReminders.Rows[e.RowIndex].Cells[4].Value.ToString();

                if (dgvReminders.Rows[e.RowIndex].Cells[2].Value.ToString() == "Meeting")
                {
                    cmbType.SelectedIndex = 0;
                }
                else
                {
                    cmbType.SelectedIndex = 1;
                }
            }
            catch (Exception x)
            {
            }
        }

        private void btnAddReminder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSummary.Text))
            {
                MessageBox.Show("Summary field empty. Type in a summary for the reminder", "Required Fields Not Filled!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string entry = "";
                string[] str = txtDescription.Lines;
                txtDescription.Text = "";
                foreach (string strTemp in str)
                {
                    if (strTemp.Trim().Length != 0)
                        txtDescription.Text += strTemp + "##NL##";
                    if (strTemp.Trim().Length == 0)
                        txtDescription.Text += "##NL##";
                }
                if (txtDescription.Text.Contains(","))
                {
                    txtDescription.Text = txtDescription.Text.Replace(",", "##CO##");
                }
                entry += User.curr + "," + dtpDatePicker.Value.ToString() + "," + dtpTimePicker.Value.ToString() + "," + cmbType.Text + ","
                    + txtSummary.Text + "," + txtDescription.Text;
                Console.WriteLine(dtpTimePicker.Value.ToString());
                IO.AddReminder(entry);
                IO.ReadRemindersList(User.curr);
                Clear();
                btnListReminders_Click(sender, e);
            }
        }

        private void btnListReminders_Click(object sender, EventArgs e)
        {
            dgvReminders.Rows.Clear();
            dgvReminders.Refresh();
            string reminders = IO.ReadRemindersList(User.curr);
            if (reminders == "FileNotFound") { return; }
            for(int i =0; i < User.userList[User.curr].remindersList.Count; i++)
            {
                if (User.userList[User.curr].remindersList[i].description.Contains("##CO##"))
                {
                    User.userList[User.curr].remindersList[i].description = User.userList[User.curr].remindersList[i].description.Replace( "##CO##","," );
                }
                if (User.userList[User.curr].remindersList[i].description.Contains("##NL##"))
                {
                    User.userList[User.curr].remindersList[i].description = User.userList[User.curr].remindersList[i].description.Replace("##NL##",Environment.NewLine);
                }
                dgvReminders.Rows.Add(User.userList[User.curr].remindersList[i].Date, User.userList[User.curr].remindersList[i].Time,
                    User.userList[User.curr].remindersList[i].type, User.userList[User.curr].remindersList[i].summary,
                    User.userList[User.curr].remindersList[i].description);
            }
        }

        private void btnDeleteReminder_Click(object sender, EventArgs e)
        {
            if (dgvReminders.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvReminders.SelectedRows)
                {
                    try
                    {
                        int index = dgvReminders.SelectedRows[0].Index;
                        dgvReminders.Rows.Remove(row);
                        IO.DeleteReminder(index);
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message, "Deletion Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                btnListReminders_Click(sender, e);
            }
            else
            {
                MessageBox.Show("You have not selected any Reminders. Select Reminder to delete!", "Deletion Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditReminder_Click(object sender, EventArgs e)
        {
            if (dgvReminders.SelectedRows.Count > 0)
            {
                int index = dgvReminders.SelectedRows[0].Index;
                IO.DeleteReminder(index);
                btnAddReminder_Click(sender, e);
                btnListReminders_Click(sender, e);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Form currentForm = Form.ActiveForm;
                if (currentForm.Name == "LogInPage" || currentForm.Name == "Registration") { timer1.Enabled = false; }
                if (!(currentForm.Name == "LogInPage" || currentForm.Name == "Registration"))
                {
                    for (int i = 0; i < User.userList[User.curr].remindersList.Count; i++)
                    {
                        if ((DateTime.Now.Date >= User.userList[User.curr].remindersList[i].Date.Date)&&
                            (DateTime.Now.Hour >= User.userList[User.curr].remindersList[i].Time.Hour)&&
                            (DateTime.Now.Minute >= User.userList[User.curr].remindersList[i].Time.Minute))
                        {
                            IO.DeleteReminder(i);
                            Shake(currentForm);
                            try
                            {
                                string formName = currentForm.Text;
                                currentForm.Text = User.userList[User.curr].remindersList[i].summary;
                                string reminderType = User.userList[User.curr].remindersList[i].type;
                                string reminderTime = User.userList[User.curr].remindersList[i].Time.Hour.ToString() + ":" +
                                    User.userList[User.curr].remindersList[i].Time.Minute.ToString()+" ";
                                MessageBox.Show(this, reminderTime + reminderType + ":\n\n" + User.userList[User.curr].remindersList[i].description,
                                    User.userList[User.curr].remindersList[i].summary, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                currentForm.Text = formName;                            
                            }
                            catch (Exception) { }
                            btnListReminders_Click(sender, e);
                        }
                    }
                }
            }
            catch (Exception) { }
        }
        public static void Shake(Form form)
        {
            try
            {
                var original = form.Location;
                var rnd = new Random(1337);
                const int shake_amplitude = 10;
                for (int i = 0; i < 10; i++)
                {
                    form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                    System.Threading.Thread.Sleep(20);
                }
                form.Location = original;
            }
            catch (Exception) { }
        }

        private void Reminders_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
