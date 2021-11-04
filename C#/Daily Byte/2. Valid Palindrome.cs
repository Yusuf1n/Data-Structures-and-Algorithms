// Daily Byte

/*
This question is asked by Facebook. Given a string, return whether or not it forms a palindrome ignoring case and non-alphabetical characters.
Note: a palindrome is a sequence of characters that reads the same forwards and backwards.

Ex: Given the following strings...

"level", return true
"algorithm", return false
"A man, a plan, a canal: Panama.", return true
*/

using System;

namespace Code_Playground
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(palindrome("££level@".ToLower()));
            Console.ReadLine();
        }

        static bool palindrome(string input)
        {
            Regex rgx = new Regex("[^a-zA-Z]");
            input = rgx.Replace(input, "");

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string newCharArray = new string (charArray);

            if (input == newCharArray)
            {
                return true;
            }
            return false;
        }
    } 
}
