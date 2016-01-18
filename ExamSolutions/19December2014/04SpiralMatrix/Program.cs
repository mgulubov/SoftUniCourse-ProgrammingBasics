using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04SpiralMatrix
{
    class Program
    {
        private static char[,] _matrix;
        private static int _startRow;
        private static int _endRow;
        private static int _startCol;
        private static int _endCol;
        private static int _index;
        private static byte _flag;
        private static string _text;
        private static int _n;

        static void Main(string[] args)
        {
            _n = int.Parse(Console.ReadLine());
            _text = Console.ReadLine();

            _matrix = new char[_n, _n];

            _startRow = 0;
            _endRow = _n - 1;
            _startCol = 0;
            _endCol = _n - 1;
            _index = 0;
            _flag = 0;

            while (true)
            {
                _flag = GoRight();
                _startRow++;
                if (_flag == 1)
                {
                    break;
                }

                _flag = GoDown();
                _endCol--;
                if (_flag == 1)
                {
                    break;
                }

                _flag = GoLeft();
                _endRow--;
                if (_flag == 1)
                {
                    break;
                }

                _flag = GoUp();
                _startCol++;
                if (_flag == 1)
                {
                    break;
                }
            }

            //printMatrix();
            int biggestWeight = 0;
            int biggestRow = 0;
            int weight = 0;
            for (int row = 0; row < _n; row++)
            {
                weight = GetWeight(row);
                if (weight > biggestWeight)
                {
                    biggestWeight = weight;
                    biggestRow = row;
                }
            }

            Console.WriteLine("{0} - {1}", biggestRow, biggestWeight);
        }

        private static int GetWeight(int row)
        {
            int sum = 0;
            for (int col = 0; col < _n; col++)
            {
                int c = char.ToUpper(_matrix[row, col]) - 64;
                sum = sum + (c * 10);
            }
            return sum;
        }

        private static void PrintMatrix()
        {
            for (int i = 0; i < _n; i++)
            {
                for (int b = 0; b < _n; b++)
                {
                    Console.Write(_matrix[i, b]);
                }
                Console.WriteLine();
            }
        }

        private static byte GoUp()
        {
            if (_matrix[_endRow, _startCol] != '\0')
            {
                return 1;
            }
            for (int i = _endRow; i >= _startRow; i--)
            {
                if (_index == _text.Length)
                {
                    _index = 0;
                }
                _matrix[i, _startCol] = _text[_index];
                _index++;
            }
            return 0;
        }

        private static byte GoLeft()
        {
            if (_matrix[_endRow, _endCol] != '\0')
            {
                return 1;
            }
            for (int i = _endCol; i >= _startCol; i--)
            {
                if (_index == _text.Length)
                {
                    _index = 0;
                }
                _matrix[_endRow, i] = _text[_index];
                _index++;
            }
            return 0;
        }

        private static byte GoDown()
        {
            if (_matrix[_startRow, _endCol] != '\0')
            {
                return 1;
            }
            for (int i = _startRow; i <= _endRow; i++)
            {
                if (_index == _text.Length)
                {
                    _index = 0;
                }
                _matrix[i, _endCol] = _text[_index];
                _index++;
            }
            return 0;
        }

        private static byte GoRight()
        {
            if (_matrix[_startRow, _startCol] != '\0')
            {
                return 1;
            }
            for (int i = _startCol; i <= _endCol; i++)
            {
                if (_index == _text.Length)
                {
                    _index = 0;
                }
                _matrix[_startRow, i] = _text[_index];
                _index++;
            }
            return 0;
        }
    }
}
