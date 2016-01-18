using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitIsSeven
{
    class ThirdDigitIsSeven
    {
        static void Main(string[] args)
        {
            int n = 0;

            Console.Write("OHHHHH, this is going to be pfuunnn mastaaa! Give me the numbaaaassss: ");
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("That's not pfuunnn mastaa :(. Don't breaks itt! Try againss!");
                Environment.Exit(1);
            }

            int digit = (n / 100) % 10; //Saves space and effort, from converting it to string :)
            bool result = digit == 7;

            Console.WriteLine(result);
        }
    }
}
