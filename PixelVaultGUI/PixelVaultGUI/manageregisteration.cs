using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelVaultGUI
{
    public partial class manageregisteration : UserControl
    {
        public string UserName;
        Controller controller = new Controller();
        public manageregisteration()
        {
            InitializeComponent();
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
            Environment.Exit(0);
        }

        private void Refresh_Click(object sender, EventArgs e)
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

        private void manageregisteration_Load(object sender, EventArgs e)
        {
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
    }
}
