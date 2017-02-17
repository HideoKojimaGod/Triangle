using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    class Point
    {
        public readonly double X; 
        public readonly double Y;

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public static bool operator== (Point a, Point b)
        {
            return a.X == b.X && a.Y == b.Y; 
        }
        public static bool operator!= (Point a, Point b)
        {
            return a.X != b.X || a.Y != b.Y;
        }
    }
}
