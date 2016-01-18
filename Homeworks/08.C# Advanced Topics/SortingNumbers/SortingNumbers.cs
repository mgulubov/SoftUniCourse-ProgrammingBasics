using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingNumbers
{
    class SortingNumbers
    {
        static void Main(string[] args)
        {
            //I WILL NOT BE CONTAINED BY THE BOUNDARIES OF THE PROGRAMMING LANGUAGE!!!
            //I CANNOT BE CONTAINED... BY ANY CONTAINER!!
            //"WE ARE AT EVERY KILOMETEEEER! FROM HERE TO THE END OF THE WOOO..." CABUUUUM!
            //MUAHAHAHAHAHA

            //Anyway, we won't be using the built-in sorting algorithms - we will create our VERY OWN!!
            //And we will choose Merge Sort, because I like it and because it's my personal favourite ;P

            int n = 0;
            try
            {
                Console.Write("N: ");
                n = int.Parse(Console.ReadLine()); 
            }
            catch (FormatException fe)
            {
                Console.WriteLine("DON'T DO DRUGS!");
                Environment.Exit(1);
            }

            //We use ArrayList because the List<> library SUCKS. FUCK YOU MICROSOFT. YOU DIDN'T EVEN BOTHER TO CREATE A PROPER LIST ITERATOR CLASS! BASTARDS!!
            ArrayList list = new ArrayList(n);
            int number = 0;
            for (int i = 0; i < n; i++)
            {
                //We can actually optimize this and use a Binary Searcher/Inserter to sort the list.
                //But... I do like Merge Sort so very very much :P
                try
                {
                    Console.Write("Number No. " + (i + 1) + ": ");
                    number = int.Parse(Console.ReadLine());
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("ARRRRGGGGGHHH INVALID INPUT MATEY!");
                    Environment.Exit(1);
                }

                list.Add(number);
            }

            ListSorter sorter = ListSorter.INSTANCE;
            list = sorter.sort(list);

            foreach (int num in list)
            {
                Console.WriteLine(num);
            }
        }

        private class ListSorter
        {
            public static readonly ListSorter INSTANCE = new ListSorter();

            private ListSorter()
            {
                //We use the singleton pattern here. No need for multiple instances
            }

            public ArrayList sort(ArrayList list)
            {
                return mergeSort(list, 0, list.Count - 1);
            }

            private ArrayList mergeSort(ArrayList list, int startIndex, int endIndex)
            {
                if (startIndex >= endIndex)
                {
                    ArrayList result = new ArrayList(1);
                    result.Add(list[startIndex]);
                    return result;
                }

                int middleIndex = startIndex + (endIndex - startIndex) / 2;
                ArrayList leftList = mergeSort(list, startIndex, middleIndex);
                ArrayList rightList = mergeSort(list, middleIndex + 1, endIndex);

                return merge(leftList, rightList);
            }

            private ArrayList merge(ArrayList leftList, ArrayList rightList)
            {
                //Pssst...<whispering>This is where the magic happens</whispering> :P
                //DON'T FORGET TO FLUSH AND WASH YOU HANDS!!!
                int size = 0;
                if (rightList.Count > leftList.Count)
                {
                    size = rightList.Count;
                }
                else
                {
                    size = leftList.Count;
                }

                ArrayList result = new ArrayList(size);
                
                IEnumerator left = leftList.GetEnumerator();
                IEnumerator right = rightList.GetEnumerator();
                left.MoveNext();
                right.MoveNext();

                while (!(isDone(left) && isDone(right)))
                {
                    if (isDone(left))
                    {
                        result.Add(right.Current);
                        right.MoveNext();
                    }
                    else if (isDone(right))
                    {
                        result.Add(left.Current);
                        left.MoveNext();
                    }
                    else
                    {
                        bool check = int.Parse(left.Current.ToString()) > int.Parse(right.Current.ToString());

                        if (check)
                        {
                            result.Add(right.Current);
                            right.MoveNext();
                        }
                        else
                        {
                            result.Add(left.Current);
                            left.MoveNext();
                        }
                    }
                }

                return result; //FLUSHHHHHHH
            }
        }

        private static bool isDone(IEnumerator i)
        {
            //This is what we are forced to do, because of the lack of a proper Iterator class.
            //C# - The Modern Language!
            //MY ASS!! 
            //Even Java, which, by the way, was still around when the Budha decided to sit under a tree, has an Iterator method for its List class
            try
            {
                Object check = i.Current;
            }
            catch (InvalidOperationException)
            {
                return true;
            }

            return false;
        }
    }
}
