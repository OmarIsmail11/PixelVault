using System;
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
        public GamerMain(string username)
        {
            InitializeComponent();
            UserName = username;
            WelcomeUserLabel.Text = "Welcome, " + UserName + "";
            gameLibrary1.GamerUserName = UserName;
            tournaments1.GamerUserName = UserName;
            gameLibrary1.Visible = true;
            tournaments1.Visible = false;

        }

        private void GamerMain_Load(object sender, EventArgs e)
        {

        }

        private void GamerLibraryButton_Click(object sender, EventArgs e)
        {
            GamerLibraryButton.BackColor = Color.Thistle;
            TournamentsButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            gameLibrary1.Visible = true;
            tournaments1.Visible = false;
        }

        private void gameLibrary1_Load(object sender, EventArgs e)
        {

        }

        private void TournamentsButton_Click(object sender, EventArgs e)
        {
            TournamentsButton.BackColor = Color.Thistle;
            GamerLibraryButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            tournaments1.Visible = true;
            gameLibrary1.Visible = false;
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
                MessageBox.Show("Logged out successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SignIn signIn = new SignIn();
                signIn.Show();
                this.Close();
            }
            else return;
        }
    }
}
