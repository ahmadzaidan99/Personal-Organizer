using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Personal_Organiser_App
{
    public partial class Set_New_Password : Form
    {
        int userID;
        public Set_New_Password(int userID)
        {
            InitializeComponent();
            btnConfirm.Enabled = false;
            this.userID = userID;
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            pnlProgress.Visible = false;
            if (!string.IsNullOrEmpty(txtNewPassword.Text))
            {
                btnConfirm.Enabled = true;
            }
            else
            {
                btnConfirm.Enabled = false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Hash.sha256(txtNewPassword.Text) != User.userList[userID].password)
            {
                User.userList[userID].password = Hash.sha256(txtNewPassword.Text);
                MessageBox.Show("Password successfully changed", "Password Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnConfirm.Enabled = false;
                IO.WriteUserList("mydb.csv");

                if(MessageBox.Show("Send updated password to user's email?", "Send Email?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SendEmail();
                }
            }
            else
            {
                MessageBox.Show("You have entered " + User.userList[userID].username + "'s existing password.\nEnter a new password."
                    , "Enter New Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Clear();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            User_Managment myForm = new User_Managment();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnReturn_Click(sender, e);
        }

        private void Set_New_Password_Load(object sender, EventArgs e)
        {
            lblSetNewPassword.Text += User.userList[userID].username;
            pnlProgress.Visible = false;

            Reminders myForm = new Reminders();
            myForm.Reminders_Load(sender, e);
            myForm.Hide();
        }

        private void SendEmail()
        {
            string receiverAddress = User.userList[userID].emailAddress;

            if (receiverAddress == "")
            {
                MessageBox.Show("This user does not have a registered email address in the system.", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("personalorganiserapp@gmail.com");
                msg.To.Add(User.userList[userID].emailAddress);
                msg.Subject = "Password Reset!";
                msg.Body = "Dear " + User.userList[userID].username + ",\n\nYour password has successfully been reset to: " + txtNewPassword.Text + "\n\nYours," +
                    "\nThe Personal Organiser App Team";

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "personalorganiserapp@gmail.com";
                ntcd.Password = "!qwerty1234";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);
                IntialiseProgressBar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IntialiseProgressBar()
        {
            btnCancel.Enabled = false;
            lblSentEmail.Visible = false;
            pnlProgress.Visible = true;
            prgProgressBar.Minimum = 1;
            prgProgressBar.Maximum = 10000;
            prgProgressBar.Value = 1;
            prgProgressBar.Step = 1;
            lblProgress.Visible = true;
            for (int x = 1; x <= 10000; x++)
            {
                prgProgressBar.Value = x;                
            }
            lblProgress.Text = "Progress: 100%";
            lblSentEmail.Visible = true;            
        }

        private void Set_New_Password_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}