using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.PlayWithIntDoubleAndString
{
    class PlayWithIntDoubleAndString
    {
        static void Main(string[] args)
        {
            byte choice = 0;

            try
            {
                Console.Write("Choose your weapon:\n1 --> int\n2 --> double\n3 --> string\n\n" +
                                 "And your weapon of choice is: ");
                choice = byte.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                //Continue to default switch;
            }

            switch (choice)
            {
                case 1:
                    int n = 0;
                    try
                    {
                        Console.Write("Please enter an integer: ");
                        n = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException fe)
                    {
                        Console.WriteLine("OH, MY GOD! YOU KILLED MY PROGRAM! YOU BASTARDS!");
                        Environment.Exit(1);
                    }

                    n += 1;
                    Console.WriteLine(n);
                    break;
                case 2:
                    double d = 0.0;
                    try
                    {
                        Console.Write("Please enter a double: ");
                        d = double.Parse(Console.ReadLine());
                    }
                    catch (FormatException fe)
                    {
                        Console.WriteLine("OH, MY GOD! YOU KILLED MY PROGRAM! YOU BASTARDS!");
                        Environment.Exit(1);
                    }

                    d += 1.0;
                    Console.WriteLine(d);
                    break;
                case 3:
                    String str = "";
                    Console.Write("Please enter a string: ");
                    str = Console.ReadLine();
                    str = str.Insert(str.Length, "*"); //How can they have 'Insert', but not have 'Add'! Fuckin' lazy developers maaaaan
                    Console.WriteLine(str);
                    break;
                default:
                    Console.WriteLine("I'm sorry, but the weapon that you've chosen cannot be found in our armory.\n" +
                                  "I will have the royal blacksmith castrated for this mistake.\n" +
                                  "In the mean time, please restart the program and choose a different weapon.");
                    break;
            }

        }
    }
}
