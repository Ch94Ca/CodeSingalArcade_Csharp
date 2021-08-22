using System;

namespace ReachNextLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(reachNextLevel(10, 15, 5));
        }

        static bool reachNextLevel(int experience, int threshold, int reward)
        {
            if ((experience + reward) >= threshold)
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
