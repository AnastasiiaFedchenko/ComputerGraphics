using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lab_05_01
{

    public partial class Form1 : Form
    {
        List<Point> vertices;
        List<(Point, Point)> edges;
        List<Point> cross_points;
        Dictionary<int, List<Node>> y_groups;
        //List<Point> pixels;
        Graphics bitmap_graphics;
        Bitmap picture;
        bool closed;
        public Form1()
        {
            InitializeComponent();
            vertices = new List<Point>();
            edges = new List<(Point, Point)>();
            cross_points = new List<Point>();
            //pixels = new List<Point>();
            picture = new Bitmap(PictureBox.Width, PictureBox.Width);
            bitmap_graphics = Graphics.FromImage(picture);
            closed = false;
        }

        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (closed == false)
            {
                vertices.Add(new Point(e.X, e.Y));
                if (vertices.Count > 1)
                    edges.Add((vertices[vertices.Count - 2], vertices[vertices.Count - 1]));
                PointsListBox.Items.Add(vertices[vertices.Count - 1]);
                PictureBox.Invalidate();
            }
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Brush brush = new SolidBrush(ColorButton.BackColor);
            Pen pen = new Pen(ColorButton.BackColor, 1);
            foreach (Point p in vertices)
                bitmap_graphics.FillRectangle(brush, p.X - 1, p.Y - 1, 2, 2);
            for (int i = 0; i < edges.Count; i++)
                bitmap_graphics.DrawLine(pen, edges[i].Item1, edges[i].Item2);
            PictureBox.Image = picture;
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
            vertices.Add(new Point(x, y));
            if (vertices.Count > 1)
                edges.Add((vertices[vertices.Count - 2], vertices[vertices.Count - 1]));
            PointsListBox.Items.Add(vertices[vertices.Count - 1]);
            PictureBox.Invalidate();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            closed = false;
            vertices.Clear();
            edges.Clear();
            cross_points.Clear();
            PointsListBox.Items.Clear();
            PictureBox.Invalidate();
        }

        private void CloseFigureButton_Click(object sender, EventArgs e)
        {
            if (closed == false)
            {
                if (vertices.Count > 3)
                {
                    edges.Add((vertices[vertices.Count - 1], vertices[0]));
                    closed = true;
                }
            }
            PictureBox.Invalidate();
        }
        private int Min_y()
        {
            int min_y = vertices[0].Y;
            foreach (var vertex in vertices)
                if (vertex.Y < min_y)
                    min_y = vertex.Y;
            return min_y;
        }
        private int Max_y()
        {
            int max_y = vertices[0].Y;
            foreach (var vertex in vertices)
                if (vertex.Y > max_y)
                    max_y = vertex.Y;
            return max_y;
        }

        private void update_y_groups(Point p1, Point p2)
        {
            Point p_start = (p1.Y <= p2.Y) ? p1 : p2;
            Point p_end = (p1.Y > p2.Y) ? p1 : p2;
            double y_proj = Math.Abs(p_end.Y - p_start.Y);
            double x_step;
            if (y_proj != 0)
            {
                x_step = -(p_end.X - p_start.X) / y_proj;
                y_groups[p_end.Y].Add(new Node(p_end.X, x_step, y_proj));
            }
        }

        private void make_y_groups(int min_y, int max_y)
        {
            y_groups = new Dictionary<int, List<Node>>();
            for (int y = min_y; y <= max_y; y++)
                y_groups.Add(y, new List<Node>());
        }

        private void iterator_active_edges(List<Node> active_edges)
        {
            int i = 0;
            while (i < active_edges.Count)
            {
                active_edges[i].X += active_edges[i].Dx;
                active_edges[i].Dy -= 1;
                if (active_edges[i].Dy < 1)
                    active_edges.RemoveAt(i);
                else
                    i += 1;
            }
        }

        private static int CompareNodesByX(Node a, Node b) 
        {
            return (int)(a.X - b.X);
        }
        private void add_active_edges(List<Node> active_edges, int y)
        {
            for (int i = 0; i < y_groups[y].Count; i++)
                active_edges.Add(y_groups[y][i]);
            active_edges.Sort(CompareNodesByX);
        }

        private double cross_point_x(double y, Point p1, Point p2) 
        {
            return ((p2.X - p1.X)*(y - p1.Y) + p1.X * (p2.Y - p1.Y)) / (p2.Y - p1.Y);
        }

        private void draw_part(List<Node> active_edges, int y)
        {
            Pen pen = new Pen(ColorButton.BackColor, 1);
            for (int i = 0; i < active_edges.Count; i += 2)
                bitmap_graphics.DrawLine(pen, (int)active_edges[i].X, y, (int)active_edges[i + 1].X, y);
        }
        private void ColorThePicture(bool delay) 
        {
            int min_y =Min_y();
            int max_y = Max_y();
            for (double y = min_y + 0.5; y < max_y; y += 1.0) 
            {
                foreach (var edge in edges) 
                {
                    if (edge.Item1.Y != edge.Item2.Y && 
                        y >= Math.Min(edge.Item1.Y, edge.Item2.Y) && y < Math.Max(edge.Item1.Y, edge.Item2.Y)) 
                    {
                        cross_points.Add(new Point((int)cross_point_x(y, edge.Item1, edge.Item2), (int)y));
                    }
                }
            }
            make_y_groups(min_y, max_y);
            foreach (var edge in edges)
                update_y_groups(edge.Item1, edge.Item2);
            List<Node> active_edges = new List<Node> ();
            while (max_y > min_y)
            {
                iterator_active_edges(active_edges);
                add_active_edges(active_edges, max_y);
                max_y -= 1;
                draw_part(active_edges, max_y);
            }
        }

        private void ColorThePictureButton_Click(object sender, EventArgs e)
        {
            if (vertices.Count < 3)
            {
                MessageBox.Show("Not enough points too make polygon.");
                return;
            }
            if (closed == false)
            {
                MessageBox.Show("The polygon is not closed.");
                return;
            }
            ColorThePicture(false);
            PictureBox.Invalidate();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.Color = ColorButton.BackColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
                ColorButton.BackColor = MyDialog.Color;
        }
    }
    public class Node 
    {
        double x;
        double dx, dy;
        public Node(int x, double dx, double dy) 
        {
            this.x = x;
            this.dx = dx;
            this.dy = dy; 
        }
        public double X { get { return x; } set {  x = value; } }
        public double Dx { get { return dx; } set { dx = value; } }
        public double Dy { get { return dy; } set { dy = value; } }
    }
}
