using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01TorrentPirate
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal megabytes = decimal.Parse(Console.ReadLine());
            decimal cinemaMoney = decimal.Parse(Console.ReadLine());
            decimal wifeMoneyPerHour = decimal.Parse(Console.ReadLine());

            decimal downloadTime = (((megabytes / 2m) / 60m) / 60m);
            decimal priceForDownload = downloadTime * wifeMoneyPerHour;
            decimal numberOfMovies = megabytes / 1500m;
            decimal cinemaPrice = numberOfMovies * cinemaMoney;

            if (cinemaPrice > priceForDownload)
            {
                Console.WriteLine("mall -> {0:F2}lv", priceForDownload);
            }
            else if (cinemaPrice < priceForDownload)
            {
                Console.WriteLine("cinema -> {0:F2}lv", cinemaPrice);
            }
            else
            {
                Console.WriteLine("mall -> {0:F2}lv", priceForDownload);
            }
        }
    }
}
