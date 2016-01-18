using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            int n = 0;
            try
            {
                Console.Write("So babe, what you wanna do tonight?\n" +
                "What was that? Calculate the sum of random numbers, over and over and over again?\n" +
                "Sure that sounds like fun. Who needs sex anyway, right?!\n" +
                "Soooo, how many numbers we'll sum this time: ");
                n = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("DON'T DO DRUGS!");
                Environment.Exit(1);
            }

            float[] floatArr = new float[n];
            for (int i = 0; i < floatArr.Length; i++)
            {
                try
                {
                    Console.Write("What's the " + (i + 1) + " number: ");
                    floatArr[i] = float.Parse(Console.ReadLine());
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Drugs are baaaaaad, m'kaaaay!");
                    Environment.Exit(1);
                }
            }

            float result = 0f;
            for (int i = 0; i < floatArr.Length; i++)
            {
                result += float.Parse(floatArr[i].ToString());
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
