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
            DataTable dt = controllerObj.Get_Played_Games_By_userrating_pub(PublisherUsername);
            dataGridView1.DataSource = dt;
            if (dt == null)
            {
                MessageBox.Show("There is no players playing this publisher Games");
                return;
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
            MostTrendingGame.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            MostTrendingGenre.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            MostTrendingPlatform.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            MostTrendingEngine.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
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

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Get_Played_Games_By_Rating_Pub(PublisherUsername);
            dataGridView1.DataSource = dt;
            if (dt == null)
            {
                MessageBox.Show("There is no players playing this publisher Games");
                return;
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
            MostTrendingGame.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            MostTrendingGenre.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            MostTrendingPlatform.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            MostTrendingEngine.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Get_Played_Games_Pub(PublisherUsername);
            dataGridView1.DataSource = dt;
            if (dt == null)
            {
                MessageBox.Show("There is no players playing this publisher Games");
                return;
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
            MostTrendingGame.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            MostTrendingGenre.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            MostTrendingPlatform.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            MostTrendingEngine.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
        }

        private void AwardedGamesButton_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Get_Rewarded_Games_pub(PublisherUsername);
            dataGridView1.DataSource = dt;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();

        }

        private void DeleteGameButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedrow = dataGridView1.SelectedRows[0];
                string selectedgame = selectedrow.Cells["GameName"].Value.ToString();
                int res = controllerObj.Delete_Game(selectedgame);
                if (res == 0)
                {
                    MessageBox.Show("Deletion Failed");
                    return;
                }
                else
                {
                    MessageBox.Show("Deletion Successful");
                }
                DataTable dt = controllerObj.Get_All_Published_Games(PublisherUsername);
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Please choose a game to delete");
            }
        }

        private void UpdateAwardButton_Click(object sender, EventArgs e)
        {
            Form form = new UpdateAward(PublisherUsername);
            form.Show();
        }
    }
}
