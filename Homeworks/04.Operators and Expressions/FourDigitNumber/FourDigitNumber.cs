using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            String n = ""; //We'll need a string to peform all those nasty operations here. NASTYYYY :p

            try
            {
                Console.Write("ICE CUBE WILL 'YA PASS ME MA' STEEL?! I'M THE KING OF THE HILL (Please provide a number): ");
                n = Console.ReadLine();
            }
            catch (FormatException fe)
            {
                Console.WriteLine("\"Check yourself before you wreck yourself!\"\nDon't break ma' shit now!");
                Environment.Exit(1);
            }

            int sum = calcSum(n);
            String reverseCowGirl = reverseString(n);
            String frontCowGirl = setLastDigitAsFirst(n);
            String pervertedCowGirl = swapSecondAndThirdDigits(n);

            Console.WriteLine("Sum of all SUMS :): {0}\n" +
                              "Reverse: {1}\n" +
                              "Last digit in front: {2}\n" +
                              "Second and Third changed: {3}",
                              sum, reverseCowGirl, frontCowGirl, pervertedCowGirl);
        }

        private static String swapSecondAndThirdDigits(String str)
        {
            String tmp = str[1].ToString();
            str = str.Remove(1, 1);
            str = str.Insert(2, tmp);

            return str;
        }

        private static String setLastDigitAsFirst(String str) 
        {
            String tmp = str[str.Length - 1].ToString();
            str = str.Remove(str.Length - 1);
            str = tmp + str;

            return str;
        }

        private static String reverseString(String str)
        {
            String result = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i].ToString();
            }

            return result;
        }

        private static int calcSum(String str)
        {
            int result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                result += int.Parse(str[i].ToString());
            }

            return result;
        }
    }
}
