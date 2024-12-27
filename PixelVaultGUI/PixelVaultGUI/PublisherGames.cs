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
    public partial class PublisherGames : UserControl
    {

        Controller controllerObj = new Controller();
        public string PublisherUsername;
        public PublisherGames()
        {
            InitializeComponent();
            DataTable dt = controllerObj.Get_All_Published_Games(PublisherUsername);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();

        }

        private void PublisherGames_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Get_All_Published_Games(PublisherUsername);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PublishGameButton_Click(object sender, EventArgs e)
        {
            Form F = new Publish_Game(PublisherUsername);
            F.Show();
        }

        private void RefreshListButton_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Get_All_Published_Games(PublisherUsername);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
        }
    }
}
