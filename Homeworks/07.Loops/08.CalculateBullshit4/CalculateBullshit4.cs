using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08.CalculateBullshit4
{
    class CalculateBullshit4
    {
        static void Main(string[] args)
        {
            //Seriously?! Catalan numbers?! Fuckin' 'ell!
            //And what the fuck is this is this SHYTE- we have "1 < n < 100" in the problem condition 
            //However, we then have n = 0 in the first example! FUCK LOGIC!!!
            //Let's get this SHYTE over with
            //We first take the SHYTE from the console
            int n = 0;
            try
            {
                Console.Write("N: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0 || n >= 100)
                {
                    n = int.Parse("KUR!!");
                }
            }
            catch (Exception e) //We then handle the Exception SHYTE
            {
                Console.WriteLine("I'm really not in the mood for this SHYTE\nN HAS TO BE >= 0 AND <= int.MaxValue");
                Environment.Exit(1);
            }

            //We hardcode the 'zero' SHYTE
            if (n == 0)
            {
                Console.WriteLine("1");
                Environment.Exit(0);
            }

            //Same logic as before
            //We declare the SHYTE
            int x = 2 * n;
            int y = 1 + n;

            BigInteger xFactorial = 1;
            BigInteger yFactorial = 1;
            BigInteger nFactorial = 1;

            //We calculate the factorial SHYTE
            for (int i = 0; i < x; i++)
            {
                int radix = i + 1;
                if ((i >= n) && (i >= y))
                {
                    xFactorial = radix * xFactorial;
                    continue;
                }
                else if (i >= n)
                {
                    xFactorial = radix * xFactorial;
                    yFactorial = radix * yFactorial;
                    continue;
                }
                else if (i >= y)
                {
                    xFactorial = radix * xFactorial;
                    nFactorial = radix * nFactorial;
                    continue;
                }
                else
                {
                    xFactorial = radix * xFactorial;
                    yFactorial = radix * yFactorial;
                    nFactorial = radix * nFactorial;
                }
            }

            //We now calculate the Catalan SHYTE
            BigInteger result = xFactorial / (yFactorial * nFactorial);

            //And we now print the Catalan SHYTE
            Console.WriteLine(result);
        }
    }
}
