using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    class Polygon
    {
        public readonly List<Point> Point;
        public readonly List<double> Edge;
        public Polygon(List<Point> point)
        {
            this.Point = point;
            Edge = new List<double>();
            for (int i = 0; i < point.Count - 1; i++)
            {
                Edge.Add(new Edge(point[i], point[i + 1]).Length); 
            }
            Edge.Add(new Edge(point[point.Count - 1], point[0]).Length);
        }
        public double Perimeter
        {
            get
            {
                return Edge.Sum();
            }
        }
        public double Area
        {
            get
            {
                double sum = 0;
                for (int i = 0; i < Point.Count - 1; i++)
                    sum += (Point[i + 1].X - Point[i].X) * (Point[i + 1].Y + Point[i].Y);
                sum += (Point[0].X - Point[Point.Count - 1].X) * (Point[0].Y + Point[Point.Count - 1].Y);
                return Math.Abs(sum) / 2.0;
            }
        }
    }
}
