// Daily Byte - 16/12/21

/*
This question is asked by Microsoft. Given a string, return the index of its first unique character. If a unique character does not exist, return -1.

Ex: Given the following strings...

"abcabd", return 2
"thedailybyte", return 1
"developer", return 0
*/

using System;

namespace Code_Playground
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "thedailybyte";

            Console.WriteLine(firstUniqueCharacter(input));
            Console.ReadLine();
        }

        static int firstUniqueCharacter(string str)
        {
            // Counts the occurences of a character
            int charCount = 0;

            // Current character in the foreach loop below
            int currentCharIndex = 0;

            foreach (char letter in str)
            {
                for (int otherLetterIndex = 0; otherLetterIndex < str.Length; otherLetterIndex++)
                {
                    if (str[currentCharIndex] == str[otherLetterIndex])
                        charCount++;

                    if (charCount > 1)
                        break;
                }

                // If the number of occurences of a character is = 1 then that's the first unique character
                if (charCount == 1)
                    return currentCharIndex;

                charCount = 0;
                currentCharIndex++;
            }
            return -1;
        }
    }
}