using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Dumbbell
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int height = n;
            int width = n * 3;

            int dumpTop = ((n + 1) / 2);

            PrintTop(n, width, (int)Math.Floor(n / 2f));
            PrintMiddle(n, width, (int)Math.Floor(n / 2f) + 1);
        }

        private static void PrintMiddle(int n, int width, int height)
        {
            int dumpTopWidth = ((n + 1) / 2);
            int leftStart = 0;
            int leftEnd = n - 1;
            int rightStart = (leftEnd + n) + 1;
            int rightEnd = width - 1;
            for (int i = 0; i < height; i++)
            {
                for (int b = 0; b < width; b++)
                {
                    if (i == 0)
                    {
                        if (b == leftStart || b == leftEnd || b == rightStart || b == rightEnd)
                        {
                            Console.Write("&");
                        }
                        else if ((b > leftStart && b < leftEnd) || (b > rightStart && b < rightEnd))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("=");
                        }
                    }
                    else if (i == height - 1)
                    {
                        if ((b >= leftStart && b <= leftEnd) || (b >= rightStart && b <= rightEnd))
                        {
                            Console.Write("&");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                    else
                    {
                        if (b == leftStart || b == leftEnd || b == rightStart || b == rightEnd)
                        {
                            Console.Write("&");
                        }
                        else if ((b > leftStart && b < leftEnd) || (b > rightStart && b < rightEnd))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                }
                Console.WriteLine();
                leftStart++;
                rightEnd--;
            }
        }

        private static void PrintTop(int n, int width, int height)
        {
            int dumpTopWidth = ((n + 1) / 2);
            int leftEnd = n - 1;
            int leftStart = n - dumpTopWidth;
            int rightStart = (leftEnd + n) + 1;
            int rightEnd = (rightStart + dumpTopWidth) - 1;
            for (int i = 0; i < height; i++)
            {
                for (int b = 0; b < width; b++)
                {
                    if (i == 0 || i == width - 1)
                    {
                        if ((b >= leftStart && b <= leftEnd) || (b >= rightStart && b <= rightEnd))
                        {
                            Console.Write("&");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                    else
                    {
                        if (b == leftStart || b == leftEnd || b == rightStart || b == rightEnd)
                        {
                            Console.Write("&");
                        }
                        else if ((b > leftStart && b < leftEnd) || (b > rightStart && b < rightEnd))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                }
                Console.WriteLine();
                leftStart--;
                rightEnd++;
            }
        }
    }
}
