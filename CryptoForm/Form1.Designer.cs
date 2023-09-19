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
            this.Encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.originalText = new System.Windows.Forms.RichTextBox();
            this.afterEncryption = new System.Windows.Forms.RichTextBox();
            this.afterDecryption = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Key = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Encrypt
            // 
            this.Encrypt.BackColor = System.Drawing.SystemColors.Highlight;
            this.Encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Encrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Encrypt.ForeColor = System.Drawing.SystemColors.Control;
            this.Encrypt.Location = new System.Drawing.Point(629, 109);
            this.Encrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(211, 79);
            this.Encrypt.TabIndex = 0;
            this.Encrypt.Text = "Зашифровать";
            this.Encrypt.UseVisualStyleBackColor = false;
            // 
            // Decrypt
            // 
            this.Decrypt.BackColor = System.Drawing.SystemColors.Highlight;
            this.Decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Decrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Decrypt.ForeColor = System.Drawing.SystemColors.Control;
            this.Decrypt.Location = new System.Drawing.Point(629, 315);
            this.Decrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(211, 79);
            this.Decrypt.TabIndex = 1;
            this.Decrypt.Text = "Расшифровать";
            this.Decrypt.UseVisualStyleBackColor = false;
            // 
            // originalText
            // 
            this.originalText.BackColor = System.Drawing.SystemColors.Menu;
            this.originalText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.originalText.Location = new System.Drawing.Point(67, 75);
            this.originalText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.originalText.Name = "originalText";
            this.originalText.Size = new System.Drawing.Size(443, 140);
            this.originalText.TabIndex = 2;
            this.originalText.Text = "";
            // 
            // afterEncryption
            // 
            this.afterEncryption.BackColor = System.Drawing.SystemColors.Menu;
            this.afterEncryption.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.afterEncryption.Location = new System.Drawing.Point(67, 285);
            this.afterEncryption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.afterEncryption.Name = "afterEncryption";
            this.afterEncryption.Size = new System.Drawing.Size(443, 140);
            this.afterEncryption.TabIndex = 3;
            this.afterEncryption.Text = "";
            // 
            // afterDecryption
            // 
            this.afterDecryption.BackColor = System.Drawing.SystemColors.Menu;
            this.afterDecryption.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.afterDecryption.Location = new System.Drawing.Point(67, 491);
            this.afterDecryption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.afterDecryption.Name = "afterDecryption";
            this.afterDecryption.Size = new System.Drawing.Size(443, 140);
            this.afterDecryption.TabIndex = 4;
            this.afterDecryption.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Изначальный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(67, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "После зашифровки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(67, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "После расшифровки";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(854, 609);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 55);
            this.button1.TabIndex = 8;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(645, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 80);
            this.button2.TabIndex = 9;
            this.button2.Text = "Шифр Цезаря";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(645, 567);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 84);
            this.button3.TabIndex = 10;
            this.button3.Text = "Расшифровка";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Key
            // 
            this.Key.Location = new System.Drawing.Point(531, 615);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(91, 27);
            this.Key.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(531, 567);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 38);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ключ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 680);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.afterDecryption);
            this.Controls.Add(this.afterEncryption);
            this.Controls.Add(this.originalText);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Проект - Криптография";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}