﻿using DBapplication;
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
            pubhead.DataSource = countries;

            string[] Platforms = { "Cross-Platform", "Mobile", "Windows", "Playstation" };
            engplat.DataSource = Platforms;

            manname1.DataSource = controllerObj.selectman();
            manname1.DisplayMember = "ManufacturerName";
            manname1.ValueMember = "ManufacturerName";

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
            if (!Validations.ValidateName(name)) return;

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
            if (!Validations.ValidateName(name)) return;

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
            if (!Validations.ValidateName(name)) return;

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
            if (!Validations.ValidateName(name)) return;

            if (!Validations.IsComboBoxEmpty(manname1)) return;

            DateTime selectedDate = condate.Value;
            string Date = selectedDate.ToString("yyyy-MM-dd");

            if (controllerObj.addcon(name, Date, Convert.ToString(manname1.SelectedItem)) > 0)
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

        private void addstor_Click_1(object sender, EventArgs e)
        {
            string name = storname.Text;
            if (!Validations.ValidateName(name)) return;

            string hotline = storhot.Text;
            if (!Validations.Isint(hotline)) return;

            int rating = storrate.Value;

            if (controllerObj.addstor(name, rating, Convert.ToInt32(hotline)) > 0)
            {
                MessageBox.Show("Game Store added succesfully !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Error ! Game Store was not added!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void addpub_Click_1(object sender, EventArgs e)
        {
            string name = pubname.Text;
            if (!Validations.ValidateName(name)) return;

            if (!Validations.IsComboBoxEmpty(pubhead)) return;

            string type = pubtype.Text;
            if (Validations.Isempty(type) || !(Validations.StringLengthIsinrange(type, 1, 30)))
            {
                MessageBox.Show("Error ! Console Type is either empty or too long", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime selectedDate = revdate.Value;
            string Date = selectedDate.ToString("yyyy-MM-dd");

            if (controllerObj.addpub(name, Convert.ToString(pubhead.SelectedItem), type, Date) > 0)
            {
                MessageBox.Show("Game Publisher added succesfully !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Error ! Game Publisher was not added!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
