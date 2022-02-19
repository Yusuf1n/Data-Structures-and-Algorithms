// Daily Byte - 19/02/22

/*
This question is asked by Google. Given two integer arrays, return their intersection.
Note: the intersection is the set of elements that are common to both arrays.

Ex: Given the following arrays...

nums1 = [2, 4, 4, 2], nums2 = [2, 4], return [2, 4]
nums1 = [1, 2, 3, 3], nums2 = [3, 3], return [3]
nums1 = [2, 4, 6, 8], nums2 = [1, 3, 5, 7], return []
*/

using System;

namespace Code_Playground
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 2, 4, 4, 2 };
            int[] nums2 = { 2, 4 };

            intersection(nums1, nums2);
            Console.ReadLine();
        }

        static void intersection(int[] nums1, int[] nums2)
        {
            List<int> commonNums = new List<int>();

            foreach (int num2 in nums2)
            {
                foreach (int num1 in nums1)
                {
                    if (num1 == num2)
                    {
                        commonNums.Add(num2);
                        break;
                    }
                }
            }

            foreach (int num in commonNums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
