using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02SpyHard
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            char[] message = Console.ReadLine().ToCharArray();

            int sum = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsLetter(message[i]))
                {
                    sum += char.ToUpper(message[i]) - 64;
                    continue;
                }

                byte[] bits = Encoding.ASCII.GetBytes(message[i].ToString());
                String asciiNum = "";
                for (int b = 0; b < bits.Length; b++)
                {
                    asciiNum += bits[b].ToString();
                }
                sum += int.Parse(asciiNum);
            }

            string result = key.ToString() + message.Length.ToString() + DecimalToArbitrarySystem(sum, key);

            Console.WriteLine(result);
        }

        public static string DecimalToArbitrarySystem(long decimalNumber, int radix)
        {
            const int bitsInLong = 64;
            const string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (radix < 2 || radix > digits.Length)
                throw new ArgumentException("The radix must be >= 2 and <= " + digits.Length.ToString());

            if (decimalNumber == 0)
                return "0";

            int index = bitsInLong - 1;
            long currentNumber = Math.Abs(decimalNumber);
            char[] charArray = new char[bitsInLong];

            while (currentNumber != 0)
            {
                int remainder = (int)(currentNumber % radix);
                charArray[index--] = digits[remainder];
                currentNumber = currentNumber / radix;
            }

            string result = new String(charArray, index + 1, bitsInLong - index - 1);
            if (decimalNumber < 0)
            {
                result = "-" + result;
            }

            return result;
        }
    }
}
