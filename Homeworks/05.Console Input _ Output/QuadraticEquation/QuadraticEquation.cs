using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            float a = 0f;
            float b = 0f;
            float c = 0f;
            try
            {
                Console.Write("Arrrgghhh! Gimme the A, ye salty, pox-faced kraken: ");
                a = float.Parse(Console.ReadLine());

                Console.Write("Ye parrot-loving, mutinous rogue! Gimme the B: ");
                b = float.Parse(Console.ReadLine());

                Console.Write("Ill skewer yer gizzard, ye salty sea bass... Gimme the C! Avast!: ");
                c = float.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid value, ye sorry, scurvy-infested, bilge-drinkin' swab!!");
                Environment.Exit(1);
            }

            //Quadratic equasion formulla specs
            float qf1 = -(b);
            float qf2 = (float)Math.Sqrt((Math.Pow(b, 2)) - 4 * a * c);
            float qf3 = 2 * a;

            float x2 = (qf1 + qf2) / qf3;
            float x1 = (qf1 - qf2) / qf3;

            if (x1 == x2)
            {
                Console.WriteLine("X1 = X2 = {0}", x1);
                Environment.Exit(0);
            }
            else if (x1.ToString() == "NaN" && x2.ToString() == "NaN")
            {
                Console.WriteLine("no real roots");
            }
            else
            {
                Console.WriteLine("X1 = {0}; X2 = {1}", x1, x2);
            }
        }
    }
}
