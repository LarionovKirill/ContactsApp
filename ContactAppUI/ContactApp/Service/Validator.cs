﻿using ContactApp.Model;

namespace ContactApp.Service
{
    /// <summary>
    /// Класс валидатор полей класса <see cref="Contact"/>.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверка переданной строки на превышение длины.
        /// </summary>
        /// <param name="word">Переданное слово.</param>
        /// <param name="maxLength">Максимальная длина строки.</param>
        /// <exception cref="ArgumentException">Если длина строки больше переданной.</exception>
        public static void СheckMaxStringLength(string word, int maxLength)
        {
            if (word.Length > maxLength || word.Length == 0)
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Проверка правильности даты рождения человека в контактах.
        /// </summary>
        /// <param name="birtday">Дата рождения</param>
        /// <exception cref="ArgumentException">В случае года ниже 1900 или даты,
        /// которой еще не было на данный момент.</exception>
        public static void CheckBirthDay(DateTime birtday)
        {
            if (birtday > DateTime.Now || birtday.Year < 1900)
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Проверка номера телефона на соответсвие номера телефона России.
        /// </summary>
        /// <param name="number">Номер телефона.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void CheckPhoneNumber(string number)
        {
            if (number.Length != 11 ||
                number[0] != '7' ||
                HasOtherSymbols(number) ||
                number.Length == 0)
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Проверяет строку на соответствие строки номеру телефона.
        /// </summary>
        /// <param name="str">Проверяемая строка.</param>
        /// <returns>True, если имеет символы, отличные от чисел, иначе false.</returns>
        private static bool HasOtherSymbols(string str)
        {
            foreach (var symbol in str)
            {
                if (symbol < '0' || symbol > '9')
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Проверяет, соответсвует ли строка адресу электронной почты.
        /// </summary>
        /// <param name="email">Строка почты.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void IsThatStringEmail(string email)
        {
            if (email.IndexOf('@') != email.LastIndexOf('@') ||
                (email.LastIndexOf('.') < email.LastIndexOf('@')) ||
                (email.IndexOf('@') == -1))
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Делает первый символ переданной строки в верхний регистр.
        /// </summary>
        /// <param name="str">Переданная строка.</param>
        /// <returns>Строку в верхнем регистре.</returns>
        public static string CreateFirstSymbolUpper(string str)
        {
            var a = str[0].ToString();
            a = a.ToUpper();
            var b = a + str.Substring(1, str.Length-1);
            return b;
        }
    }
}
