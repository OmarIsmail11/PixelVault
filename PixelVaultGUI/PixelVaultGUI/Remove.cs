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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PixelVaultGUI
{
    public partial class Remove : Form
    {
        Controller controllerObj = new Controller();
        public Remove()
        {
            InitializeComponent();
            DataTable dt = controllerObj.selectpub();
            pub.DataSource = dt;
            pub.DisplayMember = "PublisherUserName";
            pub.ValueMember = "PublisherUserName";

            DataTable dt1 = controllerObj.selectman();
            man.DataSource = dt1;
            man.DisplayMember = "ManufacturerName";
            man.ValueMember = "ManufacturerName";

            DataTable dt2 = controllerObj.selectcon();
            con.DataSource = dt2;
            con.DisplayMember = "ConsoleName";
            con.ValueMember = "ConsoleName";

            DataTable dt3 = controllerObj.selectgamer();
            gamer.DataSource = dt3;
            gamer.DisplayMember = "UserName";
            gamer.ValueMember = "UserName";

            DataTable dt4 = controllerObj.selecteng();
            eng.DataSource = dt4;
            eng.DisplayMember = "EngineName";
            eng.ValueMember = "EngineName";

            DataTable dt5 = controllerObj.selectstor();
            stor.DataSource = dt5;
            stor.DisplayMember = "StoreUserName";
            stor.ValueMember = "StoreUserName";

            DataTable dt6 = controllerObj.selectrev();
            rev.DataSource = dt6;
            rev.DisplayMember = "ReviewerName";
            rev.ValueMember = "ReviewerName";
        }

        private void Remove_Load(object sender, EventArgs e)
        {
            
        }

        private void rempub_Click(object sender, EventArgs e)
        {
            if (pub.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select record!");
            }
            else
            {
                if (controllerObj.deletepub(Convert.ToString(pub.SelectedValue)) > 0)
                {
                    MessageBox.Show("Record has been successfully removed");
                }
                else
                {
                    MessageBox.Show("Error! Try again");
                }
            }
        }

        private void remstor_Click(object sender, EventArgs e)
        {
            if (stor.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select record!");
            }
            else
            {
                if (controllerObj.deletestor(Convert.ToString(stor.SelectedValue)) > 0)
                {
                    MessageBox.Show("Record has been successfully removed");
                }
                else
                {
                    MessageBox.Show("Error! Try again");
                }
            }
        }

        private void remcon_Click(object sender, EventArgs e)
        {
            if (con.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select record!");
            }
            else
            {
                if (controllerObj.deletecon(Convert.ToString(con.SelectedValue)) > 0)
                {
                    MessageBox.Show("Record has been successfully removed");
                }
                else
                {
                    MessageBox.Show("Error! Try again");
                }
            }
        }

        private void remman_Click(object sender, EventArgs e)
        {
            if (man.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select record!");
            }
            else
            {
                if (controllerObj.deleteman(Convert.ToString(man.SelectedValue)) > 0)
                {
                    MessageBox.Show("Record has been successfully removed");
                }
                else
                {
                    MessageBox.Show("Error! Try again");
                }
            }
        }

        private void remeng_Click(object sender, EventArgs e)
        {
            if (eng.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select record!");
            }
            else
            {
                if (controllerObj.deleteeng(Convert.ToString(eng.SelectedValue)) > 0)
                {
                    MessageBox.Show("Record has been successfully removed");
                }
                else
                {
                    MessageBox.Show("Error! Try again");
                }
            }
        }

        private void remgamer_Click(object sender, EventArgs e)
        {
            if (gamer.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select record!");
            }
            else
            {
                if (controllerObj.deletegamer(Convert.ToString(gamer.SelectedValue)) > 0)
                {
                    MessageBox.Show("Record has been successfully removed");
                }
                else
                {
                    MessageBox.Show("Error! Try again");
                }
            }
        }

        private void remrev_Click(object sender, EventArgs e)
        {
            if (rev.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select record!");
            }
            else
            {
                if (controllerObj.deleterev(Convert.ToString(rev.SelectedValue)) > 0)
                {
                    MessageBox.Show("Record has been successfully removed");
                }
                else
                {
                    MessageBox.Show("Error! Try again");
                }
            }
        }
    }
}
