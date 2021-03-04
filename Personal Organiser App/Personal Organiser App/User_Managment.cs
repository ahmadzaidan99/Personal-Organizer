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
    public partial class User_Managment : Form
    {
        public User_Managment()
        {
            InitializeComponent();
            btnSetNewPassword.Enabled = false;
            btnViewInformation.Enabled = false;
            btnSaveChanges.Enabled = false;
        }

        private void User_Managment_Load(object sender, EventArgs e)
        {
            for (var i = 0; i < User.userList.Count; i++)
            {
                int rowId = dgvUsers.Rows.Add();
                DataGridViewRow row = dgvUsers.Rows[rowId];
                row.Cells["UserName"].Value = User.userList[i].username;
                row.Cells["UserType"].Value = User.userList[i].userType;
            }
            dgvUsers.Rows[0].ReadOnly = true;
            Reminders myForm = new Reminders();
            myForm.Reminders_Load(sender, e);
            myForm.Hide();
        }
        private void UpdateUser()
        {
            for (var i = 0; i < User.userList.Count; i++)
            {
                User.userList[i].userType = dgvUsers.Rows[i].Cells["UserType"].Value.ToString();
            }
            IO.WriteUserList("mydb.csv");
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage myForm = new MainPage();
            myForm.ShowDialog();
            this.Close();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                btnSetNewPassword.Enabled = true;
                btnViewInformation.Enabled = true;
            }
            else
            {
                btnSetNewPassword.Enabled = false;
                btnViewInformation.Enabled = false;
            }
        }

        private void btnSetNewPassword_Click(object sender, EventArgs e)
        {
            string userName = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();
            int userID = 0;
            bool edit = false;
            for (var i = 0; i < User.userList.Count; i++) {
                if (User.userList[i].username == userName)
                {
                    edit = true;
                    userID = i;
                    break;
                }
            }
            if (edit)
            {               
                this.Hide();
                Set_New_Password myForm = new Set_New_Password(userID);
                myForm.ShowDialog();
                this.Close();
            }
        }
   
        private void User_Managment_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnViewInformation_Click(object sender, EventArgs e)
        {
            string userName = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();
            int userID = 0;
            bool edit = false;
            for (var i = 0; i < User.userList.Count; i++)
            {
                if (User.userList[i].username == userName)
                {
                    edit = true;
                    userID = i;
                    break;
                }
            }
            if (edit)
            {
                this.Hide();
                Personal_Information myForm = new Personal_Information(userID,true);
                myForm.ShowDialog();
                this.Close();
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            UpdateUser();
            btnSaveChanges.Enabled = false;
        }

        private void dgvUsers_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = true;
        }

        private void btnExport_Click(object sender, EventArgs e) //change name
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog(); //change name
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.Title = "Export user list";
            saveFileDialog1.DefaultExt = "tsv";
            saveFileDialog1.Filter = "TSV files (*.tsv)|*.tsv|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string x = saveFileDialog1.FileName;
                IO.Tabbed(x);
            }
        }
    }
}