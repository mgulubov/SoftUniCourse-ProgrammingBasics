using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarProblems
{
    class StarProblems
    {
        private static void ripOffSelection()
        {
            Console.Clear();
            Console.WriteLine("After carefull consideration, you decide that instead of getting one " +
                "\"Super-Awesome Mega-Rare One-Of-A-Kind Forged-By-God-Herself ARMOR OF ETHERNAL WISDOM\" " +
                "it would be a better idea to get 7 cheap ripoffs instead.\n" +
                "The ripoffs however, don't provide any attributes, other than just looking flashy from a distance and " +
                "also have a slightly misspeled brand logo on the back.\n\n");
        }

        private static void attackSelection()
        {
            Console.Clear();
            Console.WriteLine("You viciously attack the creepy, yet incredibly polite, shop-keeper, not realizing that " +
                             "he has a very creepy and not incredibly polite, 12-gauge shotgun behind the counter.\n" +
                             "Instead of killing you however, he knocks you out and drags you to the basement for an UNKNOWN, creepy and not at all polite, purspose.");
            Console.Write("\n\n\n");
            System.Threading.Thread.Sleep(13000);
            Console.WriteLine("A few hours later:");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("ZED: \"Bring out the gimp.\"");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("SHOP-KEEPER: \"I think the gimp's sleeping.\"");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("ZED: \"Well, I guess you're gonna have to go wake him up now, won't you?\"\n\n");
            System.Threading.Thread.Sleep(5000);
        }

        private static void leaveSelection()
        {
            Console.Clear();
            String conf;
            Console.Write("You have selected to leave this fine app. Do you confirm (Y/n): ");
            conf = Console.ReadLine();
            if (conf.Equals("Y") || conf.Equals("y"))
            {
                Console.Write("\n\nAre you absolutely postive and certain that deep in your heart you don't want to stay and "+
                    "that staying here will not make you infinitelly happy beyond your wildest dreams? (Y/n): ");
                conf = Console.ReadLine();
                if (conf.Equals("Y") || conf.Equals("y"))
                {
                    Console.Write("\n\nYou broke my heart! BUT I respect you as an individual, so without any further delay, " +
                        "if you really want to leave, simply type \"Wdsdgheu86WU@(DSjfnhx0-(&#W^&ERGbnd\": ");
                    System.Threading.Thread.Sleep(10000);
                    Console.WriteLine("\n\nJust kidding :)");
                    Console.WriteLine("Quiting automatically in 3s.");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("\n\nLIVE LONG AND PROSPER!\n\n");
                    System.Threading.Thread.Sleep(1000);
                    System.Threading.Thread.Sleep(1000);
                    Environment.Exit(0);
                }
                else
                {
                    postAction();
                }
            }
            else
            {
                postAction();
            }
        }

        private static void armorSelection()
        {
            Console.Clear();
            Console.WriteLine("CONGRATILATIONS! You have acquired the \"Super-Awesome Mega-Rare One-Of-A-Kind Forged-By-God-Herself ARMOR OF ETHERNAL WISDOM\"\n" +
                "You now have +1000000000 to All Attributes and +Infinite Awesomeness.\n" + 
                "You have also been recognized world-wide for officially acheiving the status of NERD!\n\n");
        }

        private static void espressoSelection()
        {
            Console.Clear();
            Console.WriteLine("You order an espresso without noticing that the coffee beans came from the mountins of Jamaica.\n" +
                              "After you drank it, you had to instantly go to the back of the shop, where you had a " +
                              "long and spiritually satisfying... \"prayer\"\n\n");
        }

        private static void worldPeaceSelection()
        {
            Console.Clear();
            Console.WriteLine("You were about to request an \"Instant World Peace\" service, " +
                "but you decided that with no wars and random violence, " + 
                "the World will become too cheesy and overly-crowded, so you drop the idea.\n\n");
        }
        private static void getAPairSelection()
        {
            Console.Clear();
            Console.WriteLine("The creepy, yet incredibly polite, shop-keeper hands you a pair of the brand new \"Air Jordan -1\" model, designed with the new \"Medieval Jump-High\" technology " +
                                "consisting of a little imp-slave, whose back you step on, every time you want to get additional elevation.\n\n");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Unfortunately, you don't have enough money to afford these, so you hand back the shoes and you tap the imp-slave on the head, when he walks by you.\n\n");
        }

        private static void printDateAndTimeSelection()
        {
            Console.Clear();
            DateTime date = DateTime.Now;
            Console.WriteLine("The current date and time, sine the birth of Lord and Savior, is: " + date);
            Console.Write("\n\n");
        }

        private static void printALongSequenceSelection()
        {
            Console.Clear();
            Console.WriteLine("The creepy, yet incredibly polite shop-keeper looks and you and thinks \"What a creepy guy\".\n" +
                             "He then grabs a pen and paper and starts writing the incredibly long sequence for you.\n" +
                             "Here's what he wrote: \n");
            System.Threading.Thread.Sleep(8000);
            printALongSequence();
            Console.Write("\n\n\n");
        }

        private static void calcAgeSelection()
        {
            Console.Clear();
            Console.WriteLine("\"Please share your birthday with me," + 
                " so that I can tell you what awaits you in the future.\"\n");
            Console.WriteLine("What do you do: \n\n" +
                "1) Share your birth date with the creepy, but yet incredibly polite shop-keeper\n" +
                "2) Say \"Piss off\" and call him a \"Creepy Wanker\"\n");
            Console.Write("Selection (1-2): ");

            DateTime birthDate = DateTime.Now;
            String action = Console.ReadLine();
            switch (action)
            {
                case "1":
                    birthDate = getBirthDateFromUser();
                    calcAge(birthDate);
                    break;
                case "1)":
                    birthDate = getBirthDateFromUser();
                    calcAge(birthDate);
                    break;
                case "2":
                    Console.WriteLine("How rude of you. You are a bad, bad human being for treating the creepy, yet incredibly polite shop-keeper, like that.\n" +
                                     "See?! He's now crying in the corner!\n" +
                                     "Maaan, I sure as hell don't want your karma!\n\n");
                    break;
                case "2)":
                    Console.WriteLine("How rude of you. You are a bad, bad human being for treating the creepy, yet incredibly polite shop-keeper, like that.\n" +
                                     "See?! He's now crying in the corner!\n" +
                                     "Maaan, I sure as hell don't want your karma!\n\n");
                    break;
                default:
                    Console.WriteLine("Your reply wasn't understood by the creepy, but yet incredibly polite shop-keeper.\n" +
                                      "He's a bit on the slow side, so he starts the conversation from the beggining.\n\n");
                    calcAgeSelection();
                    break;
            }
        }

        private static void printALongSequence()
        {
            for (int i = 2; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    Console.Write(-(i) + " ");
                }

                if (i == 1000)
                {
                    Console.WriteLine();
                }
            }
        }

        private static void postAction()
        {
            Console.WriteLine("With this awesome action performed, is there anything else that you need to do here?\n\n");
            printOptions();
            getSelection();
        }

        private static void calcAge(DateTime birthDate)
        {
            DateTime now = DateTime.Today;
            int ageNow = now.Year - birthDate.Year;
            if (birthDate > now.AddYears(-ageNow))
            {
                ageNow--;
            }

            int ageAfter10Years = ageNow + 10;

            Console.Write("\n\n\"Thank you for sharing your birth date with me.\"\n");
            Console.Write("\"I will now use my incredibly awesome and powerfull psychic powers, to determine what awaits you in the future.\"\n");
            Console.Write("\"Please wait here, while I go consult my crystal ball.\"\n");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("...uuugh...");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("...uuuuuuughhh...");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("...UUUUUUUUGGGHHHH...");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("...UUUUUUUUUUUUUUUUGGGGGGGHHHHHAAAAAARRRRRGGGGGHHHHH...AAAAAAAAaaaaaaa");
            System.Threading.Thread.Sleep(800);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(800);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(800);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\n\nFFFFFFLUUUUUUSSSSSSSHHHHHHHHHHHHHHH\n\n");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("\"Thank you for waiting.\nAfter consulting my crystal ball and carefully examining my gut feelings," +
                             " I have determined that your current age is: " + ageNow + ".\"\n" +
                             "\"I have also predicted that after exactly 10 years from now, you will be exactly " +
                             ageAfter10Years + " YEARS OLD!!!\"\nISN'T THAT GREAT? AM I GOOD, OR AM I GOOD?!\"\n\n\n" +
                             "\"By the way, you don't happen to have any toilet paper on you, don't you?\"\n\n");

            
        }

        private static DateTime getBirthDateFromUser()
        {
            Console.Write("Share your birthdate with the creepy, yet incredibly polite, shop-keeper (mm/dd/yyyy): ");
            String birthDateString = Console.ReadLine();
            IFormatProvider culture = new System.Globalization.CultureInfo("en-US", true);
            DateTime birthDate = DateTime.Parse(birthDateString, culture, System.Globalization.DateTimeStyles.AssumeLocal);
            return birthDate;
        }

        private static void printOptions()
        {
            Console.WriteLine("1) Print Current Date And Time\n" +
                                "2) Calculate my age after 10 years from now\n" +
                                "3) Print a long sequence\n" +
                                "4) Get a pair of Jordan sneakers\n" +
                                "5) Instant World Peace\n" +
                                "6) Have an espresso\n" +
                                "7) Buy the \"Super-Awesome Mega-Rare One-Of-A-Kind Forged-By-God-Herself ARMOR OF ETHERNAL WISDOM\"\n" +
                                "8) Buy a cheap rip-off of the \"Super-Awesome Mega-Rare One-Of-A-Kind Forged-By-God-Herself ARMOR OF ETHERNAL WISDOM\"\n" +
                                "9) Attack the creepy, yet incredibly polite, shop keeper\n" +
                                "10) Leave\n");
        }

        private static void getSelection()
        {
            Console.Write("\nWhat say you: ");
            String selection = Console.ReadLine();

            int action = considerSelection(selection);
            doSelectedAction(action);
        }

        private static int considerSelection(String selection)
        {
            switch (selection)
            {
                case "1":
                    return 1;
                case "1)":
                    return 1;
                case "2":
                    return 2;
                case "2)":
                    return 2;
                case "3":
                    return 3;
                case "3)":
                    return 3;
                case "4":
                    return 4;
                case "4)":
                    return 4;
                case "5":
                    return 5;
                case "5)":
                    return 5;
                case "6":
                    return 6;
                case "6)":
                    return 6;
                case "7":
                    return 7;
                case "7)":
                    return 7;
                case "8":
                    return 8;
                case "8)":
                    return 8;
                case "9":
                    return 9;
                case "9)":
                    return 9;
                case "10":
                    return 10;
                case "10)":
                    return 10;
                case "11":
                    return 11;
                case "11)":
                    return 11;
                default:
                    return -1;

            }
        }

        private static void doSelectedAction(int action)
        {
            switch (action)
            {
                case 1:
                    printDateAndTimeSelection();
                    break;
                case 2:
                    calcAgeSelection();
                    break;
                case 3:
                    printALongSequenceSelection();
                    break;
                case 4:
                    getAPairSelection();
                    break;
                case 5:
                    worldPeaceSelection();
                    break;
                case 6:
                    espressoSelection();
                    break;
                case 7:
                    armorSelection();
                    break;
                case 8:
                    ripOffSelection();
                    break;
                case 9:
                    attackSelection();
                    break;
                case 10:
                    leaveSelection();
                    break;
                default:
                    Console.WriteLine("Unfortunately, your selection was not understood by the creepy, yet incredibly polity, shop-keeper.\nPlease try again,");
                    break;
            }

            postAction();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\"Welcome to my humble app stranger!\"\n" +
                                "\"Can I interest you in any of my wares?\"\n\n");
            printOptions();
            getSelection();
        }
    }
}
