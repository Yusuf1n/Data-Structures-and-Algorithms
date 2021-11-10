// Daily Byte - 10/11/21

/*
This question is asked by Facebook. Given a string and the ability to delete at most one character, return whether or not it can form a palindrome.
Note: a palindrome is a sequence of characters that reads the same forwards and backwards.

Ex: Given the following strings...

"abcba", return true
"foobof", return true (remove the first 'o', the second 'o', or 'b')
"abccab", return false
*/

using System;

namespace Code_Playground
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(palindrome("foobof".ToLower()));
            Console.ReadLine();
        }

        static bool palindrome(string input)
        {
            Regex rgx = new Regex("[^a-zA-Z]");
            input = rgx.Replace(input, "");

            char[] charArray1 = input.ToCharArray();
            Array.Reverse(charArray1);
            string CharArray2 = new string(charArray1);

            if (input == CharArray2)
            {
                return true;
            }
            else if (input != CharArray2)
            {
                foreach (char letter in input)
                {
                    string newInput = input.Remove(input.IndexOf(letter), 1);

                    char[] CharArray3 = newInput.ToCharArray();
                    Array.Reverse(CharArray3);
                    string CharArray4 = new string(CharArray3);

                    if (newInput == CharArray4)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}