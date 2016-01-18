using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sailHeight = n;
            int width = n * 2;
            int bodyHeight = (n - 1) / 2;

            PrintSail(n, sailHeight, width);
            PrintBody(n, bodyHeight, width);
        }

        private static void PrintBody(int n, int height, int width)
        {
            int startIndex = 0;
            int endIndex = width - 1;
            for (int i = 0; i < height; i++)
            {
                for (int b = 0; b < width; b++)
                {
                    if (b >= startIndex && b <= endIndex)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
                startIndex++;
                endIndex--;
            }
        }

        private static void PrintSail(int n, int height, int width)
        {
            int startIndex = n - 1;
            int endIndex = n - 1;
            int flag = 0;
            for (int i = 0; i < height; i++)
            {
                if (startIndex == 0)
                {
                    flag = 1;
                }
                for (int b = 0; b < width; b++)
                {
                    if (b >= startIndex && b <= endIndex)
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
                    startIndex -= 2;
                }
                else
                {
                    startIndex += 2;
                }
            }
        }
    }
}
