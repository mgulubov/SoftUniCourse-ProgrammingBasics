using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumbersInIntervalDividableByGivenNumber
{
    class NumbersInIntervalDividableByGivenNumber
    {
        static void Main(string[] args)
        {
            int leftInt = 0;
            int rightInt = 0;
            try
            {
                Console.WriteLine("This is a star problem, so don't fuck it up by giving me negative, or non-integer bullshits, ALRIGHT!!! :P");
                Console.Write("So, what's the first number: ");
                leftInt = int.Parse(Console.ReadLine());
                checkIfPositive(leftInt);

                Console.Write("YESSS, you did't fuck it up :). Going on, then. What's the second number: ");
                rightInt = int.Parse(Console.ReadLine());
                checkIfPositive(rightInt);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("I knew that you will fuck up! I just know it. I had that gut feeling about it.\n" +
                    "Well, it's either that, or it's an upcoming diarrhea sensation.\n" + 
                    "In any case, you should try again:)");
                Environment.Exit(1);
            }

            int count = 0;
            for (int i = leftInt; i <= rightInt; i++)
            {
                //I'm too lazy so I'm not going to optimize this one bit :P
                //Yes, yes, I know, I'm a sucky programmer. Keep it to yourself mate :D
                Boolean checkFive = i % 5 == 0;
                if (checkFive == true)
                {
                    count++;
                }
            }

            Console.WriteLine("\nP is... hehe \"pee\" :D. I'm sorry, It's late(early) and I'm listening to the American McGee's Alice's OST :D\n: " + 
                "Aaaaanywaaaaay, THE LONG AWAITED ANSWER IIIIIISSS: " + count);
        }

        private static void checkIfPositive(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("I knew that you will fuck up! I just know it. I had that gut feeling about it.\n" +
                    "Well, it's either that, or it's an upcoming diarrhea sensation.\n" +
                    "In any case, you should try again:)");
                Environment.Exit(1);
            }
        }
    }
}
