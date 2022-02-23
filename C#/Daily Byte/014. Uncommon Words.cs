// Daily Byte - 21/02/22

/*
This question is asked by Amazon. Given two strings representing sentences, return the words that are not common to both strings (i.e. the words that only appear in one of the sentences). You may assume that each sentence is a sequence of words (without punctuation) correctly separated using space characters.

Ex: given the following strings...

sentence1 = "the quick", sentence2 = "brown fox", return ["the", "quick", "brown", "fox"]
sentence1 = "the tortoise beat the haire", sentence2 = "the tortoise lost to the haire", return ["beat", "to", "lost"]
sentence1 = "copper coffee pot", sentence2 = "hot coffee pot", return ["copper", "hot"]
*/

using System;

namespace Code_Playground
{
    public class Program
    {
        static void Main(string[] args)
        {

            string sentence1 = "copper coffee pot";
            string sentence2 = "hot coffee pot";

            uncommonWords(sentence1, sentence2);
            Console.ReadLine();
        }

        static void uncommonWords(string sentence1, string sentence2)
        {
            string[] sentence1Arr = sentence1.Split(' ');
            string[] sentence2Arr = sentence2.Split(' ');

            List<string> uncommonWordsList = new List<string>();

            foreach (string word1 in sentence1Arr)
            {
                foreach (string word2 in sentence2Arr)
                {
                    if (word1.Equals(word2))
                    {
                        break;
                    }

                    int word2Index = Array.IndexOf(sentence2Arr, word2);

                    if (word2Index == sentence2Arr.Length - 1)
                    {
                        run();
                    }
                }

                void run()
                {
                    uncommonWordsList.Add(word1);
                }
            }

            foreach (string word2 in sentence2Arr)
            {
                foreach (string word1 in sentence1Arr)
                {
                    if (word2.Equals(word1))
                    {
                        break;
                    }

                    int word1Index = Array.IndexOf(sentence1Arr, word1);

                    if (word1Index == sentence1Arr.Length - 1)
                    {
                        run();
                    }
                }

                void run()
                {
                    uncommonWordsList.Add(word2);
                }
            }

            foreach (string word in uncommonWordsList)
            {
                Console.WriteLine(word);
            }
        }
    }
}