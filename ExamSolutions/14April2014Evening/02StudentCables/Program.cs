using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02StudentCables
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<int> input = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                string m = Console.ReadLine();

                if (m == "meters")
                {
                    number = number * 100;
                }

                if (number < 20)
                {
                    continue;
                }
                input.Add(number);
            }

            int totalLength = 0;
            for (int i = 0; i < input.Count; i++)
            {
                totalLength += input[i];
            }
            totalLength -= 3 * (input.Count - 1);

            int count = 0;
            while (totalLength >= 504)
            {
                totalLength -= 504;
                count++;
            }

            Console.WriteLine(count);
            Console.WriteLine(totalLength);
        }
    }
}
