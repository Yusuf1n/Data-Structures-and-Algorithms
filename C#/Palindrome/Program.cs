using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
