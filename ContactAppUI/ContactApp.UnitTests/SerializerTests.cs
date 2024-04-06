using ContactApp.Service;
using ContactApp.Model;
using NUnit.Framework;

namespace ContactApp.UnitTests
{
    /// <summary>
    /// Класс тестирования класса <see cref="Serializer"/>.
    /// </summary>
    [TestFixture]
    public class SerializerTests
    {
        /// <summary>
        /// Тестовый список контактов.
        /// </summary>
        private List<Contact> _contacts = new List<Contact>();

        /// <summary>
        /// Начальный метод создания тестового списка конактов.
        /// </summary>
        [SetUp]
        public void CreateTestList()
        {
            _contacts.Clear();
            _contacts.Add(new Contact(
                "Иванов",
                "Иван",
                "Ivanov@gmail.com",
                new DateTime(2000, 1, 1),
                "id1234567",
                "78901234567"));
        }

        /// <summary>
        /// Метод удаления файла после теста.
        /// </summary>
        [TearDown]
        public void DeleteTestFile() 
        {
            File.Delete(Paths.PathToFilesTest);
        }

        /// <summary>
        /// Положительный тест сериализации списка контактов.
        /// </summary>
        [Test]
        public void TestSerialize() 
        {
            Serializer.SaveToFile(_contacts, Paths.PathToFilesTest);
            var expected = File.ReadAllText(Paths.PathToStandard);
            var actual = File.ReadAllText(Paths.PathToFilesTest);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Положительный тест десериализации списка контактов.
        /// </summary>
        [Test]
        public void TestDeserialize()
        {
            Serializer.SaveToFile(_contacts, Paths.PathToFilesTest);
            var actual = Serializer.LoadFromFile(Paths.PathToFilesTest);
            var expected = _contacts;
            Assert.IsTrue(expected[0].Equals(actual[0]));
        }
    }
}
