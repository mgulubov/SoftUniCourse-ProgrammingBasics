using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _06.JoinLists
{
    class JoinLists
    {
        static void Main()
        {
            //Again, we will do things in a different manner. Binary Search/Insert... AWAAAAAAAAYYYY!!!
            Console.Write("List 1: ");
            string[] n1 = Console.ReadLine().Split(' ');
            Console.Write("List 2: ");
            string[] n2 = Console.ReadLine().Split(' ');

            ArrayList list1 = new ArrayList(n1);
            ArrayList list2 = new ArrayList(n2);

            ListInserter inserter = ListInserter.INSTANCE;

            ArrayList result = new ArrayList();
            result = inserter.insert(list1, list2);

            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i]);
                if (i < result.Count - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        private class ListInserter
        {
            public readonly static ListInserter INSTANCE = new ListInserter();
            private static ListSearcher _searcher = ListSearcher.INSTANCE;

            private ListInserter()
            {
                //private constructor
            }

            public ArrayList insert(ArrayList list1, ArrayList list2)
            {
                ArrayList result = new ArrayList();

                IEnumerator left = list1.GetEnumerator();
                IEnumerator right = list2.GetEnumerator();
                left.MoveNext();
                right.MoveNext();

                while (!(isDone(left) && isDone(right)))
                {
                    if (!isDone(left))
                    {
                        result = addIfDoesntExist(result, left.Current);
                        left.MoveNext();
                    }

                    if (!isDone(right))
                    {
                        result = addIfDoesntExist(result, right.Current);
                        right.MoveNext();
                    }
                }

                return result;
            }

            private bool isDone(IEnumerator i)
            {
                try
                {
                    Object tmp = i.Current;
                }
                catch (Exception)
                {
                    return true;
                }
                return false;
            }

            private ArrayList addIfDoesntExist(ArrayList list, Object value)
            {
                int index = _searcher.search(list, value);
                if (index < 0)
                {
                    list.Insert(-(index + 1), value);
                }
                return list;
            }
        }

        private class ListSearcher
        {
            public readonly static ListSearcher INSTANCE = new ListSearcher();

            private ListSearcher()
            {
                //private constructor
            }

            public int search(ArrayList list, Object value)
            {
                int startIndex = 0;
                int endIndex = list.Count - 1;
                int middleIndex = 0;
                while (startIndex <= endIndex)
                {
                    middleIndex = startIndex + (endIndex - startIndex) / 2;
                    if (int.Parse(list[middleIndex].ToString()) == int.Parse(value.ToString()))
                    {
                        return middleIndex;
                    }
                    else if (int.Parse(list[middleIndex].ToString()) < int.Parse(value.ToString()))
                    {
                        startIndex = middleIndex + 1;
                    }
                    else
                    {
                        endIndex = middleIndex - 1;
                    }
                }

                return -(startIndex + 1);
            }
        }
    }
}
