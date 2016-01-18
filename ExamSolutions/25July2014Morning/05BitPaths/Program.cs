using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BitPaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[8, 4];
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    matrix[row, col] = '0';
                }
            }

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(',');
                int commandIndex = 1;
                int col = int.Parse(command[0]);
                for (int row = 0; row < 8; row++)
                {
                    char bit = matrix[row, col];
                    if (bit == '0')
                    {
                        matrix[row, col] = '1';
                    }
                    else
                    {
                        matrix[row, col] = '0';
                    }

                    if (commandIndex >= command.Length)
                    {
                        continue;
                    }
                    if (command[commandIndex] == "+1")
                    {
                        col += 1;
                    }
                    else if (command[commandIndex] == "-1")
                    {
                        col -= 1;
                    }
                    commandIndex++;
                }
            }

            int sum = 0;
            for (int row = 0; row < 8; row++)
            {
                string str = "";
                for (int col = 0; col < 4; col++)
                {
                    str += matrix[row, col];
                }
                sum += Convert.ToInt32(str, 2);
            }

            Console.WriteLine("{0}\n{1}", Convert.ToString(sum, 2), Convert.ToString(sum, 16).ToUpper());
        }
    }
}
