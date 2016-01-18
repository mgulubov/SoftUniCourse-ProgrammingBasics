using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CountOfNames
{
    class CountOfNames
    {
        static void Main()
        {
            Console.Write("Names: ");
            string[] input = Console.ReadLine().Split(' ');

            SortedDictionary<string, int> dict = new SortedDictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (dict.ContainsKey(input[i].ToString()))
                {
                    dict[input[i].ToString()] = dict[input[i].ToString()] + 1;
                    continue;
                }

                dict[input[i].ToString()] = 1;
            }

            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine("{0} --> {1}", kvp.Key, kvp.Value);
            }
        }

    }
}
