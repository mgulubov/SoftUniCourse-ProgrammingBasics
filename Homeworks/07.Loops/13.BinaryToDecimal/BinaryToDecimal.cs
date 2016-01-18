using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Binary Number: ");
            String bin = Console.ReadLine();

            long result = 0;
            int pow = 0;
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                int num = (int)Math.Pow(2, pow);
                pow++;
                result += num * long.Parse(bin[i].ToString());
            }

            Console.WriteLine(result);
        }
    }
}
