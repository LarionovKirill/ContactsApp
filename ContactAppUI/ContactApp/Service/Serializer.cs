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
        /// Метод сериализации данных объектов класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="data">Список объектов класса <see cref="Contact"/>.</param>
        /// <param name="path">Путь для сохранения файлов.</param>
        public static void SaveToFile(List<Contact> data, string path)
        {
            var serialized = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(path, serialized);
        }

        /// <summary>
        /// Метод десериализации данных объектов класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="path">Путь до файла, который надо десереализовать.</param>
        /// <returns>Список объектов класса <see cref="Contact"/>.</returns>
        public static List<Contact> LoadFromFile(string path) 
        {
            var data = new List<Contact>();
            if (File.Exists(path))
            {
                var jsonConvert = File.ReadAllText(path);
                data = JsonConvert.DeserializeObject<List<Contact>>(jsonConvert);
            }
            return data;
        }
    }
}
