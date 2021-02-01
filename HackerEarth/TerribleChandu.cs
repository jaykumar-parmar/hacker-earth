using System;
using System.Collections.Generic;
using System.Text;

namespace HackerEarth
{
    // Basics of string manipulation
    // Problem : Palindrome

    public static class TerribleChandu
    {
        //static void Main(string[] args)
        //{
        //    StringReversal();
        //    Console.ReadKey();
        //}

        static void StringReversal()
        {
            int testCaseCount = 0;
            string[] testCases;

            if (int.TryParse(Console.ReadLine(), out testCaseCount))
            {
                testCases = new string[testCaseCount];

                for (int i = 0; i < testCaseCount; i++)
                {
                    string stringFromUser = Console.ReadLine();
                    Console.WriteLine(FindPalindrome(stringFromUser));
                }
            }

        }

        static string FindPalindrome(string orignalString)
        {
            string reversedString = "";

            for (int i = orignalString.Length - 1; i >= 0; i--)
            {
                reversedString += orignalString[i];
            }

            return reversedString;
        }
    }
}
