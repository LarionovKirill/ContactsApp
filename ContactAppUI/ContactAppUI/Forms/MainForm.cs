
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
        /// Задает и возвращает класс формы About.
        /// </summary>
        private AboutForm AboutForm { get; set; }

        /// <summary>
        /// Конструктор инициализации формы.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
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
    }
}
