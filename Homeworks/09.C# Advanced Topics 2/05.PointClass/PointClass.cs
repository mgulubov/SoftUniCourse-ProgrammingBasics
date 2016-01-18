using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PointClass
{
    class PointClass
    {
        static void Main(string[] args)
        {
            Point pointA = new Point();
            Point pointB = new Point(0, 100);

            pointA.setX(20);
            pointA.setY(30);
        }

        private class Point
        {
            private int _x;
            private int _y;

            public Point()
                : this(0, 0)
            {

            }

            public Point(int x, int y)
            {
                setX(x);
                setY(y);
            }

            public void setX(int x)
            {
                this._x = x;
            }

            public int getX()
            {
                return this._x;
            }

            public void setY(int y)
            {
                this._y = y;
            }

            public int getY()
            {
                return this._y;
            }
        }
    }
}
