using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03House
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int houseHeight = n;
            int houseWidth = n;
            int center = (n + 1) / 2;
            int roofHeight = center;
            int roofWallsDistance = n / 4;
            int wallsHeight = n - roofHeight;

            PrintRoof(n, center, roofHeight);
            PrintWalls(n, roofWallsDistance, wallsHeight);
        }

        private static void PrintWalls(int n, int roofWallsDistance, int wallsHeight)
        {
            int startIndex = roofWallsDistance + 1;
            int endIndex = n - roofWallsDistance;

            for (int i = 0; i < wallsHeight; i++)
            {
                if (i == wallsHeight - 1)
                {
                    for (int b = 1; b <= n; b++)
                    {
                        if (b >= startIndex && b <= endIndex)
                        {
                            Console.Write("*");
                            continue;
                        }
                        Console.Write(".");
                    }
                    Console.Write("\n");
                    break;
                }

                for (int b = 1; b <= n; b++)
                {
                    if (b == startIndex || b == endIndex)
                    {
                        Console.Write("*");
                        continue;
                    }
                    Console.Write(".");
                }

                Console.Write("\n");
            }
        }

        private static void PrintRoof(int n, int center, int roofHeight)
        {
            int startIndex = center;
            int endIndex = center;

            for (int i = 0; i < roofHeight; i++)
            {
                if (i == roofHeight - 1)
                {
                    for (int b = 0; b < n; b++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                    break;
                }
                for (int b = 1; b <= n; b++)
                {
                    if (b == startIndex || b == endIndex)
                    {
                        Console.Write("*");
                        continue;
                    }
                    Console.Write(".");
                }
                Console.Write("\n");

                startIndex--;
                endIndex++;
            }
        }
    }
}
