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
            var triangles = new List<Triangle>();
            Polygon polygon;
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
                    Point point1 = new Point(x1, y1);
                    Point point2 = new Point(x2, y2);
                    Point point3 = new Point(x3, y3);
                    try
                    {
                        var triangle = new Triangle(point1, point2, point3);
                        triangles.Add(triangle);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    } 
                }
            }
            using (StreamReader sr = new StreamReader("input2.txt"))
            {
                string pattern = @"([0-9]*\,?[0-9]+)[ ]+([0-9]*\,?[0-9]+)[ ]*";
                Regex regex = new Regex(pattern);
                var point = new List<Point>();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    double x = Convert.ToDouble(Regex.Replace(line, pattern, "$1"));
                    double y = Convert.ToDouble(Regex.Replace(line, pattern, "$2"));
                    point.Add(new Point(x, y));
                }
                polygon = new Polygon(point);
            }
            Console.WriteLine("Периметр прямоугольных треугольников:");
            Console.WriteLine(Average.Perimeter(triangles));
            Console.WriteLine("Периметр равнобедренных треугольников:");
            Console.WriteLine(Average.Area(triangles));
            Console.WriteLine("Кол-во добавленных треугольников:");
            Console.WriteLine(triangles.Count);
            Console.WriteLine("Площадь многоугольника:");
            Console.WriteLine(polygon.Area);
            Console.WriteLine("Периметр многоугольника:");
            Console.WriteLine(polygon.Perimeter);

        }
    }
}