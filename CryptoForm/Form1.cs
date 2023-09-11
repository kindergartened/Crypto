using static Crypto.Client;
using System;
using System.Numerics;
using System.Security.Cryptography;

namespace CryptoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartSession();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            afterDecryption.Text = "";
            afterEncryption.Text = "";
            originalText.Text = "";
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            if (originalText.Text == "")
            {
                MessageBox.Show("Пустое поле");
            }
            afterEncryption.Text = Encrypt(originalText.Text).ToString();
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            if (afterEncryption.Text == "")
            {
                MessageBox.Show("Пустое поле");
            }
            afterDecryption.Text = Decrypt(BigInteger.Parse(afterEncryption.Text));
        }
    }
}