﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Personal_Organiser_App
{
    public partial class Personal_Information : Form
    {
        int userID;
        bool fromUserManagement = false;
        public string picPhotoFileName="";
        public bool pictureChanged = false;
        Stack undoStack = new Stack();
        Stack redoStack = new Stack();
        Stack undoStringsStack = new Stack();
        Stack redoStringsStack = new Stack();
        string firstName = string.Empty;
        string surname = string.Empty;
        string phoneNumber = string.Empty;
        string emailAddress = string.Empty;
        string address = string.Empty;
        public bool btnUndo = false;
        public bool btnRedo = false;
        public bool btnImageUndo = false;
        public bool btnImageRedo = false;
        string oldFirstNameText = string.Empty;
        string oldSurnameText = string.Empty;
         
        public Personal_Information(int ID, bool readOnly)
        {
            InitializeComponent();
            userID = ID;
            if (readOnly)
            {
                btnChangePassword.Visible = false;
                btnEditPic.Visible = false;
                btnSaveChanges.Visible = false;
                txtFirstName.ReadOnly = true;
                txtSurname.ReadOnly = true;
                txtPhoneNumber.ReadOnly = true;
                txtEmailAddress.ReadOnly = true;
                txtAddress.ReadOnly = true;
                fromUserManagement = true;
            }
        }
        private void Personal_Information_Load(object sender, EventArgs e)
        {
            Reminders myForm = new Reminders();
            myForm.Reminders_Load(sender, e);
            myForm.Hide();

            IO users = new IO("mydb.csv");
            users.ReadUserList();
            txtFirstName.Text = User.userList[userID].firstName;
            oldFirstNameText = User.userList[userID].firstName;
            txtSurname.Text = User.userList[userID].surname;
            oldSurnameText = User.userList[userID].surname;
            txtPhoneNumber.Text = User.userList[userID].phoneNumber;
            txtEmailAddress.Text = User.userList[userID].emailAddress;
            txtAddress.Text = User.userList[userID].address;
            txtMinimumSalary.Text = "₺" + User.userList[userID].minimumSalary.ToString("0,000.00");
            firstName = txtFirstName.Text;
            surname = txtSurname.Text;
            phoneNumber = txtPhoneNumber.Text;
            emailAddress = txtEmailAddress.Text;
            address = txtAddress.Text;
            Clear();
            ClearUndo();
            btnSaveChanges.Enabled = false;
            if (User.userList[userID].picture != "")
            {
                byte[] byte1 = Convert.FromBase64String(User.userList[userID].picture);
                Bitmap bmp;
                using (var ms = new System.IO.MemoryStream(byte1))
                {
                    bmp = new Bitmap(ms);
                }
                picPhotoID.Image = bmp;
                picPhotoID.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (fromUserManagement)
            {
                this.Hide();
                User_Managment myForm = new User_Managment();
                myForm.ShowDialog();
                this.Close();
            }
            else {
                this.Hide();
                MainPage myForm = new MainPage();
                myForm.ShowDialog();
                this.Close();
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Change_Password myForm = new Change_Password();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnEditPic_Click(object sender, EventArgs e)
        {
            try {
                if (!btnImageUndo && !btnImageRedo)
                {
                    OpenFileDialog dialog = new OpenFileDialog()
                    {
                        Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
                    };
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        Bitmap bit = new Bitmap(dialog.FileName);
                        picPhotoID.Image = bit;
                        undoStringsStack.Push(picPhotoFileName);
                        picPhotoFileName = dialog.FileName;
                        undoStack.Push("6");
                        picPhotoID.SizeMode = PictureBoxSizeMode.StretchImage;
                        btnSaveChanges.Enabled = true;
                        pictureChanged = true;
                    }
                }
                else if (btnImageUndo)
                {
                    string FileName = undoStringsStack.Pop().ToString();
                    redoStringsStack.Push(picPhotoFileName);
                    picPhotoFileName = FileName;
                    if (FileName == "")
                    {
                        picPhotoID.Image = null;
                    }
                    else
                    {
                        Bitmap bit = new Bitmap(FileName);
                        picPhotoID.Image = bit;
                        picPhotoID.SizeMode = PictureBoxSizeMode.StretchImage;
                        btnSaveChanges.Enabled = true;
                        pictureChanged = true;
                    }
                }
                else if (btnImageRedo)
                {
                    string FileName = redoStringsStack.Pop().ToString();
                    undoStringsStack.Push(picPhotoFileName);
                    undoStack.Push("6");
                    Bitmap bit = new Bitmap(FileName);
                    picPhotoID.Image = bit;
                    picPhotoFileName = FileName;
                    picPhotoID.SizeMode = PictureBoxSizeMode.StretchImage;
                    btnSaveChanges.Enabled = true;
                    pictureChanged = true;
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Empty Stack");
            }
        }
        
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {            
            string pattern = "^[A-Za-z ]+$";
            Regex regex = new Regex(pattern);
            if ((regex.IsMatch(txtFirstName.Text) == true || (string.IsNullOrEmpty(txtFirstName.Text))) && (txtFirstName.Text != User.userList[User.curr].firstName))
            {
                oldFirstNameText = txtFirstName.Text;
                txtFirstName.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.txtFirstName.Text);
                txtFirstName.Select(txtFirstName.Text.Length, 0);
                btnSaveChanges.Enabled = true;
                if (!btnUndo)
                {
                    undoStringsStack.Push(firstName);
                    firstName = txtFirstName.Text;
                    undoStack.Push("1");
                    if (!btnRedo) { Clear(); }
                }
            }
            else if(regex.IsMatch(txtFirstName.Text) == false && txtFirstName.Text.Length>0)
            {
                txtFirstName.Text = oldFirstNameText;
                txtFirstName.Select(txtFirstName.Text.Length, 0);
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[A-Za-z ]+$";
            Regex regex = new Regex(pattern);
            if ((regex.IsMatch(txtSurname.Text) == true || (string.IsNullOrEmpty(txtSurname.Text))) && (txtSurname.Text != User.userList[User.curr].surname))
            {
                oldSurnameText = txtSurname.Text;
                txtSurname.Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.txtSurname.Text);
                txtSurname.Select(txtSurname.Text.Length, 0);
                btnSaveChanges.Enabled = true;
                if (!btnUndo)
                {
                    undoStringsStack.Push(surname);
                    surname = txtSurname.Text;
                    undoStack.Push("2");
                    if (!btnRedo) { Clear(); }
                }
            }
            else if(regex.IsMatch(txtSurname.Text) == false && txtSurname.Text.Length > 0)
            {
                txtSurname.Text = oldSurnameText;
                txtSurname.Select(txtSurname.Text.Length, 0);
            }
        }
        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {           
            btnSaveChanges.Enabled = true;
            if (!btnUndo)
            {
                undoStringsStack.Push(phoneNumber);
                phoneNumber = txtPhoneNumber.Text;
                undoStack.Push("3");
                if (!btnRedo) { Clear(); }
            }
        }        

        private void txtEmailAddress_TextChanged(object sender, EventArgs e)
        {
           btnSaveChanges.Enabled = true;
            if (!btnUndo)
            {
                undoStringsStack.Push(emailAddress);
                emailAddress = txtEmailAddress.Text;
                undoStack.Push("4");
                if (!btnRedo) { Clear(); }
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = true;
            if (!btnUndo)
            {
                undoStringsStack.Push(address);
                address = txtAddress.Text;
                undoStack.Push("5");
                if (!btnRedo) { Clear(); }
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (Phonebook.EmailChecker(txtEmailAddress.Text))
            {
                if (pictureChanged)
                {
                    Bitmap bit = new Bitmap(picPhotoFileName);
                    User.userList[User.curr].picture = IO.PhotoBase64(bit);
                }
                User.userList[userID].firstName = txtFirstName.Text;
                User.userList[userID].surname = txtSurname.Text;
                User.userList[userID].phoneNumber = txtPhoneNumber.Text;
                User.userList[userID].emailAddress = txtEmailAddress.Text;
                User.userList[userID].address = txtAddress.Text;                
                btnSaveChanges.Enabled = false;
                pictureChanged = false;
                IO.WriteUserList("mydb.csv");
            }
            else
            {
                MessageBox.Show("Enter an Email address in the form username@company.com", "Invalid Email Address!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Personal_Information_KeyDown(object sender, KeyEventArgs e)
        {
            try {
                if (e.KeyCode == Keys.Z && Control.ModifierKeys == Keys.Control && undoStack.Count > 0)
                {
                    btnUndo = true;
                    btnRedo = false;
                    string popped = undoStack.Pop().ToString();
                    redoStack.Push(popped);
                    if (popped == "1")
                    {
                        txtFirstName.Text = undoStringsStack.Pop().ToString();
                        txtFirstName.Focus();
                        txtFirstName.Select(txtFirstName.Text.Length, 0);
                        redoStringsStack.Push(firstName);
                        firstName = txtFirstName.Text;
                    }
                    if (popped == "2")
                    {
                        txtSurname.Text = undoStringsStack.Pop().ToString();
                        txtSurname.Focus();
                        txtSurname.Select(txtSurname.Text.Length, 0);
                        redoStringsStack.Push(surname);
                        surname = txtSurname.Text;
                    }
                    if (popped == "3")
                    {
                        txtPhoneNumber.Text = undoStringsStack.Pop().ToString();
                        txtPhoneNumber.Focus();
                        txtPhoneNumber.Select(txtPhoneNumber.Text.Length, 0);
                        redoStringsStack.Push(phoneNumber);
                        phoneNumber = txtPhoneNumber.Text;
                    }
                    if (popped == "4")
                    {
                        txtEmailAddress.Text = undoStringsStack.Pop().ToString();
                        txtEmailAddress.Focus();
                        txtEmailAddress.Select(txtEmailAddress.Text.Length, 0);
                        redoStringsStack.Push(emailAddress);
                        emailAddress = txtEmailAddress.Text;
                    }
                    if (popped == "5")
                    {
                        txtAddress.Text = undoStringsStack.Pop().ToString();
                        txtAddress.Focus();
                        txtAddress.Select(txtAddress.Text.Length, 0);
                        redoStringsStack.Push(address);
                        address = txtAddress.Text;
                    }
                    if (popped == "6")
                    {
                        btnImageUndo = true;
                        btnEditPic_Click(sender, e);
                        btnImageUndo = false;
                    }
                }
                else if (e.KeyCode == Keys.Y && Control.ModifierKeys == Keys.Control && redoStack.Count > 0)
                {    
                    btnUndo = false;
                    btnRedo = true;
                    string popped = redoStack.Pop().ToString();
                    if (popped == "1")
                    {
                        txtFirstName.Text = redoStringsStack.Pop().ToString();
                        txtFirstName.Focus();
                        txtFirstName.Select(txtFirstName.Text.Length,0);
                    }
                    if (popped == "2")
                    {
                        txtSurname.Text = redoStringsStack.Pop().ToString();
                        txtSurname.Focus();
                        txtSurname.Select(txtSurname.Text.Length,0);
                    }
                    if (popped == "3")
                    {
                        txtPhoneNumber.Text = redoStringsStack.Pop().ToString();
                        txtPhoneNumber.Focus();
                        txtPhoneNumber.Select(txtPhoneNumber.Text.Length,0);
                    }
                    if (popped == "4")
                    {
                        txtEmailAddress.Text = redoStringsStack.Pop().ToString();
                        txtEmailAddress.Focus();
                        txtEmailAddress.Select(txtEmailAddress.Text.Length,0);
                    }
                    if (popped == "5")
                    {
                        txtAddress.Text = redoStringsStack.Pop().ToString();
                        txtAddress.Focus();
                        txtAddress.Select(txtAddress.Text.Length,0);
                    }
                    if (popped == "6")
                    {
                        btnImageRedo = true;
                        btnEditPic_Click(sender, e);
                        btnImageRedo = false;
                    }
                }
                else
                {
                    btnUndo = false;
                    btnRedo = false;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Empty Stack");
            }
        }
        public void Clear()
        {
            redoStringsStack.Clear();
            redoStack.Clear();
        }
        public void ClearUndo()
        {
            undoStringsStack.Clear();
            undoStack.Clear();
        }

        private void Personal_Information_FormClosing(object sender, FormClosingEventArgs e)
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
