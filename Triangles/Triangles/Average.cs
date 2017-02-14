using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;


namespace Triangles
{
    static class Average
    {
        public static double Perimeter(ArrayList triangles)
        {
            int count = 0;
            double perimeter = 0;
            foreach (Triangle triangle in triangles)
            {
                if (triangle.IsRight)
                {
                    count++;
                    perimeter += triangle.Perimeter;
                }
            }
            return count != 0 ? perimeter / count : 0;
        }

        public static double Area(ArrayList triangles)
        {
            int count = 0;
            double area = 0;
            foreach (Triangle triangle in triangles)
            {
                if (triangle.IsIsosceles)
                {
                    count++;
                    area += triangle.Area;
                }
            }
            return count != 0 ? area / count : 0;
        }
    }
}
