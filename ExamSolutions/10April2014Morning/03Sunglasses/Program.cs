using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int height = n;
            int frameWidth = n * 2;
            int lenseWidth = frameWidth - 2;
            int bridgeWidth = n;
            int middle = height / 2;
            int totalWidth = bridgeWidth + (frameWidth * 2);
     
            for (int i = 0; i < height; i++) 
            {
                if (i == 0 || i == height - 1)
                {
                    PrintFrame(frameWidth, bridgeWidth, totalWidth);
                    Console.WriteLine();
                    continue;
                }

                if (i == middle)
                {
                    PrintLenseWithBridge(lenseWidth, bridgeWidth, n);
                    Console.WriteLine();
                    continue;
                }

                PrintLenseWithoutBridge(lenseWidth, bridgeWidth, n);
                Console.WriteLine();
            }
        }

        private static void PrintLenseWithBridge(int lenseWidth, int bridgeWidth, int n)
        {
            PrintLense(n * 2, lenseWidth);
            PrintBridge(bridgeWidth);
            PrintLense(n * 2, lenseWidth);
        }

        private static void PrintBridge(int bridgeWidth)
        {
            for (int i = 0; i < bridgeWidth; i++)
            {
                Console.Write("|");
            }
        }

        private static void PrintLenseWithoutBridge(int lenseWidth, int bridgeWidth, int n)
        {
                PrintLense(n * 2, lenseWidth);
                PrintGap(bridgeWidth);
                PrintLense(n * 2, lenseWidth);
        }

        private static void PrintGap(int bridgeWidth)
        {
            for (int i = 0; i < bridgeWidth; i++)
            {
                Console.Write(" ");
            }
        }

        private static void PrintLense(int frameWidth, int lensiWidth)
        {
            int startIndex = 0;
            int endIndex = frameWidth;
            for (int i = 0; i < frameWidth; i++)
            {
                if (i == startIndex || i == endIndex - 1)
                {
                    Console.Write("*");
                    continue;
                }
                Console.Write("/");
            }
        }

        private static void PrintFrame(int frameWidth)
        {
            for (int i = 0; i < frameWidth; i++)
            {
                Console.Write("*");
            }
        }

        private static void PrintFrame(int frameWidth, int bridgeWidth, int totalWidth)
        {
            PrintFrame(frameWidth);
            PrintGap(bridgeWidth);
            PrintFrame(frameWidth);
        }
    }
}
