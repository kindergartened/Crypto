using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace Crypto
{
    public class RSA
    {

        private static RandomNumberGenerator rng = RandomNumberGenerator.Create();

        /// <summary>
        /// Генерирует случайное простое число BigInteger заданной длины.
        /// </summary>
        /// <returns>Случайное простое число BigInteger.</returns>
        public static BigInteger GeneratePrime(int keySizeInBits)
        {
            while (true)
            {
                BigInteger candidate = GenerateRandomPositiveBigInteger(keySizeInBits);
                if (IsProbablyPrime(candidate))
                    return candidate;
            }
        }

        /// <summary>
        /// Генерирует случайное положительное BigInteger заданной длины.
        /// </summary>
        /// <param name="bitLength">Длина числа в битах.</param>
        /// <returns>Случайное положительное BigInteger.</returns>
        private static BigInteger GenerateRandomPositiveBigInteger(int bitLength)
        {
            byte[] bytes = new byte[bitLength / 8];
            rng.GetBytes(bytes);
            bytes[bytes.Length - 1] &= 0x7F; // Установим младший бит в 0, чтобы гарантировать положительное число
            return new BigInteger(bytes);
        }

        /// <summary>
        /// Проверяет, вероятно ли число является простым числом.
        /// </summary>
        /// <param name="n">Проверяемое число.</param>
        /// <param name="iterations">Количество итераций для теста Миллера-Рабина (по умолчанию 10).</param>
        /// <returns>True, если число вероятно простое, иначе False.</returns>
        private static bool IsProbablyPrime(BigInteger n, int iterations = 10)
        {
            if (n <= 1 || n % 2 == 0)
                return false;
            if (n <= 3)
                return true;

            BigInteger d = n - 1;
            int s = 0;
            while (d % 2 == 0)
            {
                d >>= 1; // Правый сдвиг на 1 эквивалентен делению на 2
                s++;
            }

            for (int i = 0; i < iterations; i++)
            {
                if (!MillerRabinTest(n, d, s))
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Проводит тест Миллера-Рабина для проверки вероятности простоты числа.
        /// </summary>
        /// <param name="n">Проверяемое число.</param>
        /// <param name="d">Число d из разложения n - 1 = 2^s * d.</param>
        /// <param name="s">Число s из разложения n - 1 = 2^s * d.</param>
        /// <returns>True, если число вероятно простое, иначе False.</returns>
        private static bool MillerRabinTest(BigInteger n, BigInteger d, int s)
        {
            BigInteger a = GenerateRandomPositiveBigInteger(n.ToByteArray().Length * 8 - 1) % (n - 2) + 2;
            BigInteger x = BigInteger.ModPow(a, d, n);

            if (x == 1 || x == n - 1)
                return true;

            for (int r = 1; r < s; r++)
            {
                x = BigInteger.ModPow(x, 2, n);
                if (x == n - 1)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Генерирует открытую экспоненту для алгоритма RSA.
        /// </summary>
        /// <param name="phi">Значение функции Эйлера (phi).</param>
        /// <returns>Открытая экспонента (e).</returns>
        public static BigInteger GeneratePublicKey(BigInteger phi, int keySizeInBits)
        {
            // Генерация открытой экспоненты (для упрощения можно использовать стандартное значение)
            BigInteger publicKey;

            do
            {
                publicKey = GenerateRandomPositiveBigInteger(keySizeInBits);
            }
            while (BigInteger.GreatestCommonDivisor(publicKey, phi) != 1);

            return publicKey;
        }
        /// <summary>
        /// Вычисляет закрытый ключ для алгоритма RSA.
        /// </summary>
        /// <param name="e">Открытая экспонента (e).</param>
        /// <param name="phi">Значение функции Эйлера (phi).</param>
        /// <returns>Закрытый ключ (d).</returns>
        public static BigInteger CalculatePrivateKey(BigInteger e, BigInteger phi)
        {
            BigInteger d = ModInverse(e, phi);
            return d;
        }

        /// <summary>
        /// Вычисляет модульное обратное значение (мультипликативно обратное) числа a по модулю m.
        /// </summary>
        /// <param name="a">Число, для которого вычисляется обратное значение.</param>
        /// <param name="m">Модуль, по которому производится вычисление.</param>
        /// <returns>Модульное обратное значение (a^(-1) mod m).</returns>
        static BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m;
            BigInteger x0 = 0;
            BigInteger x1 = 1;

            while (a > 1)
            {
                BigInteger q = a / m;
                BigInteger t = m;

                m = a % m;
                a = t;
                t = x0;

                x0 = x1 - q * x0;
                x1 = t;
            }

            if (x1 < 0)
            {
                x1 += m0;
            }

            return x1;
        }

        /// <summary>
        /// Шифрует строку данных с использованием открытого ключа RSA.
        /// </summary>
        /// <param name="data">Исходная строка данных для шифрования.</param>
        /// <param name="e">Открытая экспонента (e).</param>
        /// <param name="n">Модуль (n).</param>
        /// <returns>Шифртекст в виде BigInteger.</returns>
        public static BigInteger Encrypt(string data, BigInteger e, BigInteger n)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            BigInteger plaintext = new BigInteger(bytes);
            BigInteger ciphertext = BigInteger.ModPow(plaintext, e, n);
            return ciphertext;
        }

        /// <summary>
        /// Расшифровывает шифртекст, используя закрытый ключ RSA.
        /// </summary>
        /// <param name="ciphertext">Шифртекст в виде BigInteger.</param>
        /// <param name="d">Закрытый ключ (d).</param>
        /// <param name="n">Модуль (n).</param>
        /// <returns>Исходная строка данных после расшифровки.</returns>
        public static string Decrypt(BigInteger ciphertext, BigInteger d, BigInteger n)
        {
            BigInteger plaintext = BigInteger.ModPow(ciphertext, d, n);
            byte[] bytes = plaintext.ToByteArray();
            return Encoding.UTF8.GetString(bytes);
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
        public static int keySizeInBitsForPrivate = 512;
        public static int keySizeInBitsForPublic = 16;
        public static void StartSession()
        {
            p = RSA.GeneratePrime(keySizeInBitsForPrivate);
            q = RSA.GeneratePrime(keySizeInBitsForPrivate);
            n = p * q;
            phi = (p - 1) * (q - 1);
            publicKey = RSA.GeneratePublicKey(phi, keySizeInBitsForPublic);
            privateKey = RSA.CalculatePrivateKey(publicKey, phi);
        }
        public static BigInteger Encrypt(string data)
        {
            return RSA.Encrypt(data, publicKey, n);
        }
        public static string Decrypt(BigInteger ciphertext)
        {
            return RSA.Decrypt(ciphertext, privateKey, n);
        }
    }
}