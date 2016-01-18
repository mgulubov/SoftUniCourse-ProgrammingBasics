using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.CalculateBullshit3
{
    class CalculateBullshit3
    {
        static void Main(string[] args)
        {
            int n = 0, k = 0;
            try
            {
                Console.Write("N: ");
                n = int.Parse(Console.ReadLine());
                Console.Write("K: ");
                k = int.Parse(Console.ReadLine());

                if (n <= k || n >= 100)
                {
                    n = int.Parse("coffee");
                }
                if (n <= 1 || k <= 1)
                {
                    n = int.Parse("MORE COFFEE");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Seems like you need a cup'a Joe, because you SUCK!");
                Environment.Exit(1);
            }

            int x = n - k;
            BigInteger nFactorial = 1;
            BigInteger kFactorial = 1;
            BigInteger xFactorial = 1;
            //We use the same logic as in CalculateBullshit2
            for (int i = 0; i < n; i++)
            {
                int radix = i + 1;

                if (i >= k && i >= x)
                {
                    nFactorial = radix * nFactorial;
                    continue;
                }
                else if (i >= k)
                {
                    nFactorial = radix * nFactorial;
                    xFactorial = radix * xFactorial;
                    continue;
                }
                else if (i >= x)
                {
                    nFactorial = radix * nFactorial;
                    kFactorial = radix * kFactorial;
                    continue;
                }
                else
                {
                    nFactorial = radix * nFactorial;
                    kFactorial = radix * kFactorial;
                    xFactorial = radix * xFactorial;
                }
            }

            //Final bullshit calculation
            BigInteger result = nFactorial / (kFactorial * xFactorial);

            Console.WriteLine(result);
        }
    }
}
