using System;

namespace Candies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int candies(int n, int m)
        {
            decimal avg = m / n;

            return (int)Math.Floor(avg) * n;
        }
    }
}
