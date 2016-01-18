using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03PandaScotlandFlag
{
    class Program
    {
        private static string _letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static int _letterIndex = 0;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = n;
            int middle = (int)Math.Floor(n / 2m);

            PrintTop(n, width, middle);
            PrintMiddle(n, width, middle);
            PrintBottom(n, width, middle, middle);
        }

        private static void PrintBottom(int n, int width, int height, int middleIndex)
        {
            int leftLetterIndex = middleIndex - 1;
            int rightLetterIndex = middleIndex + 1;
            int leftChar = middleIndex;
            int rightChar = middleIndex;
            for (int i = 0; i < height; i++)
            {
                for (int b = 0; b < width; b++)
                {
                    if (b == leftLetterIndex || b == rightLetterIndex)
                    {
                        Console.Write(GetNextLetter());
                    }
                    else if (b >= leftChar && b <= rightChar)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("~");
                    }
                }
                Console.WriteLine();
                leftLetterIndex--;
                rightLetterIndex++;
                leftChar--;
                rightChar++;
            }
        }

        private static void PrintMiddle(int n, int width, int middle)
        {
            for (int i = 0; i < width; i++)
            {
                if (i == middle)
                {
                    Console.Write(GetNextLetter());
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine();
        }

        private static void PrintTop(int n, int width, int height)
        {
            int leftLetterIndex = 0;
            int rightLetterIndex = width - 1;
            int leftChar = leftLetterIndex + 1;
            int rightChar = rightLetterIndex - 1;
            for (int i = 0; i < height; i++)
            {
                for (int b = 0; b < width; b++)
                {
                    if (b == leftLetterIndex || b == rightLetterIndex)
                    {
                        Console.Write(GetNextLetter());
                    }
                    else if (b >= leftChar && b <= rightChar)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("~");
                    }
                }
                Console.WriteLine();
                leftLetterIndex++;
                rightLetterIndex--;
                leftChar++;
                rightChar--;
            }
        }

        private static string GetNextLetter()
        {
            if (_letterIndex > _letters.Length - 1)
            {
                _letterIndex = 0;
            }
            char result = _letters[_letterIndex];
            _letterIndex++;
            return result.ToString();
        }
    }
}
