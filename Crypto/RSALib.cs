using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using Lib;

namespace Crypto
{
    public class RSA
    {

        private static RandomNumberGenerator rng = RandomNumberGenerator.Create();

        /// <summary>
        /// Генерирует случайное простое число BigInt заданной длины.
        /// </summary>
        /// <returns>Случайное простое число BigInt.</returns>
        public static BigInt GeneratePrime(int keySizeInBits)
        {
            while (true)
            {
                BigInt candidate = GenerateRandomPositiveBigInteger(keySizeInBits);
                if (IsProbablyPrime(candidate))
                    return candidate;
            }
        }

        /// <summary>
        /// Генерирует случайное положительное BigInt заданной длины.
        /// </summary>
        /// <param name="bitLength">Длина числа в битах.</param>
        /// <returns>Случайное положительное BigInt.</returns>
        private static BigInt GenerateRandomPositiveBigInteger(int bitLength)
        {
            byte[] bytes = new byte[bitLength / 8];
            rng.GetBytes(bytes);
            bytes[bytes.Length - 1] &= 0x7F; // Установим младший бит в 0, чтобы гарантировать положительное число
            return new BigInt(bytes);
        }

        /// <summary>
        /// Проверяет, вероятно ли число является простым числом.
        /// </summary>
        /// <param name="n">Проверяемое число.</param>
        /// <param name="iterations">Количество итераций для теста Миллера-Рабина (по умолчанию 10).</param>
        /// <returns>True, если число вероятно простое, иначе False.</returns>
        private static bool IsProbablyPrime(BigInt n, int iterations = 10)
        {
            if (n <= 1 || n % 2 == 0)
                return false;
            if (n <= 3)
                return true;

            BigInt d = n - 1;
            int s = 0;
            while (d % 2 == 0)
            {
                d /= 2;
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
        private static bool MillerRabinTest(BigInt n, BigInt d, int s)
        {
            BigInt a = GenerateRandomPositiveBigInteger(n.ToByteArray().Length * 8 - 1) % (n - 2) + 2;
            BigInt x = BigInt.ModPow(a, d, n);

            if (x == 1 || x == n - 1)
                return true;

            for (int r = 1; r < s; r++)
            {
                x = BigInt.ModPow(x, 2, n);
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
        public static BigInt GeneratePublicKey(BigInt phi, int keySizeInBits)
        {
            // Генерация открытой экспоненты (для упрощения можно использовать стандартное значение)
            BigInt publicKey;

            do
            {
                publicKey = GenerateRandomPositiveBigInteger(keySizeInBits);
            }
            while (BigInt.GreatestCommonDivisor(publicKey, phi) != 1);

            return publicKey;
        }
        /// <summary>
        /// Вычисляет закрытый ключ для алгоритма RSA.
        /// </summary>
        /// <param name="e">Открытая экспонента (e).</param>
        /// <param name="phi">Значение функции Эйлера (phi).</param>
        /// <returns>Закрытый ключ (d).</returns>
        public static BigInt CalculatePrivateKey(BigInt e, BigInt phi)
        {
            BigInt d = ModInverse(e, phi);
            return d;
        }

        /// <summary>
        /// Вычисляет модульное обратное значение (мультипликативно обратное) числа a по модулю m.
        /// </summary>
        /// <param name="a">Число, для которого вычисляется обратное значение.</param>
        /// <param name="m">Модуль, по которому производится вычисление.</param>
        /// <returns>Модульное обратное значение (a^(-1) mod m).</returns>
        static BigInt ModInverse(BigInt a, BigInt m)
        {
            BigInt m0 = m;
            BigInt x0 = new("0");
            BigInt x1 = new("1");

            while (a > 1)
            {
                BigInt q = a / m;
                BigInt t = m;

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
        /// <returns>Шифртекст в виде BigInt.</returns>
        public static BigInt Encrypt(string data, BigInt e, BigInt n)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            BigInt plaintext = new BigInt(bytes);
            BigInt ciphertext = BigInt.ModPow(plaintext, e, n);
            return ciphertext;
        }

        /// <summary>
        /// Расшифровывает шифртекст, используя закрытый ключ RSA.
        /// </summary>
        /// <param name="ciphertext">Шифртекст в виде BigInt.</param>
        /// <param name="d">Закрытый ключ (d).</param>
        /// <param name="n">Модуль (n).</param>
        /// <returns>Исходная строка данных после расшифровки.</returns>
        public static string Decrypt(BigInt ciphertext, BigInt d, BigInt n)
        {
            BigInt plaintext = BigInt.ModPow(ciphertext, d, n);
            byte[] bytes = plaintext.ToByteArray();
            return Encoding.UTF8.GetString(bytes);
        }
    }
    public class Client
    {
        private static BigInt privateKey;
        private static BigInt p;
        private static BigInt q;
        private static BigInt phi;

        public static BigInt n;
        public static BigInt publicKey;
        public static int keySizeInBitsForPrivate = 8;
        public static int keySizeInBitsForPublic = 8;

        private static string alf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"+
        "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static void StartSession()
        {
            p = RSA.GeneratePrime(keySizeInBitsForPrivate);
            q = RSA.GeneratePrime(keySizeInBitsForPrivate);
            n = p * q;
            phi = (p - 1) * (q - 1);
            publicKey = RSA.GeneratePublicKey(phi, keySizeInBitsForPublic);
            privateKey = RSA.CalculatePrivateKey(publicKey, phi);
        }
        public static BigInt Encrypt(string data)
        {
            return RSA.Encrypt(data, publicKey, n);
        }
        public static string Decrypt(BigInt ciphertext)
        {
            return RSA.Decrypt(ciphertext, privateKey, n);
        }
        
        public static string Caesar(string data,int key)
        {
            int alflen=alf.Length;
            string res = "";
            for (int i=0; i < data.Length; i++)
            {
                var c = data[i];
                var index = alf.IndexOf(c);
                if (index < 0)
                {
                    res += c.ToString(); //символ,которого нет в алфавите,оставляем без изменений
                }
                else
                {
                    int codeIndex = (alflen+ index + key) % alflen;
                    res += alf[codeIndex];
                }
            }
            return res;
        }
    }
}