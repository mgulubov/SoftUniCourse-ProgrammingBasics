using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main(string[] args)
        {
            Console.Write("First Date: ");
            string[] first = Console.ReadLine().Split('.');
            Console.Write("Second Date: ");
            string[] second = Console.ReadLine().Split('.');

            DateTime startDate = new DateTime();
            DateTime endDate = new DateTime();
            try
            { //dd.mm.yyyy
                startDate = new DateTime(int.Parse(first[2]), int.Parse(first[1]), int.Parse(first[0]));
                endDate = new DateTime(int.Parse(second[2]), int.Parse(second[1]), int.Parse(second[0]));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid format");
                Environment.Exit(1);
            }

            Console.WriteLine(daysBetween(startDate, endDate));
        }

        private static int daysBetween(DateTime start, DateTime end)
        {
            return (int)(end - start).TotalDays;
        }
    }
}
