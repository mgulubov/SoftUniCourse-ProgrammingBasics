using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ChangeEvenBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            uint target = uint.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                int num = numbers[i];
                int length = Convert.ToString(num, 2).Length;
                int[] positions = new int[length];
                int p = 0;
                for (int b = 0; b < positions.Length; b++)
                {
                    positions[b] = p;
                    p += 2;
                }

                for (int b = 0; b < positions.Length; b++)
                {
                    int pos = positions[b];
                    uint bite = 1 & (target >> pos);
                    if (bite == 0)
                    {
                        uint mask = (uint)1 << pos;
                        target = target | mask;
                        count++;
                    }
                }
            }
            Console.WriteLine("{0}\n{1}", target, count);
        }
    }
}
