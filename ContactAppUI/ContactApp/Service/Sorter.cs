using ContactApp.Model;

namespace ContactApp.Service
{
    /// <summary>
    /// Класс сортировки списка контактов.
    /// </summary>
    public static class Sorter
    {
        /// <summary>
        /// Сортирует список контактов по алфавиту.
        /// </summary>
        /// <param name="contacts">Список контактов.</param>
        /// <returns>Отсортированный список контактов.</returns>
        public static List<Contact> SortContacts(List<Contact> contacts)
        {
            contacts.Sort();
            return contacts;
        }

        /// <summary>
        /// Сортирует список контактов по алфавиту и ищет контакты по введенной подстроке.
        /// </summary>
        /// <param name="contacts">Список контактов.</param>
        /// <param name="mask">Маска поиска контактов.</param>
        /// <returns>Отсортированный список контактов.</returns>
        public static List<Contact> SortContacts(List<Contact> contacts, string mask)
        {
            mask = mask.ToLower();
            var foundedContacts = new List<Contact>();
            contacts.Sort();
            foreach (var contact in contacts) 
            {
                if (contact.Surname.ToLower().IndexOf(mask) != -1 ||
                    contact.Name.ToLower().IndexOf(mask) != -1)
                {
                    foundedContacts.Add(contact);
                }
            }
            return foundedContacts;
        }

        /// <summary>
        /// Получение именинников.
        /// </summary>
        /// <param name="contacts">Список контактов.</param>
        /// <param name="date">Сегодняшняя дата.</param>
        /// <returns>Строку с именинниками.</returns>
        public static string GetBirthdayBoys(List<Contact> contacts, DateTime date)
        {
            var birtdaysBoys = string.Empty;
            foreach (var contact in contacts)
            {
                if (contact.Birthday.Day == date.Day &&
                    contact.Birthday.Month == date.Month)
                {
                    birtdaysBoys += contact.Surname + ", ";
                }
            }
            if (birtdaysBoys.Length > 2)
            {
                return birtdaysBoys.Substring(0, birtdaysBoys.Length - 2);
            }
            else
            {
                return birtdaysBoys;
            }    
        }
    }
}
