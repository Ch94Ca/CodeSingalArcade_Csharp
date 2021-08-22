using System;

namespace LateRide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(lateRide(808));
        }

        public static int lateRide(int n)
        {

            int hours = n / 60;
            int minutes = (n % 60);
            string str = hours.ToString() + minutes.ToString();
            int strLen = str.Length;
            int result = 0;

            for (int i = 0; i < strLen; i++)
            {
                result += int.Parse(str[i].ToString());
            }

            return result;
        }
    }
}
