using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Organiser_App
{
    public partial class Change_Password : Form
    {
        Stack undoStack = new Stack();
        Stack redoStack = new Stack();
        Stack undoStringsStack = new Stack();
        Stack redoStringsStack = new Stack();
        string currentPassword="";
        string newPassword="";
        string confirmNewPassword="";
        public bool btnUndo = false;
        public bool btnRedo = false;
        public Change_Password()
        {
            InitializeComponent();
            btnSaveNewPassword.Enabled = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Personal_Information myForm = new Personal_Information(User.curr,false);
            myForm.ShowDialog();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnReturn_Click(sender, e);
        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            btnSaveNewPassword.Enabled = false;
            txtNewPassword.Clear();
            txtConfirmNewPassword.Clear();

            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                txtCurrentPassword.BackColor = SystemColors.Window;
                return;
            }
            else if (Hash.sha256(txtCurrentPassword.Text) == User.userList[User.curr].password)
            {
                txtCurrentPassword.BackColor = System.Drawing.Color.Lime;
                txtNewPassword.ReadOnly = false;
                txtConfirmNewPassword.ReadOnly = false;
            }
            else
            {
                txtCurrentPassword.BackColor = System.Drawing.Color.DarkRed;
                txtNewPassword.ReadOnly = true;
                txtConfirmNewPassword.ReadOnly = true;
            }
            if (!btnUndo)
            {
                undoStringsStack.Push(currentPassword);
                currentPassword = txtCurrentPassword.Text;
                undoStack.Push("1");
                if (!btnRedo) { Clear(); }
            }
        }
        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {          
            txtConfirmNewPassword.Clear();
            txtConfirmNewPassword.BackColor = SystemColors.Window;
            txtNewPassword.BackColor = SystemColors.Window;
            if (!btnUndo)
            {
                undoStringsStack.Push(newPassword);
                newPassword = txtNewPassword.Text;
                undoStack.Push("2");
                if (!btnRedo) { Clear(); }
            }
        }

        private void txtConfirmNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmNewPassword.Text))
            {
                txtConfirmNewPassword.BackColor = SystemColors.Window;
                txtNewPassword.BackColor = SystemColors.Window;
                btnSaveNewPassword.Enabled = false;
            }
            if (txtConfirmNewPassword.Text == txtNewPassword.Text&& !(string.IsNullOrWhiteSpace(txtNewPassword.Text)|| string.IsNullOrWhiteSpace(txtConfirmNewPassword.Text)))
            {
                txtConfirmNewPassword.BackColor = System.Drawing.Color.Lime;
                txtNewPassword.BackColor = System.Drawing.Color.Lime;
                btnSaveNewPassword.Enabled = true;
            }
            else if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                txtConfirmNewPassword.BackColor = SystemColors.Window;
                txtNewPassword.BackColor = SystemColors.Window;
                btnSaveNewPassword.Enabled = false;
            }
            else if(txtConfirmNewPassword.Text != txtNewPassword.Text && !(string.IsNullOrWhiteSpace(txtNewPassword.Text) || string.IsNullOrWhiteSpace(txtConfirmNewPassword.Text))){
                txtConfirmNewPassword.BackColor = System.Drawing.Color.DarkRed;
                txtNewPassword.BackColor = System.Drawing.Color.DarkRed;
                btnSaveNewPassword.Enabled = false;
            }
            if (!btnUndo)
            {
                undoStringsStack.Push(confirmNewPassword);
                confirmNewPassword = txtConfirmNewPassword.Text;
                undoStack.Push("3");
                if (!btnRedo) { Clear(); }
            }
        }

        private void btnSaveNewPassword_Click(object sender, EventArgs e)
        {
            if (txtConfirmNewPassword.BackColor == System.Drawing.Color.Lime)
            {
                if (Hash.sha256(txtConfirmNewPassword.Text) == User.userList[User.curr].password)
                {
                    MessageBox.Show("New password cannot be the same as current password!", "Unuccessful Password Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCurrentPassword.Clear();
                    txtNewPassword.Clear();
                    txtConfirmNewPassword.Clear();
                    txtNewPassword.ReadOnly = true;
                    txtConfirmNewPassword.ReadOnly = true;
                    btnSaveNewPassword.Enabled = false;
                }
                else if(MessageBox.Show("Are you sure you want to change your password?", "Update Password?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    User.userList[User.curr].password = Hash.sha256(txtConfirmNewPassword.Text);
                    IO.WriteUserList("mydb.csv");
                    MessageBox.Show("Password successfully updated!", "Successful Password Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnReturn_Click(sender, e);
                }
            }           
        }

        private void Change_Password_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Z && Control.ModifierKeys == Keys.Control && undoStack.Count > 0)
                {
                    btnUndo = true;
                    btnRedo = false;
                    string popped = undoStack.Pop().ToString();
                    redoStack.Push(popped);
                    if (popped == "1")
                    {
                        txtCurrentPassword.Text = undoStringsStack.Pop().ToString();
                        txtCurrentPassword.Focus();
                        txtCurrentPassword.Select(txtCurrentPassword.Text.Length, 0);
                        redoStringsStack.Push(currentPassword);
                        currentPassword = txtCurrentPassword.Text;
                    }
                    if (popped == "2")
                    {
                        txtNewPassword.Text = undoStringsStack.Pop().ToString();
                        txtNewPassword.Focus();
                        txtNewPassword.Select(txtNewPassword.Text.Length, 0);
                        redoStringsStack.Push(newPassword);
                        newPassword = txtNewPassword.Text;
                    }
                    if (popped == "3")
                    {
                        txtConfirmNewPassword.Text = undoStringsStack.Pop().ToString();
                        txtConfirmNewPassword.Focus();
                        txtConfirmNewPassword.Select(txtConfirmNewPassword.Text.Length, 0);
                        redoStringsStack.Push(confirmNewPassword);
                        confirmNewPassword = txtConfirmNewPassword.Text;
                    }
                }
                else if (e.KeyCode == Keys.Y && Control.ModifierKeys == Keys.Control && redoStack.Count > 0)
                {
                    btnUndo = false;
                    btnRedo = true;
                    string popped = redoStack.Pop().ToString();
                    if (popped == "1")
                    {
                        txtCurrentPassword.Text = redoStringsStack.Pop().ToString();
                        txtCurrentPassword.Focus();
                        txtCurrentPassword.Select(txtCurrentPassword.Text.Length, 0);
                    }
                    if (popped == "2")
                    {
                        txtNewPassword.Text = redoStringsStack.Pop().ToString();
                        txtNewPassword.Focus();
                        txtNewPassword.Select(txtNewPassword.Text.Length, 0);
                    }
                    if (popped == "3")
                    {
                        txtConfirmNewPassword.Text = redoStringsStack.Pop().ToString();
                        txtConfirmNewPassword.Focus();
                        txtConfirmNewPassword.Select(txtConfirmNewPassword.Text.Length, 0);
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

        private void Change_Password_Load(object sender, EventArgs e)
        {
            Reminders myForm = new Reminders();
            myForm.Reminders_Load(sender, e);
            myForm.Hide();
        }

        private void Change_Password_FormClosing(object sender, FormClosingEventArgs e)
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
