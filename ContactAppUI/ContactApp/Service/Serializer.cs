using ContactApp.Model;
using Newtonsoft.Json;

namespace ContactApp.Service
{
    /// <summary>
    /// Класс сериализатор контактов.
    /// </summary>
    public static class Serializer
    {
        /// <summary>
        /// Путь к JSON - файлу контактов.
        /// </summary>
        private static readonly string _path =
            Path.Combine(AppContext.BaseDirectory, "Contacts.json");

        /// <summary>
        /// Метод сериализации данных объектов класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="data">Список объектов класса <see cref="Contact"/>.</param>
        public static void SaveToFile(List<Contact> data)
        {
            var serialized = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(_path, serialized);
        }

        /// <summary>
        /// Метод десериализации данных объектов класса <see cref="Contact"/>.
        /// </summary>
        /// <returns>Список объектов класса <see cref="Contact"/>.</returns>
        public static List<Contact> LoadFromFile() 
        {
            var data = new List<Contact>();
            if (File.Exists(_path))
            {
                var jsonConvert = File.ReadAllText(_path);
                data = JsonConvert.DeserializeObject<List<Contact>>(jsonConvert);
            }
            return data;
        }
    }
}
