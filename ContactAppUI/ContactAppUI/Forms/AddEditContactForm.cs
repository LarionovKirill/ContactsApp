using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactAppUI.Forms
{
    /// <summary>
    /// Класс формы создания и редактирования контакта.
    /// </summary>
    public partial class AddEditContactForm : Form
    {
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
    }
}
