using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int score = 0;
            try
            {
                Console.Write("Score: ");
                score = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("NOOOOOOOOOOO\nYou broke my program :(");
                Environment.Exit(1);
            }

            if (score <= 0 || score > 9)
            {
                Console.WriteLine("Invalid score");
            }
            else if (score >= 1 && score <= 3)
            {
                score *= 10;
                printResultAndExit(score);
            }
            else if (score >= 4 && score <= 6)
            {
                score *= 100;
                printResultAndExit(score);
            }
            else if (score >= 7 && score <= 9)
            {
                score *= 1000;
                printResultAndExit(score);
            }
        }

        private static void printResultAndExit(int score)
        {
            Console.WriteLine(score);
            Environment.Exit(0);
        }
    }
}
