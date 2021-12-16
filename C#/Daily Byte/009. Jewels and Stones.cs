// Daily Byte - 12/11/21

/*
This question is asked by Amazon. Given a string representing your stones and another string representing a list of jewels, return the number of stones that you have that are also jewels.

Ex: Given the following jewels and stones...

jewels = "abc", stones = "ac", return 2
jewels = "Af", stones = "AaaddfFf", return 3
jewels = "AYOPD", stones = "ayopd", return 0
*/

using System;

namespace Code_Playground
{
    public class Program
    {
        static void Main(string[] args)
        {
            string jewels = "abc";
            string stones = "ac";

            Console.WriteLine(jewelsAndStones(jewels, stones));
            Console.ReadLine();
        }

        static int jewelsAndStones(string inputJ, string inputS)
        {
            int count = 0;

            for (int i = 0; i < inputJ.Length; i++)
            {
                char letterJ = inputJ[i];

                for (int k = 0; k < inputS.Length; k++)
                {
                    char letterS = inputS[k];

                    if (letterJ == letterS)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
