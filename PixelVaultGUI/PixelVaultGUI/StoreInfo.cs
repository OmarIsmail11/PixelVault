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
    public partial class StoreInfo : Form
    {
        public string UserName;
        public StoreInfo(string username)
        {
            InitializeComponent();
            UserName = username;
        }

        private void StoreInfo_Load(object sender, EventArgs e)
        {

        }

        
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
