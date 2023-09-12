using System;
using System.Numerics;
using static Crypto.Client;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            StartSession();
            BigInteger b = Encrypt("123");
            string s = Decrypt(b);
        }
    }
}
