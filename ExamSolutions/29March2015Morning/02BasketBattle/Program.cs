using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BasketBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayer = Console.ReadLine();
            int rounds = int.Parse(Console.ReadLine());

            string secondPlayer = "";
            if (firstPlayer == "Simeon")
            {
                secondPlayer = "Nakov";
            }
            else
            {
                secondPlayer = "Simeon";
            }

            int simeonScore = 0;
            int nakovScore = 0;
            for (int round = 0; round < rounds; round++)
            {
                for (int i = 0; i < 2; i++)
                {
                    int points = int.Parse(Console.ReadLine());
                    string success = Console.ReadLine();
                    if (success == "success")
                    {
                        if (i == 0)
                        {
                            if (firstPlayer == "Simeon")
                            {
                                if (points + simeonScore <= 500)
                                {
                                    simeonScore += points;
                                }
                                if (simeonScore == 500)
                                {
                                    Console.WriteLine("Simeon\n{0}\n{1}", (round + 1), nakovScore);
                                    Environment.Exit(0);
                                }
                            }
                            else
                            {
                                if (points + nakovScore <= 500)
                                {
                                    nakovScore += points;
                                }
                                if (nakovScore == 500)
                                {
                                    Console.WriteLine("Nakov\n{0}\n{1}", (round + 1), simeonScore);
                                    Environment.Exit(0);
                                }
                            }
                        }
                        else
                        {
                            if (secondPlayer == "Simeon")
                            {
                                if (points + simeonScore <= 500)
                                {
                                    simeonScore += points;
                                }
                                if (simeonScore == 500)
                                {
                                    Console.WriteLine("Simeon\n{0}\n{1}", (round + 1), nakovScore);
                                    Environment.Exit(0);
                                }
                            }
                            else
                            {
                                if (points + nakovScore <= 500)
                                {
                                    nakovScore += points;
                                }
                                if (nakovScore == 500)
                                {
                                    Console.WriteLine("Nakov\n{0}\n{1}", (round + 1), simeonScore);
                                    Environment.Exit(0);
                                }
                            }
                        }
                    }
                }

                if (simeonScore == 500)
                {
                    Console.WriteLine("Simeon\n{0}\n{1}", (round + 1), nakovScore);
                    Environment.Exit(0);
                }
                else if (nakovScore == 500)
                {
                    Console.WriteLine("Nakov\n{0}\n{1}", (round + 1), simeonScore);
                    Environment.Exit(0);
                }

                if (firstPlayer == "Simeon")
                {
                    firstPlayer = "Nakov";
                    secondPlayer = "Simeon";
                }
                else
                {
                    firstPlayer = "Simeon";
                    secondPlayer = "Nakov";
                }

            }

            if (simeonScore == nakovScore)
            {
                Console.WriteLine("DRAW\n{0}", simeonScore);
                //Environment.Exit(0);
            }
            else
            {
                if (simeonScore > nakovScore)
                {
                    Console.WriteLine("Simeon\n{0}", (simeonScore - nakovScore));
                }
                else
                {
                    Console.WriteLine("Nakov\n{0}", (nakovScore - simeonScore));
                }
            }
        }
    }
}
