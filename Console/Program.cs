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
            Console.WriteLine(publicKey);
        }
    }
}
