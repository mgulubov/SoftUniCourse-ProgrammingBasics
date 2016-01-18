using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03RockLq
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 3 * n;

            PrintTop(n, width);
            PrintMiddle(n, width);
            PrintBottom(n, width);
        }

        private static void PrintBottom(int n, int width)
        {
            int left = n - 1;
            int right = (left + n) + 1;
            while (left >= 0)
            {
                for (int i = 0; i < width; i++)
                {
                    if (left == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (i == left || i == right)
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

        private static void PrintMiddle(int n, int widht)
        {
            int leftStart = n - 1;
            int leftEnd = n - 1;
            int rightStart = (leftStart + n) + 1;
            int rightEnd = (leftStart + n) + 1;
            while (leftStart > 1)
            {
                for (int i = 0; i < widht; i++)
                {
                    if (i == 0 || i == widht - 1 || i == leftStart || i == leftEnd || i == rightStart || i == rightEnd)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
                leftStart -= 2;
                rightEnd += 2;
            }
        }

        private static void PrintTop(int n, int width)
        {
            int left = n;
            int right = (left + n) - 1;
            int flag = 0;
            while (left > 0)
            {
                for (int i = 0; i < width; i++)
                {
                    if (flag == 0)
                    {
                        if (i >= left && i <= right)
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
                        if (i == left || i == right)
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
                left -= 2;
                right += 2;
                if (flag == 0)
                {
                    flag = 1;
                }
            }
        }
    }
}
