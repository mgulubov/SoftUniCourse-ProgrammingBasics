using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            float x = 0f;
            float y = 0f;
            try
            {
                Console.Write("What's the X: ");
                x = float.Parse(Console.ReadLine());

                Console.Write("What's the Y: ");
                y = float.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("You broke my shit :(");
                Environment.Exit(1);
            }

            int circleX = 0;
            int circleY = 0;
            int circleRadius = 2;

            double distance = Math.Pow(x - circleX, 2) + Math.Pow(y - circleY, 2);
            Boolean check = distance <= Math.Pow(circleRadius, 2);

            Console.WriteLine(check);
        }
    }
}
