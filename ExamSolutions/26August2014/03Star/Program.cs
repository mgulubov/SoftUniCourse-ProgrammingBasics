using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Star
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n + 1;
            int topHeight = (n / 2) + 1;
            int middleHeight = (n / 2) - 1;
            int legsHeight = n / 2 + 1;

            PrintTop(n, width, topHeight);
            PrintMiddle(n, width, middleHeight);
            PrintBase(n, width, legsHeight);
        }

        private static void PrintBase(int n, int width, int height)
        {
            int leftStart = n / 2;
            int leftEnd = n;
            int rightStart = n;
            int rightEnd = (width - 1) - (n / 2);
            for (int i = 0; i < height; i++)
            {
                for (int b = 0; b < width; b++)
                {
                    if (i == height - 1)
                    {
                        if ((b >= 0 && b <= leftEnd) || (b >= rightStart && b <= width - 1))
                        {
                            Console.Write("*");
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
                leftEnd--;
                rightStart++;
                rightEnd++;
            }
        }

        private static void PrintMiddle(int n, int widht, int height)
        {
            int left = 1;
            int right = widht - 2;
            for (int i = 0; i < height; i++)
            {
                for (int b = 0; b < widht; b++)
                {
                    if (b == left || b == right)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
                left++;
                right--;
            }
        }

        private static void PrintTop(int n, int width, int height)
        {
            int left = n;
            int right = n;
            for (int i = 0; i < height; i++)
            {
                for (int b = 0; b < width; b++)
                {
                    if (i == height - 1)
                    {
                        if ((b >= 0 && b <= left) || (b >= right && b <= width - 1))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                    else
                    {
                        if (b == left || b == right)
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
                left--;
                right++;
            }
        }
    }
}
