// Daily Byte - 11/11/21

/*
This question is asked by Google. Given an array of integers, return whether or not two numbers sum to a given target, k.
Note: you may not sum a number with itself.

Ex: Given the following...

[1, 3, 8, 2], k = 10, return true (8 + 2)
[3, 9, 13, 7], k = 8, return false
[4, 2, 6, 5, 2], k = 4, return true (2 + 2)
*/

using System;

namespace Code_Playground
{
    public class Program
    {
        static int k = 4;
        static int[] intArr = { 4, 2, 6, 5, 2 };

        static void Main(string[] args)
        {
            Console.WriteLine(twoSum(Program.intArr));
            Console.ReadLine();
        }

        static bool twoSum(int[] input)
        {
            if (input.Length == 1)
            {
                return false;
            }
            else
            {
                foreach (int num in input)
                {
                    foreach (int otherNum in input)
                    {
                        int numIndex = Array.IndexOf(input, num);
                        int otherNumIndex = Array.LastIndexOf(input, otherNum);

                        if (numIndex == otherNumIndex)
                        {
                            continue;
                        }
                        int result = num + otherNum;
                        if (result == Program.k)
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
