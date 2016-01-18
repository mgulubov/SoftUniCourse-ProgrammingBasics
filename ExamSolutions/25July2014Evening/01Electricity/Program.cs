using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Electricity
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int flats = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine().Replace(":", ""));

            decimal totalFlats = floors * flats;
            decimal lampsCosumption = 100.53m;
            decimal computerConsumption = 125.90m;

            decimal totalConsumption = 0m;
            if (time >= 1400 && time <= 1859)
            {
                totalConsumption = ((2m * lampsCosumption) + (2m * computerConsumption));
            }
            else if (time >= 1900 && time <= 2359)
            {
                totalConsumption = ((7m * lampsCosumption) + (6m * computerConsumption));
            }
            else if (time >= 0000 && time <= 0859)
            {
                totalConsumption = ((1m * lampsCosumption) + (8m * computerConsumption));
            }

            totalConsumption *= totalFlats;

            Console.WriteLine("{0} Watts", Math.Floor(totalConsumption));
        }
    }
}
