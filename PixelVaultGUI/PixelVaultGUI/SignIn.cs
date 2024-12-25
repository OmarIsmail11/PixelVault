using DBapplication;
using System.ComponentModel.DataAnnotations;

namespace PixelVaultGUI
{
    public partial class SignIn : Form
    {
        private static bool PasswordIsHidden = true;
        Controller controllerObj = new Controller();
        public SignIn()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ShowHideButton_Click(object sender, EventArgs e)
        {
            if (PasswordIsHidden)
            {
                ShowHideButton.Image = Properties.Resources.Show_password;
                PasswordSignInTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                ShowHideButton.Image = Properties.Resources.Hide_password;
                PasswordSignInTextBox.UseSystemPasswordChar = true;
            }
            PasswordIsHidden = !PasswordIsHidden;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string UserName = UserNameSignInTextBox.Text;
            if (!Validations.ValidateUserName(UserName))
            {
                UserNameSignInTextBox.Text = "";
                PasswordSignInTextBox.Text = "";
                return;
            }

            string Password = PasswordSignInTextBox.Text;
            if (Validations.Isempty(Password))
            {
                MessageBox.Show("Invalid ! Password is empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameSignInTextBox.Text = "";
                PasswordSignInTextBox.Text = "";
                return;
            }

            string Authorization = controllerObj.CheckCredentials(UserName, Password);
            if (Authorization == "")
            {
                MessageBox.Show("Incorrect username or password!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameSignInTextBox.Text = "";
                PasswordSignInTextBox.Text = "";
                return;
            }
            if (Authorization == "Gamer")
            {
                MessageBox.Show($"Welcome back, {UserName}!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                GamerMain gamerMain = new GamerMain(UserName);
                gamerMain.ShowDialog();
                this.UserNameSignInTextBox.Text = "";
                this.PasswordSignInTextBox.Text = "";
                this.Show();


                //Open Gamer Form
            }
            else if (Authorization == "Game Store")
            {
                MessageBox.Show($"Welcome back, {UserName}!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                StoreMain storeMain = new StoreMain(UserName);
                storeMain.ShowDialog();
                storeMain.Show();
                //Open Game Store Form
            }
            else if (Authorization == "Game Publisher")
            {
                MessageBox.Show("Welcome back " + UserName + "! (Opens Publisher)");
                //Open Game Publisher Form
                this.Hide();
                GamePublisherMain gamerpublisherMain = new GamePublisherMain(UserName);
                gamerpublisherMain.ShowDialog();
                this.Show();
            }
            else if (Authorization == "Admin")
            {
                MessageBox.Show("Welcome back " + UserName + "! (Opens Admin)");
                this.Hide();
                Admin_Edit admin_Edit = new Admin_Edit();
                admin_Edit.ShowDialog();
                this.Show();
                //Open Admin Form
                //Ba2ollak ya tarek ma3ak shelen ? Eh ? Arken Belen.
            }

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            //this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
