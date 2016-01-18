using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountOfLetters
{
    class CountOfLetters
    {
        static void Main()
        {
            Console.Write("String of letters: ");
            string input = Console.ReadLine().Replace(" ", string.Empty);

            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (dict.ContainsKey(input[i]))
                {
                    dict[input[i]] = dict[input[i]] + 1;
                    continue;
                }

                dict[input[i]] = 1;
            }

            foreach (KeyValuePair<char, int> kvp in dict)
            {
                Console.WriteLine("{0} --> {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
