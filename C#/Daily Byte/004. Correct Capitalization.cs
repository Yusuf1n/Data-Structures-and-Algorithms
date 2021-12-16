// Daily Byte - 04/11/21

/*
This question is asked by Google. Given a string, return whether or not it uses capitalization correctly. A string correctly uses capitalization if all letters are capitalized, no letters are capitalized, or only the first letter is capitalized.

Ex: Given the following strings...

"USA", return true
"Calvin", return true
"compUter", return false
"coding", return true
*/

using System;

namespace Code_Playground
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(stringCapitalization("compUter"));
            Console.ReadLine();
        }

        static bool stringCapitalization(string input)
        {
            if (input[0] == Char.ToUpper(input[0]) && input.Substring(1) == input.Substring(1).ToLower())
            {
                return true;
            }
            else if (input == input.ToUpper() || input == input.ToLower())
            {
                return true;
            }
            return false;
        }
    }
}
