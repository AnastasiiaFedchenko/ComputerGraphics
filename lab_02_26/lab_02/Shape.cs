using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    public abstract class Shape: EventArgs
    {
        public Shape() { }

        public abstract void draw(Graphics g);

        private void rotation(ref Point p, Change ch)
        {
            Point new_p = new Point(p.X, p.Y);
            new_p.X = (int)(ch.Ox1 + (p.X - ch.Ox1) * Math.Cos(ch.Degrees) + (p.Y - ch.Oy1) * Math.Sin(ch.Degrees));
            new_p.Y = (int)(ch.Oy1 - (p.X - ch.Ox1) * Math.Sin(ch.Degrees) + (p.Y - ch.Oy1) * Math.Cos(ch.Degrees));
            p = new_p;
        }
        private void shift(ref Point p, Change ch)
        {
            p.X += ch.Dx;
            p.Y += ch.Dy;
        }
        private void scaling(ref Point p, Change ch)
        {
            p.X = (int)(ch.Ox2 + ch.Kx * (p.X - ch.Ox2));
            p.Y = (int)(ch.Oy2 + ch.Ky * (p.Y - ch.Oy2));
        }
        protected void renew_point(ref Point p, Change ch, bool reversed)
        {
            if (!reversed)
            {
                rotation(ref p, ch);
                shift(ref p, ch);
                scaling(ref p, ch);
            }
            else
            {
                scaling(ref p, ch);
                shift(ref p, ch);
                rotation(ref p, ch);
            }
        }
        public abstract void renew(Change change, bool reversed);
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

        public override void renew(Change change, bool reversed)
        {
            for (int i = 0; i < points.Count(); i++)
            {
                renew_point(ref points[i], change, reversed);
            }
        }
    }

    public class Ellipse : Shape
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
        public override void renew(Change change, bool reversed)
        {
            renew_point(ref O, change, reversed);
            renew_point(ref A, change, reversed);
            renew_point(ref B, change, reversed);
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
        public override void renew(Change change, bool reversed)
        {
            renew_point(ref O, change, reversed);
            renew_point(ref A, change, reversed);
            renew_point(ref B, change, reversed);
        }
    }

    public class Cross : Cross_Rhomb
    {
        public Cross(Point p, int a, int b, Color color) : base(p, a, b, color) { }

        public override void draw(Graphics g)
        {
            Pen pen = new Pen(this.color, 5);

            g.DrawLine(pen, A, new Point(O.X + (O.X - A.X), O.Y - (A.Y - O.Y)));
            g.DrawLine(pen, B, new Point(O.X + (O.X - B.X), O.Y - (B.Y - O.Y)));
        }
    }
    public class Rhomb : Cross_Rhomb
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
