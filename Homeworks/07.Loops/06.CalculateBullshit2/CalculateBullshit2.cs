using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06.CalculateBullshit2
{
    class CalculateBullshit2
    {
        static void Main(string[] args)
        {
            int n = 0, k = 0;
            try
            {
                Console.Write("n: ");
                n = int.Parse(Console.ReadLine());
                Console.Write("k: ");
                k = int.Parse(Console.ReadLine());

                if (k >= n || n >= 100)
                {
                    n = int.Parse("dris");
                }
                if (k <= 1 || n <= 1)
                {
                    n = int.Parse("More dris");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("This shit is pointless enough, without you trying to break my program!\nFUCK OFF!");
                Environment.Exit(1);
            }

            BigInteger nFactorial = 1;
            BigInteger kFactorial = 1;
            for (int i = 0; i < n; i++)
            {
                int radix = i + 1;
                if (i >= k)
                {
                    nFactorial = radix * nFactorial;
                }
                else
                {
                    nFactorial = radix * nFactorial;
                    kFactorial = radix * kFactorial;
                }
            }

            BigInteger result = nFactorial / kFactorial;

            Console.WriteLine(result);
        }
    }
}
