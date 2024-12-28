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
            ReloadData();
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
            string TName;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                TName = dataGridView1.SelectedRows[0].Cells["TName"].Value.ToString();


                
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    int result = controller.RegStatus(TName,Status);
                    if (result == 0)
                    {
                        MessageBox.Show("Failed to Update Registration Status !");
                        return;
                    }
                    else
                    {
                        ReloadData();
                        MessageBox.Show("Updated Registration Status succesfully !");
                        return;
                    }
                
            }
            else
            {
                MessageBox.Show("Please select a Tournament.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
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
        public void ReloadData()
        {
            DataTable dt = new DataTable();
            dt = controller.Tournamentdata(UserName);
            dataGridView1.DataSource = dt;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
        }
        private void manageregisteration_Load(object sender, EventArgs e)
        {

            ReloadData();
            Open.Checked = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
