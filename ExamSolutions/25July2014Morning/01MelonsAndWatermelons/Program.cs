using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01MelonsAndWatermelons
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int seq = int.Parse(Console.ReadLine());

            int melonsCount = 0;
            int watermelonsCount = 0;
            for (int i = 0; i < seq; i++)
            {
                if (day > 7)
                {
                    day = 1;
                }
                melonsCount += GetMelons(day - 1);
                watermelonsCount += GetWatermelons(day - 1);
                day++;
            }

            if (melonsCount > watermelonsCount)
            {
                Console.WriteLine("{0} more melons", (melonsCount - watermelonsCount));
            }
            else if (melonsCount < watermelonsCount)
            {
                Console.WriteLine("{0} more watermelons", (watermelonsCount - melonsCount));
            }
            else
            {
                Console.WriteLine("Equal amount: {0}", melonsCount);
            }
        }

        private static int GetMelons(int day)
        {
            int[] usage = new int[] { 0, 2, 1, 0, 2, 2, 0 };
            return usage[day];
        }

        private static int GetWatermelons(int day)
        {
            int[] usage = new int[] { 1, 0, 1, 2, 2, 1, 0 };
            return usage[day];
        }
    }
}
