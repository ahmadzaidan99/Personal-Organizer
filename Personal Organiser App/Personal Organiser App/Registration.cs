﻿using System;
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
    public partial class Registration : Form
    {
        string oldRegisterUsernameText = string.Empty;

        public Registration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegisterUsername.Text))
            {
                MessageBox.Show("Please input valid username!", "Invalid username!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtRegisterPassword.Text))
            {
                MessageBox.Show("Please input valid password!", "Invalid password!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool usernameExists = false;
                for (var i = 0; i<User.userList.Count; i++)
                {
                    if (txtRegisterUsername.Text == User.userList[i].username)
                    {
                        usernameExists = true;
                        MessageBox.Show("Error! Username already exits!", "Error! Existing Username!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                }
                if (!usernameExists)
                {
                    if (User.userList.Count > 0) {
                        User user = new User(txtRegisterUsername.Text, Hash.sha256(txtRegisterPassword.Text));
                        user.ID = User.userList.Count;
                        User.AddUserToList(user);
                    }
                    else {
                        User user = new User(txtRegisterUsername.Text, Hash.sha256(txtRegisterPassword.Text),userType:"Admin");
                        user.ID = 0;
                        User.AddUserToList(user);
                    }

                    IO.WriteUserList("mydb.csv");
                    MessageBox.Show("You have succesfuly created a new account!", "Succesful Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LogInPage myForm = new LogInPage();
                    this.Hide();
                    myForm.Activate();
                    myForm.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LogInPage myForm1 = new LogInPage();
            this.Hide();
            myForm1.Activate();
            myForm1.ShowDialog();
            this.Close();
        }

        private void txtRegisterUsername_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[a-zA-Z0-9_]*$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(txtRegisterUsername.Text) == true || string.IsNullOrEmpty(txtRegisterUsername.Text))
            {
                oldRegisterUsernameText = txtRegisterUsername.Text;
                txtRegisterUsername.Select(txtRegisterUsername.Text.Length, 0);            
            }
            else if (regex.IsMatch(txtRegisterUsername.Text) == false && txtRegisterUsername.Text.Length > 0)
            {
                txtRegisterUsername.Text = oldRegisterUsernameText;
                txtRegisterUsername.Select(txtRegisterUsername.Text.Length, 0);
            }
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
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
