using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04EncryptedMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string direction = Console.ReadLine();

            string convertedMessage = "";
            for (int i = 0; i < message.Length; i++)
            {
                char c = message[i];
                byte[] bits = Encoding.ASCII.GetBytes(c.ToString());
                String asciiNum = "";
                for (int b = 0; b < bits.Length; b++)
                {
                    asciiNum += bits[b].ToString();
                }
                convertedMessage += asciiNum[asciiNum.Length - 1];
            }

            //Console.WriteLine(convertedMessage);
            string result = "";
            for (int i = 0; i < convertedMessage.Length; i++)
            {
                int digit = int.Parse(convertedMessage[i].ToString());
                if (digit % 2 == 0 || digit == 0)
                {
                    digit *= digit;
                }
                else
                {
                    int previosIndex = i - 1;
                    int nextIndex = i + 1;
                    int prevNum = 0;
                    int nextNum = 0;
                    if (previosIndex < 0)
                    {
                        prevNum = 0;
                    }
                    else
                    {
                        prevNum = int.Parse(convertedMessage[previosIndex].ToString());
                    }

                    if (nextIndex > convertedMessage.Length - 1)
                    {
                        nextNum = 0;
                    }
                    else
                    {
                        nextNum = int.Parse(convertedMessage[nextIndex].ToString());
                    }

                    digit += prevNum;
                    digit += nextNum;
                }
                result += digit.ToString();
            }

            //Console.WriteLine(result);
            int height = result.Length;
            int width = result.Length;
            if (direction == "\\")
            {
                int colIndex = 0;
                int numIndex = 0;
                for (int row = 0; row < height; row++)
                {
                    for (int col = 0; col < width; col++)
                    {
                        if (col == colIndex)
                        {
                            Console.Write(result[numIndex]);
                        }
                        else
                        {
                            Console.Write("0");
                        }

                        if (col < width - 1)
                        {
                            Console.Write(" ");
                        }
                    }
                    colIndex++;
                    numIndex++;
                    Console.WriteLine();
                }
            }
            else
            {
                int colIndex = width - 1;
                int numIndex = result.Length - 1;
                for (int row = 0; row < height; row++)
                {
                    for (int col = 0; col < width; col++)
                    {
                        if (col == colIndex)
                        {
                            Console.Write(result[numIndex]);
                        }
                        else
                        {
                            Console.Write("0");
                        }
                        if (col < width - 1)
                        {
                            Console.Write(" ");
                        }
                    }
                    colIndex--;
                    numIndex--;
                    Console.WriteLine();
                }
            }
        }
    }
}
