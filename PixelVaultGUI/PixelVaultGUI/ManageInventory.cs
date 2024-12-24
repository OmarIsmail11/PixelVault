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
    public partial class ManageInventory : UserControl
    {
        Controller controller = new Controller();
        public string UserName;
        public ManageInventory()
        {
            
            InitializeComponent();
            dataGridView1.DataSource = controller.GetInventory(UserName);
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
