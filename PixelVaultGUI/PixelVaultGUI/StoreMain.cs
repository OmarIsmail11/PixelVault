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
    public partial class StoreMain : Form
    {
        public string UserName;
        public StoreMain(string username_in)
        {
            InitializeComponent();
            Inventory.Hide();
            UserName = username_in;
            Welcome.Text = "Welcome, " + UserName + "";
        }

        private void StoreMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StoreInfo storeInfo = new StoreInfo(UserName);
            storeInfo.Show();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Inventory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inventory_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
