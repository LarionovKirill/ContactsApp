using ContactApp.Model;
using ContactApp.Service;
using ContactAppUI.Forms;
using ContactAppUI.Properties;

namespace ContactAppUI
{
    /// <summary>
    /// ����� ������� ����� ���������� ContactApp.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// ���� �� ���������.
        /// </summary>
        private DateTime DefaultDate { get; set; } = new DateTime(2000,1,1);

        /// <summary>
        /// ������ � ���������� ����� ����� About.
        /// </summary>
        private AboutForm AboutForm { get; set; }

        /// <summary>
        /// ������ ���������.
        /// </summary>
        private List<Contact> Contacts { get; set; }

        /// <summary>
        /// ����������� ������������� �����.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Contacts = Serializer.LoadFromFile();
            UpdateContacts();
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
            if (Application.OpenForms["AboutForm"] == null)
            {
                AboutForm = new AboutForm();
                AboutForm.Show();
            }
        }

        /// <summary>
        /// ������� ��������� ������� �� ������ ���������� ��������.
        /// </summary>
        private void AddContactPicture_MouseEnter(object sender, EventArgs e)
        {
            AddContactPicture.Image = Resources.AddContactIconContrast_512x512;
        }

        /// <summary>
        /// ������� ����� ������� �� �������� ������ ���������� ��������.
        /// </summary>
        private void AddContactPicture_MouseLeave(object sender, EventArgs e)
        {
            AddContactPicture.Image = Resources.AddContactIcon_512x512;
        }

        /// <summary>
        /// ������� ��������� ������� �� ������ ���������� ��������.
        /// </summary>
        private void EditContactPicture_MouseEnter(object sender, EventArgs e)
        {
            EditContactPicture.Image = Resources.EditContactIconContrast_512x512;
        }

        /// <summary>
        /// ������� ����� ������� �� �������� ������ ���������� ��������.
        /// </summary>
        private void EditContactPicture_MouseLeave(object sender, EventArgs e)
        {
            EditContactPicture.Image = Resources.EditContactIcon_512x512;
        }

        /// <summary>
        /// ������� ��������� ������� �� ������ ���������� ��������.
        /// </summary>
        private void DeleteContactPicture_MouseEnter(object sender, EventArgs e)
        {
            DeleteContactPicture.Image = Resources.DeleteContactIconContrast_512x512;
        }

        /// <summary>
        /// ������� ����� ������� �� �������� ������ ���������� ��������.
        /// </summary>
        private void DeleteContactPicture_MouseLeave(object sender, EventArgs e)
        {
            DeleteContactPicture.Image = Resources.DeleteContactIcon_512x512;
        }

        /// <summary>
        /// ������� �������� ��������.
        /// </summary>
        private void AddContact_Click(object sender, EventArgs e)
        {
            TransferContact.Data = new Contact();
            var addForm = new AddEditContactForm();
            addForm.ShowDialog();
            if (addForm.DialogResult == DialogResult.OK)
            {
                Contacts.Add(TransferContact.Data);
                Serializer.SaveToFile(Contacts);
                UpdateContacts();
            }
        }

        /// <summary>
        /// ����� ���������� ��������� � ListBox.
        /// </summary>
        private void UpdateContacts()
        {
            ContactsListBox.Items.Clear();

            foreach (var contact in Contacts)
            {
                ContactsListBox.Items.Add(contact.Surname);
            }
        }

        /// <summary>
        /// ���������� ����� � ����������� �� ��������.
        /// </summary>
        /// <param name="contact">�������.</param>
        private void UpdateContactInformation(Contact contact)
        {
            SurnameTextBox.Text = contact.Surname;
            NameTextBox.Text = contact.Name;
            BirthdayDateTime.Value = contact.Birthday;
            PhoneTextBox.Text = contact.PhoneNumber.Phone;
            EmailTextBox.Text = contact.Email;
            VkTextBox.Text = contact.VkID;
        }

        /// <summary>
        /// ���������� ������ �������� �� ������.
        /// </summary>
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = ContactsListBox.SelectedIndex;
            if (index >= 0)
            {
                UpdateContactInformation(Contacts[index]);
            }
        }

        /// <summary>
        /// ���������� ��������� ���� � ������� ����.
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
    }
}
