﻿using System.Text.RegularExpressions;

namespace Dominio.Utilerias
{
    public static class GenericValidatorText
    {

        public static bool IsUserName(string userName)
        {
            Regex userNameRegularExpression = new Regex(@"\b{1}S\d{8}");

            return userNameRegularExpression.IsMatch(userName);
        }

        public static bool IsTelephoneNumber(string telephoneNumber)
        {
            Regex telephoneNumberRegularExpression = new Regex(@"\d");

            return telephoneNumberRegularExpression.IsMatch(telephoneNumber);
        }

        public static bool IsEmail(string email)
        {
            Regex emailRegularExpresion = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");

            return emailRegularExpresion.IsMatch(email);
        }

        public static bool IsRightExpression(string text)
        {
            Regex rightRegularExpression = new Regex(@"([a-zA-Z]{1,}\s{0,1}){10,}");

            return rightRegularExpression.IsMatch(text);
        }

        public static bool IsPersonName(string name)
        {
            Regex nameRegularExpression = new Regex(@"^[\p{L}\p{M}' \.\-]+$");

            return nameRegularExpression.IsMatch(name);
        }

        public static bool IsANumber(string number)
        {
            Regex numberRegularExpression = new Regex(@"(\d{1,4})$");

            return numberRegularExpression.IsMatch(number);
        }

    }
}
