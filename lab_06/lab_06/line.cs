using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace lab_06
{
    public enum Method
    {
        Canonic,
        Parametric,
        MiddlePoint,
        Bresenham,
        Lib
    };
    public class line
    {
        Point p1;
        Point p2;
        Color color;
        public line(int x1, int y1, int x2, int y2, Color color)
        {
            this.p1.X = x1;
            this.p1.Y = y1;
            this.p2.X = x2;
            this.p2.Y = y2;
            this.color = color;
        }
        public Point P1 { get { return this.p1; } }
        public Point P2 { get { return this.p2; } }
        public void draw(Graphics g) 
        {
            Pen pen = new Pen(color);
            pen.Width = 1;
            Point temp1 = new Point(p1.X, p1.Y);
            Point temp2 = new Point(p2.X, p2.Y);
            g.DrawLine(pen, temp1, temp2);
        }
        public Color Color { get { return color; } }
    }
}
