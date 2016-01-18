using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BitBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            while (true)
            {
                int pos = 0;
                try
                {
                    pos = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    break;
                }
                string command = Console.ReadLine();
                if (command == "quit")
                {
                    break;
                }
                if (command == "skip")
                {
                    continue;
                }

                long mask = 0;
                string stringAsMask = new string('1', pos);
                if (pos != 0)
                {
                    mask = Convert.ToInt64(stringAsMask, 2);
                }

                switch (command)
                {
                    case "flip":
                        {
                            num = num ^ (1 << pos);
                            break;
                        }
                    case "insert":
                        {
                            long rightBits = num & mask;
                            num = num >> pos;
                            num = num << (pos + 1);
                            num = num | ((long)1 << pos);
                            num = num | rightBits;
                            break;
                        }
                    case "remove":
                        {
                            long rightBits = num & mask;
                            num = num >> (pos + 1);
                            num = num << pos;
                            num = num | rightBits;
                            break;
                        }
                }
            }

            Console.WriteLine(num);
        }
    }
}
