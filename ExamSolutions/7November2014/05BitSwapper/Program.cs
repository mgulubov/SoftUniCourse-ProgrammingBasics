using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BitSwapper
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = new long[4];
            for (int i = 0; i < 4; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
            }

            while (true)
            {
                string command1 = Console.ReadLine().Replace(" ", string.Empty);
                if (command1 == "End")
                {
                    break;
                }
                string command2 = Console.ReadLine().Replace(" ", string.Empty);

                long num1 = numbers[long.Parse(command1[0].ToString())];
                long num2 = numbers[long.Parse(command2[0].ToString())];
                int num1Pos = int.Parse(command1[1].ToString()) * 4;
                int num2Pos = int.Parse(command2[1].ToString()) * 4;
                if (command1[0] == command2[0])
                {
                    for (int i = 0; i < 4; i++)
                    {
                        long byte1 = (long)1 & (num1 >> num1Pos);
                        long byte2 = (long)1 & (num1 >> num2Pos);
                        if (byte1 != byte2)
                        {
                            num1 = num1 ^ ((long)1 << num1Pos);
                            num1 = num1 ^ ((long)1 << num2Pos);
                        }
                        num1Pos++;
                        num2Pos++;
                    }
                    numbers[int.Parse(command1[0].ToString())] = num1;
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        long byte1 = (long)1 & (num1 >> num1Pos);
                        long byte2 = (long)1 & (num2 >> num2Pos);
                        if (byte1 != byte2)
                        {
                            num1 = num1 ^ ((long)1 << num1Pos);
                            num2 = num2 ^ ((long)1 << num2Pos);
                        }
                        num1Pos++;
                        num2Pos++;
                    }
                    numbers[int.Parse(command1[0].ToString())] = num1;
                    numbers[int.Parse(command2[0].ToString())] = num2;
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i].ToString());
            }
        }
    }
}
