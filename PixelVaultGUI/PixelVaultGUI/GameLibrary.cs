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
    public partial class GameLibrary : UserControl
    {
        Controller controllerObj = new Controller();
        public string GamerUserName;
        public GameLibrary()
        {
            InitializeComponent();
            DataTable yourGames = controllerObj.RetreiveGamerGamesLibrary(GamerUserName);
            YourGamesDataGridView.DataSource = yourGames;
            YourGamesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            YourGamesDataGridView.Refresh();
        }

        private void GameLibrary_Load(object sender, EventArgs e)
        {
            DataTable yourGames = controllerObj.RetreiveGamerGamesLibrary(GamerUserName);
            YourGamesDataGridView.DataSource = yourGames;
            YourGamesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            YourGamesDataGridView.Refresh();
        }
        public void RefreshLibrary()
        {
            DataTable yourGames = controllerObj.RetreiveGamerGamesLibrary(GamerUserName);
            YourGamesDataGridView.DataSource = yourGames;
            YourGamesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            YourGamesDataGridView.Refresh();
        }
        private void button1_Click(object sender, EventArgs e) //Remove Game Button
        {
            string gameName;
            if (YourGamesDataGridView.SelectedRows.Count > 0)
            {
                gameName = YourGamesDataGridView.SelectedRows[0].Cells["Name"].Value.ToString();

                var output = MessageBox.Show($"Are you sure you want to remove the game: {gameName}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (output == DialogResult.Yes)
                {
                    YourGamesDataGridView.Rows.RemoveAt(YourGamesDataGridView.SelectedRows[0].Index);
                    int result = controllerObj.RemoveGameFromLibrary(gameName);
                    if (result == 0)
                    {
                        MessageBox.Show("Failed to remove game !");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Game was removed succesfully !");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a game to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void UpdateGameCompletionButton_Click(object sender, EventArgs e)
        {
            if (YourGamesDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = YourGamesDataGridView.SelectedRows[0];

                string gameName = selectedRow.Cells["Name"].Value.ToString();

                string newStatus = Microsoft.VisualBasic.Interaction.InputBox(
                    $"Enter the new Completion Status for '{gameName}' (YES/NO):",
                    "Update Completion Status",
                    selectedRow.Cells["Completed"].Value?.ToString() ?? "");

                if (string.Equals(newStatus, "YES", StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(newStatus, "NO", StringComparison.OrdinalIgnoreCase))
                {
                    selectedRow.Cells["Completed"].Value = newStatus.ToUpper();
                    int result = controllerObj.UpdateCompletionStatus(gameName, newStatus, GamerUserName);
                    if (result == 0)
                    {
                        MessageBox.Show("Failed to update completion status");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Completion status was updated succesfully !");
                        return;
                    }
                }
                else
                {
                    // Show an error message for invalid input
                    MessageBox.Show("Invalid input! Please enter 'YES' or 'NO' only.",
                                    "Invalid Input",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RateGameButton_Click(object sender, EventArgs e)
        {
            string gameName;
            if (YourGamesDataGridView.SelectedRows.Count > 0)
            {
                gameName = YourGamesDataGridView.SelectedRows[0].Cells["Name"].Value.ToString();
                var selectedRow = YourGamesDataGridView.SelectedRows[0];
                RateGame rateGame = new RateGame(GamerUserName, gameName, selectedRow);
                rateGame.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a game to rate.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
