using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab_01
{
    public class Shape: EventArgs
    {
        protected double x;
        protected double y;
        protected int r;
        protected Color color;
        protected bool draganddropped;
        protected int offsetX;
        protected int offsetY;
        protected SolidBrush brush;
        public Shape(double x, double y, Color color_now)
        {
            this.x = x;
            this.y = y;
            this.r = 15; 
            draganddropped = true;
            color = color_now;
            brush = new SolidBrush(color);
        }
        public double X
        { get { return x; } set { x = value; } }
        public double Y
        { get { return y; } set { y = value; } }
        public int R
        { get { return r; } set { r = value; } }
        public Color COLOR
        {
            get { return color; }
            set
            {
                color = value;
                brush = new SolidBrush(color);
            }
        }
        public bool DragAndDropped
        {   get
            { return draganddropped; }
            set
            { draganddropped = value; }
        }
        public int OffsetX
        {
            get
            { return offsetX; }
            set
            { offsetX = value; }
        }

        public int OffsetY
        {
            get
            { return offsetY; }
            set
            { offsetY = value; }
        }
        public void draw(Graphics g, int OX, int OY, double K) 
        {
            g.FillEllipse(brush, OX + (int)(x * K) - r, OY - (int)(y * K) - r, 2 * r, 2 * r);
        }
        public bool IsInside(int xCursor, int yCursor, int OX, int OY, double K)
        {
            if (Math.Sqrt(Math.Pow((x * K) + OX - xCursor, 2.0) + Math.Pow(OY - (y * K) - yCursor, 2.0)) <= (double)r)
            {
                return true;
            }
            return false;
        }

        public delegate void NewPointCanBeAdded(object sender, Shape e);
    }
}
