using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            int num = 2;
            for (int i = 0; i < 10; i++)
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + " ");
                }
                else
                {
                    Console.Write(-(num) + " ");
                }

                if (i == 9)
                {
                    Console.WriteLine();
                }

                num++;
            }
        }
    }
}
