using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _18.TrailingZeroesInNFactorial
{
    class TrailingZeroesInNFactorial
    {
        static void Main(string[] args)
        {
            int n = 0;
            try
            {
                Console.Write("N: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    n = int.Parse("ThinkPad kicks ASS");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Program failed. Input == Stupid. You failed program with stupid input. You SUCK!");
                Environment.Exit(1);
            }

            BigInteger factorial = 1;
            for (int i = 0; i < n; i++)
            {
                int radix = i + 1;
                factorial = radix * factorial;
            }

            String str = factorial.ToString();
            int count = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                byte digit = byte.Parse(str[i].ToString());
                if (digit == 0)
                {
                    count++;
                    continue;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(count);
            //10000! has 24999 trailing zeroes, because there are 24999 trailing zeroes in 10000! :p
            //You never saw that coming did 'ya :D
        }
    }
}
