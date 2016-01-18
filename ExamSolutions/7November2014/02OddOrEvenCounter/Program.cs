using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02OddOrEvenCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int sets = int.Parse(Console.ReadLine());
            int numbers = int.Parse(Console.ReadLine());
            string oddOrEven = Console.ReadLine();

            int biggestEvenCount = 0;
            int biggestOddCount = 0;
            int setWithBiggstEven = 0;
            int setWithBiggestOdd = 0;
            for (int set = 0; set < sets; set++)
            {
                int evenCount = 0;
                int oddCount = 0;
                for (int number = 0; number < numbers; number++)
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        evenCount++;
                    }
                    else
                    {
                        oddCount++;
                    }
                }
                if (evenCount > biggestEvenCount)
                {
                    biggestEvenCount = evenCount;
                    setWithBiggstEven = set + 1;
                }
                if (oddCount > biggestOddCount)
                {
                    biggestOddCount = oddCount;
                    setWithBiggestOdd = set + 1;
                }
            }

            if (oddOrEven == "odd")
            {
                string word = GetWord(setWithBiggestOdd);
                if (word == null)
                {
                    Console.WriteLine("No");
                }
                else
                {
                    Console.WriteLine("{0} set has the most odd numbers: {1}", word, biggestOddCount);
                }
            }
            else
            {
                string word = GetWord(setWithBiggstEven);
                if (word == null)
                {
                    Console.WriteLine("No");
                }
                else
                {
                    Console.WriteLine("{0} set has the most even numbers: {1}", word, biggestEvenCount);
                }
            }
        }

        private static string GetWord(int num)
        {
            switch (num)
            {
                case 1:
                    {
                        return "First";
                    }
                case 2:
                    {
                        return "Second";
                    }
                case 3:
                    {
                        return "Third";
                    }
                case 4:
                    {
                        return "Fourth";
                    }
                case 5:
                    {
                        return "Fifth";
                    }
                case 6:
                    {
                        return "Sixth";
                    }
                case 7:
                    {
                        return "Seventh";
                    }
                case 8:
                    {
                        return "Eighth";
                    }
                case 9:
                    {
                        return "Ninth";
                    }
                case 10:
                    {
                        return "Tenth";
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}
