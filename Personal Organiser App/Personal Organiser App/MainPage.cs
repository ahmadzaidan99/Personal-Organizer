﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Personal_Organiser_App
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            Reminders myForm = new Reminders();
            myForm.Reminders_Load(sender, e);
            myForm.Hide();
            lblWelcome.Text = "Welcome " + User.userList[User.curr].username;
            if (User.userList[User.curr].userType == "Admin")
            {
                btnUserManagement.Visible = true; //change
            }
            else
            {
                btnUserManagement.Visible = false; //change
            }
        }
        private void btnSignout_Click(object sender, EventArgs e) //change name
        {
            User.userList[User.curr].remember = false;
            IO.WriteUserList("mydb.csv");
            this.Hide();
            LogInPage myForm1 = new LogInPage();
            myForm1.ShowDialog();
            this.Close();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)//change name
        {
            User_Managment myForm = new User_Managment();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnPhonebook_Click(object sender, EventArgs e)//change name
        {
            Phonebook myForm = new Phonebook();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnNotes_Click(object sender, EventArgs e) //change name
        {
            Notes myForm = new Notes();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnPersonalInformation_Click(object sender, EventArgs e)
        {
            Personal_Information myForm = new Personal_Information(User.curr,false);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnSalaryCalculator_Click(object sender, EventArgs e) {
            Salary myForm = new Salary();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnReminders_Click(object sender, EventArgs e)
        {
            Reminders myForm = new Reminders();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
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