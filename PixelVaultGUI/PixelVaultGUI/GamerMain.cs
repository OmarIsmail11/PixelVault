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
            gameLibrary1.Visible = true;

        }

        private void GamerMain_Load(object sender, EventArgs e)
        {

        }

        private void GamerLibraryButton_Click(object sender, EventArgs e)
        {
            GamerLibraryButton.BackColor = Color.Thistle;
            gameLibrary1.Visible = true;
        }

        private void gameLibrary1_Load(object sender, EventArgs e)
        {

        }

        private void TournamentsButton_Click(object sender, EventArgs e)
        {
            TournamentsButton.BackColor = Color.Thistle;
            GamerLibraryButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            gameLibrary1.Visible = false;
        }
    }
}
