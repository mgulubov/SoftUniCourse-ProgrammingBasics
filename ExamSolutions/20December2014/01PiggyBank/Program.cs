using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01PiggyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            double tankPrice = double.Parse(Console.ReadLine());
            short partyDays = short.Parse(Console.ReadLine());

            double savedInAMonth = ((30 - partyDays) * 2) - (partyDays * 5);
            if (savedInAMonth <= 0)
            {
                Console.WriteLine("never");
                Environment.Exit(0);
            }

            double totalMonths = tankPrice / savedInAMonth;
            int years = (int)Math.Floor(totalMonths / 12);
            int months = 0;
            if (totalMonths % 12 != 0)
            {
                months = (int)Math.Ceiling(totalMonths % 12);
            }
            if (months == 12)
            {
                months = 0;
                years++;
            }

            Console.WriteLine("{0} years, {1} months", years, months);
        }
    }
}
