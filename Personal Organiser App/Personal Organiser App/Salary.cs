using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Organiser_App {
    public partial class Salary : Form {
        public double minimumSalary;
        public double multiplier = 0;
        public double experienceMultiplier = 0;
        public double cityMultiplier = 0;
        public double educationMultiplier = 0;
        public double languageMultiplier = 0;
        public double roleMultiplier = 0;
        public double familyMultiplier = 0;
        public Salary() {
            InitializeComponent();
            cmbBabies.Enabled = false;
            cmbStudents.Enabled = false;
            cmbTeens.Enabled = false;
        }
        private void Salary_Load(object sender, EventArgs e)
        {
            Reminders myForm = new Reminders();
            myForm.Reminders_Load(sender, e);
            myForm.Hide();
        }
        private void cboExperience_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = this.cmbExperience.SelectedIndex;
            if (selected == 0)
                experienceMultiplier = 0;
            else if (selected == 1)
                experienceMultiplier = 0.6;
            else if (selected == 2)
                experienceMultiplier = 1;
            else if (selected == 3)
                experienceMultiplier = 1.2;
            else if (selected == 4)
                experienceMultiplier = 1.35;
            else if (selected == 5)
                experienceMultiplier = 1.5;
            Calculate();
        }

        private void cboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = this.cmbCity.SelectedIndex;
            if (selected == 0)
                cityMultiplier = 0.15;
            else if (selected == 1 || selected == 2)
                cityMultiplier = 0.10;
            else if (selected == 3 || selected == 4)
                cityMultiplier = 0.05;
            else if (selected == cmbCity.Items.Count - 1)
                cityMultiplier = 0;
            else
                cityMultiplier = 0.03;
            Calculate();
        }

        private void cboEducation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = this.cmbEducation.SelectedIndex;
            if (selected == 0)
                educationMultiplier = 0;
            else if (selected == 1)
                educationMultiplier = 0.10;
            else if (selected == 2)
                educationMultiplier = 0.30;
            else if (selected == 3)
                educationMultiplier = 0.35;
            else if (selected == 4)
                educationMultiplier = 0.05;
            else if (selected == 5)
                educationMultiplier = 0.15;
            Calculate();
        }

        private void cboEnglishLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = this.cmbEnglishLanguage.SelectedIndex;
            if (selected == 0)
                languageMultiplier = 0;
            else
                languageMultiplier = 0.2;
            if (!string.IsNullOrWhiteSpace(txtOtherLanguages.Text))
            {
                int qty = Int32.Parse(txtOtherLanguages.Text);
                languageMultiplier += (0.05 * qty);
            }
            Calculate();
        }
        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = this.cmbRole.SelectedIndex;
            if (selected == 0)
                roleMultiplier = 0.50;
            else if (selected == 1)
                roleMultiplier = 0.75;
            else if (selected == 2)
                roleMultiplier = 0.85;
            else if (selected == 3)
                roleMultiplier = 1;
            else if (selected == 4)
                roleMultiplier = 0.40;
            else if (selected == 5)
                roleMultiplier = 0.60;
            Calculate();
        }
        private void txtLangs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ChkFamily_CheckStateChanged(object sender, EventArgs e)
        {
            familyMultiplier = 0;
            int childrenCount = 0;

            if (chkStudents.Checked) { 
                cmbStudents.Enabled = true;
                if (this.cmbStudents.SelectedIndex == 0)
                {
                    childrenCount++;
                    familyMultiplier += 0.4;
                }
                else if (this.cmbStudents.SelectedIndex == 1)
                {
                    childrenCount += 2;
                    familyMultiplier += 0.8;
                }
            }
            else { cmbStudents.Enabled = false; }

            if (chkBabies.Checked) { cmbBabies.Enabled = true; }
            else { cmbBabies.Enabled = false; }

            if (chkTeens.Checked) { cmbTeens.Enabled = true; }
            else { cmbTeens.Enabled = false; }

            if (chkMarried.Checked) { familyMultiplier += 0.2; }
                        
            if(chkTeens.Checked && childrenCount < 2)
            {
                if (this.cmbTeens.SelectedIndex == 0)
                {
                    childrenCount++;
                    familyMultiplier += 0.3;
                }
                else if (this.cmbStudents.SelectedIndex == 1 && childrenCount==0)
                {
                    childrenCount += 2;
                    familyMultiplier += 0.6;
                }
                else if (this.cmbStudents.SelectedIndex == 1 && childrenCount == 1)
                {
                    childrenCount ++;
                    familyMultiplier += 0.3;
                }
            }
            if (chkBabies.Checked && childrenCount < 2)
            {
                if (this.cmbBabies.SelectedIndex == 0)
                {
                    childrenCount++;
                    familyMultiplier += 0.2;
                }
                else if (this.cmbStudents.SelectedIndex == 1 && childrenCount == 0)
                {
                    childrenCount += 2;
                    familyMultiplier += 0.4;
                }
                else if (this.cmbStudents.SelectedIndex == 1 && childrenCount == 1)
                {
                    childrenCount++;
                    familyMultiplier += 0.4;
                }
            }
            Calculate();
        }
        private void Calculate()
        {
            multiplier = 1 + experienceMultiplier + cityMultiplier + educationMultiplier + languageMultiplier + roleMultiplier + familyMultiplier;
            minimumSalary = Convert.ToDouble(5000 * multiplier);
            if(User.userList[User.curr].userType=="Part-Time User")
            {
                minimumSalary *= 0.5;
            }
            txtMinimumSalary.Text = "₺" + minimumSalary.ToString("0,000.00");           
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage myForm = new MainPage();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User.userList[User.curr].minimumSalary = minimumSalary;
            IO.WriteUserList("mydb.csv");
        }

        private void Salary_FormClosing(object sender, FormClosingEventArgs e)
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
