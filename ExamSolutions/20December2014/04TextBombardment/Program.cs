using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04TextBombardment
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = Console.ReadLine();
            int width = int.Parse(Console.ReadLine());
            String[] bombs = Console.ReadLine().Split(' ');

            int height = text.Length / width;
            if (text.Length % width != 0)
            {
                height++;
            }

            char[,] matrix = new char[height, width];
            int index = 0;
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    try
                    {
                        matrix[row, col] = text[index];
                        index++;
                    }
                    catch (Exception)
                    {
                        matrix[row, col] = ' ';
                    }
                }
            }

            for (int i = 0; i < bombs.Length; i++)
            {
                int bomb = int.Parse(bombs[i]);
                for (int row = 0; row < height; row++)
                {
                    if (matrix[row, bomb] == ' ')
                    {
                        continue;
                    }

                    matrix[row, bomb] = ' ';
                    if (row < height - 1)
                    {
                        if (matrix[row + 1, bomb] == ' ')
                        {
                            break;
                        }
                    }
                }
            }

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    Console.Write(matrix[row, col]);
                }
            }
            Console.WriteLine();
        }
    }
}
