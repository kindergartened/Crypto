using static Crypto.Client;
using Lib;

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
                BigInt bigInteger;
                bool maybeBigInteger = BigInt.TryParse(afterEncryption.Text, out bigInteger);
                if (!maybeBigInteger)
                {
                    MessageBox.Show("������ �����������: ������� ������ ������ ��� �����������.");
                }
                afterDecryption.Text = Decrypt(bigInteger);
            }
            catch
            {
                MessageBox.Show("�������������� ������");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Key.Text == "")
            {
                MessageBox.Show("������ ����");
                return;
            }
            int key = Convert.ToInt32(Key.Text);
            if (originalText.Text == "")
            {
                MessageBox.Show("������ ����");
                return;
            }
            afterEncryption.Text = Caesar(originalText.Text, key);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Key.Text == "")
            {
                MessageBox.Show("������ ����");
                return;
            }
            int key = Convert.ToInt32(Key.Text);
            if (afterEncryption.Text == "")
            {
                MessageBox.Show("������ ����");
                return;
            }
            afterDecryption.Text = Caesar(afterEncryption.Text, -key);
        }

        private void Encrypt_Click_1(object sender, EventArgs e)
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

        private void Decrypt_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (afterEncryption.Text == "")
                {
                    MessageBox.Show("������ ����");
                }
                BigInt bigInteger;
                bool maybeBigInteger = BigInt.TryParse(afterEncryption.Text, out bigInteger);
                if (!maybeBigInteger)
                {
                    MessageBox.Show("������ �����������: ������� ������ ������ ��� �����������.");
                }
                afterDecryption.Text = Decrypt(bigInteger);
            }
            catch
            {
                MessageBox.Show("�������������� ������");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            afterDecryption.Text = "";
            afterEncryption.Text = "";
            originalText.Text = "";
            afterDecryption2.Text = "";
            afterEncryption2.Text = "";
            originalText2.Text = "";
        }
    }
}