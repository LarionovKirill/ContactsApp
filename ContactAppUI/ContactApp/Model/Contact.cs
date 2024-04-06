using ContactApp.Service;

namespace ContactApp.Model
{
    /// <summary>
    /// Класс контакта пользователя.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Эл. почта контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Дата рождения человека в контактах.
        /// </summary>
        private DateTime _birthday;

        /// <summary>
        /// Vk ID человека в контактах.
        /// </summary>
        private string _vkID;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private PhoneNumber _phoneNumber;

        /// <summary>
        /// Конструктор класса <see cref="Contact"/> без параметров.
        /// </summary>
        public Contact()
        {
            PhoneNumber = new PhoneNumber();
        }

        /// <summary>
        /// Конструктор класса <see cref="Contact"/> с параметрами.
        /// </summary>
        /// <param name="surname">Фамилия.</param>
        /// <param name="name">Имя.</param>
        /// <param name="email">Эл. почта.</param>
        /// <param name="birtday">День рождения.</param>
        /// <param name="vkID">Vk ID.</param>
        /// <param name="number">Номер телефона.</param>
        public Contact(
            string surname,
            string name,
            string email,
            DateTime birtday,
            string vkID,
            string number)
        {
            Surname = surname;
            Name = name;
            Email = email;
            Birthday = birtday;
            VkID = vkID;
            PhoneNumber = new PhoneNumber(number);
            
        }

        /// <summary>
        /// Возвращает и задает фамилию контакта.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                Validator.СheckMaxStringLength(value, 50);
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.СheckMaxStringLength(value, 50);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает эл. почту контакта.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                Validator.СheckMaxStringLength(value, 50);
                Validator.IsThatStringEmail(value);
                _email = value;
            }
        }

        /// <summary>
        /// Возвращает и задает Vk ID человека в контактах.
        /// </summary>
        public string VkID
        {
            get
            {
                return _vkID;
            }
            set
            {
                Validator.СheckMaxStringLength(value, 15);
                _vkID = value;
            }
        }

        /// <summary>
        /// Возвращает и задает дату рождения контакта.
        /// </summary>
        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }
            set
            {
                Validator.CheckBirthDay(value);
                _birthday = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта.
        /// </summary>
        public PhoneNumber PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }
    }
}
