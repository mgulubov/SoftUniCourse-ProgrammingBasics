using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ProgrammerDNA
{
    class Program
    {
        public static void Main()
        {
            int height = int.Parse(Console.ReadLine());
            string startLetter = Console.ReadLine();

            int width = 7;
            List<string> list = new List<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");
            list.Add("E");
            list.Add("F");
            list.Add("G");

            int letterIndex = list.IndexOf(startLetter);
            int startIndex = 3;
            int endIndex = 3;
            int flag = 0;
            int threeFlag = 0;
            for (int i = 0; i < height; i++)
            {
                if (startIndex == 0)
                {
                    flag = 1;
                }

                if (startIndex == 3)
                {
                    if (threeFlag == 0 && i != 0)
                    {
                        flag = 3;
                        threeFlag++;
                    }
                    else
                    {
                        flag = 0;
                        threeFlag = 0;
                    }

                }
                for (int b = 0; b < width; b++)
                {
                    if ((b >= startIndex && b <= endIndex))
                    {
                        if (letterIndex >= list.Count)
                        {
                            letterIndex = 0;
                        }
                        Console.Write(list[letterIndex]);
                        letterIndex++;
                        continue;
                    }
                    Console.Write(".");
                }
                Console.WriteLine();

                if (flag == 0)
                {
                    startIndex--;
                    endIndex++;
                }
                else if (flag == 3)
                {
                    startIndex = 3;
                    endIndex = 3;
                }
                else
                {
                    startIndex++;
                    endIndex--;
                }
            }
        }
    }
}
