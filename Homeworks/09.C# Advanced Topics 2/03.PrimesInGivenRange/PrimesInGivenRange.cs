using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _03.PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            //int start = 0;
            int start = int.Parse(Console.ReadLine());
            int end = 0;
            try
            {
                Console.Write("Start: ");
                start = int.Parse(Console.ReadLine());
                Console.Write("End: ");
                end = int.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid value");
                Environment.Exit(1);
            }
            if (start > end)
            {
                Console.WriteLine("(empty List)");
                Environment.Exit(0);
            }

            ArrayList list = getPrimesInRange(start, end);

            printList(list);
        }

        private static void printList(ArrayList list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("(empty List)");
                return;
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if (i < list.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        private static ArrayList getPrimesInRange(int startIndex, int endIndex)
        {
            ArrayList result = new ArrayList((endIndex - startIndex) + 1);
            while (startIndex <= endIndex)
            {
                if (isPrime(startIndex))
                {
                    result.Add(startIndex);
                }
                startIndex++;
            }

            return result;
        }

        private static bool isPrime(long n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }

            if (n == 2 || n == 3)
            {
                return true;
            }

            if (canBeDividedBy(n, 2) || canBeDividedBy(n, 3))
            {
                return false;
            }

            if (n > 5 && canBeDividedBy(n, 5))
            {
                return false;
            }

            int squareRoot = (int)Math.Sqrt(n);
            for (int i = 3; i <= squareRoot; i++)
            {
                if (isPrime(i) && canBeDividedBy(n, i))
                {
                    return false;
                }
            }

            return true;
        }

        private static Boolean canBeDividedBy(long number, long divider)
        {
            long result = number % divider;
            if (result == 0)
            {
                return true;
            }

            return false;
        }
    }
}
