using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Triangles
{
    class Triangle
    {
        public Point point1, point2, point3;
        public Edge edge1, edge2, edge3;
        public Triangle(Point point1, Point point2, Point point3)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            edge1 = new Edge(point1, point2);
            edge2 = new Edge(point2, point3);
            edge3 = new Edge(point3, point1);
        }
        public double Perimeter
        {
            get
            {
                return edge1.Length() + edge2.Length() + edge3.Length();
            }
        }
        public double Area
        {
            get
            {
                double HalfPerimeter = (edge1.Length() + edge2.Length() + edge3.Length()) / 2;
                return Math.Sqrt(HalfPerimeter *
                    (HalfPerimeter - edge1.Length()) * (HalfPerimeter - edge2.Length()) * (HalfPerimeter - edge3.Length()));
            }
        }
        public bool IsRight()
        {
            double a = edge1.Length();
            double b = edge2.Length();
            double c = edge3.Length();
            return a == Math.Sqrt(b * b + c * c) || b == Math.Sqrt(a * a + c * c)
                || c == Math.Sqrt(b * b + a * a);

        }
        public bool IsIsosceles()
        {
            double a = edge1.Length();
            double b = edge2.Length();
            double c = edge3.Length();
            return a == b || b == c || c == a;
        }
    }
}

