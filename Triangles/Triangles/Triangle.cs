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
        public readonly Point Point1, Point2, Point3;
        public readonly double Edge1, Edge2, Edge3;
        public Triangle(Point point1, Point point2, Point point3)
        {
            var edge1 = new Edge(point1, point2).Length;
            var edge2 = new Edge(point2, point3).Length;
            var edge3 = new Edge(point3, point1).Length;
            if (edge1 + edge2 > edge3 && edge1 + edge3 > edge2 && edge2 + edge3 > edge1)
            {
                this.Point1 = point1;
                this.Point2 = point2;
                this.Point3 = point3;
                this.Edge1 = edge1;
                this.Edge2 = edge2;
                this.Edge3 = edge3;
            }
            else
            {
                throw new ArgumentException("Невозможно создать треугольник с данными точками");
            }

        }
        public double Perimeter
        {
            get
            {
                return Edge1 + Edge2 + Edge3;
            }
        }
        public double Area
        {
            get
            {
                double HalfPerimeter = Perimeter / 2;
                return Math.Sqrt(HalfPerimeter *
                    (HalfPerimeter - Edge1) * (HalfPerimeter - Edge2) * (HalfPerimeter - Edge3));
            }
        }
        public bool IsRight
        {
            get
            {
                return Edge1 == Math.Sqrt(Edge2 * Edge2 + Edge3 * Edge3) 
                    || Edge2 == Math.Sqrt(Edge1 * Edge1 + Edge3 * Edge3)
                    || Edge3 == Math.Sqrt(Edge2 * Edge2 + Edge1 * Edge1);
            }
        }
        public bool IsIsosceles
        {
            get
            {
                return Edge1 == Edge2 || Edge2 == Edge3 || Edge3 == Edge1;
            }
        }
        public static bool operator ==(Triangle a, Triangle b)
        {
            return a.Edge1 == b.Edge1 && a.Edge2 == b.Edge2 ||
                   a.Edge1 == b.Edge2 && a.Edge2 == b.Edge1 ||
                   a.Edge3 == b.Edge3 && a.Edge2 == b.Edge2 ||
                   a.Edge3 == b.Edge2 && a.Edge2 == b.Edge3 ||
                   a.Edge1 == b.Edge1 && a.Edge3 == b.Edge3 ||
                   a.Edge1 == b.Edge3 && a.Edge3 == b.Edge1;
        }
        public static bool operator !=(Triangle a, Triangle b)
        {
            return !(a == b);
        }
    }
}


