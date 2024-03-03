using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    public abstract class Shape: EventArgs
    {
        public Shape() { }

        public abstract void draw(Graphics g);
        public abstract void renew(int dx, int dy);
    }

    public class Polygon : Shape
    {
        // рисовать будем рисовать FillPolygon
        Point[] points;
        Color color;
        public Polygon(int x, int y, int width, int height, Color color) // прямоугольник
        {
            points = new Point[] { new Point(x, y), new Point(x + width, y),
                new Point(x + width, y + height), new Point(x, y + height) };
            this.color = color;
        }
        public Polygon(Point p1, Point p2, Point p3, Color color) // треугольник
        {
            points = new Point[] { p1, p2, p3 };
            this.color = color;
        }
    
        public override void draw(Graphics g) 
        {
            Brush brush = new SolidBrush(this.color);
            g.FillPolygon(brush, points);
        }

        public override void renew(int dx, int dy)
        {
            for (int i = 0; i < points.Count(); i++) 
            {
                points[i].X += dx;
                points[i].Y -= dy;
            }
        }
    }

    public class Ellipse: Shape
    {
        Point O;
        Point A;
        Point B;
        Color color;
        public Ellipse(Point O, int a, int b, Color color) 
        {
            this.O = O;
            A.X = O.X + a;
            A.Y = O.Y;
            B.X = O.X;
            B.Y = O.Y + b;
            this.color = color;
        }
        private Point[] CreatePointArr() 
        {
            int n = 100;
            Point[] arr = new Point[n];
            for (int i = 0; i < n; i++) 
            {
                arr[i].X = (int)(O.X + (A.X - O.X) * Math.Cos(i * 2 * Math.PI / n) + 
                    (B.X - O.X) * Math.Sin(i * 2 * Math.PI / n));
                arr[i].Y = (int)(O.Y + (A.Y - O.Y) * Math.Cos(i * 2 * Math.PI / n) +
                  (B.Y - O.Y) * Math.Sin(i * 2 * Math.PI / n));

            }
            return arr;
        }
        public override void draw(Graphics g) 
        {
            Brush brush = new SolidBrush(this.color);
            g.FillPolygon(brush, CreatePointArr());
        }
        public override void renew(int dx, int dy)
        {
            O.X += dx;
            O.Y -= dy;
            A.X += dx;
            A.Y -= dy;
            B.X += dx;
            B.Y -= dy;
        }
    }

    public class Cross: Shape
    {
        Point O;
        int a;
        int b;
        Color color;
        public Cross(Point p, int a, int b, Color color)
        {
            O = p;
            this.a = a; 
            this.b = b;
            this.color = color;
        }

        public override void draw(Graphics g) 
        {
            Pen pen = new Pen(this.color, 5);
            g.DrawLine(pen, new Point(O.X - a, O.Y), new Point(O.X + a, O.Y));
            g.DrawLine(pen, new Point(O.X, O.Y - b), new Point(O.X, O.Y + b));
        }
        public override void renew(int dx, int dy)
        {
            O.X += dx;
            O.Y -= dy;
        }
    }
    public class Rhomb: Shape 
    {
        Point O;
        int a;
        int b;
        Color color;
        public Rhomb(Point p, int a, int b, Color color)
        {
            O = p;
            this.a = a;
            this.b = b;
            this.color = color;
        }
        public override void draw(Graphics g)
        {
            Pen pen = new Pen(this.color, 5);
            g.DrawLine(pen, new Point(O.X - a, O.Y), new Point(O.X, O.Y  - b));
            g.DrawLine(pen, new Point(O.X, O.Y - b), new Point(O.X + a, O.Y));
            g.DrawLine(pen, new Point(O.X + a, O.Y), new Point(O.X, O.Y + b));
            g.DrawLine(pen, new Point(O.X, O.Y + b), new Point(O.X - a, O.Y));
        }
        public override void renew(int dx, int dy)
        {
            O.X += dx;
            O.Y -= dy;
        }
    }
}
