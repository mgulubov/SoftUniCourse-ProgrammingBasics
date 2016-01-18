using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Globalization;

namespace _10.BeerTime
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            Console.Write("Please provide the time in the following \"format hh:mm tt\": ");
            String time = Console.ReadLine();
            DateTime dateTime = new DateTime();

            try
            {
                //dateTime = DateTime.ParseExact(time, "HH:MM ", DateTimeFormatInfo.InvariantInfo);
                dateTime = Convert.ToDateTime(time);
                
            }
            catch
            {
                Console.WriteLine("Invalid time or format! Check your shit and stay off mine!");
                Environment.Exit(1);
            }

            DateTime beerTimeBegins = Convert.ToDateTime("1:00 PM");
            DateTime beerTimeEnds = Convert.ToDateTime("3:00 AM");
            //Console.WriteLine(dateTime.ToString("tt"));

            if (dateTime.ToString("tt") == "PM")
            {
                beerTimeEnds = beerTimeEnds.AddDays(1);
                if (dateTime.Ticks >= beerTimeBegins.Ticks && dateTime.Ticks < beerTimeEnds.Ticks)
                {
                    Console.WriteLine("beer time");
                    Environment.Exit(0);
                }

            }
            else
            {
                beerTimeBegins = beerTimeBegins.AddDays(-1);
                if (dateTime.Ticks >= beerTimeBegins.Ticks && dateTime.Ticks < beerTimeEnds.Ticks)
                {
                    Console.WriteLine("beer time");
                    Environment.Exit(0);
                }
            }

            Console.WriteLine("non-beer time");

            //Console.WriteLine(dateTime.Ticks);
           // Console.WriteLine(beerTimeBegins.Ticks);
            //Console.WriteLine(beerTimeEnds.Ticks);
        }
    }
}
