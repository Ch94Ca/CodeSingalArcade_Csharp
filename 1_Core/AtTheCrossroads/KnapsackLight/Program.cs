using System;

namespace KnapsackLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(knapsackLight(10, 5, 6, 4, 8));
            Console.WriteLine(knapsackLight(10, 5, 6, 4, 9));
            Console.WriteLine(knapsackLight(5, 3, 7, 4, 6));
            Console.WriteLine(knapsackLight(10, 2, 11, 3, 1));
        }

        static int knapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {
            bool canTaketwo = ((weight1 + weight2) <= maxW) ? true : false;

            if (canTaketwo)
            {
                return value1 + value2;
            }
            else
            {
                int item1Value = 0;
                int item2Value = 0;

                if (weight1 <= maxW)
                {
                    item1Value = value1;
                }
                if (weight2 <= maxW)
                {
                    item2Value = value2;
                }

                return (item1Value > item2Value) ? item1Value : item2Value;
            }
        }
    }
}
