using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartMe
{
    class StartMe
    {
        static void Main(string[] args)
        {
            declareVariables();
            floatOrDouble();
            variableInHexadecimalFormat();
            uncodeCharacter();
            booleanVariable();
            stringsAndObjects();
            quotesInStrings();
            isoscelesTriangle();
            exchangeVariableValues();
            employeeData("InEEd", "M$neY");
            bankAccountData();
            nullValuesArithmetics();
            comparingFloats();
            printAsciiTable();
        }

        private static void printAsciiTable()
        {   
            int count = 0;
            for (int i = 0; i < 255; i++)
            {
                if (count == 19)
                {
                    Console.WriteLine();
                    count = 0;
                }

                Console.OutputEncoding = Encoding.Unicode;
                Console.Write((char)i + " ");
                count++;
            }
            Console.WriteLine();
        }

        private static void comparingFloats()
        {
            double[] numArray = getNumbersFromUser();
            double esp = 0.000001;
            Boolean areEqual = numsAreEqual(numArray[0], numArray[1], esp);

            if (areEqual)
            {
                Console.WriteLine("{0} is equal to {1}", numArray[0].ToString(), numArray[1].ToString());
            }
            else
            {
                Console.WriteLine("{0} is NOT equal to {1}", numArray[0].ToString(), numArray[1].ToString());
            }
        }

        private static Boolean numsAreEqual(double leftNum, double rightNum, double esp)
        {
            double leftMinusRight = leftNum - rightNum;
            if (leftMinusRight < 0)
            {
                leftMinusRight = -(leftMinusRight);
            }

            if (leftMinusRight > esp)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static double[] getNumbersFromUser()
        {
            double[] result = new double[2];

            Console.Write("Give me the first Number to compare: ");
            result[0] = double.Parse(Console.ReadLine());
            Console.Write("Give me the second Number to compare: ");
            result[1] = double.Parse(Console.ReadLine());

            return result;
        }

        private static void nullValuesArithmetics()
        {
            int nullInt = 0;
            double nullDouble = 0;

            Console.WriteLine("Null(0) int: {0}\n" +
                              "Null(0) double: {1}",
                              nullInt, nullDouble);

            //We want the exception case here.
            try
            {
                //We'll do it like that, in order to avoid compilation errors
                nullInt = int.Parse(null);
                nullDouble = double.Parse(null);
                //

                Console.WriteLine("Null(null) int: {0}\n" +
                              "Null(null) double: {1}",
                              nullInt, nullDouble);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Assigning NULL values to int and double variables throws an ArgumentNullException!\n" +
                                  "This reminds me of an ancient Chineese haiku poem entitled: \n" + 
                                  @"""He who watches for null values fears not!""");
            }
            //
        }

        private static void bankAccountData()
        {
            String firstname = "Tragic";
            String middleName = "Quntin";
            String lastname = "Brawnson";
            float availableAmount = 13.03f;
            String bankName = "AaaaaandItsGone Bank";
            String iban = "BG13 1313 1313 1313 1313 1313 313";
            long visaCardNum = 1313131313131313;
            long masterCardNum = 3131313131313131;
            long americanSuxPressCardNum = 3311113333111133;

            Console.WriteLine("First Name: {0}\n" +
                              "Middle Name: {1}\n" +
                              "Last Name: {2}\n" +
                              "Available Balance: {3}\n" +
                              "Bank Name: {4}\n" +
                              "IBAN: {5}\n" +
                              "Flisa Card Number: {6}\n" +
                              "Faster Card Number: {7}\n" +
                              "American SuxxPress Card Number: {8}", 
                              firstname, middleName, lastname, availableAmount, 
                              bankName, iban, visaCardNum, masterCardNum, americanSuxPressCardNum);
        }

        private static void employeeData(String fName, String lName)
        {
            char[] firstName = new char[fName.Length];
            char[] lastName = new char[lName.Length];
            byte age = 27;
            char gender = 'm';
            long parsonalId = 8711081313;
            int uniqEmployeeNum = 13131313;

            for (int i = 0; i < firstName.Length; i++)
            {
                firstName[i] = fName[i];
            }

            for (int i = 0; i < lastName.Length; i++)
            {
                lastName[i] = lName[i];
            }

            Console.Write("First Name: ");
            for (int i = 0; i < firstName.Length; i++)
            {
                Console.Write(firstName[i].ToString());
                if (i == firstName.Length - 1)
                {
                    Console.Write("\n");
                }
            }

            Console.Write("Last Name: ");
            for (int i = 0; i < lastName.Length; i++)
            {
                Console.Write(lastName[i].ToString());
                if (i == lastName.Length - 1)
                {
                    Console.Write("\n");
                }
            }

            Console.WriteLine("Age: {0}\n" +
                              "Gender: {1}\n" +
                              "Personal ID: {2}\n" +
                              "Unique Employee Number: {3}",
                              age, gender, parsonalId, uniqEmployeeNum);

        }

        private static void exchangeVariableValues()
        {   
            int a = 5;
            int b = 10;

            Console.WriteLine("a: {0}\nb: {1}", a, b);

            int tmp = a;
            a = b;
            b = tmp;

            Console.WriteLine("a: {0}\nb: {1}", a, b);
        }

        private static void isoscelesTriangle()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Had to change the console fonts to Lucida Fonts, which SUCKS");
            Console.WriteLine();
            Console.WriteLine("    ©\n" +
                              "   © ©\n" +
                              "  ©   © \n" +
                              " © © © ©");
        }

        private static void quotesInStrings()
        {
            String withQuotedStrings = @"The ""use"" of quotations causes diffculties.";
            String withoutQuotedStrings = "The \"use\" of quotations causes difficulties";

            Console.WriteLine("With Quoted Strings: {0}\n" +
                              "Without Quoted Strings: {1}"
                              , withQuotedStrings, withoutQuotedStrings);
        }

        private static void stringsAndObjects()
        {
            String hello = "Hello";
            String world = "World";
            Object helloWorld = hello + " " + world + "!";
            String result = helloWorld.ToString();

            Console.WriteLine(result);
        }

        private static void booleanVariable()
        {
            Boolean isFemale = false;

            Console.WriteLine("Female?: {0}", isFemale);
        }

        private static void uncodeCharacter()
        {
            String hex = convertToHexadecimal(42);
            char ch = (char)(Convert.ToInt32(hex, 16));

            Console.WriteLine("char: {0}", ch.ToString());
        }

        private static void variableInHexadecimalFormat()
        {
            String hex = convertToHexadecimal(254);
            int value = Convert.ToInt32(hex, 16);

            Console.WriteLine("254: {0}", value);
        }

        private static String convertToHexadecimal(int value)
        {
            return value.ToString("X");
        }

        private static void declareVariables()
        {
            //52130, -115, 4825932, 97, -10000
            byte myByte = 97;
            sbyte mySByte = -115;
            short myShort = -10000;
            int myUint = 52130;
            int mySecondInt = 4825932;

            Console.WriteLine("byte: {0}\n" + 
                "sbyte: {1}\nshort: " + 
                "{2}\nint: {3}\n" + 
                "second int: {4}", myByte, mySByte, myShort, myUint, mySecondInt);
        }

        private static void floatOrDouble()
        {
            //34.567839023, 12.345, 8923.1234857, 3456.091
            double myFirstDouble = 34.567839023;
            float myFirstFloat = 12.345F;
            double mySecondDouble = 8923.1234857;
            float mySecondFloat = 3456.091F;

            Console.WriteLine("FirstDouble: {0}\n" +
                "FirstFloat: {1}\n" +
                "SecondDouble: {2}\n" +
                "SecondFloat: {3}", myFirstDouble, myFirstFloat, mySecondDouble, mySecondFloat);
        }
    }
}
