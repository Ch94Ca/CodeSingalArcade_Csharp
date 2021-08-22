using System;

namespace CheckPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static bool checkPalindrome(string inputString)
        {
            char[] inputArray = inputString.ToCharArray();
            Array.Reverse(inputArray);
            string reverseInput = new string(inputArray);

            return inputString.Equals(reverseInput);
        }
    }
}
