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
            Console.WriteLine(reverseString("Hello Yusuf"));
            Console.ReadLine();
        }

        static string reverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string (charArray);
        }
    }
}
