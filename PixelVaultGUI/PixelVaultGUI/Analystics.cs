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
    public partial class Analystics : UserControl
    {
        Controller controllerobj = new Controller();
        public string Publisherusername;
        public Analystics()
        {
            InitializeComponent();
            dataGridView1.DataSource = controllerobj.Get_Played_Games();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
            MostTrendingGame.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
        }

        private void Analystics_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controllerobj.Get_Played_Games();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
            MostTrendingGame.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            MostTrendingGenre.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            MostTrendingPlatform.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            MostTrendingEngine.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
