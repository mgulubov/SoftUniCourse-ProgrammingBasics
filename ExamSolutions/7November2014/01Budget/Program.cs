using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Budget
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int daysOut = int.Parse(Console.ReadLine());
            int hometown = int.Parse(Console.ReadLine());

            int expenses = (((int)(0.03 * budget) + 10) * daysOut) +
                ((22 - daysOut) * 10) +
                ((4 - hometown) * 2 * 20) +
                150;

            if (expenses > budget)
            {
                Console.WriteLine("No, not enough {0}.", expenses - budget);
            }
            else if (expenses < budget)
            {
                Console.WriteLine("Yes, leftover {0}.", budget - expenses);
            }
            else
            {
                Console.WriteLine("Exact Budget.");
            }
        }
    }
}
