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
    public partial class ShowReports : UserControl
    {
        public string UserName;
        Controller controller = new Controller();
        private DataTable dt = new DataTable();
        public ShowReports()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void ReloadData(DataTable dt)
        {
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
        }
        private void PartnersNum_Click(object sender, EventArgs e)
        {
            PartnersNum.BackColor = Color.Thistle;
            AvgPMoney.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            AvgPrice.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            TournamentsNum.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            dt = controller.PartnersNum(UserName);
            ReloadData(dt);
        }

        private void AvgPrice_Click(object sender, EventArgs e)
        {
            PartnersNum.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            AvgPMoney.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            AvgPrice.BackColor = Color.Thistle;
            TournamentsNum.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            dt = controller.AvgGPrice(UserName);
            ReloadData(dt);
        }

        private void TournamentsNum_Click(object sender, EventArgs e)
        {
            PartnersNum.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            AvgPMoney.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            AvgPrice.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            TournamentsNum.BackColor = Color.Thistle;
            dt = controller.TNum(UserName);
            ReloadData(dt);
        }

        private void AvgPMoney_Click(object sender, EventArgs e)
        {
            PartnersNum.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            AvgPMoney.BackColor = Color.Thistle;
            AvgPrice.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            TournamentsNum.BackColor = System.Drawing.ColorTranslator.FromHtml("#BABAD4");
            dt = controller.AvgPMoney(UserName);
            ReloadData(dt);
        }

    }
}
