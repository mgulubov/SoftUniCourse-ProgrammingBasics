using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddOrEvenProduct
{
    class OddOrEvenProduct
    {
        static void Main(string[] args)
        {
            Console.Write("Provide the numbers... please: ");
            String str = Console.ReadLine();
            String[] arr = str.Split(' ');
            int[] numbers = new int[arr.Length];
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    numbers[i] = int.Parse(arr[i].ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("You entered an invalid character. Only numbers allowed\nTry again... please");
                Environment.Exit(1);
            }

            int oddSum = 1;
            int evenSum = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                int radix = i + 1;
                if (radix % 2 == 0)
                {
                    evenSum *= numbers[i];
                }
                else
                {
                    oddSum *= numbers[i];
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("yes\nproduct = {0}", oddSum);
            }
            else
            {
                Console.WriteLine("no\nodd_product = {0}\neven_product = {1}", oddSum, evenSum);
            }

        }
    }
}
