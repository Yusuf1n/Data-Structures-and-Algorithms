// Daily Byte

/*
This question is asked by Amazon. Given a string representing the sequence of moves a robot vacuum makes, return whether or not it will return to its original position. The string will only contain L, R, U, and D characters, representing left, right, up, and down respectively.

Ex: Given the following strings...

"LR", return true
"URURD", return false
"RUULLDRD", return true
*/

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
            Console.WriteLine(robotVacuum("RUULLDRD"));
            Console.ReadLine();
        }

        static bool robotVacuum(string move)
        {
            int l = move.Length;
            int countUp = 0, countDown = 0, countLeft = 0, countRight = 0;
            
            for (int i = 0; i < l; i++)
            {
                if (move[i] == 'U') countUp++;
                else if (move[i] == 'D') countDown++;
                else if (move[i] == 'L') countLeft++;
                else if (move[i] == 'R') countRight++;
            }

            int upDown = countUp - countDown;
            int leftRight = countRight - countLeft;
            int[] position = { upDown, leftRight };

            Console.WriteLine("Final position is " + position[0] + "," + position[1]);
            if (position[0] == 0 && position[1] == 0)
            {
                return true;
            }
            return false;
        }    
    } 
}
