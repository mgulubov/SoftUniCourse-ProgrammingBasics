using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfThreeNumbers
{
    class SumOfThreeNumbers
    {
        static void Main(string[] args)
        {
            float a = 0f;
            float b = 0f;
            float c = 0f;

            try
            {
                Console.Write("f1rSt NumB3r: ");
                a = float.Parse(Console.ReadLine());

                Console.Write("S3c0nd numb3r: ");
                b = float.Parse(Console.ReadLine());

                Console.Write("tH1Rd nUmb3R: ");
                c = float.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("TIMMAAY! LLLLLIIIIIWIIAAAN ALLLIIIIIEEEAAAA LLLLLIIIIIWIIAAAN TIMMAAAYY!");
                Environment.Exit(1);
            }

            Console.WriteLine(a + b + c);
        }
    }
}
