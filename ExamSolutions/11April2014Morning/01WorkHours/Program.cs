using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01WorkHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetHours = int.Parse(Console.ReadLine());
            decimal days = decimal.Parse(Console.ReadLine());
            decimal productivity = decimal.Parse(Console.ReadLine());

            decimal workDays = days - (days * (10m / 100m));
            decimal workHours = workDays * 12m;
            int productiveHours = (int)(workHours * (productivity / 100m));

            int difference = productiveHours - targetHours;
            string answer = difference < 0 ? "No" : "Yes";

            Console.WriteLine("{0}\n{1}", answer, difference);

        }
    }
}
