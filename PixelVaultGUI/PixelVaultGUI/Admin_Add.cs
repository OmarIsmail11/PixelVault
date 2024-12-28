using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PixelVaultGUI
{
    public partial class Admin_Add : Form
    {
        Controller controllerObj = new Controller();
        public Admin_Add()
        {
            InitializeComponent();
            string[] countries =
                {
                    "Australia", "Brazil", "Canada", "Egypt", "France", "Germany", "India", "Italy",
                    "Japan", "Mexico", "New Zealand", "Singapore", "South Korea","Spain", "UK", "USA"
            };

            manhead.DataSource = countries;

            string[] Platforms = { "Cross-Platform", "Mobile", "Windows", "Playstation" };
            engplat.DataSource = Platforms;

            manname1.DataSource = controllerObj.selectman();
            manname1.DisplayMember = "ManufacturerName";
            manname1.ValueMember = "ManufacturerName";

            awardgenre.DataSource = controllerObj.selectgenre();
            awardgenre.DisplayMember = "Genre";
            awardgenre.ValueMember = "Genre";

            awardrev.DataSource = controllerObj.selectawardrev();
            awardrev.DisplayMember = "ReviewerName";
            awardrev.ValueMember = "ReviewerName";

        }

        private void Admin_Add_Load(object sender, EventArgs e)
        {

        }

        private void addmin_Click_1(object sender, EventArgs e)
        {
            string UserName = admin_username.Text;
            if (!Validations.ValidateUserName(UserName)) return;

            string password = adminpass.Text;
            if (!Validations.ValidatePassword(password)) return;

            if (!Validations.CheckIfNewUserNameNotAlreadyExisiting(UserName)) return;

            string repassword = renterpass.Text;
            if (repassword == "")
            {
                MessageBox.Show("Invalid! Please re-enter password in the required field!");
                return;
            }
            if (password != repassword)
            {
                MessageBox.Show("Invalid! Passwords must be the same!");
                return;
            }

            if (controllerObj.addadmin(admin_username.Text, adminpass.Text) > 0)
            {
                MessageBox.Show("Admin added succesfully !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Error ! Admin was not added!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void addman_Click_1(object sender, EventArgs e)
        {
            string name = manname.Text;
            if (!Validations.ValidateRealName(name)) return;

            if (!Validations.IsComboBoxEmpty(manhead)) return;

            if (controllerObj.addman(name, Convert.ToString(manhead.SelectedItem)) > 0)
            {
                MessageBox.Show("Manufacturer added succesfully !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Error ! Manufacturer was not added!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void addeng_Click_1(object sender, EventArgs e)
        {
            string name = engname.Text;
            if (!Validations.ValidateRealName(name)) return;

            if (!Validations.IsComboBoxEmpty(engplat)) return;

            string language = englang.Text;
            if (Validations.Isempty(language) || !(Validations.StringLengthIsinrange(language, 1, 30)))
            {
                MessageBox.Show("Error ! Lanuguage name is either empty or too long", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (controllerObj.addeng(name, language, Convert.ToString(engplat.SelectedItem)) > 0)
            {
                MessageBox.Show("Game Engine added succesfully !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Error ! Game Engine was not added!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void addrev_Click_1(object sender, EventArgs e)
        {
            string name = revname.Text;
            if (!Validations.ValidateRealName(name)) return;

            DateTime selectedDate = revdate.Value;
            string Date = selectedDate.ToString("yyyy-MM-dd");

            string url = revurl.Text;
            if (!(Validations.IsValidUrl(url))) return;

            if (controllerObj.addrev(name, revurl.Text, Date) > 0)
            {
                MessageBox.Show("Game Reviewer added succesfully !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Error ! Game Reviewer was not added!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void addcon_Click_1(object sender, EventArgs e)
        {
            string name = conname.Text;
            if (!Validations.ValidateRealName(name)) return;

            if (!Validations.IsComboBoxEmpty(manname1)) return;

            DateTime selectedDate = condate.Value;
            string Date = selectedDate.ToString("yyyy-MM-dd");

            if (controllerObj.addcon(name, Date, Convert.ToString(manname1.SelectedValue)) > 0)
            {
                MessageBox.Show("Console added succesfully !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Error ! Console was not added!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void manhead_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addaward_Click(object sender, EventArgs e)
        {
            string name = awardname.Text;
            if (!Validations.ValidateRealName(name)) return;

            if (!Validations.IsComboBoxEmpty(awardgenre)) return;

            if (!Validations.IsComboBoxEmpty(awardrev)) return;

            if (controllerObj.addaward(name, Convert.ToString(awardgenre.SelectedValue), Convert.ToString(awardrev.SelectedValue)) > 0)
            {
                MessageBox.Show("Game Award added succesfully !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Error ! Game Award was not added!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
