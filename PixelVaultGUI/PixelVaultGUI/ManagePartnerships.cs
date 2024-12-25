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
    public partial class ManagePartnerships : UserControl
    {
        public string SUserName;
        Controller controller = new Controller();
        //ManageInventory inventory = new ManageInventory();
        public ManagePartnerships()
        {
            InitializeComponent();
            ReloadData();
        }
        public void ReloadData()
        {
            DataTable dataTable = new DataTable();
            dataTable = controller.getPartners(SUserName);
            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();

        }
        private void RemovePub_Click(object sender, EventArgs e)
        {
            string PName;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                PName = dataGridView1.SelectedRows[0].Cells["PUserName"].Value.ToString();

                var output = MessageBox.Show($"Are you sure you want to remove the publisher: {PName}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (output == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    int result = controller.RemovePartner(SUserName, PName);
                    if (result == 0)
                    {
                        MessageBox.Show("Failed to remove Partner !");
                        return;
                    }
                    else
                    {
                        ReloadData();

                        MessageBox.Show("Partner was removed succesfully !");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Partner to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ManagePartnerships_Load(object sender, EventArgs e)
        {
            ReloadData();
        }
    }
}
