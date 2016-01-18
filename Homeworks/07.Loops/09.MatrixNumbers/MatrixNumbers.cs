using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MatrixNumbers
{
    class MatrixNumbers
    {
        static void Main(string[] args)
        {
            int n = 0;
            try
            {
                Console.Write("N: ");
                n = int.Parse(Console.ReadLine());
                if (n < 1 || n > 20)
                {
                    n = int.Parse("Bob S Nadenica");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Praz Luk");
                Environment.Exit(1);
            }

            //We can't really use an actual matrix, since we will need two loops to populate it and then two more loops to print it
            //We'll just print the numbers instead
            int startNum = 1;
            for (int row = 0; row < n; row++)
            {
                int num = startNum;
                for (int col = 0; col < n; col++)
                {
                    Console.Write(num);
                    num++;
                    if (col < n - 1)
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
                startNum++;
            }
        }
    }
}
