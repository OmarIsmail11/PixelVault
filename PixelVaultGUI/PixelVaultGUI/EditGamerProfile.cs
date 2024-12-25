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
    public partial class EditGamerProfile : Form
    {
        public string GamerUserName;
        Controller controllerObj = new Controller();
        public EditGamerProfile()
        {
            InitializeComponent();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string password = PasswordTextBox.Text;
            if (!Validations.ValidatePassword(password)) return;

            string passwordReEnter = NewPasswordTextBox.Text;
            if (passwordReEnter == "")
            {
                MessageBox.Show("Invalid! Please re-enter password in the required field!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password != passwordReEnter)
            {
                MessageBox.Show("Invalid! Passwords must be the same!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int isAlreadyUsed = controllerObj.CheckIfNewPasswordAlreadyUsed(GamerUserName, password);
            if (isAlreadyUsed != 0)
            {
                MessageBox.Show("Invalid! New password can't be the same as your current password!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int result = controllerObj.UpdatePassword(GamerUserName, password);
            if (result == 0)
            {
                MessageBox.Show("Error! Password wasn't updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Password updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
        }
    }
}
