using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LoginApp.Models
{
    public class UserData
    {
        public UserData(string login, string password, string email)
        {
            if (String.IsNullOrWhiteSpace(login) || login.Length < 2)
                throw new Exception();

            if (String.IsNullOrWhiteSpace(password) || password.Length < 3)
                throw new Exception();

            if (String.IsNullOrWhiteSpace(email) || !CheckEmailPropriety(email))
                throw new Exception();

            Login = login;
            Password = password;
            Email = email;
        }

        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        private bool CheckEmailPropriety(string email)
        {
            bool result = false;

            string RegularExpresion = @"^[A-Za-zżźćńółęąśŻŹĆĄŚĘŁÓŃ]+\.?[A-Za-zżźćńółęąśŻŹĆĄŚĘŁÓŃ0-9]+@[A-Za-zżźćńółęąśŻŹĆĄŚĘŁÓŃ]+\.[A-Za-zżźćńółęąśŻŹĆĄŚĘŁÓŃ]{2,3}$";
            Regex regex = new Regex(RegularExpresion);

            if (regex.IsMatch(email))
            {
                result = true;
            }

            return result;
        }
    }
}
