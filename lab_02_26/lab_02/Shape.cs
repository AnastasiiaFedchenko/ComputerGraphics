using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    public abstract class Shape: EventArgs
    {
        public Shape() { }
        public abstract void draw(Graphics g);
    }

    public class Polygon: Shape 
    {
        // рисовать будем рисовать FillPolygon
        Point[] points;
        Color color;
        public Polygon(Point p1, Point p2, Point p3, Point p4, Color color) // прямоугольник
        {
            points = new Point[] { p1, p2, p3, p4 };
            this.color = color;
        }
        public Polygon(Point p1, Point p2, Point p3, Color color) // треугольник
        {
            points = new Point[] { p1, p2, p3 };
            this.color = color;
        }
        public Polygon(Point F1, Point F2, int a, Color color) // эллипс
        {
            this.color = color;
        }
        public override void draw(Graphics g) { }

    }

    public class Ellipse: Shape
    {
        Point[] points;
        public Ellipse() { }
        public override void draw(Graphics g) { }
    }

    public class Triangle: Shape
    {
        Point p1;
        Point p2;
        Point p3;
        public Triangle() { }
        public override void draw(Graphics g) { }
    }

    public class Cross: Shape
    {
        Point p1; // the top one
        Point p2; // the bottom one
        Point p3; // the left one
        Point p4; // the right one
        Color color;
        public override void draw(Graphics g) { }
    }
}
