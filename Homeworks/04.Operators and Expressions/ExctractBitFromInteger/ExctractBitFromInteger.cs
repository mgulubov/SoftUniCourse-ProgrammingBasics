using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExctractBitFromInteger
{
    class ExctractBitFromInteger
    {
        static void Main(string[] args)
        {
            int n = 0;
            int p = 0;
            try
            {
                Console.Write("Integer: ");
                n = int.Parse(Console.ReadLine());

                Console.Write("Position: ");
                p = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("No frenzy outbursts allowed!");
                Environment.Exit(1);
            }

            int mask = n >> p;
            int check = (mask & n) != 0 ? 1 : 0;

            Console.WriteLine(check);
        }
    }
}
