using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PrintADeckOf52Cards
{
    class PrintADeckOf52Cards
    {
        static void Main(string[] args)
        {
            //No input here?! Whooo-Hooooo :P

            //Just as a pre-coution. 
            Console.OutputEncoding = Encoding.UTF8;
            //If you still have a problem with displaying the suit chars properly, then... that's your fuckin' problem :p.
            //Just kidding - you should probably try changing the console font to Lucida

            for (int rank = 0; rank < 13; rank++)
            {
                String card = "";
                if (rank >= 0 && rank <= 8) {
                    card += (rank + 2).ToString();
                }
                else
                {
                    switch (rank)
                    {
                        case 9:
                            card += "J";
                            break;
                        case 10:
                            card += "Q";
                            break;
                        case 11:
                            card += "K";
                            break;
                        case 12:
                            card += "A";
                            break;
                    }
                }

                for (int color = 0; color < 4; color++)
                {
                    switch (color)
                    {
                        case 0:
                            Console.Write(card + "♣");
                            break;
                        case 1:
                            Console.Write(card + "♦");
                            break;
                        case 2:
                            Console.Write(card + "♥");
                            break;
                        case 3:
                            Console.Write(card + "♠");
                            break;
                    }

                    if (color < 3)
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
