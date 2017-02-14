using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    class Edge
    {
        public Point point1, point2;
        public Edge(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }
        public double Length()
        {
            return Math.Sqrt(Math.Pow(point1.x - point2.x, 2) + Math.Pow(point1.y - point2.y, 2));
        }
    }
}
