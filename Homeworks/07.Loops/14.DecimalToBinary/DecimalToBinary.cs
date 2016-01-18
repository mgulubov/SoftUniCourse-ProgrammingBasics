using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            long num = 0;
            try
            {
                Console.Write("Decimal number: ");
                num = long.Parse(Console.ReadLine());
                if (num < 0)
                {
                    num = int.Parse("Svurshiha mi cigarite :(");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Trqbva da hodq za cigari :(");
                Environment.Exit(1);
            }

            if (num == 0)
            {
                Console.WriteLine(0);
                Environment.Exit(0);
            }

            String result = "";
            while (num > 0)
            {
                long leftOver = num % 2;
                result = leftOver.ToString() + result;
                num = num / 2;
            }

            Console.WriteLine(result);
        }
    }
}
