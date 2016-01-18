using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.CalculateGCD
{
    class CalculateGCD
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            try
            {
                Console.Write("First Number: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Second Number: ");
                b = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("I HAS CIGAREEEEETTS! I HAS COFFEEEEEE! I CAN SEE THE CODE AGAIN!!!!! I HAPPPPYYYYYYY!!!!");
                Console.WriteLine("God bless di.fm!!!!!");
                Environment.Exit(1);
            }

            int biggerNum = a;
            if (a < b)
            {
                biggerNum = b;
            }

            int gcd = 0;
            for (int i = 0; i < biggerNum; i++)
            {
                int divisor = i + 1;
                if ((a % divisor == 0) && (b % divisor == 0))
                {
                    if (divisor > gcd)
                    {
                        gcd = divisor;
                    }
                }
            }

            Console.WriteLine(gcd);
        }
    }
}
