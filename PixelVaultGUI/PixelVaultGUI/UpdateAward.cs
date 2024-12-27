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
    public partial class UpdateAward : Form
    {
        Controller controllerobj =new Controller();
        public UpdateAward()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string GameName= GameNametext.Text;
            string AwardName = AwardNametext.Text;
            bool isint = Int32.TryParse(AwardYearText.Text, out int AwardYear);
            if(GameName=="")
            {
                MessageBox.Show("Please Enter a GameName");
                return;
            }

            if(AwardName=="")
            {
                MessageBox.Show("Please Enter a AwardName");
                return;
            }
            if (AwardYearText.Text == "")
            {
                MessageBox.Show("Please Enter A number In the Awarded Date");
                return;
            }
            if (!isint)
            {
                MessageBox.Show("Please Enter A number In the Awarded Date");
                return;
            }

            int res = controllerobj.Award_Game(GameName, AwardName,AwardYear);
            if (res == 0)
            {
                MessageBox.Show("Game Was not Rewarded");
                return;
            }
            else
            {
                MessageBox.Show("Game Got Rewarded");
                return;
            }

            
        }
    }
}
