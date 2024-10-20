using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomValidator.Models
{
    public class CustomValidatorClass
    {
        public bool ValidateUserName(string username)
        {
            return username.Length >= 2;
        }
        public bool ValidatePassword(string password)
        {
            var passwordPattern = @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+=\[{\]};:<>|./?,-]).{8,}$";
            return Regex.IsMatch(password, passwordPattern) && password.Length >= 8;
        }
        public bool ValidateName(string name)
        {
            return name.Length >= 2;
        }
        public bool ValidateSurName(string surname)
        {
            return surname.Length >= 2;
        }
        public bool ValidateAge(byte age)
        {
            return age > 0;
        }
        public bool ValidateBirthday(DateTime birthday)
        {
            return birthday.Year >= 1970;
        }
    }
}
