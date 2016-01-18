using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSum
{
    class HalfSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] leftArray = new int[n];
            int[] rightArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                leftArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                rightArray[i] = int.Parse(Console.ReadLine());
            }

            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < leftArray.Length; i++)
            {
                leftSum += int.Parse(leftArray[i].ToString());
            }
            for (int i = 0; i < rightArray.Length; i++)
            {
                rightSum += int.Parse(rightArray[i].ToString());
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum={0}", leftSum);
            }
            else
            {
                int diff = leftSum - rightSum;
                if (diff < 0)
                {
                    diff = -(diff);
                }

                Console.WriteLine("No, diff={0}", diff);
            }
        }
    }
}
