using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckABitAtGivenPosition
{
    class CheckABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            int n = 0;
            int p = 0;
            try
            {
                Console.Write("Number: ");
                n = int.Parse(Console.ReadLine());

                Console.Write("Position: ");
                p = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("ERRRRRROOOOORRRRR!");
                Environment.Exit(1);
            }

            int bit = ((n << p) & n) != 0 ? 1 : 0;

            Console.WriteLine(bit == 1);
        }
    }
}
