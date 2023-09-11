using System.Numerics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Crypto
{
    public class RSALib
    {
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        byte[] plaintext;
        byte[] encryptedtext;
        /// <summary>
        /// Example Encryption
        /// </summary>
        /// <param name="Data">Data for decrypt</param>
        /// <param name="RSAKey">Public key</param>
        /// <param name="DoOAEPPadding">IsSalt?</param>
        /// <returns>Array bytes</returns>
        static public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        /// <summary>
        /// Example Decryption
        /// </summary>
        /// <param name="Data">Data for decrypt</param>
        /// <param name="RSAKey">Public key</param>
        /// <param name="DoOAEPPadding">IsSalt?</param>
        /// <returns>Array bytes</returns>
        static public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
    public class RSA
    {
        public static BigInteger GeneratePrimeNumber()
        {
            return 17;
            // Генерация случайного простого числа
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] randomNumber = new byte[64]; // Размер в байтах, можно увеличить для более длинных чисел
                rng.GetBytes(randomNumber);

                BigInteger prime = new BigInteger(randomNumber);
                prime = BigInteger.Abs(prime); // Убедитесь, что число положительное

                // Проверка на простоту
                if (IsPrime(prime))
                {
                    return prime;
                }
                else
                {
                    return GeneratePrimeNumber(); // Повторная попытка, если число не простое
                }
            }
        }

        static bool IsPrime(BigInteger n)
        {
            if (n <= 1)
                return false;
            if (n <= 3)
                return true;
            if (n % 2 == 0 || n % 3 == 0)
                return false;

            for (BigInteger i = 5; i * i <= n; i += 6)
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;

            return true;
        }

        public static BigInteger GeneratePublicKey(BigInteger phi)
        {
            return 65537;
            // Генерация открытой экспоненты (для упрощения можно использовать стандартное значение)
            BigInteger publicKey;

            do
            {
                publicKey = RandomBigInteger(BigInteger.One, phi);
            }
            while (BigInteger.GreatestCommonDivisor(publicKey, phi) != 1);

            return publicKey;
        }

        static BigInteger RandomBigInteger(BigInteger minValue, BigInteger maxValue)
        {
            if (minValue == maxValue)
                return minValue;

            byte[] bytes = maxValue.ToByteArray();
            BigInteger result;

            do
            {
                using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(bytes);
                }

                bytes[bytes.Length - 1] &= (byte)0x7F; // Ensure positive value
                result = new BigInteger(bytes);
            }
            while (result < minValue || result >= maxValue);

            return result;
        }

        public static BigInteger CalculatePrivateKey(BigInteger e, BigInteger phi)
        {
            // Вычисление закрытой экспоненты (d) с помощью расширенного алгоритма Эвклида
            BigInteger d, x, y;
            ExtendedEuclideanAlgorithm(e, phi, out d, out x, out y);
            if (d < 0)
            {
                d += phi;
            }
            return d;
        }

        static void ExtendedEuclideanAlgorithm(BigInteger a, BigInteger b, out BigInteger gcd, out BigInteger x, out BigInteger y)
        {
            gcd = 1;
            x = 1;
            y = 0;
            return;
            // Расширенный алгоритм Эвклида для вычисления НОД и коэффициентов x и y
            if (b == 0)
            {
                gcd = a;
                x = 1;
                y = 0;
            }
            else
            {
                ExtendedEuclideanAlgorithm(b, a % b, out gcd, out x, out y);
                BigInteger temp = x;
                x = y;
                y = temp - (a / b) * y;
            }
        }

        public static BigInteger Encrypt(byte[] data, BigInteger e, BigInteger n)
        {
            BigInteger plaintext = new BigInteger(data);
            BigInteger ciphertext = BigInteger.ModPow(plaintext, e, n);
            return ciphertext;
        }

        public static byte[] Decrypt(BigInteger ciphertext, BigInteger d, BigInteger n)
        {
            BigInteger plaintext = BigInteger.ModPow(ciphertext, d, n);
            return plaintext.ToByteArray();
        }
    }
    public class Client
    {
        private static BigInteger privateKey;
        private static BigInteger p;
        private static BigInteger q;
        private static BigInteger phi;

        public static BigInteger n;
        public static BigInteger publicKey;
        public static void StartSession()
        {
            p = RSA.GeneratePrimeNumber();
            q = RSA.GeneratePrimeNumber();
            n = p * q;
            phi = (p - 1) * (q - 1);
            publicKey = RSA.GeneratePublicKey(phi);
            privateKey = RSA.CalculatePrivateKey(publicKey, phi);
            Console.WriteLine($"{p}, {q}, {phi}, {publicKey}, {privateKey}");
        }
        public static BigInteger Encrypt(string data)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            return RSA.Encrypt(dataBytes, publicKey, n);
        }
        public static string Decrypt(BigInteger ciphertext)
        {
            byte[] bytes = RSA.Decrypt(ciphertext, privateKey, n);
            return Encoding.UTF8.GetString(bytes);
        }
    }
}