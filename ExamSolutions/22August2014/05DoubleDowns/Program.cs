using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DoubleDowns
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

            int rightDCount = 0;
            int leftDCount = 0;
            int vertCount = 0;
            for (int i = 0; i < n - 1; i++)
            {
                int length = Convert.ToString(numbers[i], 2).Length;
                int num1 = numbers[i];
                for (int pos = 0; pos < length; pos++)
                {
                    int bit1 = 1 & (num1 >> pos);
                    if (bit1 != 1)
                    {
                        continue;
                    }

                    //check rightD
                    int num2 = numbers[i + 1];
                    int bit2 = 1 & (num2 >> pos - 1);
                    if (bit2 == 1)
                    {
                        rightDCount++;
                    }

                    //check vert
                    bit2 = 1 & (num2 >> pos);
                    if (bit2 == 1)
                    {
                        vertCount++;
                    }

                    //check rightD
                    bit2 = 1 & (num2 >> (pos + 1));
                    if (bit2 == 1)
                    {
                        leftDCount++;
                    }
                }
            }

            Console.WriteLine("{0}\n{1}\n{2}", rightDCount, leftDCount, vertCount);
        }
    }
}
