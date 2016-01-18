using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            int a = 0;
            float b = 0f;
            float c = 0f;
            try
            {
                Console.Write("Arrrrrrgghhh! I’ll devour yer parrot, ye skirt wearing, harbour hog! Tell me what the A might be: ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Hands off me booty, ye yellow bellied, scurvy dog! What's the B: ");
                b = float.Parse(Console.ReadLine());

                Console.Write("I’ll cut out yer tongue and feed it to the sharks, if ye don't gimme the C: ");
                c = float.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Wrong format, ye hammock hogging, flea ridden, grog-snarfing shark bait!");
                Environment.Exit(1);
            }

            String hex = a.ToString("X");
            int bin = int.Parse(Convert.ToString(a, 2));
            b = float.Parse(b.ToString("0.00"));
            c = float.Parse(c.ToString("0.000"));

            Console.WriteLine("|{0}\t|{1}|\t{2}|{3}\t|", hex, bin.ToString("D10"), b, c);
        }
    }
}
