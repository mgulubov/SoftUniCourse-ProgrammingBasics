using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05X_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[8];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                int length = Convert.ToString(numbers[i], 2).Length;
                int num1 = numbers[i];
                int num2 = numbers[i + 1];
                int num3 = numbers[i + 2];
                for (int pos = 0; pos < length - 2; pos++)
                {
                    int num1Bit1 = 1 & num1 >> pos;
                    if (num1Bit1 == 1)
                    {
                        int num1Bit2 = 1 & num1 >> (pos + 1);
                        if (num1Bit2 == 0)
                        {
                            int num1Bit3 = 1 & num1 >> (pos + 2);
                            if (num1Bit3 == 1)
                            {
                                int num2Bi1 = 1 & num2 >> pos;
                                if (num2Bi1 == 0)
                                {
                                    int num2Bit2 = 1 & num2 >> (pos + 1);
                                    if (num2Bit2 == 1)
                                    {
                                        int num2Bit3 = 1 & num2 >> (pos + 2);
                                        if (num2Bit3 == 0)
                                        {
                                            int num3Bit1 = 1 & num3 >> pos;
                                            if (num3Bit1 == 1)
                                            {
                                                int num3Bit2 = 1 & num3 >> (pos + 1);
                                                if (num3Bit2 == 0)
                                                {
                                                    int num3Bit3 = 1 & num3 >> (pos + 2);
                                                    if (num3Bit3 == 1)
                                                    {
                                                        count++;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
