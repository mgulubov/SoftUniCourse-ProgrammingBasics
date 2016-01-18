using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            int n = 0;
            try
            {
                Console.Write("Number: ");
                n = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("ERROR!\nYOU CAUSED AN ERROR AND MUST NOW BE FORCED TO REPAY YOUR MISTAKES!!!!!\n" +
                    "BOW DOWN BEFORE YOUR NEW MASTER!!!!! :p");
                Environment.Exit(1);
            }

            Console.WriteLine(isPrime(n));
        }

        private static Boolean isPrime(int number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }

            if (number == 2 || number == 3)
            {
                return true;
            }

            if (canBeDividedBy(number, 2) || canBeDividedBy(number, 3))
            {
                return false;
            }

            if (number > 5 && canBeDividedBy(number, 5))
            {
                return false;
            }

            int squareRoot = (int)Math.Sqrt(number);
            for (int i = 3; i <= squareRoot; i++)
            {
                if (isPrime(i) && canBeDividedBy(number, i))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool canBeDividedBy(int number, int divisor)
        {
            return number % divisor == 0;
        }
    }
}
