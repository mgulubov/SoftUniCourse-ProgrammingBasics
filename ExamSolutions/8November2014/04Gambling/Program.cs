using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Gambling
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            string[] dealerCards = Console.ReadLine().Split(' ');

            decimal pot = 2m * cash;

            int dealerHand = 0;
            for (int i = 0; i < dealerCards.Length; i++)
            {
                switch (dealerCards[i].ToString())
                {
                    case "J":
                        {
                            dealerHand += 11;
                            break;
                        }
                    case "Q":
                        {
                            dealerHand += 12;
                            break;
                        }
                    case "K":
                        {
                            dealerHand += 13;
                            break;
                        }
                    case "A":
                        {
                            dealerHand += 14;
                            break;
                        }
                    default:
                        {
                            dealerHand += int.Parse(dealerCards[i].ToString());
                            break;
                        }
                }
            }

            int totalHands = 0;
            int biggerHands = 0;
            for (int card1 = 2; card1 < 15; card1++)
            {
                for (int card2 = 2; card2 < 15; card2++)
                {
                    for (int card3 = 2; card3 < 15; card3++)
                    {
                        for (int card4 = 2; card4 < 15; card4++)
                        {
                            totalHands++;
                            if (card1 + card2 + card3 + card4 > dealerHand)
                            {
                                biggerHands++;
                            }
                        }
                    }
                }
            }

            decimal ratio = (decimal)(biggerHands) / (decimal)(totalHands);
            if (ratio > 0.5m)
            {
                Console.WriteLine("DRAW");
            }
            else
            {
                Console.WriteLine("FOLD");
            }

            decimal winings = ratio * pot;
            Console.WriteLine("{0:F2}", winings);
        }
    }
}
