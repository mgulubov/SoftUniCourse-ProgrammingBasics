using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04WeirdCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            string comb = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            int count = 0;
            for (int index1 = 0; index1 < comb.Length; index1++)
            {
                for (int index2 = 0; index2 < comb.Length; index2++)
                {
                    for (int index3 = 0; index3 < comb.Length; index3++)
                    {
                        for (int index4 = 0; index4 < comb.Length; index4++)
                        {
                            for (int index5 = 0; index5 < comb.Length; index5++)
                            {
                                if (count == num)
                                {
                                    string result = comb[index1].ToString() + comb[index2].ToString() +
                                        comb[index3].ToString() + comb[index4].ToString() + comb[index5].ToString();
                                    Console.WriteLine(result);
                                    Environment.Exit(0);
                                }
                                count++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("No");
        }
    }
}
