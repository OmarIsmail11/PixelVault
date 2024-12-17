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
    public partial class BrowseTournaments : UserControl
    {
        Controller controllerObj = new Controller();
        public BrowseTournaments()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BrowseTournaments_Load(object sender, EventArgs e)
        {
            DataTable LiveTournaments = controllerObj.RetreiveAllLiveTournaments();
            LiveTournamentsDataGrid.DataSource = LiveTournaments;
            LiveTournamentsDataGrid.Refresh();
        }
    }
}
