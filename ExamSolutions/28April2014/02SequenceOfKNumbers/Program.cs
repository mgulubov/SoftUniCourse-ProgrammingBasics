using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02SequenceOfKNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int k = int.Parse(Console.ReadLine());

            for (int startIndex = 0; startIndex < input.Length; startIndex++)
            {
                int count = 0;
                for (int i = 0; i < k; i++)
                {
                    try
                    {
                        if (input[startIndex] == input[startIndex + i])
                        {
                            count++;
                        }
                    }
                    catch (Exception)
                    {
                        //continue;
                    }
                }
                if (count >= k)
                {
                    for (int i = 0; i < k; i++)
                    {
                        input[startIndex + i] = "";
                    }
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == "")
                {
                    continue;
                }
                Console.Write(input[i]);
                if (i < input.Length - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
