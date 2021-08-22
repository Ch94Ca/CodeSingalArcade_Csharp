using System;

namespace PhoneCall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(phoneCall(3, 1, 2, 20));
        }
        public static int phoneCall(int min1, int min2_10, int min11, int s)
        {
            int totalMinutes = 0;

            if (s >= min1)
            {
                s -= min1;
                totalMinutes++;
            }

            if (s >= min2_10)
            {
                int max = min2_10 * 9;
                if (s >= max)
                {
                    s -= max;
                    totalMinutes += 9;
                }
                else
                {
                    max = s / min2_10;
                    s -= max * min2_10;
                    totalMinutes += max;
                }
            }

            if ((s >= min11) && (totalMinutes >= 10))
            {
                int max = s / min11;
                totalMinutes += max;
            }

            return totalMinutes;
        }
    }
}