using System;

namespace TennisSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(tennisSet(3, 6));
            Console.WriteLine(tennisSet(8, 5));
            Console.WriteLine(tennisSet(6, 5));
            Console.WriteLine(tennisSet(7, 2));
            Console.WriteLine(tennisSet(7, 7));
        }
        static bool tennisSet(int score1, int score2)
        {
            if ((score1 == 6) && score2 < 5)
            {
                return true;

            }
            else if ((score2 == 6) && score1 < 5)
            {
                return true;

            }
            else if ((score1 == 6) && score2 < 5)
            {

                return true;

            }
            else if ((score2 == 6) && score1 < 5)
            {

                return true;

            }
            else if ((score1 == 7) && ((5 <= score2) && (score2 < 7)))
            {
                return true;
            }
            else if (score2 == 7 && ((5 <= score1) && (score1 < 7)))
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
