using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            int number = 12345;
            float sqrt = (float)Math.Sqrt(number);
            sqrt = (float)Math.Round(sqrt, 3);

            Console.WriteLine(sqrt);
        }
    }
}
