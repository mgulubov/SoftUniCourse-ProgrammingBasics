using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CheckForAPlayCard
{
    class CheckForAPlayCard
    {
        static void Main(string[] args)
        {
            //There's no char '10', so we'll use String, instead of char, for this one
            Console.Write("What character should we check: ");
            String character = Console.ReadLine();

            //I hate dealing with regular expressions, so we'll use the long version of the code instead :)
            switch (character)
            {
                case "2":
                    print("yes");
                    break;
                case "3":
                    print("yes");
                    break;
                case "4":
                    print("yes");
                    break;
                case "5":
                    print("yes");
                    break;
                case "6":
                    print("yes");
                    break;
                case "7":
                    print("yes");
                    break;
                case "8":
                    print("yes");
                    break;
                case "9":
                    print("yes");
                    break;
                case "10":
                    print("yes");
                    break;
                case "J":
                    print("yes");
                    break;
                case "Q":
                    print("yes");
                    break;
                case "K":
                    print("yes");
                    break;
                case "A":
                    print("yes");
                    break;
                default:
                    print("no");
                    break;
            }
        }

        private static void print(String answer)
        {
            Console.WriteLine(answer);
            Environment.Exit(0);
        }
    }
}
