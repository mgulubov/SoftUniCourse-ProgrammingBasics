using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.HexadecimalToDecimalNumber
{
    class HexadecimalToDecimalNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Hexadecimal Num: ");
            String hex = Console.ReadLine();

            long result = 0;
            int pow = 0;
            for (int i = hex.Length - 1; i >= 0; i--)
            {
                int num = 0;
                if (char.IsDigit(hex[i]))
                {
                    num = int.Parse(hex[i].ToString());
                }
                else
                {
                    switch (char.ToUpper(hex[i]))
                    {
                        case 'A':
                            num = 10;
                            break;
                        case 'B':
                            num = 11;
                            break;
                        case 'C':
                            num = 12;
                            break;
                        case 'D':
                            num = 13;
                            break;
                        case 'E':
                            num = 14;
                            break;
                        case 'F':
                            num = 15;
                            break;
                        default:
                            Console.WriteLine("Invalid Hexadecimal Number. Only [0-9] && [A-F]. JACKASS");
                            Environment.Exit(1);
                            break;
                    }
                }

                result += num * (long)Math.Pow(16, pow);
                pow++;
            }

            Console.WriteLine(result);
        }
    }
}
