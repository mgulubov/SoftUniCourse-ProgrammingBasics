using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05PaintBall
{
    class Program
    {
        private static char[,] _matrix;

        static void Main(string[] args)
        {
            //matrix
            _matrix = new char[10, 10];

            //populating with 1s
            for (int i = 0; i < 10; i++)
            {
                for (int b = 0; b < 10; b++)
                {
                    _matrix[i, b] = '1';
                }
            }

            //printMatrix();
            //black = '0'
            //white = '1'
            char flag = '0';
            String command = "";
            while (command != "End")
            {
                command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                String[] commands = command.Split(' ');

                int row = int.Parse(commands[0].ToString());
                int col = 9 - int.Parse(commands[1].ToString());
                int radius = int.Parse(commands[2].ToString());

                //_matrix[row, col] = '0';


                int startRow = row - radius;
                int endRow = row + radius;
                int startCol = col - radius;
                int endCol = col + radius;

                while (startRow < 0)
                {
                    startRow++;
                }
                while (endRow > 9)
                {
                    endRow--;
                }
                while (startCol < 0)
                {
                    startCol++;
                }
                while (endCol > 9)
                {
                    endCol--;
                }

                for (int i = startRow; i <= endRow; i++)
                {
                    for (int b = startCol; b <= endCol; b++)
                    {
                        if (_matrix[i, b] == flag)
                        {
                            continue;
                        }
                        else if (_matrix[i, b] == '1')
                        {
                            _matrix[i, b] = '0';
                            continue;
                        }
                        else
                        {
                            _matrix[i, b] = '1';
                        }
                    }
                }

                if (flag == '0')
                {
                    flag = '1';
                }
                else
                {
                    flag = '0';
                }

                //printMatrix();
            }

            String num = "";
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                num = "";
                for (int b = 0; b < 10; b++)
                {
                    num += _matrix[i, b].ToString();
                }
                int number = Convert.ToInt32(num, 2);
                sum += number;
            }

            Console.WriteLine(sum);


        }

        private static void PrintMatrix()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int b = 0; b < 10; b++)
                {
                    Console.Write(_matrix[i, b].ToString());
                }
                Console.Write("\n");
            }
        }
    }
}
