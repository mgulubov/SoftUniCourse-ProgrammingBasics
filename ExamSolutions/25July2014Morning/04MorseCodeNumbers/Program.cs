using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04MorseCodeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int nSum = GetSumOf(n);

            int count = 0;
            for (int num1 = 0; num1 < 6; num1++)
            {
                for (int num2 = 0; num2 < 6; num2++)
                {
                    for (int num3 = 0; num3 < 6; num3++)
                    {
                        for (int num4 = 0; num4 < 6; num4++)
                        {
                            for (int num5 = 0; num5 < 6; num5++)
                            {
                                for (int num6 = 0; num6 < 6; num6++)
                                {
                                    int product = num1 * num2 * num3 * num4 * num5 * num6;
                                    if (product == nSum)
                                    {
                                        //Console.WriteLine(nSum);
                                        // Console.WriteLine(num1.ToString() + num2.ToString() + num3.ToString() +
                                        // num4.ToString() + num5.ToString() + num6.ToString());
                                        PrintMorseCodeOf(num1, num2, num3, num4, num5, num6);
                                        count++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }

        private static void PrintMorseCodeOf(int num1, int num2, int num3, int num4, int num5, int num6)
        {
            int[] arr = new int[] { num1, num2, num3, num4, num5, num6 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int b = 0; b < 5; b++)
                {
                    if (b + 1 <= arr[i])
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.Write("|");
            }
            Console.WriteLine();
        }

        private static int GetSumOf(int n)
        {
            int result = 0;
            for (int i = 0; i < n.ToString().Length; i++)
            {
                result += int.Parse(n.ToString()[i].ToString());
            }
            return result;
        }
    }
}
