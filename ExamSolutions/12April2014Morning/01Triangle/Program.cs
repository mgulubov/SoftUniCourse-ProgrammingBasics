using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Triangle
{
    class Program
    {
        static void Main()
        {
            float aX = float.Parse(Console.ReadLine());
            float aY = float.Parse(Console.ReadLine());
            float bX = float.Parse(Console.ReadLine());
            float bY = float.Parse(Console.ReadLine());
            float cX = float.Parse(Console.ReadLine());
            float cY = float.Parse(Console.ReadLine());

            //Lets find the distances
            float ab = (float)Math.Sqrt((Math.Pow((bX - aX), 2)) + (Math.Pow((bY - aY), 2)));
            float ac = (float)Math.Sqrt((Math.Pow((cX - aX), 2)) + (Math.Pow((cY - aY), 2)));
            float bc = (float)Math.Sqrt((Math.Pow((cX - bX), 2)) + (Math.Pow((cY - bY), 2)));

            Boolean check = ((ab + ac) > bc) && ((ab + bc) > ac) && ((ac + bc) > ab);

            if (check == true)
            {
                float halfPerimeter = (ab + ac + bc) / 2f;
                float area = (float)Math.Sqrt(halfPerimeter * ((halfPerimeter - ab) * (halfPerimeter - ac) * (halfPerimeter - bc)));

                Console.WriteLine("Yes");
                Console.WriteLine(area.ToString("0.00"));
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine(ab.ToString("0.00"));
            }
        }
    }
}
