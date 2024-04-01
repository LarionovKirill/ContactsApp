using ContactApp.Model;

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
            if (word.Length > maxLength)
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
            if (birtday > DateTime.Now || birtday.Year<1900)
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
            if (number.Length != 11 || number[0] != '7' || HasOtherSymbols(number))
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
    }
}
