// Daily Byte - 12/11/21

/*
This question is asked by Facebook. Given two strings s and t return whether or not s is an anagram of t.
Note: An anagram is a word formed by reordering the letters of another word.

Ex: Given the following strings...

s = "cat", t = "tac", return true
s = "listen", t = "silent", return true
s = "program", t = "function", return false
*/

using System;

namespace Code_Playground
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = "cat";
            string t = "tac";

            Console.WriteLine(validAnagram(s, t));
            Console.ReadLine();
        }

        static bool validAnagram(string inputS, string inputT)
        {
            int count = 0;
            for (int i = 0; i < inputS.Length; i++)
            {
                char letterS = inputS[i];
                char letterT = '\0';

                for (int j = 0; j < inputT.Length; j++)
                {
                    letterT = inputT[j];
                    if (letterS == letterT)
                    {
                        count++;
                        if (count == inputS.Length)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
