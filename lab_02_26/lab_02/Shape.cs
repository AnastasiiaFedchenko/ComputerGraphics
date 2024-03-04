using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_02
{
    public abstract class Shape: EventArgs
    {
        public Shape() { }

        public abstract void draw(Graphics g);

        private protected void renew_point(ref Point p, int Ox1, int Oy1, double degrees, int dx, int dy, int Ox2, int Oy2, double kx, double ky) 
        {
            Point new_p = new Point(p.X, p.Y);
            new_p.X = (int)(Ox1 + (p.X - Ox1) * Math.Cos(degrees) + (p.Y - Oy1) * Math.Sin(degrees));
            new_p.Y = (int)(Oy1 - (p.X - Ox1) * Math.Sin(degrees) + (p.Y - Oy1) * Math.Cos(degrees));
            new_p.X += dx;
            new_p.Y -= dy;
            new_p.X = (int)(kx * new_p.X + Ox2 * (1 - kx));
            new_p.Y = (int)(ky * new_p.Y + Oy2 * (1 - ky));
            p = new_p;
        }
        public abstract void renew(int Ox1, int Oy1, double degrees, int dx, int dy, int Ox2, int Oy2, double kx, double ky);
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

        public override void renew(int Ox1, int Oy1, double degrees, int dx, int dy, int Ox2, int Oy2, double kx, double ky)
        {
            for (int i = 0; i < points.Count(); i++) 
            {
                renew_point(ref points[i], Ox1, Oy1, degrees, dx, dy, Ox2, Oy2, kx, ky);
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
        public override void renew(int Ox1, int Oy1, double degrees, int dx, int dy, int Ox2, int Oy2, double kx, double ky)
        {
            renew_point(ref O, Ox1, Oy1, degrees, dx, dy, Ox2, Oy2, kx, ky);
            renew_point(ref A, Ox1, Oy1, degrees, dx, dy, Ox2, Oy2, kx, ky);
            renew_point(ref B, Ox1, Oy1, degrees, dx, dy, Ox2, Oy2, kx, ky);
        }
    }

    public abstract class Cross_Rhomb : Shape
    {
        protected Point O;
        protected Point A;
        protected Point B;
        protected Color color;
        public Cross_Rhomb(Point p, int a, int b, Color color)
        {
            O = p;
            A = new Point(O.X - a, O.Y);
            B = new Point(O.X, O.Y - b);
            this.color = color;
        }
        public override void renew(int Ox1, int Oy1, double degrees, int dx, int dy, int Ox2, int Oy2, double kx, double ky)
        {
            renew_point(ref O, Ox1, Oy1, degrees, dx, dy, Ox2, Oy2, kx, ky);
            renew_point(ref A, Ox1, Oy1, degrees, dx, dy, Ox2, Oy2, kx, ky);
            renew_point(ref B, Ox1, Oy1, degrees, dx, dy, Ox2, Oy2, kx, ky);
        }
    }

    public class Cross: Cross_Rhomb
    {
        public Cross(Point p, int a, int b, Color color) : base(p, a, b, color) {}

        public override void draw(Graphics g) 
        {
            Pen pen = new Pen(this.color, 5);

            g.DrawLine(pen, A, new Point(O.X + (O.X - A.X), O.Y - (A.Y - O.Y)));
            g.DrawLine(pen, B, new Point(O.X + (O.X - B.X), O.Y - (B.Y - O.Y)));
            //g.DrawEllipse(new Pen(Color.Black, 5), O.X - 5, O.Y - 5, 5, 5);
            //g.DrawEllipse(new Pen(Color.Black, 5), A.X - 5, A.Y - 5, 5, 5);
            //g.DrawEllipse(new Pen(Color.Black, 5), B.X - 5, B.Y - 5, 5, 5);
        }
    }
    public class Rhomb: Cross_Rhomb 
    {
        public Rhomb(Point p, int a, int b, Color color) : base(p, a, b, color) { }
        public override void draw(Graphics g)
        {
            Pen pen = new Pen(this.color, 5);
            g.DrawLine(pen, A, B);
            g.DrawLine(pen, B, new Point(O.X + (O.X - A.X), O.Y - (A.Y - O.Y)));
            g.DrawLine(pen, new Point(O.X + (O.X - A.X), O.Y - (A.Y - O.Y)), new Point(O.X + (O.X - B.X), O.Y - (B.Y - O.Y)));
            g.DrawLine(pen, new Point(O.X + (O.X - B.X), O.Y - (B.Y - O.Y)), A);
        }
    }
}
