using ContactApp.Service;

namespace ContactApp.Model
{
    /// <summary>
    /// Класс номера телефона пользователя.
    /// </summary>
    public class PhoneNumber
    {
        /// <summary>
        /// Номер телефона пользователя.
        /// </summary>
        private string _phone;

        /// <summary>
        /// Конструктор класса <see cref="PhoneNumber"/> без параметров.
        /// </summary>
        public PhoneNumber()
        {
            
        }

        /// <summary>
        /// Конструктор класса <see cref="PhoneNumber"/> с параметрами.
        /// </summary>
        /// <param name="number">Номер телефона.</param>
        public PhoneNumber(string number)
        {
            Phone = number;
        }

        /// <summary>
        /// Возвращает и задает номер телефона пользователя.
        /// </summary>
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                Validator.CheckPhoneNumber(value);
                _phone = value;
            }
        }
    }
}
