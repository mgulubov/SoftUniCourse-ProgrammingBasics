using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SumOfFiveNumbers
{
    class SumOfFiveNumbers
    {
        static void Main()
        {
            String numbers = "";
            try
            {
                Console.Write("Please show me your numbers, my special little friend: ");
                numbers = Console.ReadLine();
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Wow, you managed to broke it?!\nYou trully are SPECIAL. Very, very SPECIAL\n" +
                "Like... Forrest Gump Special ;)");
                Environment.Exit(1);
            }

            numbers = numbers.Trim();
            numbers = numbers.Replace(" ", "|");

            float[] numArray = stringToFloatArray(numbers);

            float result = 0f;
            for (int i = 0; i < numArray.Length; i++)
            {
                result += float.Parse(numArray[i].ToString());
                // Console.WriteLine(numArray[i].ToString());
            }

            Console.WriteLine("Result: " + result);
        }

        private static float[] stringToFloatArray(String str)
        {
            int startIndex = 0;
            int endIndex = 0;
            int numberOfNumbers = 0;
            String number = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == "|")
                {
                    numberOfNumbers++;
                }
            }

            if (numberOfNumbers != 0)
            {
                numberOfNumbers++;
            }

            float[] result = new float[numberOfNumbers];
            int resultIndex = 0;
            for (int i = 0; i <= str.Length; i++)
            {
                while (endIndex < str.Length && str[endIndex].ToString() != "|")
                {
                    endIndex++;
                }

                int length = endIndex - startIndex;
                number = str.Substring(startIndex, length);

                //Console.WriteLine(number);

                result[resultIndex] = float.Parse(number);
                resultIndex++;
                endIndex++;
                startIndex = endIndex;
                i = startIndex;
            }

            return result;
        }
    }
}
