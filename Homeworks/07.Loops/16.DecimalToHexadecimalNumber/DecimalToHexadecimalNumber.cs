using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.DecimalToHexadecimalNumber
{
    class DecimalToHexadecimalNumber
    {
        static void Main(string[] args)
        {
            long num = 0;
            try
            {
                Console.Write("Decimal Num: ");
                num = long.Parse(Console.ReadLine());
                if (num < 0)
                {
                    num = long.Parse("Vse oshte nqmam cigari :(");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Mamka mu, veche naistina trqbva da otida za cigari :(");
                Environment.Exit(1);
            }

            if (num == 0)
            {
                Console.WriteLine(0);
                Environment.Exit(0);
            }

            String result = "";
            while (num > 0)
            {
                String n = "";
                long leftOver = num % 16;
                if (leftOver > 9)
                {
                    switch (leftOver)
                    {
                        case 10:
                            n = "A";
                            break;
                        case 11:
                            n = "B";
                            break;
                        case 12:
                            n = "C";
                            break;
                        case 13:
                            n = "D";
                            break;
                        case 14:
                            n = "E";
                            break;
                        case 15:
                            n = "F";
                            break;
                    }
                }
                else
                {
                    n = leftOver.ToString();
                }

                result = n + result;
                num = num / 16;
            }

            Console.WriteLine(result);
        }
    }
}
