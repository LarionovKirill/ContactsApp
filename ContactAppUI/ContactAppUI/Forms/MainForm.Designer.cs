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
            menuStrip1.SuspendLayout();
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
            ExitMenuItem.Size = new Size(180, 22);
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
            addContactToolStripMenuItem.Size = new Size(180, 22);
            addContactToolStripMenuItem.Text = "Add Contact";
            // 
            // editContactToolStripMenuItem
            // 
            editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            editContactToolStripMenuItem.Size = new Size(180, 22);
            editContactToolStripMenuItem.Text = "Edit Contact";
            // 
            // removeContactToolStripMenuItem
            // 
            removeContactToolStripMenuItem.Name = "removeContactToolStripMenuItem";
            removeContactToolStripMenuItem.Size = new Size(180, 22);
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
            AboutMenuItem.Size = new Size(180, 22);
            AboutMenuItem.Text = "About";
            AboutMenuItem.Click += this.AboutMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 461);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "ContactApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}
