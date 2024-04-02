using ContactApp.Model;
using ContactApp.Service;
using ContactAppUI.Forms;

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
            if (AboutForm == null)
            {
                AboutForm = new AboutForm();
                AboutForm.Show();
            }
        }
    }
}
