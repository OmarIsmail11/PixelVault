using DBapplication;
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
    public partial class GamePublisherMain : Form
    {
        public string UserName;
        public GamePublisherMain(string username)
        {
            InitializeComponent();
            UserName = username;
            WelcomeTextBox.Text = "Welcome, " + UserName + "";
            publisherGames1.PublisherUsername = UserName;
            manage_Partners1.Publisherusername = UserName;
            publisherGames1.Visible = true;
            analystics1.Visible = false;
            manage_Partners1.Visible = false;
        }

        private void GamePublisherMain_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            publisherGames1.Visible = false;
            analystics1.Visible = true;
            manage_Partners1.Visible = false;
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            var output = MessageBox.Show($"Are you sure you want to sign out ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (output == DialogResult.Yes)
            {
                MessageBox.Show("Logged out successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            publisherGames1.Visible = true;
            analystics1.Visible = false;
            manage_Partners1.Visible=false;
        }

        private void analystics1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            publisherGames1.Visible = false;
            analystics1.Visible = false;
            manage_Partners1.Visible = true;
        }
    }
}
