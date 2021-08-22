using System;

namespace AddTwoDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int addTwoDigits(int n)
        {

            string str = n.ToString();

            return int.Parse(str[0].ToString()) + int.Parse(str[1].ToString());

        }
    }
}
