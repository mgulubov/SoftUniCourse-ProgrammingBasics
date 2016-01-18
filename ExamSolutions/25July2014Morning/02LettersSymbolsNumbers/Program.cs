using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02LettersSymbolsNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int letterSum = 0;
            int numberSum = 0;
            int symbolSum = 0;
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                for (int b = 0; b < str.Length; b++)
                {
                    char c = str[b];
                    int cN = str[b];
                    if (char.IsLetter(c))
                    {
                        letterSum += (char.ToUpper(c) - 64) * 10;
                        //Console.WriteLine("{0} : {1}", c, letterSum);
                    }
                    else if (char.IsNumber(c))
                    {
                        numberSum += int.Parse(c.ToString()) * 20;
                        //Console.WriteLine("{0} : {1}", c, numberSum);
                    }
                    else
                    {
                        if (c != ' ' && c != '\t' && c != '\r' && c != '\n')
                        {
                            symbolSum += 200;
                            //Console.WriteLine("{0} : {1}", c, symbolSum);
                        }
                    }
                }
            }

            Console.WriteLine("{0}\n{1}\n{2}", letterSum, numberSum, symbolSum);
        }
    }
}
