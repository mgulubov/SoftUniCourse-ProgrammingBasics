using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BookOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());

            int totalBooks = 0;
            decimal totalPrice = 0m;
            for (int i = 0; i < orders; i++)
            {
                int packets = int.Parse(Console.ReadLine());
                int booksPerPacket = int.Parse(Console.ReadLine());
                decimal bookPrice = decimal.Parse(Console.ReadLine());

                int books = packets * booksPerPacket;
                if (packets >= 10 && packets <= 19)
                {
                    bookPrice -= bookPrice * 0.05m;
                }
                else if (packets >= 20 && packets <= 29)
                {
                    bookPrice -= bookPrice * 0.06m;
                }
                else if (packets >= 30 && packets <= 39)
                {
                    bookPrice -= bookPrice * 0.07m;
                }
                else if (packets >= 40 && packets <= 49)
                {
                    bookPrice -= bookPrice * 0.08m;
                }
                else if (packets >= 50 && packets <= 59)
                {
                    bookPrice -= bookPrice * 0.09m;
                }
                else if (packets >= 60 && packets <= 69)
                {
                    bookPrice -= bookPrice * 0.10m;
                }
                else if (packets >= 70 && packets <= 79)
                {
                    bookPrice -= bookPrice * 0.11m;
                }
                else if (packets >= 80 && packets <= 89)
                {
                    bookPrice -= bookPrice * 0.12m;
                }
                else if (packets >= 90 && packets <= 99)
                {
                    bookPrice -= bookPrice * 0.13m;
                }
                else if (packets >= 100 && packets <= 109)
                {
                    bookPrice -= bookPrice * 0.14m;
                }
                else if (packets >= 110)
                {
                    bookPrice -= bookPrice * 0.15m;
                }

                decimal allBooksCost = bookPrice * books;
                totalBooks += books;
                totalPrice += allBooksCost;
            }

            Console.WriteLine("{0}\n{1:F2}", totalBooks, totalPrice);
        }
    }
}
