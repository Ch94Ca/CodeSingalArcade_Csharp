using System;

namespace IsInfiniteProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isInfiniteProcess(2, 7));
        }

        static bool isInfiniteProcess(int a, int b)
        {
            bool conditionA = a > b;
            bool conditionB = ((a + b) & 1) == 1;

            return (conditionA || conditionB) ? true : false;

            //return ((a > b) || (((a + b) & 1) == 1)) ? true : false;
        }
    }
}
