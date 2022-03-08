using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrition_App.Models
{
    public sealed class Email
    {
        public string EmailAddres { get; private set; }

        public Email(string input)
        {
            if (!IsCorrect(input))
                throw new ArgumentException("Niepoprawny adres email");

            EmailAddres = input;
        }

        public static bool IsCorrect(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            if (!input.Contains("@"))
            {
                return false;
                throw new ArgumentException("Niepoprawny adres E-mail, adres nie zawiera @");
            }

            return true;
        }
    }
}
