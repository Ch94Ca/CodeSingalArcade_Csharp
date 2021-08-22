/*
 * Given a string s consisting of small English letters, 
 * find and return the first instance of a non-repeating 
 * character in it. If there is no such character, return '_'.
 */

using System;
using System.Collections.Generic;

namespace Array_firstNotRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(firstNotRepeatingCharacter("abacabad"));
            Console.WriteLine(firstNotRepeatingCharacter("abcdefghijklmnopqrstuvwxyziflskecznslkjfabe"));
        }

        public static char firstNotRepeatingCharacter(string s)
        {

            for (int i = 0; i < s.Length; i++)
            {
                if (s.IndexOf(s[i]) == s.LastIndexOf(s[i]))
                {
                    return s[i];
                }
            }

            return '_';
        }
    }
}
