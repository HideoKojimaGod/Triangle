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
        public readonly Point point1, point2, point3;
        public readonly double edge1, edge2, edge3;
        public Triangle(Point point1, Point point2, Point point3)
        {
            var edge1 = new Edge(point1, point2).Length;
            var edge2 = new Edge(point2, point3).Length;
            var edge3 = new Edge(point3, point1).Length;
            if (edge1 + edge2 > edge3 && edge1 + edge3 > edge2 && edge2 + edge3 > edge1)
            {
                this.point1 = point1;
                this.point2 = point2;
                this.point3 = point3;
                this.edge1 = edge1;
                this.edge2 = edge2;
                this.edge3 = edge3;
            }
            else
            {
                throw new Exception("Невозможно создать треугольник с данными точками");
            }

        }
        public double Perimeter
        {
            get
            {
                return edge1 + edge2 + edge3;
            }
        }
        public double Area
        {
            get
            {
                double HalfPerimeter = (edge1 + edge2 + edge3) / 2;
                return Math.Sqrt(HalfPerimeter *
                    (HalfPerimeter - edge1) * (HalfPerimeter - edge2) * (HalfPerimeter - edge3));
            }
        }
        public bool IsRight
        {
            get
            {
                double a = edge1;
                double b = edge2;
                double c = edge3;
                return a == Math.Sqrt(b * b + c * c) || b == Math.Sqrt(a * a + c * c)
                    || c == Math.Sqrt(b * b + a * a);
            }
        }
        public bool IsIsosceles
        {
            get
            {
                double a = edge1;
                double b = edge2;
                double c = edge3;
                return a == b || b == c || c == a;
            }
        }
    }
}


