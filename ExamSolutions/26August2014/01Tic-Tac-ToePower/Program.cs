using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Tic_Tac_ToePower
{
    class Program
    {
        static void Main(string[] args)
        {
            int col = int.Parse(Console.ReadLine());
            int row = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            string[,] matrix = new string[3, 3];

            int index = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int b = 0; b < 3; b++)
                {
                    string str = index.ToString() + " " + num.ToString();
                    matrix[i, b] = str;
                    index++;
                    num++;
                }
            }

            index = int.Parse(matrix[row, col].Split(' ')[0]);
            num = int.Parse(matrix[row, col].Split(' ')[1]);

            Console.WriteLine("{0}", (long)Math.Pow(num, index));
        }
    }
}
