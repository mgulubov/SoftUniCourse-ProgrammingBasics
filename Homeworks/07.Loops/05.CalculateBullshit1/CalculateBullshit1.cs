using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateBullshit1
{
    class CalculateBullshit1
    {
        static void Main(string[] args)
        {
            int n = 0, x = 0;
            try
            {
                Console.Write("n: ");
                n = int.Parse(Console.ReadLine());
                Console.Write("x: ");
                x = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    n = -(n);
                }

                if (n == 0)
                {
                    n = 1;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OI - only valid int numbers, mate! Don't screw around! You screw around too much!");
                Environment.Exit(1);
            }

            decimal result = 1m;
            decimal factorial = 1m;
            for (int i = 0; i < n; i++)
            {
                int radix = i + 1;
                factorial = radix * factorial;
                decimal xToThePowerOfRadix = (decimal)Math.Pow(x, radix);
                decimal divide = factorial / xToThePowerOfRadix;

                result += divide;
            }

            Console.WriteLine("{0:F5}", result);
        }
    }
}
