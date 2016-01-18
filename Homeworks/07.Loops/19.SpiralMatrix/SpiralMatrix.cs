using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.SpiralMatrix
{
    class SpiralMatrix
    {
        private static int[,] _matrix;

        static void Main(string[] args)
        {
            int n = 0;
            try
            {
                Console.Write("N: ");
                n = int.Parse(Console.ReadLine());
                if (n < 1 || n > 20)
                {
                    n = int.Parse("Kareem Abdul-Jabbar has 38387 career points, which is an NBA record");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("John Stockton has 15806 career assists and 3265 career steals. Both are NBA records");
                Environment.Exit(1);
            }

            _matrix = new int[n, n];

            int num = 1;
            int startCol = 0;
            int endCol = n - 1;
            int startRow = 0;
            int endRow = n - 1;
            while (num <= (n * n))
            {
                num = goRight(startRow, startCol, endCol, num);
                startRow++;
                num = goDown(endCol, startRow, endRow, num);
                endCol--;
                num = goLeft(endRow, endCol, startCol, num);
                endRow--;
                num = goUp(startCol, endRow, startRow, num);
                startCol++;
            }

            printMatrix(n);

            //Oh, I'm so fuckin' good :P :D
        }

        private static void printMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int b = 0; b < n; b++)
                {
                    Console.Write(_matrix[i, b]);
                    if (b < n - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static int goUp(int startCol, int endRow, int startRow, int num)
        {
            for (int row = endRow; row >= startRow; row--)
            {
                _matrix[row, startCol] = num;
                num++;
            }

            return num;
        }

        private static int goLeft(int endRow, int endCol, int startCol, int num)
        {
            for (int col = endCol; col >= startCol; col--)
            {
                _matrix[endRow, col] = num;
                num++;
            }

            return num;
        }

        private static int goDown(int endCol, int startRow, int endRow, int num)
        {
            for (int row = startRow; row <= endRow; row++)
            {
                _matrix[row, endCol] = num;
                num++;
            }

            return num;
        }

        private static int goRight(int startRow, int startCol, int endCol, int num)
        {
            for (int col = startCol; col <= endCol; col++)
            {
                _matrix[startRow, col] = num;
                num++;
            }

            return num;
        }
    }
}
