using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01InsideTheBuilding
{
    class Program
    {
        private static int _block1X1;
        private static int _block1Y1;
        private static int _block1X2;
        private static int _block1Y2;
        private static int _block1X3;
        private static int _block1Y3;
        private static int _block1X4;
        private static int _block1Y4;

        private static int _block2X1;
        private static int _block2Y1;
        private static int _block2X2;
        private static int _block2Y2;
        private static int _block2X3;
        private static int _block2Y3;
        private static int _block2X4;
        private static int _block2Y4;

        public static void Main()
        {
            int h = int.Parse(Console.ReadLine());

            //Horizontal Block
            //Point 1
            _block1X1 = 0;
            _block1Y1 = 0;
            //Point 2
            _block1X2 = _block1X1;
            _block1Y2 = _block1Y2 + h;
            //Point 3
            _block1X3 = _block1X1 + (3 * h);
            _block1Y3 = _block1Y2;
            //Point 4
            _block1X4 = _block1X3;
            _block1Y4 = _block1Y1;

            //Vertical Block
            //Point 1
            _block2X1 = h;
            _block2Y1 = h;
            //Point 2
            _block2X2 = _block2X1;
            _block2Y2 = _block2Y1 + (3 * h);
            //Point 3
            _block2X3 = _block2X1 + h;
            _block2Y3 = _block2Y2;
            //Point 4
            _block2X4 = _block2X3;
            _block2Y4 = _block2Y1;

            List<string> result = new List<string>(5);
            for (int i = 0; i < 5; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                if (IsInsideBuilding(x, y) || IsInsideBuilding(x, y))
                {
                    result.Add("inside");
                    continue;
                }

                result.Add("outside");
            }

            foreach (string res in result)
            {
                Console.WriteLine(res);
            }
        }

        private static bool IsInsideBuilding(int x, int y)
        {
            return IsWithinBlock1(x, y) || IsWithinBlock2(x, y);
        }

        private static bool IsWithinBlock1(int x, int y)
        {
            if (((x >= _block1X1 && y >= _block1Y1) && (x >= _block1X2 && y <= _block1Y2))
            && ((x <= _block1X3 && y <= _block1Y3) && (x <= _block1X4 && y >= _block1Y4)))
            {
                return true;
            }

            return false;
        }

        private static bool IsWithinBlock2(int x, int y)
        {
            if (((x >= _block2X1 && y >= _block2Y1) && (x >= _block2X2 && y <= _block2Y2))
            && ((x <= _block2X3 && y <= _block2Y3) && (x <= _block2X4 && y >= _block2Y4)))
            {
                return true;
            }

            return false;
        }
    }
}
