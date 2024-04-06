using ContactApp.Model;
using NUnit.Framework;

namespace ContactApp.UnitTests
{
    /// <summary>
    /// Класс Unit тестов класса <see cref="Contact"/>.
    /// </summary>
    [TestFixture]
    public class ContactTest
    {
        /// <summary>
        /// Поле контакта для тестирования.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Метод создания объекта класса перед запуском каждого тестирования.
        /// </summary>
        [SetUp]
        public void InitContact()
        {
            _contact = new Contact();
        }

        /// <summary>
        /// Позитивный тест геттера Surname.
        /// </summary>
        [Test(Description = "Позитивный тест геттера Surname.")]
        public void TestSurnameGetCurrentValue()
        {
            var expected = "Смирнов";
            _contact.Surname = expected;
            var actual = _contact.Surname;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Позитивный тест сеттера Surname.
        /// </summary>
        [Test(Description = "Позитивный тест геттера Surname.")]
        public void TestSurnameSetCurrentValue()
        {
            var expected = "Смирнов";
            _contact.Surname = expected;
            var actual = _contact.Surname;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase методов проверки сеттера свойства Surname.
        /// </summary>
        /// <param name="wrongSurname">Неверное поле фамилии.</param>
        /// <param name="message">Текст ошибки.</param>
        [TestCase("", "Должно возникать исключение, если фамилия - пустая строка",
            TestName = "Присвоение пустой строки в качестве фамилии")]
        [TestCase("СмирновСмирновСмирновСмирновСмирновСмирновСмирновСмирновСмирнов", 
            "Должно возникать исключение, если фамилия длиннее 50 символов",
            TestName = "Присвоение неправильной фамилии больше 50 символов")]
        public void TestSurnameSetArgumentException(string wrongSurname, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _contact.Surname = wrongSurname; },
            message);
        }

        /// <summary>
        /// Позитивный тест геттера Name.
        /// </summary>
        [Test(Description = "Позитивный тест геттера Name.")]
        public void TestNameGetCurrentValue()
        {
            var expected = "Иван";
            _contact.Name = expected;
            var actual = _contact.Name;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Позитивный тест сеттера Name.
        /// </summary>
        [Test(Description = "Позитивный тест геттера Name.")]
        public void TestNameSetCurrentValue()
        {
            var expected = "Иван";
            _contact.Name = expected;
            var actual = _contact.Name;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase методов проверки сеттера свойства Name.
        /// </summary>
        /// <param name="wrongSurname">Неверное поле Имени.</param>
        /// <param name="message">Текст ошибки.</param>
        [TestCase("", "Должно возникать исключение, если имя - пустая строка",
            TestName = "Присвоение пустой строки в качестве фамилии")]
        [TestCase("ИванИванИванИванИванИванИванИванИванИванИванИванИванИванИванИванИванИван",
            "Должно возникать исключение, если имя длиннее 50 символов",
            TestName = "Присвоение неправильного имени больше 50 символов")]
        public void TestNameSetArgumentException(string wrongSurname, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _contact.Surname = wrongSurname; },
            message);
        }

        /// <summary>
        /// Позитивный тест геттера Email.
        /// </summary>
        [Test(Description = "Позитивный тест геттера Email.")]
        public void TestEmailGetCurrentValue()
        {
            var expected = "Something@Gmail.com";
            _contact.Email = expected;
            var actual = _contact.Email;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Позитивный тест сеттера Email.
        /// </summary>
        [Test(Description = "Позитивный тест геттера Email.")]
        public void TestEmailSetCurrentValue()
        {
            var expected = "Something@Gmail.com";
            _contact.Email = expected;
            var actual = _contact.Email;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase методов проверки сеттера свойства Email.
        /// </summary>
        /// <param name="wrongSurname">Неверное поле Email.</param>
        /// <param name="message">Текст ошибки.</param>
        [TestCase("", "Должно возникать исключение, если Email - пустая строка",
            TestName = "Присвоение пустой строки в качестве Email")]
        [TestCase("Something@gmaillllllllllllllllllllllllllllllllllllllllll.com",
            "Должно возникать исключение, если Email длиннее 50 символов",
            TestName = "Присвоение неправильного Email больше 50 символов")]
        [TestCase("Something@gmail@.com",
            "Должно возникать исключение, если Email имеет больше 1 символа @",
            TestName = "Присвоение неправильного Email, который имеет больше 1 @")]
        [TestCase("Something@gmail",
            "Должно возникать исключение, если Email имеет неполное доменное имя",
            TestName = "Присвоение неправильного Email с неправильным доменным именем.")]
        [TestCase("Somethinggmail.com",
            "Должно возникать исключение, если Email не имеет знака @",
            TestName = "Присвоение неправильного Email без знака@.")]
        public void TestEmailSetArgumentException(string wrongSurname, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _contact.Email = wrongSurname; },
            message);
        }

