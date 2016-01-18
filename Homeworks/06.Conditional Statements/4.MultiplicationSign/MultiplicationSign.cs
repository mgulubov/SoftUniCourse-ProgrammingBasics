using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            float[] floatArray = new float[3];

            try
            {
                //Can optimize it if we run some checks after each submission, but that's not the point of the excersice
                Console.Write("First num: ");
                floatArray[0] = float.Parse(Console.ReadLine());
                Console.Write("Second num: ");
                floatArray[1] = float.Parse(Console.ReadLine());
                Console.Write("Third num: ");
                floatArray[2] = float.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.Write("You broke it :(. \nWHY?! WHY DID YOU BRAKE IT?! :(((");
                Environment.Exit(1);
            }

            int minusCount = 0;
            for (int i = 0; i < floatArray.Length; i++)
            {
                if (floatArray[i] == 0)
                {
                    print("0");
                    break;
                }

                if (floatArray[i] < 0)
                {
                    minusCount++;
                }
            }

            if (minusCount == 0)
            {
                print("+");
            }
            else if (minusCount == 1 || minusCount == 3)
            {
                print("-");
            }
            else
            {
                print("+");
            }
        }

        private static void print(String result)
        {
            Console.WriteLine(result);
            Environment.Exit(0);
        }
    }
}
