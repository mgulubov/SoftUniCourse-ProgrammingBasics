using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapeziod
{
    class Trapeziod
    {
        static void Main(string[] args)
        {
            double a = 0.0;
            double b = 0.0;
            double h = 0.0;

            try
            {
                Console.Write("Show me the 'a' homie: ");
                a = double.Parse(Console.ReadLine());

                Console.Write("Cool... Cool... now show me the 'b': ");
                b = double.Parse(Console.ReadLine());

                Console.Write("BREAK YOU'SELF! GIMME' THE 'h'! I SAID, GIMME' THE 'h' FOOL! C'MON! YOU WANNA'a DIE?!! GIMME' THE 'h': ");
                h = double.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("I TOLD YOU NOT TO BREAK MY SHIT HOMEY!! I TOLD YOU!!! FORGET 'BOUT THOSE NUMBERS, I WANT THE CASH FROM THE REGISTER NOW!!!");
                Environment.Exit(1);
            }

            double area = h * ((a + b) / 2);

            Console.WriteLine("Area: " + area);
        }
    }
}
