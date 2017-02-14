using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    class Edge
    {
        readonly Point point1, point2;
        public Edge(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }
        public double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
            }
            
        }
    }
}
