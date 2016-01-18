using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            long bundle1 = long.Parse(Console.ReadLine());
            long bundle2 = long.Parse(Console.ReadLine());
            long bundle3 = long.Parse(Console.ReadLine());
            long bundle4 = long.Parse(Console.ReadLine());

            long tops = long.Parse(Console.ReadLine());

            long target = long.Parse(Console.ReadLine());

            long requiredLegs = target * 4;

            long totalLegs = bundle1 + (bundle2 * 2) + (bundle3 * 3) + (bundle4 * 4);

            long tablesMade = (long)Math.Min((decimal)totalLegs / 4, tops);

            if (tablesMade > target)
            {
                long more = tablesMade - target;
                long topsLeft = tops - target;
                long legsLeft = totalLegs - requiredLegs;
                Console.WriteLine("more: {0}\ntops left: {1}, legs left: {2}", more, topsLeft, legsLeft);
            }
            else if (tablesMade < target)
            {
                long less = tablesMade - target;
                long topsNeeded = target - tops;
                if (topsNeeded < 0)
                {
                    topsNeeded = 0;
                }
                long legsNeeded = requiredLegs - totalLegs;
                if (legsNeeded < 0)
                {
                    legsNeeded = 0;
                }
                Console.WriteLine("less: {0}\ntops needed: {1}, legs needed: {2}", less, topsNeeded, legsNeeded);
            }
            else
            {
                Console.WriteLine("Just enough tables made: {0}", tablesMade);
            }
        }
    }
}
