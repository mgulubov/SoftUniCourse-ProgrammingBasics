using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01JoroTheFootballPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            String isLeapYear = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int homeWeekends = int.Parse(Console.ReadLine());

            float result = 0.00f;
            int totalWeekends = 52 - homeWeekends;

            //Add the homeWeekends to the total
            result = result + homeWeekends;

            //Add holidays
            result = result + (holidays / 2);

            //Add the totalWeekends
            result = result + (totalWeekends * 2 / 3);

            //Check if year is leap
            if (isLeapYear.Equals("t"))
            {
                result = result + 3;
            }

            //Convert float to int
            int rounded = (int)Math.Ceiling(result);

            Console.WriteLine(rounded);
        }
    }
}
