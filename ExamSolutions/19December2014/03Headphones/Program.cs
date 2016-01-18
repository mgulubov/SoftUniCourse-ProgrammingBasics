using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Headphones
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int middleIndex = n;
            int width = 1 + (n * 2);
            int radius = n / 2;
            int topHeight = n;
            int lowHeight = n;

            PrintTop(n, width, radius);
            PrintLow(n, width, radius);
        }

        private static void PrintLow(int n, int width, int radius)
        {
            int leftStart = radius;
            int leftEnd = radius;
            int rightStart = 1 + (radius + n);
            int rightEnd = 1 + (radius + n);
            int flag = 0;
            for (int i = 0; i < n; i++)
            {
                if (leftStart == 0)
                {
                    flag = 1;
                }
                for (int b = 0; b < width; b++)
                {
                    if ((b >= leftStart && b <= leftEnd) || (b >= rightStart && b <= rightEnd))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
                if (flag == 0)
                {
                    leftStart--;
                    leftEnd++;
                    rightStart--;
                    rightEnd++;
                }
                else
                {
                    leftStart++;
                    leftEnd--;
                    rightStart++;
                    rightEnd--;
                }
            }
        }

        private static void PrintTop(int n, int width, int radius)
        {
            int middleIndex = n;
            int startIndex = radius;
            int endIndex = 1 + (radius + n);
            for (int i = 0; i < n; i++)
            {
                for (int b = 0; b < width; b++)
                {
                    if (i == 0)
                    {
                        if (b >= startIndex && b <= endIndex)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("-");
                        }
                    }
                    else
                    {
                        if (b == startIndex || b == endIndex)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("-");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
