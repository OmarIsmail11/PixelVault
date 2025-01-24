using DBapplication;

namespace PixelVaultGUI
{
    public partial class StoreSignUp : Form
    {
        Controller controller = new Controller();
        public static bool PasswordIsHidden = true;
        public StoreSignUp()
        {
            InitializeComponent();
        }

        private void Show_Hide_Pass_Click(object sender, EventArgs e)
        {
            if (!PasswordIsHidden)
            {
                Show_Hide_Pass.Image = Properties.Resources.Show_password;
                Password.UseSystemPasswordChar = false;
                RePassword.UseSystemPasswordChar = false;
            }
            else
            {
                Show_Hide_Pass.Image = Properties.Resources.Hide_password;
                Password.UseSystemPasswordChar = true;
                RePassword.UseSystemPasswordChar = true;
            }
            PasswordIsHidden = !PasswordIsHidden;
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            string UserName = StoreUserName.Text;
            if (!Validations.ValidateUserName(UserName)) return;
            string RealName = StoreRealName.Text;
            if (!Validations.ValidateRealName(RealName)) return;
            int Ratings;
            if (Validations.Isinteger(Rating.Text, out Ratings))
            {
                if (Validations.Isinrange(Rating.Text, 1, 5))
                {
                    Ratings = Convert.ToInt32(Rating.Text);
                }
                else
                {
                    MessageBox.Show("Rating must be between 1 and 5");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Rating must be an integer");
                return;
            }
            int hotline;
            if (Validations.Isinteger(Hotline.Text, out hotline))
            {
                if (Validations.IsPositive(Hotline.Text))
                {
                    if (Validations.StringLengthIsinrange(Hotline.Text, 1, 10))
                        hotline = Convert.ToInt32(Hotline.Text);
                    else
                    {
                        MessageBox.Show("Hotline must be max 10 numbers!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Hotline must be positive");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Hotline must be an integer");
                return;
            }
            string password = Password.Text;
            if (!Validations.ValidatePassword(password)) return;

            string repassword = RePassword.Text;
            if (repassword == "")
            {
                MessageBox.Show("Invalid! Please re-enter password in the required field!");
                return;
            }
            if (password != repassword)
            {
                MessageBox.Show("Invalid! Passwords must be the same!");
                return;
            }
            if (!Validations.CheckIfNewUserNameNotAlreadyExisiting(UserName)) return;

            int result = controller.InsertNewStoreIntoUserPasswordsAuthorizationTable(UserName, password);
            if (result == 0)
            {
                MessageBox.Show("Error Acount was not created!");
                return;
            }
            int InsertResult2 = controller.InsertNewStoreIntoStoreTable(UserName, RealName, Ratings, hotline);
            if (InsertResult2 == 0)
            {
                MessageBox.Show("Error ! Account was not created!");
                return;
            }
            else
            {
                MessageBox.Show("Account created succesfully !");
                this.Close();
                StoreMain storeMain = new StoreMain(UserName);
                storeMain.Show();
                this.Hide();
                return;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void StoreSignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
