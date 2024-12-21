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
    public partial class Tournaments : UserControl
    {
        Controller controllerObj = new Controller();
        public string GamerUserName;
        public Tournaments()
        {
            InitializeComponent();
        }

        private void Tournaments_Load(object sender, EventArgs e)
        {
            DataTable tournaments = controllerObj.RetreieveTournamentsEntrolledIn(GamerUserName);
            EnrolledInTournaments.DataSource = tournaments;
            EnrolledInTournaments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EnrolledInTournaments.Refresh();
        }
        public void RefreshTournaments()
        {
            DataTable tournaments = controllerObj.RetreieveTournamentsEntrolledIn(GamerUserName);
            EnrolledInTournaments.DataSource = tournaments;
            EnrolledInTournaments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EnrolledInTournaments.Refresh();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tournamentName;
            if (EnrolledInTournaments.SelectedRows.Count > 0)
            {
                tournamentName = EnrolledInTournaments.SelectedRows[0].Cells["Name"].Value.ToString().Trim();

                var output = MessageBox.Show($"Are you sure you want to unenroll from: {tournamentName}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (output == DialogResult.Yes)
                {
                    EnrolledInTournaments.Rows.RemoveAt(EnrolledInTournaments.SelectedRows[0].Index);
                    int result1 = controllerObj.UnenrollFromTournament(GamerUserName, tournamentName);
                    if (result1 == 0)
                    {
                        MessageBox.Show("Failed to unenroll from tournament!");
                        return;
                    }

                    int result2 = controllerObj.IncrementAvailableSlots(tournamentName);
                    if (result2 == 0)
                    {
                        MessageBox.Show("Failed to unenroll from tournament!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Unenrolled from tournament succesfully!");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a tournament to unenroll from.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
