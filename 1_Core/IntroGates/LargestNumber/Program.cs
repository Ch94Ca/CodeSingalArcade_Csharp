using System;

namespace LargestNumber
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(largestNumber(2));
        }

        static public int largestNumber(int n)
        {
            string str = string.Empty;

            while (n-- != 0)
            {
                str += '9';
            }

            return int.Parse(str);
        }
    }
}
