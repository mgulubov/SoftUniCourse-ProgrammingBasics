using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _05.RemoveNames
{
    class RemoveNames
    {
        static void Main()
        {
            Console.Write("List 1: ");
            string[] names1 = Console.ReadLine().Split(' ');
            Console.Write("List 2: ");
            string[] names2 = Console.ReadLine().Split(' ');

            ArrayList list1 = new ArrayList(names1);
            ArrayList list2 = new ArrayList(names2);

            for (int i = 0; i < list2.Count; i++)
            {
                while (list1.Contains(list2[i]))
                {
                    list1.Remove(list2[i]);
                }
            }

            for (int i = 0; i < list1.Count; i++)
            {
                Console.Write(list1[i]);
                if (i < list1.Count - 1)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }

    }
}
