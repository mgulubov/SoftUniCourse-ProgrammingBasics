using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBySevenAndFive
{
    class DivideBySevenAndFive
    {
        static void Main(string[] args)
        {
            int n = 0;

            Console.Write("Gimme another numba' mastaaa: ");
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("MASTAAAAAA! WHYYYY? WHY DID YOU BROKE MA' PROGRAAAAAM :(");
                Environment.Exit(1);
            }

            

            Boolean check = (n % 5 == 0) && (n % 7 == 0);
            if (n == 0)
            {
                check = false; //Can't divide by zero ;)
            }

            Console.WriteLine(check);
        }
    }
}
