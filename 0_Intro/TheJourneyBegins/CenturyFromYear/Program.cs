using System;

namespace CenturyFromYear
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int centuryFromYear(int year)
        {
            decimal century = year / 100;

            if (year % 100 == 0)
            {
                return (int)Math.Floor(century);
            }
            else
            {
                return (int)Math.Floor(century) + 1;
            }
        }
    }
}
