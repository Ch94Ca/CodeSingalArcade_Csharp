using System;

namespace ArithmeticExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(arithmeticExpression(8, 3, 2));
        }

        static bool arithmeticExpression(int a, int b, int c)
        {
            // a # b = c

            if ((a + b) == c)
            {
                return true;
            }
            else if ((a - b) == c)
            {
                return true;
            }
            else if ((a * b) == c)
            {
                return true;
            }
            else if (a == b * c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
