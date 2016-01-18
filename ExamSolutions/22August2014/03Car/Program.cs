using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Car
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 3 * n;
            int roofHeight = (n / 2) + 1;
            int bodyHeight = (n / 2) - 1;
            int wheelHeight = n / 2 - 1;

            PrintRoof(n, width, roofHeight);
            PrintBody(n, width, bodyHeight);
            PrintWheels(n, width, wheelHeight);
        }

        private static void PrintWheels(int n, int width, int height)
        {
            int left1 = n / 2;
            int left2 = n;
            int right1 = n + (n - 1);
            int right2 = right1 + (n / 2);
            for (int i = 0; i < height; i++)
            {
                for (int b = 0; b < width; b++)
                {
                    if (i == height - 1)
                    {
                        if ((b >= left1 && b <= left2) || (b >= right1 && b <= right2))
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
                        if (b == left1 || b == left2 || b == right1 || b == right2)
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
            }
        }

        private static void PrintBody(int n, int widht, int height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int b = 0; b < widht; b++)
                {
                    if (i == height - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (b == 0 || b == widht - 1)
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
            }
        }

        private static void PrintRoof(int n, int width, int height)
        {
            int left = n;
            int right = left + (n - 1);
            for (int i = 0; i < height; i++)
            {
                for (int b = 0; b < width; b++)
                {
                    if (i == 0)
                    {
                        if (b >= left && b <= right)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                    else if (i == height - 1)
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
