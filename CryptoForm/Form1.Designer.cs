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
            button2 = new Button();
            button3 = new Button();
            Key = new TextBox();
            label4 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            afterDecryption2 = new RichTextBox();
            afterEncryption2 = new RichTextBox();
            originalText2 = new RichTextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // Encrypt
            // 
            Encrypt.BackColor = SystemColors.Highlight;
            Encrypt.FlatStyle = FlatStyle.Popup;
            Encrypt.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Encrypt.ForeColor = SystemColors.Control;
            Encrypt.Location = new Point(528, 163);
            Encrypt.Name = "Encrypt";
            Encrypt.Size = new Size(185, 59);
            Encrypt.TabIndex = 0;
            Encrypt.Text = "Зашифровать";
            Encrypt.UseVisualStyleBackColor = false;
            Encrypt.Click += Encrypt_Click_1;
            // 
            // Decrypt
            // 
            Decrypt.BackColor = SystemColors.Highlight;
            Decrypt.FlatStyle = FlatStyle.Popup;
            Decrypt.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Decrypt.ForeColor = SystemColors.Control;
            Decrypt.Location = new Point(528, 272);
            Decrypt.Name = "Decrypt";
            Decrypt.Size = new Size(185, 59);
            Decrypt.TabIndex = 1;
            Decrypt.Text = "Расшифровать";
            Decrypt.UseVisualStyleBackColor = false;
            Decrypt.Click += Decrypt_Click_1;
            // 
            // originalText
            // 
            originalText.BackColor = SystemColors.Menu;
            originalText.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            originalText.Location = new Point(28, 46);
            originalText.Name = "originalText";
            originalText.Size = new Size(388, 106);
            originalText.TabIndex = 2;
            originalText.Text = "";
            // 
            // afterEncryption
            // 
            afterEncryption.BackColor = SystemColors.Menu;
            afterEncryption.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            afterEncryption.Location = new Point(28, 204);
            afterEncryption.Name = "afterEncryption";
            afterEncryption.Size = new Size(388, 106);
            afterEncryption.TabIndex = 3;
            afterEncryption.Text = "";
            // 
            // afterDecryption
            // 
            afterDecryption.BackColor = SystemColors.Menu;
            afterDecryption.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            afterDecryption.Location = new Point(28, 358);
            afterDecryption.Name = "afterDecryption";
            afterDecryption.Size = new Size(388, 106);
            afterDecryption.TabIndex = 4;
            afterDecryption.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-4, -39);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 5;
            label1.Text = "Изначальный текст";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 176);
            label2.Name = "label2";
            label2.Size = new Size(180, 25);
            label2.TabIndex = 6;
            label2.Text = "После зашифровки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 326);
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
            button1.Location = new Point(752, 457);
            button1.Name = "button1";
            button1.Size = new Size(41, 41);
            button1.TabIndex = 8;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(464, 174);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(248, 48);
            button2.TabIndex = 9;
            button2.Text = "Шифр Цезаря";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuHighlight;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(464, 271);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(248, 51);
            button3.TabIndex = 10;
            button3.Text = "Расшифровка";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Key
            // 
            Key.Location = new Point(599, 402);
            Key.Margin = new Padding(3, 2, 3, 2);
            Key.Name = "Key";
            Key.Size = new Size(80, 32);
            Key.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(599, 366);
            label4.Name = "label4";
            label4.Size = new Size(67, 30);
            label4.TabIndex = 12;
            label4.Text = "Ключ";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(748, 506);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(Decrypt);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(Encrypt);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(afterDecryption);
            tabPage1.Controls.Add(afterEncryption);
            tabPage1.Controls.Add(originalText);
            tabPage1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(740, 478);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "RSA";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(afterDecryption2);
            tabPage2.Controls.Add(afterEncryption2);
            tabPage2.Controls.Add(originalText2);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(Key);
            tabPage2.Controls.Add(button2);
            tabPage2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(740, 478);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Caesar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(28, 18);
            label5.Name = "label5";
            label5.Size = new Size(150, 25);
            label5.TabIndex = 9;
            label5.Text = "До зашифровки";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(24, 16);
            label6.Name = "label6";
            label6.Size = new Size(150, 25);
            label6.TabIndex = 18;
            label6.Text = "До зашифровки";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(24, 324);
            label7.Name = "label7";
            label7.Size = new Size(192, 25);
            label7.TabIndex = 17;
            label7.Text = "После расшифровки";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(24, 174);
            label8.Name = "label8";
            label8.Size = new Size(180, 25);
            label8.TabIndex = 16;
            label8.Text = "После зашифровки";
            // 
            // afterDecryption2
            // 
            afterDecryption2.BackColor = SystemColors.Menu;
            afterDecryption2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            afterDecryption2.Location = new Point(24, 356);
            afterDecryption2.Name = "afterDecryption2";
            afterDecryption2.Size = new Size(388, 106);
            afterDecryption2.TabIndex = 15;
            afterDecryption2.Text = "";
            // 
            // afterEncryption2
            // 
            afterEncryption2.BackColor = SystemColors.Menu;
            afterEncryption2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            afterEncryption2.Location = new Point(24, 202);
            afterEncryption2.Name = "afterEncryption2";
            afterEncryption2.Size = new Size(388, 106);
            afterEncryption2.TabIndex = 14;
            afterEncryption2.Text = "";
            // 
            // originalText2
            // 
            originalText2.BackColor = SystemColors.Menu;
            originalText2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            originalText2.Location = new Point(24, 44);
            originalText2.Name = "originalText2";
            originalText2.Size = new Size(388, 106);
            originalText2.TabIndex = 13;
            originalText2.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Проект - Криптография";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
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
        private Button button2;
        private Button button3;
        private TextBox Key;
        private Label label4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private RichTextBox afterDecryption2;
        private RichTextBox afterEncryption2;
        private RichTextBox originalText2;
    }
}