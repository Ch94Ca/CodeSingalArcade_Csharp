using System;

namespace MaxMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(maxMultiple(3, 10));
        }
        public static int maxMultiple(int divisor, int bound)
        {
            int square = (int)Math.Sqrt(divisor);
            int max = int.MinValue;

            for (int i = 2; i <= bound; i++)
            {
                if ((i % divisor == 0) && (i > max))
                {
                    max = i;
                }
            }

            return max;
        }
    }
}
