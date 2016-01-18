using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02OddAndEvenJumps
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int oddJump = int.Parse(Console.ReadLine());
            int evenJump = int.Parse(Console.ReadLine());

            string evenString = "";
            string oddString = "";
            int count = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (count == 0)
                {
                    oddString += char.ToLower(input[i]).ToString();
                    count++;
                    continue;
                }
                if (input[i].ToString() == " ")
                {
                    count = 1;
                    continue;
                }

                if (count % 2 == 0)
                {
                    evenString += char.ToLower(input[i]).ToString();
                }
                else
                {
                    oddString += char.ToLower(input[i]).ToString();
                }
                count++;
            }

            //Console.WriteLine("{0}\n{1}", oddString, evenString);
            long result = 0;
            count = 1;
            for (int i = 0; i < oddString.Length; i++)
            {
                if (count == oddJump)
                {
                    result *= oddString[i];
                    count = 1;
                    continue;
                }
                result += oddString[i];
                count++;
            }
            Console.WriteLine("Odd: " + Convert.ToString(result, 16).ToUpper());

            result = 0;
            count = 1;
            for (int i = 0; i < evenString.Length; i++)
            {
                if (count == evenJump)
                {
                    result *= evenString[i];
                    count = 1;
                    continue;
                }
                result += evenString[i];
                count++;
            }
            Console.WriteLine("Even: " + Convert.ToString(result, 16).ToUpper());
        }
    }
}
