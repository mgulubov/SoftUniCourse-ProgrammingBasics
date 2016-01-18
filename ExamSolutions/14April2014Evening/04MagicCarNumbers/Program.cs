using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04MagicCarNumbers
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            int sum = 0;
            for (int d1 = 0; d1 < 10; d1++)
            {
                for (int d2 = 0; d2 < 10; d2++)
                {
                    for (int d3 = 0; d3 < 10; d3++)
                    {
                        for (int d4 = 0; d4 < 10; d4++)
                        {
                            for (int l1 = 0; l1 < 10; l1++)
                            {
                                int leftLetter = GetIntLetter(l1);
                                for (int l2 = 0; l2 < 10; l2++)
                                {
                                    int rightLetter = GetIntLetter(l2);
                                    sum = d1 + d2 + d3 + d4 + leftLetter + rightLetter + 30 + 10;

                                    //Pattern I
                                    if (d1 == d2 && d2 == d3 && d3 == d4)
                                    {
                                        if (sum == n)
                                        {
                                            count++;
                                            continue;
                                        }
                                    }

                                    //Pattern II
                                    if (d1 != d2 && d2 == d3 && d3 == d4)
                                    {
                                        if (sum == n)
                                        {
                                            count++;
                                            continue;
                                        }
                                    }

                                    //Pattern III
                                    if (d1 == d2 && d2 == d3 && d3 != d4)
                                    {
                                        if (sum == n)
                                        {
                                            count++;
                                            continue;
                                        }
                                    }

                                    //Pattern IV
                                    if (d1 == d2 && d2 != d3 && d3 == d4)
                                    {
                                        if (sum == n)
                                        {
                                            count++;
                                            continue;
                                        }
                                    }

                                    //Pattern V
                                    if (d1 == d3 && d2 != d3 && d2 == d4)
                                    {
                                        if (sum == n)
                                        {
                                            count++;
                                            continue;
                                        }
                                    }

                                    //Pattern VI
                                    if (d1 == d4 && d1 != d2 && d2 == d3)
                                    {
                                        if (sum == n)
                                        {
                                            count++;
                                            continue;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(count);
        }

        private static int GetIntLetter(int l)
        {
            int leftLetter = 0;
            switch (l)
            {
                case 0:
                    {
                        leftLetter = 10;
                        break;
                    }
                case 1:
                    {
                        leftLetter = 20;
                        break;
                    }
                case 2:
                    {
                        leftLetter = 30;
                        break;
                    }
                case 3:
                    {
                        leftLetter = 50;
                        break;
                    }
                case 4:
                    {
                        leftLetter = 80;
                        break;
                    }
                case 5:
                    {
                        leftLetter = 110;
                        break;
                    }
                case 6:
                    {
                        leftLetter = 130;
                        break;
                    }
                case 7:
                    {
                        leftLetter = 160;
                        break;
                    }
                case 8:
                    {
                        leftLetter = 200;
                        break;
                    }
                case 9:
                    {
                        leftLetter = 240;
                        break;
                    }
            }
            return leftLetter;
        }
    }
}
