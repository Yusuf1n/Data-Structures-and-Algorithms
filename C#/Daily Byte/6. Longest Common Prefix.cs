// Daily Byte - 04/11/21

/*
This question is asked by Microsoft. Given an array of strings, return the longest common prefix that is shared amongst all strings.
Note: you may assume all strings only contain lowercase alphabetical characters.

Ex: Given the following arrays...

["colorado", "color", "cold"], return "col"
["a", "b", "c"], return ""
["spot", "spotty", "spotted"], return "spot"
*/

using System;

namespace Code_Playground
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = { "colorado", "color", "cold" };

            Console.WriteLine("The longest common prefix is: " + longestCommonPrefix(strArr));
            Console.ReadLine();
        }

        static string longestCommonPrefix(String[] input)
        {
            if (input.Length == 0) return "";

            if (input.Length == 1) return input[0];

            Array.Sort(input);

            int lastInput = input.Length - 1;
            int lastInputLength = input[lastInput].Length;

            // Find the minimum length from the first and last string in the array
            int strMinLength = Math.Min(input[0].Length, lastInputLength);

            // Find the common prefix between the first and last string in the array
            int i = 0;
            while (i < strMinLength && input[0][i] == input[lastInput][i]) i++;

            string prefix = input[0].Substring(0, i);
            return prefix;
        }
    }
}