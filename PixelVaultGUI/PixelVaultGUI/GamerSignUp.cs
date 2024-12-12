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
    public partial class GamerSignUp : Form
    {
        Controller controllerObj = new Controller();

        public static bool PasswordIsHidden = true;
        public GamerSignUp()
        {
            InitializeComponent();
        }

        private void GamerSignUp_Load(object sender, EventArgs e)
        {
            // Set the DateTimePicker format to custom
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            // Set the custom format to display only day, month, and year
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

            string[] countries =
                {
                    "Italy", "Singapore", "Spain", "UK", "USA", "India", "Australia", "Japan", "Canada",
                    "France", "Mexico", "South Korea", "Germany", "Spain", "Brazil", "New Zealand", "Egypt"
                };

            CountryComboBox.DataSource = countries;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string UserName = UserNameTextBox.Text;
            if (!Validations.ValidateUserName(UserName)) return;

            string FirstName = FirstNameTextBox.Text;
            if (!Validations.ValidateFirstName(FirstName)) return;

            string LastName = LastNameTextBox.Text;
            if (!Validations.ValidateLastName(LastName)) return;

            string email = EmailTextBox.Text;
            if (!Validations.isValidEmail(email)) return;

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

            DateTime selectedDate = dateTimePicker1.Value;
            string BirthDate = selectedDate.ToString("yyyy-MM-dd");

            string country = CountryComboBox.Text;

            if (!Validations.CheckIfNewUserNameNotAlreadyExisiting(UserName)) return;

            int InsertResult = controllerObj.InsertNewGamerIntoGamerTable(UserName, FirstName, LastName, email, country, BirthDate);
            if (InsertResult == 0)
            {
                MessageBox.Show("Error ! Account was not created!");
                return;
            }

            int InsertResult2 = controllerObj.InsertNewGamerIntoUserPasswordsAuthorizationTable(UserName, password);
            if (InsertResult == 0)
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

        private void ShowHideButton_Click(object sender, EventArgs e)
        {
            if (PasswordIsHidden)
            {
                ShowHideButton.Image = Properties.Resources.Show_password;
                PasswordTextBox.UseSystemPasswordChar = false;
                ReEnterPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                ShowHideButton.Image = Properties.Resources.Hide_password;
                PasswordTextBox.UseSystemPasswordChar = true;
                ReEnterPasswordTextBox.UseSystemPasswordChar = true;
            }
            PasswordIsHidden = !PasswordIsHidden;
        }
    }
}
