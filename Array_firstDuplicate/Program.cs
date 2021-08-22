/*
 Given an array a that contains only numbers in the range from 1 to a.length,
 find the first duplicate number for which the second occurrence has the minimal
 index. In other words, if there are more than 1 duplicated numbers, return the 
 number for which the second occurrence has a smaller index than the second 
 occurrence of the other number does. If there are no such elements, return -1.
 */

using System;

namespace Array_FirstDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 1, 3, 5, 3, 2 };

            Console.WriteLine(FirstDuplicate(a));

        }

        public static int FirstDuplicate(int[] a)
        {
            if (a.Length <= 1)
            {
                return -1;
            }

            for (int i = 0; i < a.Length; i++)
            {
                int pos = Math.Abs(a[i]) - 1;
                if (a[pos] < 0)
                {
                    return pos + 1;
                }
                else
                {
                    a[pos] = -a[pos];
                }
            }

            return -1;
        }
    }
}
