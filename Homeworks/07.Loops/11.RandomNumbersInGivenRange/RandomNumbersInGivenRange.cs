using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main(string[] args)
        {
            int n = 0, min = 0, max = 0;
            try
            {
                Console.Write("N: ");
                n = int.Parse(Console.ReadLine());
                Console.Write("Min: ");
                min = int.Parse(Console.ReadLine());
                Console.Write("Max: ");
                max = int.Parse(Console.ReadLine());

                if (min > max) {
                    n = int.Parse("Lucky Strike Cigarettes. Filtered!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Jordan Sneakers!");
                Environment.Exit(1);
            }

            max++; //Random.Next() generates a number between min and max(max not included).So, we increment the max with 1
            Random gen = new Random();
            for (int i = 0; i < n; i++)
            {
                int num = gen.Next(min, max);
                Console.Write(num);

                if (i < n - 1)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
