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
    public partial class Manage_Partners : UserControl
    {
        public string Publisherusername;
        Controller Controllerobj = new Controller();
        public Manage_Partners()
        {
            InitializeComponent();
        }

        private void Manage_Partners_Load(object sender, EventArgs e)
        {

        }

        private void ViewStroresButton_Click(object sender, EventArgs e)
        {
            DataTable dt = Controllerobj.selectstor();

            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
        }

        private void ViewPartnersButton_Click(object sender, EventArgs e)
        {
            DataTable dt = Controllerobj.Get_Partnered_Stores(Publisherusername);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();

        }

        private void AddPartnershipButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedrow = dataGridView1.SelectedRows[0];
                string selectedstore = selectedrow.Cells["StoreUserName"].Value.ToString();
                int res = Controllerobj.Add_Partner(Publisherusername, selectedstore);
                if (res == 0)
                {
                    MessageBox.Show("PartnerShip Failed");
                    return;
                }
                else
                {
                    MessageBox.Show("Partnership Successful");
                }
                DataTable dt = Controllerobj.Get_Partnered_Stores(Publisherusername);
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Refresh();

            }
        }
    }
}
