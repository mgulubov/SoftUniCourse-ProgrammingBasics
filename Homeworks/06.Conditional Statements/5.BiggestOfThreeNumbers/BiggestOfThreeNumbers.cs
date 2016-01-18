using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BiggestOfThreeNumbers
{
    class BiggestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            float[] floatArray = new float[3];

            try
            {
                Console.Write("First Num: ");
                floatArray[0] = float.Parse(Console.ReadLine());
                Console.Write("Second Num: ");
                floatArray[1] = float.Parse(Console.ReadLine());
                Console.Write("Third Num: ");
                floatArray[2] = float.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.Write("Uhhm... You shouldn't break my program!\nBreaking my program is baaad... M'kaaay");
                Environment.Exit(1);
            }

            float biggest = floatArray[0];
            for (int i = 0; i < floatArray.Length - 1; i++) //We only need two comparisons here
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
