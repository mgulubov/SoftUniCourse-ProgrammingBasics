using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourseHomework
{
    class Homework1Mathematics
    {
        private static int[] getPrimesWithinRange(int range)
        {
            if (range <= 0)
            {
                throw new ArgumentOutOfRangeException("range can't be <= 0");
            }

            int[] result = new int[range]; //Too big. Will shrink later
            int resultCount = 0;
            for (int i = 0; i <= range; i++)
            {
                if (isPrime(i))
                {
                    result[resultCount] = i;
                    resultCount++;
                }
            }

            //Shrinking
            int[] tmpArr = new int[resultCount];
            Array.Copy(result, tmpArr, resultCount);
            result = tmpArr;
            //

            return result;
        }

        private static Boolean isPrime(int number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }

            if (number == 2 || number == 3)
            {
                return true;
            }

            if (canBeDividedBy(number, 2) || canBeDividedBy(number, 3))
            {
                return false;
            }

            if (number > 5 && canBeDividedBy(number, 5))
            {
                return false;
            }

            int squareRoot = (int)Math.Sqrt(number);
            for (int i = 3; i <= squareRoot; i++)
            {
                if (isPrime(i) && canBeDividedBy(number, i))
                {
                    return false;
                }
            }

            return true;
        }

        private static Boolean canBeDividedBy(int number, int divider)
        {
            int result = number % divider;
            if (result == 0)
            {
                return true;
            }

            return false;
        }

        private static int[] getFibonacciSequenceWithinRange(int range)
        {
            if (range < 2)
            {
                throw new ArgumentOutOfRangeException("can't have a fibonachi sequence with less than 2 numbers");
            }

            int[] result = new int[range]; //Again - too big
            int actualSize = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    result[i] = i;
                    continue;
                }

                result[i] = (result[i - 1]) + (result[i - 2]);
                if (result[i] >= range)
                {
                    actualSize = i + 1;
                    break;
                }
            }

            //Shrinking
            int[] tmpArr = new int[actualSize];
            Array.Copy(result, 0, tmpArr, 0, actualSize);
            result = tmpArr;
            //

            return result;
        }

        private static void arrayContains(int[] array, params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int leftNumber = numbers[i];
                for (int b = 0; b < array.Length; b++)
                {
                    int rightNumber = array[b];
                    if (leftNumber == rightNumber)
                    {
                        Console.WriteLine(leftNumber + " IS found within the Fibonacci sequence." + 
                            " Posittion: " + b + "(counting from 0).");
                        break;
                    }
                    else if (b == array.Length - 1)
                    {
                        Console.WriteLine(leftNumber + " is NOT found within the Fibonacci sequence.");
                    }
                }
            }
        }

        private static int[] factorialOf(int number)
        {
            int[] result = new int[number * 2]; //Too big. Will remove NULL values later
            int total = 0;
            int rem = 0;
            int count = 0;
            int index = result.Length - 1;
            result[index] = 1;
            for (count = 2; count <= number; count++)
            {
                while (index > 0)
                {
                    total = result[index] * count + rem;
                    rem = 0;
                    if (total > 9)
                    {
                        result[index] = total % 10;
                        rem = total / 10;
                    }
                    else
                    {
                        result[index] = total;
                    }
                    index--;
                }

                total = 0;
                rem = 0;
                index = result.Length - 1;
            }

            result = removeNullElementsFrom(result); //Removing NULL values. Gotta look presentable

            return result;
        }

        private static int[] removeNullElementsFrom(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    count++;
                    continue;
                }

                break;
            }

            if (count > 0)
            {
                int size = array.Length - count;
                int[] tmpArr = new int[size];
                Array.Copy(array, count, tmpArr, 0, size);
                array = tmpArr;
            }

            return array;
        }

        private static String[] removeNullElementsFrom(String[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    count++;
                    continue;
                }

                break;
            }

            if (count > 0)
            {
                int size = array.Length - count;
                String[] tmpArr = new String[size];
                Array.Copy(array, count, tmpArr, 0, size);
                array = tmpArr;
            }

            return array;
        }

        private static String arrayToString(int[] array)
        {
            String result = "";
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i].ToString();
            }

            return result;
        }

        private static String arrayToString(char[] array)
        {
            String result = "";
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i].ToString();
            }

            return result;
        }

        private static String arrayToString(String[] array)
        {
            String result = "";
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i].ToString();
            }

            return result;
        }

        private static float findHypotenuse(int leg1, int leg2)
        {
            if (leg1 <= 0 || leg2 <= 0)
            {
                throw new ArgumentOutOfRangeException("gotta have both legs for this one");
            }

            float result = (float)Math.Sqrt((leg1 * leg1) + (leg2 * leg2));
            result = (float)(Math.Round((double)result, 2)); //Round to two decimal places. Gotta look good BLING BLING

            return result;
        }

        private static int[] decimalToBinary(int number)
        {
            int[] result = new int[32];
            int index = result.Length - 1;
            while (number > 0)
            {
                int leftOver = number % 2;
                result[index] = leftOver;
                number = number / 2;
                index--;
            }

            result = removeNullElementsFrom(result);

            return result;
        }

        private static String[] decimalToHexadecimal(int number)
        {
            String[] result = new String[32];
            int index = result.Length - 1;
            while (number > 0)
            {
                int leftOver = (int)number % 16;
                if (leftOver > 9)
                {
                    switch (leftOver)
                    {
                        case 10:
                            result[index] = "A";
                            break;
                        case 11:
                            result[index] = "B";
                            break;
                        case 12:
                            result[index] = "C";
                            break;
                        case 13:
                            result[index] = "D";
                            break;
                        case 14:
                            result[index] = "E";
                            break;
                        case 15:
                            result[index] = "F";
                            break;
                    }
                }
                else
                {
                    result[index] = leftOver.ToString();
                }

                number = number / 16;
                index--;
            }

            result = removeNullElementsFrom(result);

            return result;
        }

        private static int binaryToDecimal(int number)
        {
            return Convert.ToInt32(number.ToString(), 2); //Casting from str to int suxx and changes bin to dec. Need to practice that. Burn in hell MS

            /**String numStr = number.ToString();
            int[] intArray = new int[numStr.Length];
            for (int i = 0; i < numStr.Length; i++)
            {
                intArray[i] = (int)(numStr[i] - '0');
            }

            int result = 1 * intArray[intArray.Length - 1];
            int power = 1;
            for (int i = intArray.Length - 2; i >= 0; i--)
            {
                if (power == 1)
                {
                    result += 2 * intArray[i];
                    continue;
                }

                int decNum = 2;
                for (int count = 0; count < power; count++)
                {
                    decNum *= 2;
                }

                result += decNum * intArray[i];
                power++;
            }

                return result;**/
        }

        private static int hexadecimalToDecimal(String number)
        {
            return Convert.ToInt32(number, 16); //Casting from str to int suxx and changes bin to dec. Need to practice that. Burn in hell MS
        }

        private static int findLcm(int[] array)
        {
            if (array.Length != 2)
            {
                throw new ArgumentException("array needs 2 numbers");
            }

            int leftNum, rightNum;
            if (array[0] > array[1])
            {
                leftNum = array[0];
                rightNum = array[1];
            }
            else
            {
                leftNum = array[1];
                rightNum = array[0];
            }

            for (int i = 1; i <= rightNum; i++)
            {
                if ((leftNum * i) % rightNum == 0)
                {
                    return leftNum * i;
                }
            }

            return rightNum;
        }

        public static void Main(string[] args)
        {   
            int primesRange = 1597;
            int[] primes = getPrimesWithinRange(primesRange);
            if (primes.Length < 251)
            {
                Console.WriteLine("You need to specify a bigger range. I suggest >= 1597 ;)");
                Environment.Exit(0);
            }
            Console.Write("24th Prime(counting from 1) is: " + primes[23] + "\n" +
                          "101st Prime(counting from 1) is: " + primes[100] + "\n" +
                          "251st Prime(counting from 1) is: " + primes[250] + "\n");

            int[] fib = getFibonacciSequenceWithinRange(primesRange);
            arrayContains(fib, primes[23], primes[100], primes[250]);

            int[] facNumbers = new int[] { 100, 171, 250 };
            for (int i = 0; i < facNumbers.Length; i++)
            {
                int facNumber = facNumbers[i];
                Console.WriteLine("Factorial of " + facNumber + " is: " + arrayToString(factorialOf(facNumber)));
            }

            int[] cathsPair1 = new int[] { 3, 4 };
            int[] cathsPair2 = new int[] { 10, 12 };
            int[] cathsPair3 = new int[] { 100, 250 };

            Console.WriteLine("Hyponenuse for caths " + cathsPair1[0] + " and " + cathsPair1[1] +
                             " is: " + findHypotenuse(cathsPair1[0], cathsPair1[1]));
            Console.WriteLine("Hyponenuse for caths " + cathsPair2[0] + " and " + cathsPair2[1] +
                             " is: " + findHypotenuse(cathsPair2[0], cathsPair2[1]));
            Console.WriteLine("Hyponenuse for caths " + cathsPair3[0] + " and " + cathsPair3[1] +
                             " is: " + findHypotenuse(cathsPair3[0], cathsPair3[1]));
            
            int num1 = 1234;
            Console.WriteLine(num1 + " in Binary: " + arrayToString(decimalToBinary(num1)));
            Console.WriteLine(num1 + " in Hexadecimal: " + arrayToString(decimalToHexadecimal(num1)));

            int num2 = 1100101;
            Console.WriteLine(num2 + " in decimal: " + binaryToDecimal(num2));
            Console.WriteLine(num2 + " in Hexadecimal: " + arrayToString(decimalToHexadecimal(binaryToDecimal(num2))));

            String num3 = "ABC";
            Console.WriteLine(num3 + " in decimal: " + hexadecimalToDecimal(num3));
            Console.WriteLine(num3 + " in binary: " + arrayToString(decimalToBinary(hexadecimalToDecimal(num3))));

            int[] lcmArr = new int[] { 1234, 3456};
            int lcm = findLcm(lcmArr);
           
            Console.WriteLine("The LCM of " + lcmArr[0] + " and " + lcmArr[1] + " is: " + lcm);
            Console.WriteLine(DateTime.Now);
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine(DateTime.Now);
        }
    }
}
