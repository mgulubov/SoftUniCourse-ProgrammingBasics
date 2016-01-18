using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BitFlipper
{
    class Program
    {
        static void Main()
        {
            //string a = "0111100111000000111100001111000000011111100010100011100011100001"; //64
            long num = long.Parse(Console.ReadLine());

            int length = Convert.ToString(num, 2).Length;
            //Console.WriteLine(length);
            int index = length - 1;
            while (index > 2)
            {
                long firstBit = 1 & (num >> index);
                long secondBit = 1 & (num >> (index - 1));
                long thirdBit = 1 & (num >> (index - 2));
                //Console.WriteLine("{0}{1}{2}", firstBit, secondBit, thirdBit);

                if (firstBit == secondBit && secondBit == thirdBit)
                {
                    //int end = index - 2;
                    for (int i = index; i >= index - 2; i--)
                    {
                        //Console.WriteLine(Convert.ToString(num, 2).PadLeft(64, '0'));
                        //	Console.WriteLine(Convert.ToString(((long)1 << i), 2).PadLeft(64, '0'));
                        num = num ^ ((long)1 << i);
                        // Console.WriteLine(Convert.ToString(num, 2).PadLeft(64, '0'));
                        // Console.WriteLine();
                        //index--;
                    }
                    index -= 3;
                    continue;
                }
                index--;
            }

            Console.WriteLine(num);
        }
    }
}
