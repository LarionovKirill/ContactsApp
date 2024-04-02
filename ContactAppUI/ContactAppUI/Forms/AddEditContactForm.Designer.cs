namespace ContactAppUI.Forms
{
    partial class AddEditContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SurnameLabel = new Label();
            NameLabel = new Label();
            BirthdayLabel = new Label();
            PhoneLabel = new Label();
            EmailLabel = new Label();
            VkLabel = new Label();
            SurnameTextBox = new TextBox();
            NameTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            EmailTextBox = new TextBox();
            VkTextBox = new TextBox();
            BirthdayDateTime = new DateTimePicker();
            OkButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // SurnameLabel
            // 
            SurnameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SurnameLabel.AutoSize = true;
            SurnameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SurnameLabel.Location = new Point(27, 27);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(57, 15);
            SurnameLabel.TabIndex = 0;
            SurnameLabel.Text = "Surname:";
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(42, 58);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name:";
            // 
            // BirthdayLabel
            // 
            BirthdayLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BirthdayLabel.AutoSize = true;
            BirthdayLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BirthdayLabel.Location = new Point(30, 87);
            BirthdayLabel.Name = "BirthdayLabel";
            BirthdayLabel.Size = new Size(54, 15);
            BirthdayLabel.TabIndex = 2;
            BirthdayLabel.Text = "Birthday:";
            // 
            // PhoneLabel
            // 
            PhoneLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneLabel.Location = new Point(40, 116);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(44, 15);
            PhoneLabel.TabIndex = 3;
            PhoneLabel.Text = "Phone:";
            // 
            // EmailLabel
            // 
            EmailLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel.Location = new Point(45, 145);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(39, 15);
            EmailLabel.TabIndex = 4;
            EmailLabel.Text = "Email:";
            // 
            // VkLabel
            // 
            VkLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VkLabel.AutoSize = true;
            VkLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            VkLabel.Location = new Point(35, 174);
            VkLabel.Name = "VkLabel";
            VkLabel.Size = new Size(49, 15);
            VkLabel.TabIndex = 5;
            VkLabel.Text = "vk.com:";
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SurnameTextBox.Location = new Point(90, 27);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(435, 23);
            SurnameTextBox.TabIndex = 6;
            SurnameTextBox.TextChanged += SurnameTextBox_TextChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(90, 58);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(435, 23);
            NameTextBox.TabIndex = 7;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PhoneTextBox.Location = new Point(90, 116);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(435, 23);
            PhoneTextBox.TabIndex = 8;
            PhoneTextBox.TextChanged += PhoneTextBox_TextChanged;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmailTextBox.Location = new Point(90, 145);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(435, 23);
            EmailTextBox.TabIndex = 9;
            EmailTextBox.TextChanged += EmailTextBox_TextChanged;
            // 
            // VkTextBox
            // 
            VkTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            VkTextBox.Location = new Point(90, 174);
            VkTextBox.Name = "VkTextBox";
            VkTextBox.Size = new Size(435, 23);
            VkTextBox.TabIndex = 10;
            VkTextBox.TextChanged += VkTextBox_TextChanged;
            // 
            // BirthdayDateTime
            // 
            BirthdayDateTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BirthdayDateTime.Location = new Point(90, 87);
            BirthdayDateTime.MinDate = new DateTime(1901, 1, 1, 0, 0, 0, 0);
            BirthdayDateTime.Name = "BirthdayDateTime";
            BirthdayDateTime.Size = new Size(252, 23);
            BirthdayDateTime.TabIndex = 11;
            BirthdayDateTime.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            BirthdayDateTime.ValueChanged += BirthdayDateTime_ValueChanged;
            // 
            // OkButton
            // 
            OkButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OkButton.DialogResult = DialogResult.OK;
            OkButton.Location = new Point(341, 219);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(89, 27);
            OkButton.TabIndex = 12;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelButton.Location = new Point(436, 219);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(89, 27);
            CancelButton.TabIndex = 13;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddEditContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 261);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Controls.Add(BirthdayDateTime);
            Controls.Add(VkTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(PhoneTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(SurnameTextBox);
            Controls.Add(VkLabel);
            Controls.Add(EmailLabel);
            Controls.Add(PhoneLabel);
            Controls.Add(BirthdayLabel);
            Controls.Add(NameLabel);
            Controls.Add(SurnameLabel);
            MaximumSize = new Size(2000, 300);
            MinimumSize = new Size(500, 300);
            Name = "AddEditContactForm";
            Text = "Add/EditContact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SurnameLabel;
        private Label NameLabel;
        private Label BirthdayLabel;
        private Label PhoneLabel;
        private Label EmailLabel;
        private Label VkLabel;
        private TextBox SurnameTextBox;
        private TextBox NameTextBox;
        private TextBox PhoneTextBox;
        private TextBox EmailTextBox;
        private TextBox VkTextBox;
        private DateTimePicker BirthdayDateTime;
        private Button OkButton;
        private Button CancelButton;
    }
}