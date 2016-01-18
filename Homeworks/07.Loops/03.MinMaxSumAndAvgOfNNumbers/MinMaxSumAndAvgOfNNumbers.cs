using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinMaxSumAndAvgOfNNumbers
{
    class MinMaxSumAndAvgOfNNumbers
    {
        static void Main(string[] args)
        {
            int n = 0;
            try
            {
                Console.Write("Please provide the magic 'n': ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    n = int.Parse("Diarrhea");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Brown happiness all-around!\nN must be > 0 && <= int.MaxValue");
                Environment.Exit(1);
            }

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Provide digit " + (i + 1) + ": ");
                try
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid number provided. JACKASS\nNumber must be >= int.MinValue && <= int.MaxValue");
                    Environment.Exit(1);
                }
            }

            Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:F2}",
                getMin(arr), getMax(arr), getSum(arr), getAvg(arr));
        }

        private static double getAvg(int[] arr)
        {
            int sum = getSum(arr);
            double result = (double)sum / arr.Length;

            return result;
        }

        private static int getSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        private static int getMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        private static int getMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }
    }
}
