using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SortThreeNumbersWithNestedIfs
{
    class SortThreeNumbersWithNestedIfs
    {
        static void Main(string[] args)
        {
            //No arrays here :(. Well... life sucks and then you die :)

            float num0 = 0f;
            float num1 = 0f;
            float num2 = 0f;

            try
            {
                Console.Write("First Num: ");
                num0 = float.Parse(Console.ReadLine());
                Console.Write("Second Num: ");
                num1 = float.Parse(Console.ReadLine());
                Console.Write("Third Num: ");
                num2 = float.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Uri uri = new Uri("https://www.youtube.com/watch?v=drNI98abVsQ");
                Console.WriteLine("Since you broke it, you will now suffer the squirrely wrath of Foamy the squirle!\n" + 
                                   uri.OriginalString);
                Environment.Exit(1);
            }

            //The great Budha once said: "If you have more than three nested 'if' statements, then your logic is wrong.".
            //Considering that, we'll use a sligthly different approach
            float biggest = num0;
            float middle = num0;
            float smallest = num0;

            //Find the biggest(douche in the Universe :) )
            for (int i = 1; i < 3; i++)
            {
                switch (i)
                {
                    case 1:
                        if (biggest < num1)
                        {
                            biggest = num1;
                        }
                        break;
                    case 2:
                        if (biggest < num2)
                        {
                            biggest = num2;
                        }
                        break;
                }
            }

            //Find the smallest
            for (int i = 1; i < 3; i++)
            {
                switch (i)
                {
                    case 1:
                        if (smallest > num1)
                        {
                            smallest = num1;
                        }
                        break;
                    case 2:
                        if (smallest > num2)
                        {
                            smallest = num2;
                        }
                        break;
                }
            }

            //Find the middle
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        if (biggest == num0)
                        {
                            if (smallest == num1)
                            {
                                middle = num2;
                            }
                            else if (smallest == num2)
                            {
                                middle = num1;
                            }
                        }
                        break;
                    case 1:
                        if (biggest == num1)
                        {
                            if (smallest == num0)
                            {
                                middle = num2;
                            }
                            else if (smallest == num2)
                            {
                                middle = num0;
                            }
                        }
                        break;
                    case 2:
                        if (biggest == num2)
                        {
                            if (smallest == num0)
                            {
                                middle = num1;
                            }
                            else if (smallest == num1)
                            {
                                middle = num0;
                            }
                        }
                        break;
                }
            }
            Console.WriteLine("{0} {1} {2}", biggest, middle, smallest);
            //It would've been much easier with arrays though, even if I had to write the soring algorithm myself :)
        }
    }
}
