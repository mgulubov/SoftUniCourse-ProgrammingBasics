using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BitLock
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine().Split(' ');

            int[] numbers = new int[8];
            for (int i = 0; i < n.Length; i++)
            {
                numbers[i] = int.Parse(n[i]);
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');
                if (command[0] == "end")
                {
                    break;
                }

                switch (command[0])
                {
                    case "check":
                        {
                            int col = int.Parse(command[1]);
                            int count = 0;
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                int bit = 1 & (numbers[i] >> col);
                                if (bit == 1)
                                {
                                    count++;
                                }
                            }
                            Console.WriteLine(count);
                            break;
                        }
                    default:
                        {
                            int row = int.Parse(command[0]);
                            string direction = command[1];
                            int rotations = int.Parse(command[2]);

                            string num = Convert.ToString(numbers[row], 2).PadLeft(12, '0');
                            if (direction == "left")
                            {
                                for (int i = 0; i < rotations; i++)
                                {
                                    num = num.Substring(1) + num.Substring(0, 1);
                                }
                            }
                            else
                            {
                                //Console.WriteLine(num);
                                for (int i = 0; i < rotations; i++)
                                {
                                    num = num.Substring(num.Length - 1) + num.Substring(0, num.Length - 1);
                                    //Console.WriteLine(num);
                                }
                            }

                            numbers[row] = Convert.ToInt32(num, 2);
                            break;
                        }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
                if (i < numbers.Length - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
