using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05GameOfBits
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Game Over!")
                {
                    break;
                }

                long num = 0;
                int numPos = 0;
                string numbrAsString = Convert.ToString(number, 2);
                for (int pos = 0; pos < numbrAsString.Length; pos++)
                {
                    long mask = 0;
                    string maskAsString = new string('1', pos);
                    if (pos != 0)
                    {
                        mask = Convert.ToInt64(maskAsString, 2);
                    }
                    long rightBits = num & mask;

                    int tmp = pos + 1;
                    if (command == "Odd")
                    {
                        if (tmp % 2 != 0)
                        {
                            long bit = 1 & number >> pos;
                            //num = bit + num;
                            if (bit == 1)
                            {
                                num = num >> numPos;
                                num = num << (numPos + 1);
                                num = num | ((long)1 << numPos);
                                num = num | rightBits;
                                numPos++;
                                //num = num << 1;
                                //num = num | 1;
                            }
                            else
                            {
                                num = num >> numPos;
                                num = num << (numPos + 1);
                                //num = num | ((long)1 << numPos);
                                num = num | rightBits;
                                numPos++;
                                //num = num << 1;
                            }
                        }
                    }
                    else
                    {
                        if (tmp % 2 == 0)
                        {
                            long bit = 1 & number >> pos;
                            if (bit == 1)
                            {
                                num = num >> numPos;
                                num = num << (numPos + 1);
                                num = num | ((long)1 << numPos);
                                num = num | rightBits;
                                numPos++;
                                //num = num << 1;
                                //num = num | 1;
                            }
                            else
                            {
                                num = num >> numPos;
                                num = num << (numPos + 1);
                                //num = num | ((long)1 << numPos);
                                num = num | rightBits;
                                numPos++;
                                //num = num << 1;
                            }
                        }
                    }
                }
                number = num;
            }

            int bitCount = 0;
            string numAsString = Convert.ToString(number, 2);
            for (int i = 0; i < numAsString.Length; i++)
            {
                if (numAsString[i] == '1')
                {
                    bitCount++;
                }
            }

            Console.WriteLine("{0} -> {1}", number, bitCount);

        }
    }
}
