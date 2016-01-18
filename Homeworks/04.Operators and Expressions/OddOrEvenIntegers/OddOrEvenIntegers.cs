using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            int n = 0;

            Console.Write("Pleassse tell me the number mastaaaa: ");
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("NOOOOOO you broke my program :(");
                Environment.Exit(1);
            }

            Boolean check = n % 2 != 0;

            Console.WriteLine(check);
        }
    }
}
