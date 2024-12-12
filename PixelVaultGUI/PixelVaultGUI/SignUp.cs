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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void GamerButton_Click(object sender, EventArgs e)
        {
            GamerSignUp signUp = new GamerSignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
