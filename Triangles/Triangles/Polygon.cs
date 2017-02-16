using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    class Polygon
    {
        public readonly List<Point> point;
        public readonly List<double> edge;
        public Polygon(List<Point> point)
        {
            this.point = point;
            edge = new List<double>();
            for (int i = 0; i < point.Count - 1; i++)
            {
                edge.Add(new Edge(point[i], point[i + 1]).Length); 
            }
            edge.Add(new Edge(point[point.Count - 1], point[0]).Length);
        }
        public double Perimeter
        {
            get
            {
                return edge.Sum();
            }
        }
        public double Area
        {
            get
            {
                double sum = 0;
                for (int i = 0; i < point.Count - 1; i++)
                    sum += (point[i + 1].X - point[i].X) * (point[i + 1].Y + point[i].Y);
                sum += (point[0].X - point[point.Count - 1].X) * (point[0].Y + point[point.Count - 1].Y);
                return Math.Abs(sum) / 2.0;
            }
        }
    }
}
