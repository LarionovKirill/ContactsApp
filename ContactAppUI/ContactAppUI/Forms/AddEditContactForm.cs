using ContactApp.Model;
using ContactApp.Service;

namespace ContactAppUI.Forms
{
    /// <summary>
    /// Класс формы создания и редактирования контакта.
    /// </summary>
    public partial class AddEditContactForm : Form
    {
        /// <summary>
        /// Текущий контакт для редактирования/создания.
        /// </summary>
        public Contact CurrentContact { get; set; }

        /// <summary>
        /// Инициализация формы.
        /// </summary>
        public AddEditContactForm()
        {
            InitializeComponent();
            CurrentContact = TransferContact.Data;
            if (CurrentContact.Surname == null)
            {
                BlockCreateButton();
            }
            else
            {
                UpdateContactInformation(CurrentContact);
            }
        }

        /// <summary>
        /// Метод отмены создания/редактирования контакта.
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Выключение кнопки подтвержения.
        /// </summary>
        private void BlockCreateButton()
        {
            OkButton.Enabled = false;
        }

        /// <summary>
        /// Событие изменении фамилии контакта.
        /// </summary>
        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentContact.Surname = SurnameTextBox.Text;
                SurnameTextBox.BackColor = Color.White;
            }
            catch
            {
                SurnameTextBox.BackColor = Color.LightCoral;
                BlockCreateButton();
            }
        }

        /// <summary>
        /// Событие изменении имени контакта.
        /// </summary>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentContact.Name = NameTextBox.Text;
                NameTextBox.BackColor = Color.White;
            }
            catch
            {
                NameTextBox.BackColor = Color.LightCoral;
                BlockCreateButton();
            }
        }

        /// <summary>
        /// Событие изменении дня рождения контакта.
        /// </summary>
        private void BirthdayDateTime_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentContact.Birthday = BirthdayDateTime.Value;
                BirthdayDateTime.BackColor = Color.White;
            }
            catch
            {
                BirthdayDateTime.BackColor = Color.LightCoral;
                BlockCreateButton();
            }
        }

        /// <summary>
        /// Событие измененения номера телефона.
        /// </summary>
        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentContact.PhoneNumber.Phone = PhoneTextBox.Text;
                PhoneTextBox.BackColor = Color.White;
            }
            catch
            {
                PhoneTextBox.BackColor = Color.LightCoral;
                BlockCreateButton();
            }
        }

        /// <summary>
        /// Событие изменения эл. почты телеофна.
        /// </summary>
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentContact.Email = EmailTextBox.Text;
                EmailTextBox.BackColor = Color.White;
            }
            catch
            {
                EmailTextBox.BackColor = Color.LightCoral;
                BlockCreateButton();
            }
        }

        /// <summary>
        /// Событие изменения vk контакта.
        /// </summary>
        private void VkTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentContact.VkID = VkTextBox.Text;
                VkTextBox.BackColor = Color.White;
            }
            catch
            {
                VkTextBox.BackColor = Color.LightCoral;
                BlockCreateButton();
            }
        }

        /// <summary>
        /// Обновление полей с информацией об контакте.
        /// </summary>
        /// <param name="contact">Контакт.</param>
        private void UpdateContactInformation(Contact contact)
        {
            SurnameTextBox.Text = contact.Surname;
            NameTextBox.Text = contact.Name;
            BirthdayDateTime.Value = contact.Birthday;
            PhoneTextBox.Text = contact.PhoneNumber.Phone;
            EmailTextBox.Text = contact.Email;
            VkTextBox.Text = contact.VkID;
        }
    }
}
