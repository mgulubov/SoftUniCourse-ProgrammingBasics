using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            float firstNumber = 0;
            float secondNumber = 0;
            try
            {
                Console.Write("First Number. That will be the number that comes first, or otherwise said- the number that comes before all other numbers and by other numbers I mean all numbers which will come after the first one, which is the number that you are supposed to provide right now: ");
                firstNumber = float.Parse(Console.ReadLine());

                Console.Write("Second Number. That is the number that comes second, or to put it differently- it will be the number which comes after the one that you provided before which was also the first number that you provided and since it was provided it was counted as first, so any numbers that come after it will be considered to come after the first and since this particular number, the second number, comes after the first number that you provided and also comes before any other numbers that you might provide, is thus considered second: ");
                secondNumber = float.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Unsupported format. That will be a format which is not supported, implemented, or in any other way recognized by this program, which works with only a handful of formats and since this format in particular was not found, within the forementioned handful, it is thus considered unsopported by the program in question, which is the program that you are trying to run right now, with a format that is not supported by it!");
                Environment.Exit(1);
            }

            float biggestNum = firstNumber > secondNumber ? biggestNum = firstNumber : biggestNum = secondNumber;

            Console.WriteLine("The biggest of the biggest: " + biggestNum);
        }
    }
}
