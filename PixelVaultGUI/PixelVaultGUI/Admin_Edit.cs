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
    public partial class Admin_Edit : Form
    {
        public Admin_Edit()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Hide();
            Admin_Add form1 = new Admin_Add();
            form1.ShowDialog();
            Show();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            Hide();
            Remove form1 = new Remove();
            form1.ShowDialog();
            Show();
        }

        private void reports_Click(object sender, EventArgs e)
        {
            Hide();
            Admin_Report form1 = new Admin_Report();
            form1.ShowDialog();
            Show();
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
    }
}
