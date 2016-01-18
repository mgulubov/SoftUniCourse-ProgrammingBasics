using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04NakovsMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            int d = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < firstString.Length - 1; i++)
            {
                string firstStringLeft = firstString.Substring(0, i + 1);
                string firstStringRight = firstString.Substring(i + 1);
                int firstWeightLeft = GetWeight(firstStringLeft);
                int firstWeightRight = GetWeight(firstStringRight);
                for (int b = 0; b < secondString.Length - 1; b++)
                {
                    string secondStringLeft = secondString.Substring(0, b + 1);
                    string secondStringRight = secondString.Substring(b + 1);
                    int secondWeightLeft = GetWeight(secondStringLeft);
                    int secondWieghtRight = GetWeight(secondStringRight);
                    int nakovs = Math.Abs(firstWeightLeft * secondWieghtRight - firstWeightRight * secondWeightLeft);
                    if (nakovs <= d)
                    {
                        Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs",
                            firstStringLeft, firstStringRight, secondStringLeft, secondStringRight, nakovs);
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }

        private static int GetWeight(string str)
        {
            int result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                result += str[i];
            }
            return result;
        }
    }
}
