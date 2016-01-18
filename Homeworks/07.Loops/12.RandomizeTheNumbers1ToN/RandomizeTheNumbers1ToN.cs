using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RandomizeTheNumbers1ToN
{
    class RandomizeTheNumbers1ToN
    {
        static void Main(string[] args)
        {
            int n = 0;
            try
            {
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    n = int.Parse("Vitami C");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("DON'T DO DRUGS");
                Environment.Exit(1);
            }

            Random gen = new Random();
            int min = 1;
            int max = n + 1;
            List<int> list = new List<int>();
            while (list.Count < n)
            {
                int num = gen.Next(min, max);
                if (list.Contains(num))
                {
                    continue;
                }

                list.Add(num);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if (i < list.Count - 1)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}
