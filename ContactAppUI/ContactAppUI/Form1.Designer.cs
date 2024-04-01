namespace ContactAppUI
{
    partial class Form1
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
            CreateContactButton = new Button();
            CreateContactErrorButton = new Button();
            SerializeButton = new Button();
            DeserializeButton = new Button();
            SuspendLayout();
            // 
            // CreateContactButton
            // 
            CreateContactButton.Location = new Point(36, 32);
            CreateContactButton.Name = "CreateContactButton";
            CreateContactButton.Size = new Size(139, 24);
            CreateContactButton.TabIndex = 0;
            CreateContactButton.Text = "Создать класс";
            CreateContactButton.UseVisualStyleBackColor = true;
            CreateContactButton.Click += CreateContactButton_Click;
            // 
            // CreateContactErrorButton
            // 
            CreateContactErrorButton.Location = new Point(36, 74);
            CreateContactErrorButton.Name = "CreateContactErrorButton";
            CreateContactErrorButton.Size = new Size(139, 24);
            CreateContactErrorButton.TabIndex = 1;
            CreateContactErrorButton.Text = "Проверка валидации";
            CreateContactErrorButton.UseVisualStyleBackColor = true;
            CreateContactErrorButton.Click += CreateContactErrorButton_Click;
            // 
            // SerializeButton
            // 
            SerializeButton.Location = new Point(351, 32);
            SerializeButton.Name = "SerializeButton";
            SerializeButton.Size = new Size(153, 24);
            SerializeButton.TabIndex = 2;
            SerializeButton.Text = "Сериализация данных";
            SerializeButton.UseVisualStyleBackColor = true;
            SerializeButton.Click += SerializeButton_Click;
            // 
            // DeserializeButton
            // 
            DeserializeButton.Location = new Point(351, 74);
            DeserializeButton.Name = "DeserializeButton";
            DeserializeButton.Size = new Size(153, 24);
            DeserializeButton.TabIndex = 3;
            DeserializeButton.Text = "Десериализация данных";
            DeserializeButton.UseVisualStyleBackColor = true;
            DeserializeButton.Click += DeserializeButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeserializeButton);
            Controls.Add(SerializeButton);
            Controls.Add(CreateContactErrorButton);
            Controls.Add(CreateContactButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CreateContactButton;
        private Button CreateContactErrorButton;
        private Button SerializeButton;
        private Button DeserializeButton;
    }
}
