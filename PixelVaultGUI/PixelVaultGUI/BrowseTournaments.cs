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
        public string UserName;
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

        private void FilterButton_Click(object sender, EventArgs e)
        {

        }

        private void EnrollButton_Click(object sender, EventArgs e)
        {
            if (LiveTournamentsDataGrid.SelectedRows.Count > 0)
            {
                var selectedRow = LiveTournamentsDataGrid.SelectedRows[0];
                string TournamentName = selectedRow.Cells["TName"].Value.ToString();
                int alreadyEnrolled = controllerObj.CheckIfAlreadyEnrolledInTournament(UserName, TournamentName);
                if (alreadyEnrolled != 0)
                {
                    MessageBox.Show("You are already enrolled in this tournament!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                int AvailableSpots = Convert.ToInt16(selectedRow.Cells["AvailableSpots"].Value);

                if (AvailableSpots != 0)
                {
                    selectedRow.Cells["AvailableSpots"].Value = AvailableSpots - 1;
                    int result = controllerObj.EnrollInTournament(UserName, TournamentName);
                    if (result == 0)
                    {
                        MessageBox.Show("Failed to enroll in tournament!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Enrolled in tournament succesfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Sorry tournament is full!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a tournament!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
