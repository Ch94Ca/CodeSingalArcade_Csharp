using System;

namespace ExtraNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static int extraNumber(int a, int b, int c)
        {
            return a ^ b ^ c;
        }
    }
}
