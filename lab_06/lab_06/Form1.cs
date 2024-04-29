using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_06
{
    public partial class Form1 : Form
    {
        List<Figure> figures;
        Figure fig;
        Graphics bitmap_graphics;
        Bitmap picture;

        //List<Line> lines = null;
        bool closed;
        public Form1()
        {
            InitializeComponent();
            figures = new List<Figure>();
            fig = new Figure();
            picture = new Bitmap(PictureBox.Width, PictureBox.Width);
            bitmap_graphics = Graphics.FromImage(picture);

            closed = false;
        }
        

        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (closed == true)
                closed = false;

            fig.tops.Add(new Point(e.X, e.Y));
            if (fig.tops.Count > 1)
            {
                Edge temp = new Edge(fig.tops[fig.tops.Count - 2], fig.tops[fig.tops.Count - 1]);
                fig.edges.Add(temp);
            }
            PointsListBox.Items.Add(fig.tops[fig.tops.Count - 1]);
            PictureBox.Invalidate();
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Brush brush = new SolidBrush(FillingColorButton.BackColor);
            Pen pen = new Pen(LineColorButton.BackColor, 1);
            Graphics g = e.Graphics;
            // вершины
            foreach(Point p in fig.tops)
                bitmap_graphics.FillRectangle(brush, p.X - 1, p.Y - 1, 2, 2);
            foreach (Figure f in figures)
                foreach (Point p in f.tops)
                    bitmap_graphics.FillRectangle(brush, p.X - 1, p.Y - 1, 2, 2);
            // рёбра
            for (int i = 0; i < fig.edges.Count; i++)
                bitmap_graphics.DrawLine(pen, fig.edges[i].p1, fig.edges[i].p2);
            foreach (Figure f in figures)
                for (int i = 0; i < f.edges.Count; i++)
                    bitmap_graphics.DrawLine(pen, f.edges[i].p1, f.edges[i].p2);
            //PictureBox.Image = picture;
            /*if (lines != null)
                foreach (Line line in lines)
                {
                    bitmap_graphics.DrawLine(pen, line.X1, line.Y1, line.X2, line.Y2);
                    g.DrawImage(picture, 0, 0);
                }*/
            g.DrawImage(picture, 0, 0);
        }

        private void AddPointButton_Click(object sender, EventArgs e)
        {
            int x, y;
            if (int.TryParse(XTextBox.Text, out x) == false)
            {
                MessageBox.Show("Problem with x. The value should be integer");
                return;
            }
            if (int.TryParse(YTextBox.Text, out y) == false)
            {
                MessageBox.Show("Problem with y. The value should be integer");
                return;
            }
            if (closed == true)
                closed = false;
            fig.tops.Add(new Point(x, y));
            if (fig.tops.Count > 1)
            {
                Edge temp = new Edge(fig.tops[fig.tops.Count - 2], fig.tops[fig.tops.Count - 1]);
                fig.edges.Add(temp);
            }
            PointsListBox.Items.Add(fig.tops[fig.tops.Count - 1]);
            PictureBox.Invalidate();
        }

        private void CloseFigureButton_Click(object sender, EventArgs e)
        {
            if (closed == false)
            {
                if (fig.tops.Count >= 3)
                {
                    fig.edges.Add(new Edge(fig.tops[fig.tops.Count - 1], fig.tops[0]));
                    closed = true;
                    figures.Add(fig);
                    fig = new Figure();
                }
            }
            PictureBox.Invalidate();
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            figures = new List<Figure>();
            fig = new Figure();
            Brush brush = new SolidBrush(Form1.DefaultBackColor);
            bitmap_graphics.FillRectangle(brush, 0, 0, picture.Width, picture.Height);

            closed = false;
        }
    }
    class Figure 
    {
        public List <Point> tops;
        public List <Edge> edges;
        public Figure() { edges = new List<Edge>(); tops = new List<Point>(); }
        /*public void AddEdge(Edge edge) { edges.Add(edge); }
        public void AddPoint(Point point) { tops.Add(point); } 

        public Point point(int i) { return tops[i]; }
        public void point(int i, Point value) { tops[i] = value; }
        public int Point_Count() { return  tops.Count; }*/
    }
    class Edge 
    {
        public Point p1;
        public Point p2;
        public Edge(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }
    }
    class Line
    {
        int x1, y1, x2, y2;
        public Line(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public int X1 { get { return x1; } set { x1 = value; } }
        public int Y1 { get { return y1; } set { y1 = value; } }
        public int X2 { get { return x2; } set { x2 = value; } }
        public int Y2 { get { return y2; } set { y2 = value; } }

    }
}