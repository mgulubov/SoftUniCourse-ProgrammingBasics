using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04ChessQueens
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine()) + 1;

            string[,] matrix = new string[n, n];
            for (int row = 0; row < n; row++)
            {
                char letter = GetLetterAt(row);
                for (int col = 1; col <= n; col++)
                {
                    matrix[row, col - 1] = letter.ToString() + col.ToString();
                }
            }

            List<string> result = new List<string>();
            for (int queen1Row = 0; queen1Row < n; queen1Row++)
            {
                for (int queen1Col = 0; queen1Col < n; queen1Col++)
                {
                    string queen1Pos = matrix[queen1Row, queen1Col];
                    //getLeft
                    try
                    {
                        result.Add(queen1Pos + " - " + matrix[queen1Row, queen1Col - d]);
                    }
                    catch (Exception)
                    {
                        //continue
                    }

                    //get Left Up
                    try
                    {
                        result.Add(queen1Pos + " - " + matrix[queen1Row - d, queen1Col - d]);
                    }
                    catch (Exception)
                    {
                        //continue
                    }

                    //Get Up
                    try
                    {
                        result.Add(queen1Pos + " - " + matrix[queen1Row - d, queen1Col]);
                    }
                    catch (Exception)
                    {
                        //continue
                    }

                    //Get Right Up
                    try
                    {
                        result.Add(queen1Pos + " - " + matrix[queen1Row - d, queen1Col + d]);
                    }
                    catch (Exception)
                    {
                        //continue
                    }

                    //Get right
                    try
                    {
                        result.Add(queen1Pos + " - " + matrix[queen1Row, queen1Col + d]);
                    }
                    catch (Exception)
                    {
                        //continue
                    }

                    //get right Down
                    try
                    {
                        result.Add(queen1Pos + " - " + matrix[queen1Row + d, queen1Col + d]);
                    }
                    catch (Exception)
                    {
                        //continue
                    }

                    //Get Down
                    try
                    {
                        result.Add(queen1Pos + " - " + matrix[queen1Row + d, queen1Col]);
                    }
                    catch (Exception)
                    {
                        //continue
                    }

                    //Get left Down
                    try
                    {
                        result.Add(queen1Pos + " - " + matrix[queen1Row + d, queen1Col - d]);
                    }
                    catch (Exception)
                    {
                        //continue
                    }
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine("No valid positions");
            }
            else
            {
                foreach (string r in result)
                {
                    Console.WriteLine(r);
                }
            }
        }

        private static char GetLetterAt(int pos)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return char.ToLower(alphabet[pos]);
        }
    }
}
