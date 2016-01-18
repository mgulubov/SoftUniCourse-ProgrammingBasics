using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseExtractBit3
{
    class BitwiseExtractBit3
    {
        static void Main(string[] args)
        {
            int n = 0;
            try
            {
                Console.Write("N: ");
                n = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("BROKEN :(");
                Environment.Exit(1);
            }

            int mask = n >> 3;

            int check = (n & mask) != 0 ? 1 : 0;

            Console.WriteLine(check);
        }
    }
}
