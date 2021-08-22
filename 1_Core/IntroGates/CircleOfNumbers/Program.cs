using System;

namespace CircleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(circleOfNumbers(6, 3));
        }

        public static int circleOfNumbers(int n, int firstNumber)
        {
            int result = firstNumber + (n / 2);

            if (result >= n)
            {
                result -= n;
            }

            return result;
        }
    }
}
