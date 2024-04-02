namespace ContactAppUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            EditMenuItem = new ToolStripMenuItem();
            addContactToolStripMenuItem = new ToolStripMenuItem();
            editContactToolStripMenuItem = new ToolStripMenuItem();
            removeContactToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            AboutMenuItem = new ToolStripMenuItem();
            SplitContainer = new SplitContainer();
            DeleteContactPicture = new PictureBox();
            AddContactPicture = new PictureBox();
            ContactsListBox = new ListBox();
            EditContactPicture = new PictureBox();
            FindContactTextBox = new TextBox();
            FindLabel = new Label();
            BirthdayDateTime = new DateTimePicker();
            VkTextBox = new TextBox();
            EmailTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            NameTextBox = new TextBox();
            SurnameTextBox = new TextBox();
            VkLabel = new Label();
            EmailLabel = new Label();
            PhoneLabel = new Label();
            BirthdayLabel = new Label();
            NameLabel = new Label();
            SurnameLabel = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainer).BeginInit();
            SplitContainer.Panel1.SuspendLayout();
            SplitContainer.Panel2.SuspendLayout();
            SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DeleteContactPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddContactPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditContactPicture).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, EditMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(804, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ExitMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            ExitMenuItem.Size = new Size(135, 22);
            ExitMenuItem.Text = "Exit";
            ExitMenuItem.Click += ExitMenuItem_Click;
            // 
            // EditMenuItem
            // 
            EditMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addContactToolStripMenuItem, editContactToolStripMenuItem, removeContactToolStripMenuItem });
            EditMenuItem.Name = "EditMenuItem";
            EditMenuItem.Size = new Size(39, 20);
            EditMenuItem.Text = "Edit";
            // 
            // addContactToolStripMenuItem
            // 
            addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            addContactToolStripMenuItem.Size = new Size(162, 22);
            addContactToolStripMenuItem.Text = "Add Contact";
            // 
            // editContactToolStripMenuItem
            // 
            editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            editContactToolStripMenuItem.Size = new Size(162, 22);
            editContactToolStripMenuItem.Text = "Edit Contact";
            // 
            // removeContactToolStripMenuItem
            // 
            removeContactToolStripMenuItem.Name = "removeContactToolStripMenuItem";
            removeContactToolStripMenuItem.Size = new Size(162, 22);
            removeContactToolStripMenuItem.Text = "Remove Contact";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // AboutMenuItem
            // 
            AboutMenuItem.Name = "AboutMenuItem";
            AboutMenuItem.ShortcutKeys = Keys.F1;
            AboutMenuItem.Size = new Size(126, 22);
            AboutMenuItem.Text = "About";
            AboutMenuItem.Click += AboutMenuItem_Click;
            // 
            // SplitContainer
            // 
            SplitContainer.Dock = DockStyle.Fill;
            SplitContainer.Location = new Point(0, 24);
            SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            SplitContainer.Panel1.Controls.Add(DeleteContactPicture);
            SplitContainer.Panel1.Controls.Add(AddContactPicture);
            SplitContainer.Panel1.Controls.Add(ContactsListBox);
            SplitContainer.Panel1.Controls.Add(EditContactPicture);
            SplitContainer.Panel1.Controls.Add(FindContactTextBox);
            SplitContainer.Panel1.Controls.Add(FindLabel);
            SplitContainer.Panel1MinSize = 200;
            // 
            // SplitContainer.Panel2
            // 
            SplitContainer.Panel2.Controls.Add(BirthdayDateTime);
            SplitContainer.Panel2.Controls.Add(VkTextBox);
            SplitContainer.Panel2.Controls.Add(EmailTextBox);
            SplitContainer.Panel2.Controls.Add(PhoneTextBox);
            SplitContainer.Panel2.Controls.Add(NameTextBox);
            SplitContainer.Panel2.Controls.Add(SurnameTextBox);
            SplitContainer.Panel2.Controls.Add(VkLabel);
            SplitContainer.Panel2.Controls.Add(EmailLabel);
            SplitContainer.Panel2.Controls.Add(PhoneLabel);
            SplitContainer.Panel2.Controls.Add(BirthdayLabel);
            SplitContainer.Panel2.Controls.Add(NameLabel);
            SplitContainer.Panel2.Controls.Add(SurnameLabel);
            SplitContainer.Panel2MinSize = 350;
            SplitContainer.Size = new Size(804, 446);
            SplitContainer.SplitterDistance = 245;
            SplitContainer.TabIndex = 1;
            // 
            // DeleteContactPicture
            // 
            DeleteContactPicture.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteContactPicture.Image = Properties.Resources.DeleteContactIcon_512x512;
            DeleteContactPicture.Location = new Point(87, 405);
            DeleteContactPicture.Name = "DeleteContactPicture";
            DeleteContactPicture.Size = new Size(31, 34);
            DeleteContactPicture.SizeMode = PictureBoxSizeMode.Zoom;
            DeleteContactPicture.TabIndex = 1;
            DeleteContactPicture.TabStop = false;
            DeleteContactPicture.MouseEnter += DeleteContactPicture_MouseEnter;
            DeleteContactPicture.MouseLeave += DeleteContactPicture_MouseLeave;
            // 
            // AddContactPicture
            // 
            AddContactPicture.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddContactPicture.Image = Properties.Resources.AddContactIcon_512x512;
            AddContactPicture.Location = new Point(13, 405);
            AddContactPicture.Name = "AddContactPicture";
            AddContactPicture.Size = new Size(31, 34);
            AddContactPicture.SizeMode = PictureBoxSizeMode.Zoom;
            AddContactPicture.TabIndex = 0;
            AddContactPicture.TabStop = false;
            AddContactPicture.MouseEnter += AddContactPicture_MouseEnter;
            AddContactPicture.MouseLeave += AddContactPicture_MouseLeave;
            // 
            // ContactsListBox
            // 
            ContactsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContactsListBox.FormattingEnabled = true;
            ContactsListBox.ItemHeight = 15;
            ContactsListBox.Location = new Point(12, 35);
            ContactsListBox.Name = "ContactsListBox";
            ContactsListBox.Size = new Size(230, 364);
            ContactsListBox.TabIndex = 2;
            // 
            // EditContactPicture
            // 
            EditContactPicture.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EditContactPicture.Image = Properties.Resources.EditContactIcon_512x512;
            EditContactPicture.Location = new Point(50, 405);
            EditContactPicture.Name = "EditContactPicture";
            EditContactPicture.Size = new Size(31, 34);
            EditContactPicture.SizeMode = PictureBoxSizeMode.Zoom;
            EditContactPicture.TabIndex = 0;
            EditContactPicture.TabStop = false;
            EditContactPicture.MouseEnter += EditContactPicture_MouseEnter;
            EditContactPicture.MouseLeave += EditContactPicture_MouseLeave;
            // 
            // FindContactTextBox
            // 
            FindContactTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FindContactTextBox.Location = new Point(48, 6);
            FindContactTextBox.Name = "FindContactTextBox";
            FindContactTextBox.Size = new Size(194, 23);
            FindContactTextBox.TabIndex = 1;
            // 
            // FindLabel
            // 
            FindLabel.AutoSize = true;
            FindLabel.Location = new Point(12, 9);
            FindLabel.Name = "FindLabel";
            FindLabel.Size = new Size(33, 15);
            FindLabel.TabIndex = 0;
            FindLabel.Text = "Find:";
            // 
            // BirthdayDateTime
            // 
            BirthdayDateTime.Location = new Point(78, 69);
            BirthdayDateTime.Name = "BirthdayDateTime";
            BirthdayDateTime.Size = new Size(145, 23);
            BirthdayDateTime.TabIndex = 23;
            BirthdayDateTime.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // VkTextBox
            // 
            VkTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            VkTextBox.Location = new Point(78, 156);
            VkTextBox.Name = "VkTextBox";
            VkTextBox.Size = new Size(465, 23);
            VkTextBox.TabIndex = 22;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmailTextBox.Location = new Point(78, 127);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(465, 23);
            EmailTextBox.TabIndex = 21;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PhoneTextBox.Location = new Point(78, 98);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(465, 23);
            PhoneTextBox.TabIndex = 20;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(78, 40);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(465, 23);
            NameTextBox.TabIndex = 19;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SurnameTextBox.Location = new Point(78, 9);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(465, 23);
            SurnameTextBox.TabIndex = 18;
            // 
            // VkLabel
            // 
            VkLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            VkLabel.AutoSize = true;
            VkLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            VkLabel.Location = new Point(23, 156);
            VkLabel.Name = "VkLabel";
            VkLabel.Size = new Size(49, 15);
            VkLabel.TabIndex = 17;
            VkLabel.Text = "vk.com:";
            // 
            // EmailLabel
            // 
            EmailLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel.Location = new Point(33, 127);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(39, 15);
            EmailLabel.TabIndex = 16;
            EmailLabel.Text = "Email:";
            // 
            // PhoneLabel
            // 
            PhoneLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneLabel.Location = new Point(28, 98);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(44, 15);
            PhoneLabel.TabIndex = 15;
            PhoneLabel.Text = "Phone:";
            // 
            // BirthdayLabel
            // 
            BirthdayLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BirthdayLabel.AutoSize = true;
            BirthdayLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BirthdayLabel.Location = new Point(18, 69);
            BirthdayLabel.Name = "BirthdayLabel";
            BirthdayLabel.Size = new Size(54, 15);
            BirthdayLabel.TabIndex = 14;
            BirthdayLabel.Text = "Birthday:";
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(30, 40);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 13;
            NameLabel.Text = "Name:";
            // 
            // SurnameLabel
            // 
            SurnameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SurnameLabel.AutoSize = true;
            SurnameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SurnameLabel.Location = new Point(15, 9);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(57, 15);
            SurnameLabel.TabIndex = 12;
            SurnameLabel.Text = "Surname:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 470);
            Controls.Add(SplitContainer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "ContactApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            SplitContainer.Panel1.ResumeLayout(false);
            SplitContainer.Panel1.PerformLayout();
            SplitContainer.Panel2.ResumeLayout(false);
            SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainer).EndInit();
            SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DeleteContactPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddContactPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditContactPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem EditMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem addContactToolStripMenuItem;
        private ToolStripMenuItem editContactToolStripMenuItem;
        private ToolStripMenuItem removeContactToolStripMenuItem;
        private ToolStripMenuItem AboutMenuItem;
        private SplitContainer SplitContainer;
        private TextBox FindContactTextBox;
        private Label FindLabel;
        private ListBox ContactsListBox;
        private PictureBox AddContactPicture;
        private PictureBox DeleteContactPicture;
        private PictureBox EditContactPicture;
        private DateTimePicker BirthdayDateTime;
        private TextBox VkTextBox;
        private TextBox EmailTextBox;
        private TextBox PhoneTextBox;
        private TextBox NameTextBox;
        private TextBox SurnameTextBox;
        private Label VkLabel;
        private Label EmailLabel;
        private Label PhoneLabel;
        private Label BirthdayLabel;
        private Label NameLabel;
        private Label SurnameLabel;
    }
}
