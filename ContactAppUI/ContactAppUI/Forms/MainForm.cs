using ContactApp.Model;
using ContactApp.Service;
using ContactAppUI.Forms;

namespace ContactAppUI
{
    /// <summary>
    /// ����� ������� ����� ���������� ContactApp.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// ������ � ���������� ����� ����� About.
        /// </summary>
        private AboutForm AboutForm { get; set; }

        /// <summary>
        /// ����������� ������������� �����.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ���������� ������ �� ���������.
        /// </summary>
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// �������� ����� About.
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
