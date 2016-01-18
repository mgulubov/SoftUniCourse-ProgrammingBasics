using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Plane
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = n * 3;

            PrintTop(n, width);
            PrintMiddle(n, width);
            PrintBase(n, width);
        }

        private static void PrintBase(int n, int width)
        {
            int left = n - 1;
            int right = left + (n + 1);
            while (left >= 0)
            {
                for (int i = 0; i < width; i++)
                {
                    if (left == 0 || i == left || i == right)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
                left--;
                right++;
            }
        }

        private static void PrintMiddle(int n, int width)
        {
            int left = n - 1;
            int right = left + (n + 1);
            int leftMidle = left;
            int rightMiddle = right;
            while (left > 1)
            {
                for (int i = 0; i < width; i++)
                {
                    if (i == 0 || i == left || i == leftMidle || i == rightMiddle || i == right || i == width - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
                left -= 2;
                right += 2;
            }
        }

        private static void PrintTop(int n, int width)
        {
            int middleIndex = (int)Math.Floor(width / 2d);
            int left = middleIndex;
            int right = middleIndex;
            int flag = 0;
            while (left > 0)
            {
                if (left == n - 2)
                {
                    flag = 1;
                }
                for (int i = 0; i < width; i++)
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
                Console.WriteLine();
                if (flag == 0)
                {
                    left--;
                    right++;
                }
                else
                {
                    left -= 2;
                    right += 2;
                }
            }
        }
    }
}
