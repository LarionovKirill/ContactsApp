using ContactApp.Model;
using ContactApp.Service;
using ContactAppUI.Forms;
using ContactAppUI.Properties;

namespace ContactAppUI
{
    /// <summary>
    /// Класс главной формы приложения ContactApp.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Дата по умолчанию.
        /// </summary>
        private DateTime DefaultDate { get; set; } = new DateTime(2000, 1, 1);

        /// <summary>
        /// Задает и возвращает класс формы About.
        /// </summary>
        private AboutForm AboutForm { get; set; }

        /// <summary>
        /// Список контактов.
        /// </summary>
        private List<Contact> Contacts { get; set; }

        /// <summary>
        /// Список контактов.
        /// </summary>
        private List<Contact> FoundedContacts { get; set; }

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Contacts = Serializer.LoadFromFile(Paths.PathToFiles);
            Contacts = Sorter.SortContacts(Contacts);
            UpdateContacts(Contacts);
            BirthdayBoyLabel.Text = Sorter.GetBirthdayBoys(Contacts, DateTime.Now);
        }

        /// <summary>
        /// Обработчик выхода из программы.
        /// </summary>
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Открытие формы About.
        /// </summary>
        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AboutForm"] == null)
            {
                AboutForm = new AboutForm();
                AboutForm.Show();
            }
        }

        /// <summary>
        /// Событие наведении курсора на кнопку добавления контакта.
        /// </summary>
        private void AddContactPicture_MouseEnter(object sender, EventArgs e)
        {
            AddContactPicture.Image = Resources.AddContactIconContrast_512x512;
        }

        /// <summary>
        /// Событие ухода курсора из пределов кнопки добавления контакта.
        /// </summary>
        private void AddContactPicture_MouseLeave(object sender, EventArgs e)
        {
            AddContactPicture.Image = Resources.AddContactIcon_512x512;
        }

        /// <summary>
        /// Событие наведении курсора на кнопку добавления контакта.
        /// </summary>
        private void EditContactPicture_MouseEnter(object sender, EventArgs e)
        {
            EditContactPicture.Image = Resources.EditContactIconContrast_512x512;
        }

        /// <summary>
        /// Событие ухода курсора из пределов кнопки добавления контакта.
        /// </summary>
        private void EditContactPicture_MouseLeave(object sender, EventArgs e)
        {
            EditContactPicture.Image = Resources.EditContactIcon_512x512;
        }

        /// <summary>
        /// Событие наведении курсора на кнопку добавления контакта.
        /// </summary>
        private void DeleteContactPicture_MouseEnter(object sender, EventArgs e)
        {
            DeleteContactPicture.Image = Resources.DeleteContactIconContrast_512x512;
        }

        /// <summary>
        /// Событие ухода курсора из пределов кнопки добавления контакта.
        /// </summary>
        private void DeleteContactPicture_MouseLeave(object sender, EventArgs e)
        {
            DeleteContactPicture.Image = Resources.DeleteContactIcon_512x512;
        }

        /// <summary>
        /// Событие создания контакта.
        /// </summary>
        private void AddContact_Click(object sender, EventArgs e)
        {
            TransferContact.Data = new Contact();
            var addForm = new AddEditContactForm();
            addForm.ShowDialog();
            if (addForm.DialogResult == DialogResult.OK)
            {
                Contacts.Add(TransferContact.Data);
                Serializer.SaveToFile(Contacts, Paths.PathToFiles);
                Contacts = Sorter.SortContacts(Contacts);
                UpdateContacts(Contacts);
            }
        }

        /// <summary>
        /// Метод обновления контактов в ListBox.
        /// </summary>
        private void UpdateContacts(List<Contact> contacts)
        {
            ContactsListBox.Items.Clear();

            foreach (var contact in contacts)
            {
                ContactsListBox.Items.Add(contact.Surname);
            }
        }

        /// <summary>
        /// Обновление полей с информацией об контакте.
        /// </summary>
        /// <param name="contact">Контакт.</param>
        private void UpdateContactInformation(Contact contact)
        {
            //Форматирование телефона.
            var intPhone = long.Parse(contact.PhoneNumber.Phone);
            var phone = string.Format("{0:+# (###) ###-##-##}", intPhone);

            SurnameTextBox.Text = contact.Surname;
            NameTextBox.Text = contact.Name;
            BirthdayDateTime.Value = contact.Birthday;
            PhoneTextBox.Text = phone;
            EmailTextBox.Text = contact.Email;
            VkTextBox.Text = contact.VkID;
        }

        /// <summary>
        /// Обработчик выбора контакта из списка.
        /// </summary>
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = ContactsListBox.SelectedIndex;
            if (FindContactTextBox.Text == string.Empty)
            {
                if (index >= 0)
                {
                    UpdateContactInformation(Contacts[index]);
                }
            }
            else
            {
                if (index >= 0)
                {
                    UpdateContactInformation(FoundedContacts[index]);
                }
            }
        }

        /// <summary>
        /// Обработчик изменения даты в главном окне.
        /// </summary>
        private void BirthdayDateTime_ValueChanged(object sender, EventArgs e)
        {
            var index = ContactsListBox.SelectedIndex;
            if (index >= 0)
            {
                BirthdayDateTime.Value = Contacts[index].Birthday;
            }
            else
            {
                BirthdayDateTime.Value = DefaultDate;
            }
        }

        /// <summary>
        /// Изменение созданного контакта.
        /// </summary>
        private void EditContactPicture_Click(object sender, EventArgs e)
        {
            var index = ContactsListBox.SelectedIndex;
            if (index >= 0)
            {
                TransferContact.Data = (Contact)Contacts[index].Clone();
                var addForm = new AddEditContactForm();
                addForm.ShowDialog();
                if (addForm.DialogResult == DialogResult.OK)
                {
                    Contacts[index] = TransferContact.Data;
                    Serializer.SaveToFile(Contacts, Paths.PathToFiles);
                    Contacts = Sorter.SortContacts(Contacts);
                    UpdateContacts(Contacts);
                    ContactsListBox.SelectedIndex = index;
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать контакт, который хотите редактировать",
                    "Ошибка",
                    MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Удаление контакта.
        /// </summary>
        private void DeleteContactPicture_Click(object sender, EventArgs e)
        {
            var index = ContactsListBox.SelectedIndex;
            if (index >= 0)
            {
                DialogResult warning = MessageBox.Show(
                    $"Do you really want to remove this contact: {Contacts[index].Surname}",
                    "Warning",
                    MessageBoxButtons.YesNo);
                if (warning == DialogResult.Yes)
                {
                    Contacts.RemoveAt(index);
                    Serializer.SaveToFile(Contacts, Paths.PathToFiles);
                    Contacts = Sorter.SortContacts(Contacts);
                    UpdateContacts(Contacts);
                    ContactsListBox.SelectedIndex = -1;
                    ClearTextBoxes();
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать контакт, который хотите удалить",
                    "Ошибка",
                    MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Очищает поля контактов после удаления.
        /// </summary>
        private void ClearTextBoxes()
        {
            SurnameTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            VkTextBox.Text = string.Empty;
            PhoneTextBox.Text = string.Empty;
            BirthdayDateTime.Value = new DateTime(2000, 1, 1);
        }

        /// <summary>
        /// Поиск контактов по имени или фамилии.
        /// </summary>
        private void FindContactTextBox_TextChanged(object sender, EventArgs e)
        {
            var mask = FindContactTextBox.Text;
            if (mask == string.Empty)
            {
                UpdateContacts(Contacts);
            }
            else
            {
                FoundedContacts = Sorter.SortContacts(Contacts, mask);
                UpdateContacts(FoundedContacts);
            }
        }

        /// <summary>
        /// Удаление контакта при помощи кнопки delete.
        /// </summary>
        private void ContactsListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var index = ContactsListBox.SelectedIndex;
                if (index >= 0)
                {
                    DialogResult warning = MessageBox.Show(
                        $"Do you really want to remove this contact: {Contacts[index].Surname}",
                        "Warning",
                        MessageBoxButtons.YesNo);
                    if (warning == DialogResult.Yes)
                    {
                        Contacts.RemoveAt(index);
                        Serializer.SaveToFile(Contacts, Paths.PathToFiles);
                        Contacts = Sorter.SortContacts(Contacts);
                        UpdateContacts(Contacts);
                        ContactsListBox.SelectedIndex = -1;
                        ClearTextBoxes();
                    }
                }
                else
                {
                    MessageBox.Show("Необходимо выбрать контакт, который хотите удалить",
                        "Ошибка",
                        MessageBoxButtons.OK);
                }
            }
        }
    }
}
