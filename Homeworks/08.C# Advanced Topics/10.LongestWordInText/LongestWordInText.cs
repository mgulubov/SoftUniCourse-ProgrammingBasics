using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.LongestWordInText
{
    class LongestWordInText
    {
        static void Main()
        {
            Console.Write("Text: ");
            string[] input = Console.ReadLine().Split(' ');

            int maxLength = 0;
            int resultIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString().Length > maxLength)
                {
                    maxLength = input[i].ToString().Length;
                    resultIndex = i;
                }
            }

            Console.WriteLine(input[resultIndex].ToString());
        }

    }
}
