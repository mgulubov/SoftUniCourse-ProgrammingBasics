using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = 0;
            try
            {
                Console.WriteLine("N: ");
                n = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Pruc");
                Environment.Exit(1);
            }

            Console.WriteLine(fib(n));
        }

        private static int fib(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            return fib(n - 1) + fib(n - 2);
        }
    }
}
