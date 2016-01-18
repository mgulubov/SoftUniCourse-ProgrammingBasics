using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.BiggestOfFiveNumbers
{
    class BiggestOfFiveNumbers
    {
        static void Main(string[] args)
        {
            //The same as with three numbers, but with a bigger array
            float[] floatArray = new float[5];

            try
            {
                Console.Write("First Num: ");
                floatArray[0] = float.Parse(Console.ReadLine());
                Console.Write("Second Num: ");
                floatArray[1] = float.Parse(Console.ReadLine());
                Console.Write("Third Num: ");
                floatArray[2] = float.Parse(Console.ReadLine());
                Console.Write("Fourth Num: ");
                floatArray[3] = float.Parse(Console.ReadLine());
                Console.Write("Fifth Num: ");
                floatArray[4] = float.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.Write("DRINK RESPONSIBLY");
                Environment.Exit(1);
            }

            float biggest = floatArray[0];
            for (int i = 0; i < floatArray.Length - 1; i++) //We only need four comparisons here
            {
                if (floatArray[i + 1] > biggest)
                {
                    biggest = floatArray[i + 1];
                }
            }

            Console.WriteLine(biggest);
        }
    }
}
