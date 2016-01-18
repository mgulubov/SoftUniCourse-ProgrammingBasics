using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInACircleAndOutsideARectangle
{
    class PointInACircleAndOutsideARectangle
    {
        static void Main(string[] args)
        {
            float x = 0f;
            float y = 0f;
            try
            {
                Console.Write("X: ");
                x = float.Parse(Console.ReadLine());

                Console.Write("Y: ");
                y = float.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("WRONG WRONG WRONG WRONG WRONG WRONG WRONG WRONG\n!!!!!!!!!!!!!!!!\nPlease be so kind as to try again");
                Environment.Exit(1);
            }

            float circleX = 1f;
            float circleY = 1f;
            float circleRadius = 1.5f;

            //float rectAngleWidht = 6f;   //Need to figure out a way to calc the rectangle points's x,y coordinates using the widht and height
            //float rectAngleHeight = 2f;

            //Those will be hardcoded for now
            float rectAngleX1 = -1f;
            float rectAngleY1 = 1f;
            float rectAngleX2 = 5f;
            float rectAngleY2 = 1f;
            float rectAngleX3 = 5f;
            float rectAngleY3 = -1f;
            float rectAngleX4 = -1f;
            float rectAngleY4 = -1f;

            //Let's calc the sides of the triangle
            float rectAngleSideALength = calcSideLength(rectAngleX1, rectAngleX2, rectAngleY1, rectAngleY2);
            float rectAngleSibeBLength = calcSideLength(rectAngleX2, rectAngleX3, rectAngleY2, rectAngleY3);
            float rectAngleSideCLength = calcSideLength(rectAngleX3, rectAngleX4, rectAngleY3, rectAngleY4);
            float rectAngleSideDLength = calcSideLength(rectAngleX4, rectAngleX1, rectAngleY4, rectAngleY1);

            //Now we make a line from each rectangle angle point, to the point that we are checking. We then measure those lines
            float angleLine1 = calcAngleLine(rectAngleX1, rectAngleY1, x, y);
            float angleLine2 = calcAngleLine(rectAngleX2, rectAngleY2, x, y);
            float angleLine3 = calcAngleLine(rectAngleX3, rectAngleY3, x, y);
            float angleLine4 = calcAngleLine(rectAngleX4, rectAngleY4, x, y);
            
            //We calc the area of the rectangle
            float rectangleArea = rectAngleSideALength * rectAngleSibeBLength;

            //We now need the areas of the triangles(Heron's formula), formed by the angle lines
            //We first find the semiperimeters
            float semiPerimeterTriangle1 = calcSemiPerimeter(rectAngleSideALength, angleLine1, angleLine2);
            float semiPerimeterTriangle2 = calcSemiPerimeter(rectAngleSibeBLength, angleLine2, angleLine3);
            float semiPerimeterTriangle3 = calcSemiPerimeter(rectAngleSideCLength, angleLine3, angleLine4);
            float semiPerimeterTriangle4 = calcSemiPerimeter(rectAngleSideDLength, angleLine4, angleLine1);
            //We now find the areas
            float triangle1Area = calcTriangleArea(semiPerimeterTriangle1, rectAngleSideALength, angleLine1, angleLine2);
            float triangle2Area = calcTriangleArea(semiPerimeterTriangle2, rectAngleSibeBLength, angleLine2, angleLine3);
            float triangle3Area = calcTriangleArea(semiPerimeterTriangle3, rectAngleSideCLength, angleLine3, angleLine4);
            float triangle4Area = calcTriangleArea(semiPerimeterTriangle4, rectAngleSideDLength, angleLine4, angleLine1);
            //And we finally get the sum of the triangle areas
            float trianglesAreaSum = triangle1Area + triangle2Area + triangle3Area + triangle4Area;

            Boolean isInCircle = isInsideCircle(x, y, circleX, circleY, circleRadius);
            Boolean isInTriangle = isInsideTriangle(rectangleArea, trianglesAreaSum);

            Boolean check = isInCircle && !(isInTriangle);

            /**
            Console.WriteLine("In circle: " + isInCircle);
            Console.WriteLine("In Rectangle: " + isInTriangle);
            Console.WriteLine("Check: " + check);
            **/

            
            if (check == true)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }

        private static float calcTriangleArea(float semiPerimeter, float sideA, float sideB, float sideC)
        {
            float result = (float)Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            
            return result;
        }

        private static float calcSemiPerimeter(float rectAngleSide, float angleLine1, float angleLine2)
        {
            float result = (rectAngleSide + angleLine1 + angleLine2) / 2;

            return result;
        }

        private static float calcAngleLine(float angleX1, float angleY1, float x, float y) 
        {
            float result = (float)Math.Sqrt(Math.Pow(angleX1 - x, 2) + Math.Pow(angleY1 - y, 2));

            return result;
        }     

        private static float calcSideLength(float x1, float x2, float y1, float y2)
        {
            float result = (float)Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

            return result;
        }

        private static bool isInsideTriangle(float a, float b)
        {
            return a > b;
        }

        private static bool isInsideCircle(float x, float y, float circleX, float circleY, float circleRadius)
        {
            double distance = Math.Pow(x - circleX, 2) + Math.Pow(y - circleY, 2);
            Boolean check = distance <= Math.Pow(circleRadius, 2);

            return check;
        }
    }
}
