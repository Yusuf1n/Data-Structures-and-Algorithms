using System;

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
