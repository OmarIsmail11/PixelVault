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
            DataTable GamesInTournaments = controllerObj.RetreiveAllGamesInTournaments();
            GameComboBox.DataSource = GamesInTournaments;
            GameComboBox.DisplayMember = "GameName";
            GameComboBox.SelectedIndex = -1;
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            string Genre;
            if (GenreCheckedListBox.SelectedItem != null) Genre = GenreCheckedListBox.Text;
            else Genre = "";

            string Region;
            if (RegionCheckedListBox.SelectedItem != null) Region = RegionCheckedListBox.Text;
            else Region = "";

            string Type;
            if (TypeCheckedListBox.SelectedItem != null) Type = TypeCheckedListBox.Text;
            else Type = "";

            string SortBy;
            if (SortByCheckedListBox.SelectedItem != null) SortBy = SortByCheckedListBox.Text;
            else SortBy = "";

            string Game;
            if (GameComboBox.SelectedItem != null) Game = GameComboBox.Text;
            else Game = "";

            DataTable result = controllerObj.FilterTournaments(Genre, Region, Type, Game, SortBy);
            LiveTournamentsDataGrid.DataSource = result;
            LiveTournamentsDataGrid.Refresh();
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
                string Status = selectedRow.Cells["Registration_Status"].Value.ToString();

                if (AvailableSpots != 0 && Status != "Closed")
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
                    MessageBox.Show("Sorry tournament is full or registration is closed!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a tournament!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "") return;
            else
            {
                string search = SearchTextBox.Text;
                DataTable result = controllerObj.SearchTournamentGame(search);
                LiveTournamentsDataGrid.DataSource = result;
                LiveTournamentsDataGrid.Refresh();
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox; // Cast sender to TextBox
            if (textBox != null && textBox.Text == "Search game or tournament")
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox; // Cast sender to TextBox
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Search game or tournament"; // Restore placeholder text
                textBox.ForeColor = Color.Gray;
            }
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

        private void RegionCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                // Uncheck all other items
                for (int i = 0; i < RegionCheckedListBox.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        RegionCheckedListBox.SetItemChecked(i, false);
                    }
                }

                // Update the selected item to the newly checked item
                RegionCheckedListBox.SelectedItem = RegionCheckedListBox.Items[e.Index];
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                // If the unchecked item was the selected item, clear the selection
                if (RegionCheckedListBox.SelectedItem == RegionCheckedListBox.Items[e.Index])
                {
                    RegionCheckedListBox.SelectedItem = null;
                }
            }
        }

        private void TypeCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                // Uncheck all other items
                for (int i = 0; i < TypeCheckedListBox.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        TypeCheckedListBox.SetItemChecked(i, false);
                    }
                }

                // Update the selected item to the newly checked item
                TypeCheckedListBox.SelectedItem = TypeCheckedListBox.Items[e.Index];
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                // If the unchecked item was the selected item, clear the selection
                if (TypeCheckedListBox.SelectedItem == TypeCheckedListBox.Items[e.Index])
                {
                    TypeCheckedListBox.SelectedItem = null;
                }
            }
        }

        private void SortByCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                // Uncheck all other items
                for (int i = 0; i < SortByCheckedListBox.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        SortByCheckedListBox.SetItemChecked(i, false);
                    }
                }

                // Update the selected item to the newly checked item
                SortByCheckedListBox.SelectedItem = SortByCheckedListBox.Items[e.Index];
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                // If the unchecked item was the selected item, clear the selection
                if (SortByCheckedListBox.SelectedItem == SortByCheckedListBox.Items[e.Index])
                {
                    SortByCheckedListBox.SelectedItem = null;
                }
            }
        }
    }
}
