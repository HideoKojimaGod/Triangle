using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    class Edge
    {
        public readonly Point Point1, Point2;
        public Edge(Point point1, Point point2)
        {
            this.Point1 = point1;
            this.Point2 = point2;
        }
        public double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow(Point1.X - Point2.X, 2) + Math.Pow(Point1.Y - Point2.Y, 2));
            }
            
        }
        public static bool operator ==(Edge a, Edge b)
        {
            return a.Point1 == b.Point1 && a.Point2 == b.Point2 ||
                   a.Point1 == b.Point2 && a.Point2 == b.Point1;
        }
        public static bool operator !=(Edge a, Edge b)
        {
            return !(a.Point1 == b.Point1 && a.Point2 == b.Point2 ||
                    a.Point1 == b.Point2 && a.Point2 == b.Point1);
        }
    }
}
