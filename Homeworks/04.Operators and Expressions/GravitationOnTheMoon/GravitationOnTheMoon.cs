using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            float weight = 0.0f;

            Console.Write("How much do you (truly)weight masssstaaa?: ");
            try
            {
                weight = float.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("NOOOOOOO YOUR WEIGHT BROKE MY PROGRAM :((");
                Environment.Exit(1);
            }

            float moonWeight = weight * ((float)17 / 100);

            Console.WriteLine(moonWeight);
        }
    }
}
