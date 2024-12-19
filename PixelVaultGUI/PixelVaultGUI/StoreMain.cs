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
    public partial class StoreMain : Form
    {
        public string UserName;
        Controller controller = new Controller();
        public StoreMain(string username_in)
        {
            InitializeComponent();
            UserName = username_in;
            Welcome.Text = "Welcome, " + UserName + "";
            Add_Tournament_Panel.Location = new Point(489, 36);
            Reg_panel.Location = new Point(489, 36);
            Add_Tournament_Panel.Size = new Size(716, 587);
            Reg_panel.Size = new Size(716, 587);
            Add_Tournament_Panel.Visible = false;
            Reg_panel.Visible=false;

            DataTable dt = new DataTable();
            dt = controller.Tournamentdata(UserName);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            DataTable dt2 = new DataTable();
            dt2 = controller.TName(UserName);
            TName_combobox.DataSource = dt2;
            Open.Checked = true;
        }

        private void StoreMain_Load(object sender, EventArgs e)
        {

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " ";
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
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
            Add_Tournament.BackColor = Color.Thistle;
            Manage_Inventory.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Promotions.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Manage_Partner.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Manage_TReg.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Add_Tournament_Panel.Visible=true;
            Reg_panel.Visible=false;
        }

        private void Add_Tournament_val_Click(object sender, EventArgs e)
        {
            if (TName.Text == " ") MessageBox.Show("Please Enter Tournament Name");
            string tname = TName.Text;
            int capacity;
            if (!(Capacity.Text == " "))
            {
                if (Validations.Isinteger(Capacity.Text, out capacity))
                {
                    if (Validations.IsPositive(Capacity.Text))
                    {
                        capacity = Convert.ToInt32(Capacity.Text);
                    }
                    else
                    {
                        MessageBox.Show("Capacity must be positive");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Capacity must be an integer");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Enter the Tournament's Capacity");
                return;
            }
            float Prize;
            if (Validations.Isfloat(PMoney.Text, out Prize))
            {
                if (Validations.IsPositive(PMoney.Text))
                {
                    Prize = float.Parse(PMoney.Text);
                }
                else
                {
                    MessageBox.Show("Prize Money must be positive");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Prize must be a number");
                return;
            }
            DateTime selectedDate = dateTimePicker1.Value;
            string StartDate = selectedDate.ToString("yyyy-MM-dd");
            string type = Type.Text;
            string region = Region.Text;

            /*controller.*/
        }

        private void Manage_TReg_Click(object sender, EventArgs e)
        {
            Manage_TReg.BackColor = Color.Thistle;
            Add_Tournament.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Manage_Inventory.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Promotions.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Manage_Partner.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            Manage_TReg.BackColor = Color.Thistle;
            Reg_panel.Visible=true;
            Add_Tournament_Panel.Visible = false;
            

        }

        private void Open_CheckedChanged(object sender, EventArgs e)
        {
            if (Open.Checked == true)
                Close.Checked = false;
        }

        private void Close_CheckedChanged(object sender, EventArgs e)
        {
            if (Close.Checked == true)
                Open.Checked = false;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            string Status=" ";
            if (Open.Checked == true)
                Status = "Open";
            if (Close.Checked == true)
                Status = "Closed";
            controller.RegStatus(TName_combobox.Text, Status);
            DataTable dt = new DataTable();
            dt = controller.Tournamentdata(UserName);
            dataGridView1.DataSource= dt;
            dataGridView1.Refresh();

        }
    }
}
