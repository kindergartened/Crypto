namespace CryptoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Encrypt = new Button();
            Decrypt = new Button();
            originalText = new RichTextBox();
            afterEncryption = new RichTextBox();
            afterDecryption = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Encrypt
            // 
            Encrypt.BackColor = SystemColors.Highlight;
            Encrypt.FlatStyle = FlatStyle.Popup;
            Encrypt.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Encrypt.ForeColor = SystemColors.Control;
            Encrypt.Location = new Point(550, 82);
            Encrypt.Name = "Encrypt";
            Encrypt.Size = new Size(185, 59);
            Encrypt.TabIndex = 0;
            Encrypt.Text = "Зашифровать";
            Encrypt.UseVisualStyleBackColor = false;
            Encrypt.Click += Encrypt_Click;
            // 
            // Decrypt
            // 
            Decrypt.BackColor = SystemColors.Highlight;
            Decrypt.FlatStyle = FlatStyle.Popup;
            Decrypt.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Decrypt.ForeColor = SystemColors.Control;
            Decrypt.Location = new Point(550, 236);
            Decrypt.Name = "Decrypt";
            Decrypt.Size = new Size(185, 59);
            Decrypt.TabIndex = 1;
            Decrypt.Text = "Расшифровать";
            Decrypt.UseVisualStyleBackColor = false;
            Decrypt.Click += Decrypt_Click;
            // 
            // originalText
            // 
            originalText.BackColor = SystemColors.Menu;
            originalText.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            originalText.Location = new Point(59, 56);
            originalText.Name = "originalText";
            originalText.Size = new Size(388, 106);
            originalText.TabIndex = 2;
            originalText.Text = "";
            // 
            // afterEncryption
            // 
            afterEncryption.BackColor = SystemColors.Menu;
            afterEncryption.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            afterEncryption.Location = new Point(59, 214);
            afterEncryption.Name = "afterEncryption";
            afterEncryption.Size = new Size(388, 106);
            afterEncryption.TabIndex = 3;
            afterEncryption.Text = "";
            // 
            // afterDecryption
            // 
            afterDecryption.BackColor = SystemColors.Menu;
            afterDecryption.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            afterDecryption.Location = new Point(59, 368);
            afterDecryption.Name = "afterDecryption";
            afterDecryption.Size = new Size(388, 106);
            afterDecryption.TabIndex = 4;
            afterDecryption.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(59, 28);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 5;
            label1.Text = "Изначальный текст";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(59, 186);
            label2.Name = "label2";
            label2.Size = new Size(180, 25);
            label2.TabIndex = 6;
            label2.Text = "После зашифровки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(59, 336);
            label3.Name = "label3";
            label3.Size = new Size(192, 25);
            label3.TabIndex = 7;
            label3.Text = "После расшифровки";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(747, 457);
            button1.Name = "button1";
            button1.Size = new Size(41, 41);
            button1.TabIndex = 8;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(afterDecryption);
            Controls.Add(afterEncryption);
            Controls.Add(originalText);
            Controls.Add(Decrypt);
            Controls.Add(Encrypt);
            Name = "Form1";
            Text = "Проект - Криптография";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Encrypt;
        private Button Decrypt;
        private RichTextBox originalText;
        private RichTextBox afterEncryption;
        private RichTextBox afterDecryption;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}