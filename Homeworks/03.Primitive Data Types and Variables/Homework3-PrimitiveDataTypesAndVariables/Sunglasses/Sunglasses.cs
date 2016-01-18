using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Sunglasses
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
                    printFrame(frameWidth, bridgeWidth, totalWidth);
                    Console.WriteLine();
                    continue;
                }

                if (i == middle)
                {
                    printLenseWithBridge(lenseWidth, bridgeWidth, n);
                    Console.WriteLine();
                    continue;
                }

                printLenseWithoutBridge(lenseWidth, bridgeWidth, n);
                Console.WriteLine();
            }
        }

        private static void printLenseWithBridge(int lenseWidth, int bridgeWidth, int n)
        {
            printLense(n * 2, lenseWidth);
            printBridge(bridgeWidth);
            printLense(n * 2, lenseWidth);
        }

        private static void printBridge(int bridgeWidth)
        {
            for (int i = 0; i < bridgeWidth; i++)
            {
                Console.Write("|");
            }
        }

        private static void printLenseWithoutBridge(int lenseWidth, int bridgeWidth, int n)
        {
                printLense(n * 2, lenseWidth);
                printGap(bridgeWidth);
                printLense(n * 2, lenseWidth);
        }

        private static void printGap(int bridgeWidth)
        {
            for (int i = 0; i < bridgeWidth; i++)
            {
                Console.Write(" ");
            }
        }

        private static void printLense(int frameWidth, int lensiWidth)
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

        private static void printFrame(int frameWidth)
        {
            for (int i = 0; i < frameWidth; i++)
            {
                Console.Write("*");
            }
        }

        private static void printFrame(int frameWidth, int bridgeWidth, int totalWidth)
        {
            printFrame(frameWidth);
            printGap(bridgeWidth);
            printFrame(frameWidth);
        }
    }
}
