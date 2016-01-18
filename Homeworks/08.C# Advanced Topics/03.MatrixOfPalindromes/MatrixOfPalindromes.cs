using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main()
        {
            int rows = 0;
            int cols = 0;
            try
            {
                Console.Write("Rows: ");
                rows = int.Parse(Console.ReadLine());
                Console.Write("Cols: ");
                cols = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid value specified. DON'T.. FUCK WITH ME! I'M EXTREMELY FRAGILE, RIGHT NOW");
                Environment.Exit(1);
            }

            string[,] matrix = new string[rows, cols];

            int firstLetter = 65;
            int lastLetter = 65 + 25;
            char startEndChar = '\0';
            char middleChar = '\0';
            int count = 0;
            for (int row = 0; row < rows; row++)
            {
                if (firstLetter > lastLetter)
                {
                    firstLetter = 65;
                }

                startEndChar = (char)firstLetter;
                count = firstLetter;
                for (int col = 0; col < cols; col++)
                {
                    if (count > lastLetter)
                    {
                        count = firstLetter;
                    }

                    middleChar = (char)count;

                    String input = char.ToLower(startEndChar).ToString() + char.ToLower(middleChar).ToString() + char.ToLower(startEndChar).ToString();

                    matrix[row, col] = input;

                    count++;
                }

                firstLetter++;
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                    if (col != cols - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
