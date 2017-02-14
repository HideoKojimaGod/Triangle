using System;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    class Program
    {

        static void Main(string[] args)
        {
            ArrayList triangles = new ArrayList();
            using (StreamReader sr = new StreamReader("input.txt"))
            {
                string pattern = @"([0-9]*\,?[0-9]+)[ ]+([0-9]*\,?[0-9]+)[ ]+([0-9]*\,?[0-9]+)[ ]+([0-9]*\,?[0-9]+)[ ]+([0-9]*\,?[0-9]+)[ ]+([0-9]*\,?[0-9]+)[ ]*";
                Regex regex = new Regex(pattern);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    double x1 = Convert.ToDouble(Regex.Replace(line, pattern, "$1"));
                    double y1 = Convert.ToDouble(Regex.Replace(line, pattern, "$2"));
                    double x2 = Convert.ToDouble(Regex.Replace(line, pattern, "$3"));
                    double y2 = Convert.ToDouble(Regex.Replace(line, pattern, "$4"));
                    double x3 = Convert.ToDouble(Regex.Replace(line, pattern, "$5"));
                    double y3 = Convert.ToDouble(Regex.Replace(line, pattern, "$6"));
                    Console.WriteLine(x1);
                    Console.WriteLine(y1);
                    Console.WriteLine(x2);
                    Console.WriteLine(y2);
                    Console.WriteLine(x3);
                    Console.WriteLine(y3);
                    Point point1 = new Point(x1, y1);
                    Point point2 = new Point(x2, y2);
                    Point point3 = new Point(x3, y3);
                    Triangle triangle = new Triangle(point1, point2, point3);
                    double a = triangle.edge1.Length();
                    double b = triangle.edge2.Length();
                    double c = triangle.edge3.Length();
                    if (a + b > c && a + c > b && b + c > a)
                        triangles.Add(triangle);
                    else
                    { }
                }
            }
            Console.WriteLine(Average.Perimeter(triangles));
            Console.WriteLine(Average.Area(triangles));
            Console.WriteLine(triangles.Count);
        }
    }
}