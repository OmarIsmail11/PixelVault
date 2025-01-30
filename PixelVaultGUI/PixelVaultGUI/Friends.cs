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
    public partial class Friends : UserControl
    {
        Controller controllerObj = new Controller();
        public string UserName;
        public Friends()
        {
            InitializeComponent();
        }

        private void Friends_Load(object sender, EventArgs e)
        {
            FriendsDataGridView.DataSource = controllerObj.RetreiveUserFriends(UserName);
            FriendsDataGridView.Refresh();
            DataTable RequestsSent = controllerObj.RetreiveSentFriendRequests(UserName);
            SentFriendRequestsDataGridView.DataSource = RequestsSent;
            SentFriendRequestsDataGridView.Refresh();
            DataTable RequestsReceived = controllerObj.RetreiveReceivedFriendRequests(UserName);
            ReceivedFriendRequestsDataGridView.DataSource = RequestsReceived;
            ReceivedFriendRequestsDataGridView.Refresh();


        }

        public void RefreshFriendsList()
        {
            FriendsDataGridView.DataSource = controllerObj.RetreiveUserFriends(UserName);
            FriendsDataGridView.Refresh();
            return;
        }

        public void RefreshSentRequests()
        {
            DataTable RequestsSent = controllerObj.RetreiveSentFriendRequests(UserName);
            SentFriendRequestsDataGridView.DataSource = RequestsSent;
            SentFriendRequestsDataGridView.Refresh();
            return;
        }

        public void RefreshReceivedRequests()
        {
            DataTable RequestsReceived = controllerObj.RetreiveReceivedFriendRequests(UserName);
            ReceivedFriendRequestsDataGridView.DataSource = RequestsReceived;
            ReceivedFriendRequestsDataGridView.Refresh();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void RemoveFriendButton_Click(object sender, EventArgs e)
        {
            if (FriendsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = FriendsDataGridView.SelectedRows[0];
                string FriendUserName = selectedRow.Cells["FriendUserName"].Value.ToString();
                int result = controllerObj.RemoveFriend(UserName, FriendUserName);
                if (result == 0)
                {
                    MessageBox.Show("Failed to remove friend!");
                    return;
                }
                else
                {
                    MessageBox.Show("Friend was removed successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshFriendsList();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a friend!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string search = SearchTextBox.Text;
            DataTable result = controllerObj.SearchGamers(search, UserName);
            AddFriendsDataGridView.DataSource = result;
            AddFriendsDataGridView.Refresh();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string search = SearchTextBox.Text;
            if (search == "") return;
            DataTable result = controllerObj.SearchGamers(search, UserName);
            AddFriendsDataGridView.DataSource = result;
            AddFriendsDataGridView.Refresh();
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox; // Cast sender to TextBox
            if (textBox != null && textBox.Text == "Search gamer user name")
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
                textBox.Text = "Search gamer user name"; // Restore placeholder text
                textBox.ForeColor = Color.Gray;
            }
        }

        private void AddFriendButton_Click(object sender, EventArgs e)
        {
            if (AddFriendsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = AddFriendsDataGridView.SelectedRows[0];
                string FriendUserName = selectedRow.Cells["UserName"].Value.ToString();
                int result1 = controllerObj.CheckIfAlreadySentRequest(UserName, FriendUserName);
                if (result1 == 1)
                {
                    MessageBox.Show("A request was already sent!");
                    return;
                }
                int result3 = controllerObj.CheckIfNotAlreadyFriend(UserName, FriendUserName);
                if (result3 == 1)
                {
                    MessageBox.Show("You are already friends!");
                    return;
                }
                int result2 = controllerObj.CreateFriendRequest(UserName, FriendUserName);
                if (result2 == 0)
                {
                    MessageBox.Show("Failed to sent friend request!");
                    return;
                }
                else
                {
                    MessageBox.Show("Friend request was sent succesfully!");
                    RefreshSentRequests();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a user!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (ReceivedFriendRequestsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = ReceivedFriendRequestsDataGridView.SelectedRows[0];
                string FriendUserName = selectedRow.Cells["UserName"].Value.ToString();
                int result = controllerObj.AddFriend(UserName, FriendUserName);
                if (result == 0)
                {
                    MessageBox.Show("Failed to accept friend request!");
                    return;
                }
                else
                {
                    MessageBox.Show("You and " + FriendUserName + " are now friends!");
                    int temp = controllerObj.DeleteRequest(UserName, FriendUserName);
                    RefreshReceivedRequests();
                    RefreshFriendsList();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a friend request!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (ReceivedFriendRequestsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = ReceivedFriendRequestsDataGridView.SelectedRows[0];
                string FriendUserName = selectedRow.Cells["UserName"].Value.ToString();
                int result = controllerObj.DeleteRequest(UserName, FriendUserName);
                if (result == 0)
                {
                    MessageBox.Show("Failed to decline friend request!");
                    return;
                }
                else
                {
                    MessageBox.Show("Friend request was declined succesfully!");
                    RefreshReceivedRequests();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a friend request!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
