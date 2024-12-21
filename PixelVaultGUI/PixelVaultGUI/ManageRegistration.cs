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
    public partial class ManageRegistration : Form
    {
        public string UserName;
        Controller controller = new Controller();
        public ManageRegistration(string username)
        {
            InitializeComponent();
            UserName = username;
            DataTable dt = new DataTable();
            dt = controller.Tournamentdata(UserName);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
            DataTable dt2 = new DataTable();
            dt2 = controller.TName(UserName);
            TName_combobox.DataSource = dt2;
            TName_combobox.DisplayMember = "TName";
            Open.Checked = true;
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StoreMain storeMain = new StoreMain(UserName);
            storeMain.Show();
        }

        private void Open_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Open.Checked == true)
                Close.Checked = false;
        }

        private void Refresh_Click_1(object sender, EventArgs e)
        {
            string Status = " ";
            if (Open.Checked == true)
                Status = "Open";
            if (Close.Checked == true)
                Status = "Closed";
            controller.RegStatus(TName_combobox.Text, Status);
            DataTable dt = new DataTable();
            dt = controller.Tournamentdata(UserName);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void Close_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Close.Checked == true)
                Open.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
