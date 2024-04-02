namespace ContactAppUI.Forms
{
    partial class AboutForm
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
            NameApplication = new Label();
            VersionLabel = new Label();
            AuthorLabel = new Label();
            EmailLabel = new Label();
            GitLabel = new Label();
            LowerInfo = new Label();
            EmailLink = new LinkLabel();
            GitLink = new LinkLabel();
            SuspendLayout();
            // 
            // NameApplication
            // 
            NameApplication.AutoSize = true;
            NameApplication.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            NameApplication.Location = new Point(23, 22);
            NameApplication.Name = "NameApplication";
            NameApplication.Size = new Size(118, 25);
            NameApplication.TabIndex = 0;
            NameApplication.Text = "ContactApp";
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.Location = new Point(23, 56);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(43, 15);
            VersionLabel.TabIndex = 1;
            VersionLabel.Text = "v. 1.0.0";
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(23, 116);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(125, 15);
            AuthorLabel.TabIndex = 2;
            AuthorLabel.Text = "Author:  Larionov Kirill";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(23, 163);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(119, 15);
            EmailLabel.TabIndex = 3;
            EmailLabel.Text = "e-mail for feedback:  ";
            // 
            // GitLabel
            // 
            GitLabel.AutoSize = true;
            GitLabel.Location = new Point(23, 187);
            GitLabel.Name = "GitLabel";
            GitLabel.Size = new Size(48, 15);
            GitLabel.TabIndex = 4;
            GitLabel.Text = "GitHub:";
            // 
            // LowerInfo
            // 
            LowerInfo.AutoSize = true;
            LowerInfo.Location = new Point(23, 317);
            LowerInfo.Name = "LowerInfo";
            LowerInfo.Size = new Size(117, 15);
            LowerInfo.TabIndex = 5;
            LowerInfo.Text = "2024 Larionov Kirill©";
            // 
            // EmailLink
            // 
            EmailLink.AutoSize = true;
            EmailLink.Location = new Point(136, 163);
            EmailLink.Name = "EmailLink";
            EmailLink.Size = new Size(113, 15);
            EmailLink.TabIndex = 6;
            EmailLink.TabStop = true;
            EmailLink.Text = "lari-kir2013@mail.ru";
            EmailLink.LinkClicked += EmailLink_LinkClicked;
            // 
            // GitLink
            // 
            GitLink.AutoSize = true;
            GitLink.Location = new Point(68, 187);
            GitLink.Name = "GitLink";
            GitLink.Size = new Size(257, 15);
            GitLink.TabIndex = 7;
            GitLink.TabStop = true;
            GitLink.Text = "https://github.com/LarionovKirill/ContactsApp";
            GitLink.LinkClicked += GitLink_LinkClicked;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 341);
            Controls.Add(GitLink);
            Controls.Add(EmailLink);
            Controls.Add(LowerInfo);
            Controls.Add(GitLabel);
            Controls.Add(EmailLabel);
            Controls.Add(AuthorLabel);
            Controls.Add(VersionLabel);
            Controls.Add(NameApplication);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AboutForm";
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameApplication;
        private Label VersionLabel;
        private Label AuthorLabel;
        private Label EmailLabel;
        private Label GitLabel;
        private Label LowerInfo;
        private LinkLabel EmailLink;
        private LinkLabel GitLink;
    }
}