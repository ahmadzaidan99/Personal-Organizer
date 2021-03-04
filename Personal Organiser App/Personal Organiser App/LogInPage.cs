using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Organiser_App
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool usernameExists = false;
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please input valid username!", "Invalid username!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please input valid password!", "Invalid password!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (var i = 0; i<User.userList.Count; i++)
                {
                    if (txtUsername.Text == User.userList[i].username)
                    {
                        usernameExists = true;
                        if (Hash.sha256(txtPassword.Text) == User.userList[i].password)
                        {
                            MessageBox.Show("Log-In Successful!","Successful Log-In",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            User.curr = i;
                            if (chkRemember.Checked)
                            {
                                User.userList[i].remember = true;
                                IO.WriteUserList("mydb.csv");
                            }
                            Cursor.Current = Cursors.WaitCursor;
                            System.Threading.Thread.Sleep(3000);
                            this.Hide();
                            MainPage myForm = new MainPage();
                            myForm.ShowDialog();
                            this.Close();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Password is incorrect!", "Incorrect password!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if(!usernameExists)
                MessageBox.Show("Username does not exist!", "Invalid username!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lblCreateNewAccount_Click(object sender, EventArgs e)
        {
            Registration myForm = new Registration();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            FormClosingEventArgs ee = new FormClosingEventArgs(CloseReason.None,false);
            LogInPage_FormClosing(sender, ee);
        }
       
        private void LogInPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the app?", "Exit App?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}