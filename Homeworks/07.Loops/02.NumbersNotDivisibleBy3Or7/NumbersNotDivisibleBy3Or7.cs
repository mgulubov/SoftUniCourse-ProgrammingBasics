using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumbersNotDivisibleBy3Or7
{
    class NumbersNotDivisibleBy3Or7
    {
        static void Main(string[] args)
        {
            int n = 0;
            try
            {
                Console.Write("N: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    n = int.Parse("KurciException");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The number is WROOOOONG! WROOOONG I TELL YA'!!\nN must be > 0 and <= int.MaxValue");
                Environment.Exit(1);
            }

            for (int i = 0; i < n; i++)
            {
                int num = i + 1;
                if ((num % 3 != 0) && (num % 7 != 0))
                {
                    if (num == n - 1)
                    {
                        Console.Write(num);
                        continue;
                    }
                    Console.Write(num + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
