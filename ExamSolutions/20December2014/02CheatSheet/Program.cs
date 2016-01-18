using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02CheatSheet
{
    class Program
    {
        static void Main()
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            long vStartNum = long.Parse(Console.ReadLine());
            long hStartNum = long.Parse(Console.ReadLine());

            for (int row = 0; row < r; row++)
            {
                long multiplier = vStartNum;
                long num = hStartNum;
                for (int col = 0; col < c; col++)
                {
                    Console.Write(num * multiplier);
                    if (col < c - 1)
                    {
                        Console.Write(" ");
                    }
                    num++;
                }
                Console.WriteLine();
                vStartNum++;
            }
        }
    }
}
