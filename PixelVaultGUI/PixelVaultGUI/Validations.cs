using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Mail;
using DBapplication;

namespace PixelVaultGUI
{
    internal static class Validations
    {
        public static bool Isinteger(string input, out int val)
        {
            return int.TryParse((input), out val);
        }
        public static bool IsLongInteger(string input,out long val)
        {
            return long.TryParse((input), out val);
        }
        public static bool IsAlphabetic(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool hasWhiteSpace(string input)
        {
            return input.Any(char.IsWhiteSpace);
        }

        public static bool startsWithNumber(string input)
        {
            string firstLetter = Convert.ToString(input[0]);
            int num;
            return (int.TryParse(firstLetter, out num));
        }
        public static bool Isfloat(string input, out float val)
        {
            return float.TryParse((input), out val);
        }

        public static bool Isempty(string input)
        {
            if (input == "") return true;
            return false;
        }
        public static bool Istoolong(string input, int maxlen)
        {
            if (input.Length > maxlen)
            {
                return false;
            }
            return true;
        }
        public static bool Isinrange(string input, int minval, int maxval) //for numbers
        {
            int num;
            int.TryParse((input), out num);
            if (num > maxval || num < minval)
            {
                return false;
            }
            return true;
        }

        public static bool StringLengthIsinrange(string input, int minval, int maxval)
        {
            int num = input.Length;
            if (num > maxval || num < minval)
            {
                return false;
            }
            return true;
        }

        public static bool ValidatePassword(string password)
        {
            if (Isempty(password)) //Checks if empty
            {
                MessageBox.Show( "Password is empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
            if (!StringLengthIsinrange(password, 8, 20)) //Checks if length between 8-20
            {
                MessageBox.Show("Password must be at least 8 characters!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var hasNumber = new Regex("[0-9]+");
            var hasUpperChar = new Regex("[A-Z]+");
            var hasLowerChar = new Regex("[a-z]+");
            var hasSpecialSymbol = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasNumber.IsMatch(password)) //Checks if has at least one number
            {
                MessageBox.Show("Password must contain at least one number!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!hasUpperChar.IsMatch(password)) //Checks if has at least one uppercase letter
            {
                MessageBox.Show("Password must contain at least one uppercase letter!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!hasLowerChar.IsMatch(password)) //Checks if has at least one lowercase letter
            {
                MessageBox.Show("Password must contain at least one lowercase letter!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!hasSpecialSymbol.IsMatch(password)) //Checks if has at least one special symbol
            {
                MessageBox.Show("Password must contain at least one special symbol!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool ValidateUserName(string userName)
        {
            if (Isempty(userName))
            {
                MessageBox.Show("Username is empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!StringLengthIsinrange(userName, 5, 30))
            {
                MessageBox.Show("Username must be at least 5 characters!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (hasWhiteSpace(userName))
            {
                MessageBox.Show("Username can't have whitespaces!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (startsWithNumber(userName))
            {
                MessageBox.Show("Username can't start with a number!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var hasInvalidSpecialSymbol = new Regex(@"[!@#%^&*()+=\[{\]};:<>|/?,]");
            var ValidSpecialSymbols = new Regex(@"[$_.-]");

            if (hasInvalidSpecialSymbol.IsMatch(userName))
            {
                MessageBox.Show("Username can only contain any of the following symbols ($,_,.,-)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool CheckIfNewUserNameNotAlreadyExisiting(string userName)
        {
            Controller controllerObj = new Controller();
            int UserNameExists = controllerObj.CheckIfUserNameExists(userName); //1 for exists & 0 otherwise
            if (UserNameExists == 1)
            {
                MessageBox.Show("Username is already taken!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static bool ValidateName(string name)
        {
            if (Isempty(name))
            {
                MessageBox.Show("Name is empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsAlphabetic(name))
            {
                MessageBox.Show("Name must contain only alphabetic letters!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!StringLengthIsinrange(name,5, 30))
            {
                MessageBox.Show("Name must be at least 5 characters!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool ValidateFirstName(string name)
        {
            if (Isempty(name))
            {
                MessageBox.Show("First Name is empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsAlphabetic(name))
            {
                MessageBox.Show("First name must contain only alphabetic letters!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!StringLengthIsinrange(name, 1, 30))
            {
                MessageBox.Show("First name is too long!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool ValidateLastName(string name)
        {
            if (Isempty(name))
            {
                MessageBox.Show("Last Name is empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsAlphabetic(name))
            {
                MessageBox.Show("Last name must contain only alphabetic letters!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!StringLengthIsinrange(name, 1, 30))
            {
                MessageBox.Show("Last name is too long!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool ValidateRealName(string name)
        {
            if (Isempty(name))
            {
                MessageBox.Show("Real Name is empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!StringLengthIsinrange(name, 1, 30))
            {
                MessageBox.Show("Real name is too long!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static bool isValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email is empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                // Use MailAddress class to validate email format
                var addr = new MailAddress(email);
                return true;

            }
            catch
            {
                MessageBox.Show("Invalid email address!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool CheckIfEmailTaken(string email)
        {
            Controller controllerObj = new Controller();
            int UserNameExists = controllerObj.CheckIfEmailAlreadyAssociatedWithAnAccount(email); //1 for exists & 0 otherwise
            if (UserNameExists == 1)
            {
                MessageBox.Show("This email is associated with an account!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static bool IsPositive(string Number)
        {
            int num;
            int.TryParse(Number, out num);
            if (num >= 0) return true;
            return false;

        }
    }
}
