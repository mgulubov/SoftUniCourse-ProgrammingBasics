using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01FitBoxInBox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstBoxDimensions = new int[3];
            int[] secondBoxDimensions = new int[3];
            for (int i = 0; i < 3; i++)
            {
                firstBoxDimensions[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                secondBoxDimensions[i] = int.Parse(Console.ReadLine());
            }

            //Rotate Second Box
            int w1 = firstBoxDimensions[0];
            int h1 = firstBoxDimensions[1];
            int d1 = firstBoxDimensions[2];
            int w2 = secondBoxDimensions[0];
            int h2 = secondBoxDimensions[1];
            int d2 = secondBoxDimensions[2];
            if (CanFit(w1, h2, d1, w2, h2, d2))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                    w1, h1, d1, w2, h2, d2);
            }
            w2 = secondBoxDimensions[0];
            h2 = secondBoxDimensions[2];
            d2 = secondBoxDimensions[1];
            if (CanFit(w1, h2, d1, w2, h2, d2))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                    w1, h1, d1, w2, h2, d2);
            }
            w2 = secondBoxDimensions[1];
            h2 = secondBoxDimensions[0];
            d2 = secondBoxDimensions[2];
            if (CanFit(w1, h1, d1, w2, h2, d2))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                    w1, h1, d1, w2, h2, d2);
            }
            w2 = secondBoxDimensions[1];
            h2 = secondBoxDimensions[2];
            d2 = secondBoxDimensions[0];
            if (CanFit(w1, h1, d1, w2, h2, d2))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                    w1, h1, d1, w2, h2, d2);
            }
            w2 = secondBoxDimensions[2];
            h2 = secondBoxDimensions[0];
            d2 = secondBoxDimensions[1];
            if (CanFit(w1, h1, d1, w2, h2, d2))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                    w1, h1, d1, w2, h2, d2);
            }
            w2 = secondBoxDimensions[2];
            h2 = secondBoxDimensions[1];
            d2 = secondBoxDimensions[0];
            if (CanFit(w1, h1, d1, w2, h2, d2))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                    w1, h1, d1, w2, h2, d2);
            }

            //Rotate First Box
            w1 = secondBoxDimensions[0];
            h1 = secondBoxDimensions[1];
            d1 = secondBoxDimensions[2];
            w2 = firstBoxDimensions[0];
            h2 = firstBoxDimensions[1];
            d2 = firstBoxDimensions[2];
            if (CanFit(w1, h1, d1, w2, h2, d2))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                    w1, h1, d1, w2, h2, d2);
            }
            w2 = firstBoxDimensions[0];
            h2 = firstBoxDimensions[2];
            d2 = firstBoxDimensions[1];
            if (CanFit(w1, h1, d1, w2, h2, d2))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                    w1, h1, d1, w2, h2, d2);
            }
            w2 = firstBoxDimensions[1];
            h2 = firstBoxDimensions[0];
            d2 = firstBoxDimensions[2];
            if (CanFit(w1, h1, d1, w2, h2, d2))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                    w1, h1, d1, w2, h2, d2);
            }
            w2 = firstBoxDimensions[1];
            h2 = firstBoxDimensions[2];
            d2 = firstBoxDimensions[0];
            if (CanFit(w1, h1, d1, w2, h2, d2))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                    w1, h1, d1, w2, h2, d2);
            }
            w2 = firstBoxDimensions[2];
            h2 = firstBoxDimensions[0];
            d2 = firstBoxDimensions[1];
            if (CanFit(w1, h1, d1, w2, h2, d2))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                    w1, h1, d1, w2, h2, d2);
            }
            w2 = firstBoxDimensions[2];
            h2 = firstBoxDimensions[1];
            d2 = firstBoxDimensions[0];
            if (CanFit(w1, h1, d1, w2, h2, d2))
            {
                Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                    w1, h1, d1, w2, h2, d2);
            }
        }

        private static bool CanFit(int w1, int h1, int d1, int w2, int h2, int d2)
        {
            if (w1 < w2 && h1 < h2 && d1 < d2)
            {
                return true;
            }
            return false;
        }
    }
}
