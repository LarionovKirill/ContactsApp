namespace ContactApp.Service
{
    /// <summary>
    /// Класс путей сохранения файлов сериалайзера.
    /// </summary>
    public static class Paths
    {
        public static readonly string PathToFiles =
            Path.Combine(AppContext.BaseDirectory, "Contacts.json");
    }
}
