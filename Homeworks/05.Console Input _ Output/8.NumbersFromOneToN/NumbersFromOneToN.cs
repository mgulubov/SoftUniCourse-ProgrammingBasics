using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.NumbersFromOneToN
{
    class NumbersFromOneToN
    {
        static void Main()
        {
            int n = 0;
            try
            {
                Console.Write("You know, I bet that if you were to give me a number \"N\"," +
                "I can print all numbers from 1 to \"N\"\nN: ");
                n = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Da' fuq is this?! This ain't a valid number!");
                Environment.Exit(1);
            }

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
