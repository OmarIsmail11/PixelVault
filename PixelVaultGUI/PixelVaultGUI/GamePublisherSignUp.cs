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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PixelVaultGUI
{
    public partial class GamePublisherSignUp : Form
    {
        private static bool PasswordIsHidden = false;
        Controller controllerObj = new Controller();
        public GamePublisherSignUp()
        {
            InitializeComponent();
            ShowHideButton.Image = Properties.Resources.Hide_password;
        }

        private void GamePublisherSignUp_Load(object sender, EventArgs e)
        {
            // Set the DateTimePicker format to custom
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            // Set the custom format to display only day, month, and year
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

            string[] countries =
                {
                    "Australia", "Brazil", "Canada", "Egypt", "France", "Germany", "India", "Italy",
                    "Japan", "Mexico", "New Zealand", "Singapore", "South Korea","Spain", "UK", "USA"
                };

            CountryComboBox.DataSource = countries;

            DataTable consoleTypes = controllerObj.RetrieveAllConsoleTypes();
            ConsoleTypeComboBox.DataSource = consoleTypes;
            ConsoleTypeComboBox.DisplayMember = "ConsoleType";
        }

        private void ShowHideButton_Click(object sender, EventArgs e)
        {
            if (PasswordIsHidden)
            {
                ShowHideButton.Image = Properties.Resources.Hide_password;
                PasswordTextBox.UseSystemPasswordChar = false;
                ReEnterPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                ShowHideButton.Image = Properties.Resources.Show_password;
                PasswordTextBox.UseSystemPasswordChar = true;
                ReEnterPasswordTextBox.UseSystemPasswordChar = true;
            }
            PasswordIsHidden = !PasswordIsHidden;
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string UserName = UserNameTextBox.Text;
            if (!Validations.ValidateUserName(UserName)) return;

            string RealName = RealNameTextBox.Text;
            if (!Validations.ValidateRealName(RealName)) return;

            DateTime selectedDate = dateTimePicker1.Value;
            string StartDate = selectedDate.ToString("yyyy-MM-dd");

            string country = CountryComboBox.Text;

            string ConsoleType = ConsoleTypeComboBox.Text;

            string password = PasswordTextBox.Text;
            if (!Validations.ValidatePassword(password)) return;

            string ReEnterPassword = ReEnterPasswordTextBox.Text;
            if (ReEnterPassword == "")
            {
                MessageBox.Show("Invalid! Please re-enter password in the required field!");
                return;
            }
            if (password != ReEnterPassword)
            {
                MessageBox.Show("Invalid! Passwords must be the same!");
                return;
            }

            if (!Validations.CheckIfNewUserNameNotAlreadyExisiting(UserName)) return;

            int InsertResult = controllerObj.InsertNewGamePublisherIntoUserPasswordsAuthorizationTable(UserName, password);
            if (InsertResult == 0)
            {
                MessageBox.Show("Error ! Account was not created!");
                return;
            }

            int InsertResult2 = controllerObj.InsertNewGamePublisherIntoGamePublisherTable(UserName, RealName, country, ConsoleType, StartDate);
            if (InsertResult2 == 0)
            {
                MessageBox.Show("Error ! Account was not created!");
                return;
            }
            else
            {
                MessageBox.Show("Account created succesfully !");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
