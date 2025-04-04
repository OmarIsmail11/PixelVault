﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelVaultGUI
{
    public partial class GamerMain : Form
    {
        public string UserName;
        public int SignInSignUpStatus;
        public GamerMain(string username) // 1 for sign in & 0 for sign up
        {
            InitializeComponent();
            UserName = username;
            WelcomeTextBox.Text = "Welcome, " + UserName + "";
            gameLibrary1.GamerUserName = UserName;
            tournaments1.GamerUserName = UserName;
            browseTournaments1.UserName = UserName;
            browseGames1.UserName = UserName;
            friends1.UserName = UserName;
            
            gameLibrary1.Visible = true;
            tournaments1.Visible = false;
            browseTournaments1.Visible = false;
            browseGames1.Visible = false;
            friends1.Visible = false;
        }

        private void GamerMain_Load(object sender, EventArgs e)
        {

        }

        private void GamerLibraryButton_Click(object sender, EventArgs e)
        {
            gameLibrary1.RefreshLibrary();
            GamerLibraryButton.BackColor = Color.Thistle;
            TournamentsButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            BrowseTournamentsButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            BrowseGamesButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            FriendsButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            gameLibrary1.Visible = true;
            tournaments1.Visible = false;
            browseTournaments1.Visible = false;
            browseGames1.Visible = false;
            friends1.Visible = false;

        }

        private void gameLibrary1_Load(object sender, EventArgs e)
        {

        }

        private void TournamentsButton_Click(object sender, EventArgs e)
        {
            TournamentsButton.BackColor = Color.Thistle;
            GamerLibraryButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            BrowseTournamentsButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            BrowseGamesButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            FriendsButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            tournaments1.Visible = true;
            gameLibrary1.Visible = false;
            browseTournaments1.Visible = false;
            browseGames1.Visible = false;
            friends1.Visible = false;
            tournaments1.RefreshTournaments();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            var output = MessageBox.Show($"Are you sure you want to sign out ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (output == DialogResult.Yes)
            {
                MessageBox.Show("Signed out successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                if (SignInSignUpStatus == 0)
                {
                    SignIn signIn = new SignIn();
                    signIn.Show();
                }
            }
            else return;
        }

        private void BrowseTournamentsButton_Click(object sender, EventArgs e)
        {
            BrowseTournamentsButton.BackColor = Color.Thistle;
            TournamentsButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            GamerLibraryButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            BrowseGamesButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            FriendsButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            browseTournaments1.Visible = true;
            gameLibrary1.Visible = false;
            tournaments1.Visible = false;
            browseGames1.Visible = false;
            friends1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void browseTournaments1_Load(object sender, EventArgs e)
        {

        }

        private void BrowseGamesButton_Click(object sender, EventArgs e)
        {
            BrowseGamesButton.BackColor = Color.Thistle;
            TournamentsButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            GamerLibraryButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            BrowseTournamentsButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            FriendsButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            browseGames1.Visible = true;
            gameLibrary1.Visible = false;
            tournaments1.Visible = false;
            browseTournaments1.Visible = false;
            friends1.Visible = false;
            browseGames1.RefreshBrowseGames();
        }

        private void browseGames1_Load(object sender, EventArgs e)
        {

        }

        private void EditProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditProfile editGamerProfile = new EditProfile();
            editGamerProfile.UserName = UserName;
            editGamerProfile.ShowDialog();
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FriendsButton_Click(object sender, EventArgs e)
        {
            FriendsButton.BackColor = Color.Thistle;
            TournamentsButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            GamerLibraryButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            BrowseGamesButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            BrowseTournamentsButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            friends1.Visible = true;
            browseTournaments1.Visible = false;
            gameLibrary1.Visible = false;
            tournaments1.Visible = false;
            browseGames1.Visible = false;
        }
    }
}
