using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01TravellerBob
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            int contractMonths = int.Parse(Console.ReadLine());
            int familyMonths = int.Parse(Console.ReadLine());

            int normalMonths = 12 - (contractMonths + familyMonths);
            //float result = 0f;

            int contractTravels = contractMonths * (4 * 3);
            int familyTravels = familyMonths * (2 * 2);
            float normalTravels = normalMonths * (4 * 3);
            normalTravels = normalTravels * (3f / 5f);
            //float test = (float)(2f / 5f);
            float result = (float)(contractTravels + familyTravels + normalTravels);

            float additional = 0f;
            if (s == "leap")
            {
                additional = result * (5f / 100f);
            }


            Console.WriteLine((int)(result + additional));
        }
    }
}
