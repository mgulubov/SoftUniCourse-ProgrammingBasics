using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02JumpingSums
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int jump = int.Parse(Console.ReadLine());

            int[] array = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                array[i] = int.Parse(input[i].ToString());
            }

            int biggestSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int sum = 0;
                int index = i;
                for (int j = 0; j <= jump; j++)
                {
                    //Console.WriteLine(index);
                    sum += array[index];
                    //index = array[index] + index;
                    int next = array[index];
                    for (int b = 0; b < next; b++)
                    {
                        index++;
                        if (index > array.Length - 1)
                        {
                            index = 0;
                        }
                    }
                }
                //Console.WriteLine();
                if (sum > biggestSum)
                {
                    biggestSum = sum;
                }
            }

            Console.WriteLine("max sum = {0}", biggestSum);
        }
    }
}
