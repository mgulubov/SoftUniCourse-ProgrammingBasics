using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04WinningNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int letSum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                int c = char.ToUpper(text[i]) - 64;
                letSum += c;
            }
            //Console.WriteLine(letSum);

            int count = 0;
            for (int num1 = 0; num1 < 10; num1++)
            {
                for (int num2 = 0; num2 < 10; num2++)
                {
                    for (int num3 = 0; num3 < 10; num3++)
                    {
                        for (int num4 = 0; num4 < 10; num4++)
                        {
                            for (int num5 = 0; num5 < 10; num5++)
                            {
                                for (int num6 = 0; num6 < 10; num6++)
                                {
                                    int leftProduct = num1 * num2 * num3;
                                    int rightProduct = num4 * num5 * num6;
                                    if (leftProduct == rightProduct && leftProduct == letSum)
                                    {
                                        count++;
                                        Console.WriteLine("{0}{1}{2}-{3}{4}{5}",
                                            num1, num2, num3, num4, num5, num6);
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
    }
}
