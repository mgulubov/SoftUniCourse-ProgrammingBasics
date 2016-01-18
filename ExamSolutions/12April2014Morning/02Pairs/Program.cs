using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Pairs
{
    class Program
    {
        static void Main()
        {
            String input = Console.ReadLine();
            String[] inputArr = input.Split(' ');

            int[] sums = new int[inputArr.Length / 2];
            //Console.WriteLine(sums.Length);
            //Environment.Exit(0);

            int sumsIndex = 0;
            for (int i = 0; i < inputArr.Length - 1; i++)
            {
                int sum = int.Parse(inputArr[i].ToString()) + int.Parse(inputArr[i + 1].ToString());
                i = i + 1;
                sums[sumsIndex] = sum;
                sumsIndex++;
            }

            Boolean check = ValuesAreEqual(sums);
            if (check == true)
            {
                Console.WriteLine("Yes, value={0}", sums[0]);
            }
            else
            {
                int diff = GetMaxDiff(sums);
                Console.WriteLine("No, maxdiff={0}", diff);
            }

        }

        private static bool ValuesAreEqual(int[] sums)
        {
            for (int i = 0; i < sums.Length - 1; i++)
            {
                if (sums[i] != sums[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        private static int GetMaxDiff(int[] sums)
        {
            int maxDiff = 0;
            int diff = 0;
            for (int i = 0; i < sums.Length - 1; i++)
            {
                diff = 0;
                if (sums[i] >= sums[i + 1])
                {
                    diff = sums[i] - sums[i + 1];
                }
                else
                {
                    diff = sums[i + 1] - sums[i];
                }

                if (diff > maxDiff)
                {
                    maxDiff = diff;
                }
            }

            return maxDiff;
        }
    }
}
