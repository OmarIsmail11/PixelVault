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
    public partial class BrowseGames : UserControl
    {
        Controller controllerObj = new Controller();
        public string UserName;
        public BrowseGames()
        {
            InitializeComponent();
        }

        private void BrowseGames_Load(object sender, EventArgs e)
        {
            DataTable allGames = controllerObj.RetreiveAllGames();
            AllGamesDataGridView.DataSource = allGames;
            AllGamesDataGridView.Refresh();

            DataTable recommendedGames = controllerObj.GetGameRecommendations(UserName);
            RecommendedGamesDataGrid.DataSource = recommendedGames;
            RecommendedGamesDataGrid.Refresh();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            string Genre;
            if (GenreCheckedListBox.SelectedItem != null) Genre = GenreCheckedListBox.Text;
            else return;

            DataTable result = controllerObj.FilterGames(Genre);
            AllGamesDataGridView.DataSource = result;
            AllGamesDataGridView.Refresh();
        }

        private void GenreCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                // Uncheck all other items
                for (int i = 0; i < GenreCheckedListBox.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        GenreCheckedListBox.SetItemChecked(i, false);
                    }
                }

                // Update the selected item to the newly checked item
                GenreCheckedListBox.SelectedItem = GenreCheckedListBox.Items[e.Index];
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                // If the unchecked item was the selected item, clear the selection
                if (GenreCheckedListBox.SelectedItem == GenreCheckedListBox.Items[e.Index])
                {
                    GenreCheckedListBox.SelectedItem = null;
                }
            }
        }

        private void AddToLibraryButton_Click(object sender, EventArgs e)
        {
            if (AllGamesDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = AllGamesDataGridView.SelectedRows[0];
                string GameName = selectedRow.Cells["GameName"].Value.ToString();
                int alreadyInLibrary = controllerObj.CheckIfGameIsInLibrary(UserName, GameName);
                if (alreadyInLibrary == 1)
                {
                    MessageBox.Show("Game already in library!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    int result = controllerObj.AddGameToLibrary(UserName, GameName);
                    if (result == 0)
                    {
                        MessageBox.Show("Failed to add game to your library!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Game was added to library succesfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataTable recommendedGames = controllerObj.GetGameRecommendations(UserName);
                        RecommendedGamesDataGrid.DataSource = recommendedGames;
                        RecommendedGamesDataGrid.Refresh();
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a game!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddRecommendedGameButton_Click(object sender, EventArgs e)
        {
            if (RecommendedGamesDataGrid.SelectedRows.Count > 0)
            {
                var selectedRow = RecommendedGamesDataGrid.SelectedRows[0];
                string GameName = selectedRow.Cells["GameName"].Value.ToString();
                int alreadyInLibrary = controllerObj.CheckIfGameIsInLibrary(UserName, GameName);
                if (alreadyInLibrary == 1)
                {
                    MessageBox.Show("Game already in library!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    int result = controllerObj.AddGameToLibrary(UserName, GameName);
                    if (result == 0)
                    {
                        MessageBox.Show("Failed to add game to your library!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Game was added to library succesfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataTable recommendedGames = controllerObj.GetGameRecommendations(UserName);
                        RecommendedGamesDataGrid.DataSource = recommendedGames;
                        RecommendedGamesDataGrid.Refresh();
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a game!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string search = SearchTextBox.Text;
            if (search == "" || search == "Search game")
            {
                AllGamesDataGridView.DataSource = controllerObj.RetreiveAllGames();
                AllGamesDataGridView.Refresh();
                return;
            }
            DataTable result = controllerObj.SearchGame(search);
            AllGamesDataGridView.DataSource = result;
            AllGamesDataGridView.Refresh();
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox; // Cast sender to TextBox
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Search game"; // Restore placeholder text
                textBox.ForeColor = Color.Gray;
            }
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox; // Cast sender to TextBox
            if (textBox != null && textBox.Text == "Search game")
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }
    }
}
