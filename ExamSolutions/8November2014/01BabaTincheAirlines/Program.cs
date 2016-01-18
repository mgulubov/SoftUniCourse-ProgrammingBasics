using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01BabaTincheAirlines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstClass = Console.ReadLine().Split(' ');
            string[] businessClass = Console.ReadLine().Split(' ');
            string[] economyClass = Console.ReadLine().Split(' ');

            decimal firstClassDiscountedPrice = 7000 - (0.7m * 7000);
            decimal businessClassDiscountedPrice = 3500 - (0.7m * 3500);
            decimal economyClassDiscountedPrice = 1000 - (0.7m * 1000);

            decimal firstClassMealPrice = 7000 * 0.005m;
            decimal businessClassMealPrice = 3500 * 0.005m;
            decimal economyClassMealPrice = 1000 * 0.005m;

            decimal firstClassIncome = ((int.Parse(firstClass[0]) - int.Parse(firstClass[1])) * 7000) +
                (int.Parse(firstClass[1]) * firstClassDiscountedPrice) +
                (int.Parse(firstClass[2]) * firstClassMealPrice);

            decimal businessClassIncome = ((int.Parse(businessClass[0]) - int.Parse(businessClass[1])) * 3500) +
                (int.Parse(businessClass[1]) * businessClassDiscountedPrice) +
                (int.Parse(businessClass[2]) * businessClassMealPrice);

            decimal economyClassIncome = ((int.Parse(economyClass[0]) - int.Parse(economyClass[1])) * 1000) +
                (int.Parse(economyClass[1]) * economyClassDiscountedPrice) +
                (int.Parse(economyClass[2]) * economyClassMealPrice);

            decimal totalPrice = firstClassIncome + businessClassIncome + economyClassIncome;

            decimal maxIncome = (12 * 7000) + (12 * firstClassMealPrice) +
                (28 * 3500) + (28 * businessClassMealPrice) +
                (50 * 1000) + (50 * economyClassMealPrice);

            int diff = (int)Math.Ceiling(maxIncome - totalPrice);

            Console.WriteLine("{0}\n{1}", (int)totalPrice, (int)diff);
        }
    }
}
