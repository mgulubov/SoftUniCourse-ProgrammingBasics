using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.EchangeIfGreater
{
    class EchangeIfGreater
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;

            Console.Write("First number(a): ");
            try
            {
                a = double.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Please provide an number and don't try to crash my program :(");
                Environment.Exit(1);
            }

            Console.Write("Second Number(b): ");
            try
            {
                b = double.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Please provide an integer and don't try to crash my program :(");
                Environment.Exit(1);
            }

            if (a > b)
            {
                double tmp = a;
                a = b;
                b = tmp;
            }

            Console.WriteLine(a + " " + b);
        }
    }
}
