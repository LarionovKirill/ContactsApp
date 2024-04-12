using ContactApp.Model;
using NUnit.Framework;

namespace ContactApp.UnitTests
{
    /// <summary>
    /// Класс тестов класса <see cref="PhoneNumber"/>.
    /// </summary>
    [TestFixture]
    public class PhoneNumberTest
    {
        /// <summary>
        /// Поле контакта для тестирования.
        /// </summary>
        private PhoneNumber _phone;

        /// <summary>
        /// Метод создания объекта класса перед запуском каждого тестирования.
        /// </summary>
        [SetUp]
        public void InitContact()
        {
            _phone = new PhoneNumber();
        }

        /// <summary>
        /// Позитивный тест геттера Phone.
        /// </summary>
        [Test(Description = "Позитивный тест геттера Phone.")]
        public void TestPhoneGetCurrentValue()
        {
            var expected = "79876543210";
            _phone.Phone = expected;
            var actual = _phone.Phone;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Позитивный тест сеттера Phone.
        /// </summary>
        [Test(Description = "Позитивный тест геттера Phone.")]
        public void TestPhoneSetCurrentValue()
        {
            var expected = "79876543210";
            _phone.Phone = expected;
            var actual = _phone.Phone;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TestCase методов проверки сеттера свойства Phone.
        /// </summary>
        /// <param name="wrongSurname">Неверное поле номера телефона.</param>
        /// <param name="message">Текст ошибки.</param>
        [TestCase("", "Должно возникать исключение, если телефон - пустая строка",
            TestName = "Присвоение пустой строки в качестве телефона")]
        [TestCase("87654321098",
            "Должно возникать исключение, если телефон не начинается с цифры 7",
            TestName = "Присвоение присвоение номера телефона не с цифры 7")]
        [TestCase("77654321077777798",
            "Должно возникать исключение, если телефон больше 11 цифр",
            TestName = "Присвоение присвоение номера телефона длинее 11 цифр")]
        [TestCase("7987654321п",
            "Должно возникать исключение, если телефон имеет не только цифры",
            TestName = "Присвоение присвоение номера телефона имеющего не только цифры")]
        public void TestPhoneSetArgumentException(string wrongSurname, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _phone.Phone = wrongSurname; },
            message);
        }

        /// <summary>
        /// Тест конструктора без параметров.
        /// </summary>
        [Test(Description = "Тестирование констуктора без параметров.")]
        public void TestConstructorWithoutParametrs()
        {
            Assert.DoesNotThrow(() => new PhoneNumber());
        }

        /// <summary>
        /// Тест конструктора c параметрами.
        /// </summary>
        [Test(Description = "Тестирование констуктора без параметров.")]
        public void TestConstructorWithParametrs()
        {
            Assert.DoesNotThrow(() => new PhoneNumber("78901234567"));
        }
    }
}
