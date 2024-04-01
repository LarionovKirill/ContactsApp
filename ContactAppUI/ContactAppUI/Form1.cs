using ContactApp.Model;

namespace ContactAppUI
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Конструктор инициализации формы.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод для проверки создания контакта.
        /// </summary>
        private void CreateContactButton_Click(object sender, EventArgs e)
        {
            var contact = new Contact(
                "Иванов",
                "Иван",
                "google@gamil.com",
                DateTime.Today,
                "Id2323232",
                "79336547800");
            Console.WriteLine(contact.Surname);
            Console.WriteLine(contact.Name);
            Console.WriteLine(contact.Email);
            Console.WriteLine(contact.VkID);
            Console.WriteLine(contact.PhoneNumber.Phone);
            Console.WriteLine(contact.Birthday);
        }

        /// <summary>
        /// Метод для проверки валидации.
        /// </summary>
        private void CreateContactErrorButton_Click(object sender, EventArgs e)
        {
            try
            {
                var contact = new Contact(
                    "Иванов",
                    "Иван",
                    "google@gamil.com",
                    DateTime.Today,
                    "Id2323232",
                    "793365478000000");
            }
            catch
            {
                Console.WriteLine("Has Error");
            }
        }
    }
}
