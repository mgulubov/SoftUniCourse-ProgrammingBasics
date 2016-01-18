using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBitAtGivenPosition
{
    class ModifyBitAtGivenPosition
    {
        static void Main(string[] args)
        {
            int n = 0;
            int v = 0;
            int p = 0;
            try
            {
                Console.Write("Number: ");
                n = int.Parse(Console.ReadLine());

                Console.Write("Position: ");
                p = int.Parse(Console.ReadLine());

                Console.Write("Value: ");
                v = int.Parse(Console.ReadLine());
                if (v != 0 && v != 1)
                {
                    Console.WriteLine("Only 1 or 0 are allowed for Value!\nDON'T FUCK WITH MY SHIT!");
                    Environment.Exit(1);
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("FATAL CRITICAL MICROSOFT-LIKE ERROR!\nTry again");
                Environment.Exit(1);
            }

            int bit = ((n << p) & n) != 0 ? 1 : 0;

            if (v != bit)
            {
                if (v == 0)
                {
                    n = n & (~(1 << p));
                }
                else
                {
                    n = n | (1 << p);
                }
            }

            Console.WriteLine(n);
        }
    }
}
