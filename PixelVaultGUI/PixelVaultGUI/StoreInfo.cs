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

namespace PixelVaultGUI
{
    public partial class StoreInfo : Form
    {
        public string UserName;
        Controller controller = new Controller();
        public StoreInfo(string username)
        {
            InitializeComponent();
            UserName = username;
            user_name.Text = username;
            string RealName=Convert.ToString(controller.GetStoreRealName(username));
            real_name.Text = RealName;
            int rating=controller.GetStoreRating(username);
            Rating.Text = rating.ToString();
            int hotline=controller.GetStoreHotline(username);
            Hotline.Text = hotline.ToString();
        }

        private void StoreInfo_Load(object sender, EventArgs e)
        {

        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void user_name_Click(object sender, EventArgs e)
        {

        }
    }
}
