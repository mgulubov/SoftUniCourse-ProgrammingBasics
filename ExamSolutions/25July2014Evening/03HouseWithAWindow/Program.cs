using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03HouseWithAWindow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n - 1;
            int roofHeight = n;
            int baseHeight = n + 2;
            int windowHeight = n / 2;

            PrintRoof(n, width, roofHeight);
            PrintBase(n, width, baseHeight, windowHeight);
        }

        private static void PrintBase(int n, int width, int height, int windowHeight)
        {
            int windowLeft = (n / 2) + 1;
            int windowRight = (windowLeft + (n - 3)) - 1;
            int flag = 0;
            int count = 0;
            for (int i = 0; i < height; i++)
            {
                if (i == 0 || i == height - 1)
                {
                    for (int b = 0; b < width; b++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    continue;
                }

                if (((i - 1) * 2) == windowHeight)
                {
                    flag = 1;
                }
                if (count == windowHeight)
                {
                    flag = 0;
                }

                for (int b = 0; b < width; b++)
                {
                    if (flag == 1)
                    {
                        if (b == 0 || b == width - 1)
                        {
                            Console.Write("*");
                            continue;
                        }
                        if (b >= windowLeft && b <= windowRight)
                        {
                            Console.Write("*");
                            continue;
                        }
                        Console.Write(".");
                    }
                    else
                    {
                        if (b == 0 || b == width - 1)
                        {
                            Console.Write("*");
                            continue;
                        }
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
                if (flag == 1)
                {
                    count++;
                }
            }
        }

        private static void PrintRoof(int n, int width, int height)
        {
            int leftIndex = n - 1;
            int rightIndex = n - 1;
            for (int i = 0; i < height; i++)
            {
                for (int b = 0; b < width; b++)
                {
                    if (b == leftIndex || b == rightIndex)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
                leftIndex--;
                rightIndex++;
            }
        }
    }
}
