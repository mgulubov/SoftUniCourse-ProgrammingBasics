using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            long n = 0;
            try
            {
                Console.Write("N: ");
                n = long.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("That's not a valid number. JACKASS!!!");
                Environment.Exit(1);
            }

            Console.WriteLine(isPrime(n));
        }

        private static bool isPrime(long n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }

            if (n == 2 || n == 3)
            {
                return true;
            }

            if (canBeDividedBy(n, 2) || canBeDividedBy(n, 3))
            {
                return false;
            }

            if (n > 5 && canBeDividedBy(n, 5))
            {
                return false;
            }

            int squareRoot = (int)Math.Sqrt(n);
            for (int i = 3; i <= squareRoot; i++)
            {
                if (isPrime(i) && canBeDividedBy(n, i))
                {
                    return false;
                }
            }

            return true;
        }

        private static Boolean canBeDividedBy(long number, long divider)
        {
            long result = number % divider;
            if (result == 0)
            {
                return true;
            }

            return false;
        }
    }
}