        /// <summary>
        /// Позитивный тест геттера VkID.
        /// </summary>
        [Test(Description = "Позитивный тест геттера VkID.")]
        public void TestVkIDGetCurrentValue()
        {
            var expected = "id848484848";
            _contact.VkID = expected;
            var actual = _contact.VkID;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Позитивный тест сеттера VkID.
        /// </summary>
        [Test(Description = "Позитивный тест геттера VkID.")]
        public void TestVkIDSetCurrentValue()
        {
            var expected = "id44994940";
            _contact.VkID = expected;
            var actual = _contact.VkID;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase методов проверки сеттера свойства VkID.
        /// </summary>
        /// <param name="wrongSurname">Неверное поле VkID.</param>
        /// <param name="message">Текст ошибки.</param>
        [TestCase("", "Должно возникать исключение, если VkID - пустая строка",
            TestName = "Присвоение пустой строки в качестве фамилии")]
        [TestCase("id490323385233439000000000903",
            "Должно возникать исключение, если VkID длиннее 15 символов",
            TestName = "Присвоение неправильного VkID больше 15 символов")]
        public void TestVkIDSetArgumentException(string wrongSurname, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _contact.VkID = wrongSurname; },
            message);
        }

        /// <summary>
        /// Позитивный тест геттера Birthday.
        /// </summary>
        [Test(Description = "Позитивный тест геттера Birthday.")]
        public void TestBirthdayGetCurrentValue()
        {
            var expected = new DateTime(2000,1,1);
            _contact.Birthday = expected;
            var actual = _contact.Birthday;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Позитивный тест сеттера Birthday.
        /// </summary>
        [Test(Description = "Позитивный тест геттера Birthday.")]
        public void TestBirthdayIDSetCurrentValue()
        {
            var expected = new DateTime(2000, 1, 1);
            _contact.Birthday = expected;
            var actual = _contact.Birthday;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase методов проверки сеттера свойства Birthday.
        /// </summary>
        /// <param name="wrongSurname">Неверное поле Birthday.</param>
        /// <param name="message">Текст ошибки.</param>
        [TestCase("01/20/1000", "Должно возникать исключение, если Birthday " +
            "дата раньше 1900 года",
            TestName = "Присвоение пустой строки в качестве фамилии")]
        [TestCase("01/20/3000",
            "Должно возникать исключение, если Birthday дата, которая еще не наступила.",
            TestName = "Присвоение неправильного Birthday которая еще не наступила.")]
        public void TestBirthdaySetArgumentException(DateTime wrongSurname, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _contact.Birthday = wrongSurname; },
            message);
        }

        /// <summary>
        /// Тест конструктора без параметров.
        /// </summary>
        [Test(Description = "Тестирование констуктора без параметров.")]
        public void TestСonstructorWithoutParameters()
        {
            Assert.DoesNotThrow(() => new Contact());
        }

        /// <summary>
        /// Тест конструктора c параметрами.
        /// </summary>
        [Test(Description = "Тестирование констуктора с параметрами.")]
        public void TestСonstructorWithParameters()
        {
            Assert.DoesNotThrow(() => new Contact(
                "Иванов",
                "Иван",
                "Ivanov@mail.ru",
                new DateTime(2000,1,1),
                "id49499494",
                "78901234567"
                ));
        }
    }
}
