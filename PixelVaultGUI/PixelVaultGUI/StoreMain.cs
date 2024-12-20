using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBapplication;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PixelVaultGUI
{
    public partial class StoreMain : Form
    {
        public string UserName;
        Controller controller = new Controller();
     
        public StoreMain(string username_in)
        {
            InitializeComponent();
            UserName = username_in;
            Welcome.Text = "Welcome, " + UserName + "";
        }

        private void StoreMain_Load(object sender, EventArgs e)
        {

            
        }

        private void Store_Info_Click(object sender, EventArgs e)
        {
            StoreInfo storeInfo = new StoreInfo(UserName);
            storeInfo.Show();

        }

        private void ExitButton_Click_1(object sender, EventArgs e)
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Tournament_Click(object sender, EventArgs e)
        {
            this.Close();
            Add_Tournament add_Tournament = new Add_Tournament(UserName);
            add_Tournament.Show();
        }

       

        private void Manage_TReg_Click(object sender, EventArgs e)
        {
            
            this.Close();
            ManageRegistration manageRegistration= new ManageRegistration(UserName);
            manageRegistration.Show();
        }

        
    }
}
