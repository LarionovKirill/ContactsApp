using ContactApp.Model;

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
        public Contact CurrentContact { get; set; } = new Contact();

        /// <summary>
        /// Инициализация формы.
        /// </summary>
        public AddEditContactForm()
        {
            InitializeComponent();
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
            }
            catch
            {
                VkTextBox.BackColor = Color.LightCoral;
                BlockCreateButton();
            }
        }
    }
}
