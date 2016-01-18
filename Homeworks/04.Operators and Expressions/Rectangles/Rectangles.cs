using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            float width = 0.0f;
            float height = 0.0f;

            try
            {
                Console.Write("Pleeeease mastaaa, tell me the widtthhssss: ");
                width = float.Parse(Console.ReadLine());

                Console.Write("And now the heighhttss mastaa, please, pleeeaasesss: ");
                height = float.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("UUUUPPPPSSSSEESSSSS, YOU DID IT AGAIN MASTAAAAA :D");
                Environment.Exit(1);
            }

            float perimeter = 2 * (width + height);
            float area = width * height;

            Console.WriteLine("Perimeter: " + perimeter);
            Console.WriteLine("Area: {0}", area);
        }
    }
}
