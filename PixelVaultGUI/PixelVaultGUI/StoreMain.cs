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
            manageInventory1.UserName = username_in;
            manageInventory1.Visible = false;
            managePartnerships1.SUserName = username_in;
            managePartnerships1.Visible = false;
            manageregisteration1.UserName = username_in;
            manageregisteration1.Visible = false;
            promotions1.UserName = username_in;
            promotions1.Visible = false;
            addTournament1.UserName = username_in;
            addTournament1.Visible = false;
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
            addTournament1.ReloadData();
            addTournament1.Refresh();
            Add_Tournament.BackColor = Color.Thistle;
            Manage_TReg.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Manage_Partner.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Manage_Inventory.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Promotions.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            manageregisteration1.Visible = false;           
            managePartnerships1.Visible = false;
            promotions1.Visible = false;
            manageInventory1.Visible = false;
            addTournament1.Visible = true;
        }



        private void Manage_TReg_Click(object sender, EventArgs e)
        {
            manageregisteration1.ReloadData();
            manageregisteration1.Refresh();
            Add_Tournament.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Manage_TReg.BackColor = Color.Thistle;
            Manage_Partner.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Manage_Inventory.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Promotions.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            manageInventory1.Visible = false;
            managePartnerships1.Visible = false;
            addTournament1.Visible = false;
            promotions1.Visible = false;
            manageregisteration1.Visible = true;
        }

        private void Manage_Inventory_Click(object sender, EventArgs e)
        {
            manageInventory1.ReloadData();
            manageInventory1.Refresh();
            Add_Tournament.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Manage_TReg.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Manage_Partner.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Manage_Inventory.BackColor = Color.Thistle;
            Promotions.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            manageregisteration1.Visible = false;
            addTournament1.Visible = false;
            managePartnerships1.Visible = false;
            promotions1.Visible = false;
            manageInventory1.Visible = true;

        }

        private void Manage_Partner_Click(object sender, EventArgs e)
        {
            managePartnerships1.ReloadData();
            managePartnerships1.Refresh();
            Add_Tournament.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Manage_TReg.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Manage_Partner.BackColor = Color.Thistle;
            Manage_Inventory.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Promotions.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            manageInventory1.Visible = false;
            manageregisteration1.Visible = false;
            addTournament1.Visible= false;
            promotions1.Visible = false;
            managePartnerships1.Visible = true;
        }

        private void Promotions_Click(object sender, EventArgs e)
        {
            promotions1.ReloadData();
            promotions1.Refresh();
            Add_Tournament.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Manage_TReg.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Manage_Partner.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Manage_Inventory.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Promotions.BackColor = Color.Thistle;
            manageInventory1.Visible = false;
            manageregisteration1.Visible = false;
            addTournament1.Visible = false;
            managePartnerships1.Visible = false;
            promotions1.Visible = true;
        }
    }
}
