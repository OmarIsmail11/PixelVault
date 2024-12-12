using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PixelVaultGUI
{
    internal static class Validations
    {
        public static bool Isinteger(string input, out int val)
        {
            return int.TryParse((input), out val);
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
            if (Isempty(password)) return false; //Checks if empty
            if (!Isinrange(password, 8, 20)) return false; //Checks if length between 8-20

            var hasNumber = new Regex("[0-9]+");
            var hasUpperChar = new Regex("[A-Z]+");
            var hasLowerChar = new Regex("[a-z]+");
            var hasSpecialSymbol = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasNumber.IsMatch(password)) return false; //Checks if has at least one number
            if (!hasUpperChar.IsMatch(password)) return false; //Checks if has at least one uppercase letter
            if (!hasLowerChar.IsMatch(password)) return false; //Checks if has at least one lowercase letter
            if (!hasSpecialSymbol.IsMatch(password)) return false; //Checks if has at least one special symbol

            return true;
        }

        public static bool ValidateUserName(string userName)
        {
            if (Isempty(userName))
            {
                MessageBox.Show("Invalid ! Username is empty !");
                return false;
            }
            if (!StringLengthIsinrange(userName, 5, 30))
            {
                MessageBox.Show("Invalid ! Username length is out of the valid range (min 8 characters & max 30 characters) !");
                return false;
            }
            if (hasWhiteSpace(userName))
            {
                MessageBox.Show("Invalid ! Username can't have whitespaces !");
                return false;
            }
            if (startsWithNumber(userName))
            {
                MessageBox.Show("Invalid ! Username can't start with a number !");
                return false;
            }

            var hasInvalidSpecialSymbol = new Regex(@"[!@#%^&*()+=\[{\]};:<>|/?,]");
            var ValidSpecialSymbols = new Regex(@"[$_.-]");

            if (hasInvalidSpecialSymbol.IsMatch(userName))
            {
                MessageBox.Show("Invalid ! Username can only have the following symbols ($,_,.,-)");
                return false;
            }
            return true;
        }
    }
}
