using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main(string[] args)
        {
            int n = 0;
            try
            {
                Console.Write("N: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0 || n > int.MaxValue)
                {
                    n = int.Parse("pruc");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Innnnnnnnnvaliddddddddd nnnnnnummmmmberrrrrrrrr!\nN must be > 0 and <= int.MaxValue");
                Environment.Exit(1);
            }

            for (int i = 0; i < n; i++)
            {
                if (i == n - 1)
                {
                    Console.Write(i + 1);
                    continue;
                }

                Console.Write(i + 1 + " ");
            }

            Console.WriteLine();
        }
    }
}
