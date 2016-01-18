using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = 0;
            try
            {
                Console.Write("\"Oh, great Fibonacci! We pray to you to give us understanding over recursion, but all you do is ask for another prayer.\n" +
                    "How can we understand recursion, great Fibonacci, if we first don't understand recursion?!\n" +
                    "We again pray to you and ask you to bless us with your wisdom!\n" +
                    "We offer this sequence as a tribute!\"\n\n" +
                    "How long of a sequence, shel we give to the great Fibonacci this time: ");
                n = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("If you keep giving invalid integers, the great Fibonacci will get pissed and we will never understand recursion!");
                Environment.Exit(1);
            }

            for (int counter = 0; counter < n; counter++)
            {
                Console.WriteLine(Fibonacci(counter));
            }
        }

        private static int Fibonacci(int number)
        {

            if (number == 0)
                return 0;
            else if (number == 1)
                return 1;
            else
            {
                return Fibonacci(number - 2) + Fibonacci(number - 1);
            }

        }
    }
}
