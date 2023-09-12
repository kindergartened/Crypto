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
                MessageBox.Show("������ ����");
                return;
            }
            if (originalText.Text.Length > keySizeInBitsForPrivate / 4)
            {
                MessageBox.Show($"��������� ������������ ����� ������. ({keySizeInBitsForPrivate / 4})");
                return;
            }
            afterEncryption.Text = Encrypt(originalText.Text).ToString();
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (afterEncryption.Text == "")
                {
                    MessageBox.Show("������ ����");
                }
                BigInteger bigInteger;
                bool maybeBigInteger = BigInteger.TryParse(afterEncryption.Text, out bigInteger);
                if (!maybeBigInteger)
                {
                    MessageBox.Show("������ �����������: ������� ������ ������ ��� �����������.");
                }
                afterDecryption.Text = Decrypt(bigInteger);
            } catch
            {
                MessageBox.Show("�������������� ������");
            }
            
        }
    }
}