using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            float r = 0f;
            try
            {
                Console.Write("Radius. You do know what a radius is right? You do know? So, what?! You think that because you know what a radius is you're somehow BETTER than me, is that what you think?! With your fancy... words and... and... your expensive edjucation... you think that makes you better than us simple redneck folk???!!!!: ");
                r = float.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Unexpected format! Well, I guess that fancy edjucation done do you no good after all huh?! Maybe, if you come spend some time in the corn field, you might learn sometn' about real life!!");
                Environment.Exit(1);
            }

            float pi = (float)Math.PI;
            float perimeter = 2 * (pi * r);
            float area = pi * (float)(Math.Pow(r, 2));
            Console.WriteLine("Perimeter: {0}\nArea: {1}", perimeter.ToString("0.00"), area.ToString("0.00"));
        }
    }
}
