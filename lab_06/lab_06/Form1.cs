using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace lab_06
{
    public partial class Form1 : Form
    {
        List<Figure> figures;
        List<Circle> circles;
        List<Ellipse> ellipses;
        Figure fig; // для многоугольинка
        Figure temp; // для плавных фигур

        Point zatravka_point;
        bool there_is_zatravka;

        Graphics bitmap_graphics;
        Bitmap picture;
        List<Pixel> pixels;

        //List<Line> lines = null;
        bool closed;
        bool drawing;
        //bool abstract_fig_closed;
        public Form1()
        {
            InitializeComponent();
            figures = new List<Figure>();
            circles = new List<Circle>();
            ellipses = new List<Ellipse>();
            fig = new Figure();
            temp = null;
            there_is_zatravka = false;
            picture = new Bitmap(PictureBox.Width, PictureBox.Width);
            bitmap_graphics = Graphics.FromImage(picture);
            pixels = new List<Pixel>();

            closed = true; ;
            //abstract_fig_closed = true;
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
            Brush brush = new SolidBrush(LineColorButton.BackColor);
            Pen pen = new Pen(LineColorButton.BackColor, 1);
            Graphics g = e.Graphics;
            // нынешний многоугольник
            foreach(Point p in fig.tops)
                bitmap_graphics.FillRectangle(brush, p.X - 1, p.Y - 1, 2, 2);
            for (int i = 0; i < fig.edges.Count; i++)
                bitmap_graphics.DrawLine(pen, fig.edges[i].p1, fig.edges[i].p2);
            // нынешняя плавная фигура
            if (temp != null)
            {
                foreach (Point p in temp.tops)
                    bitmap_graphics.FillRectangle(brush, p.X - 1, p.Y - 1, 2, 2);
                for (int i = 0; i < temp.edges.Count; i++)
                    bitmap_graphics.DrawLine(pen, temp.edges[i].p1, temp.edges[i].p2);
            }
            // остальные многоугольники
            foreach (Figure f in figures)
                foreach (Point p in f.tops)
                    bitmap_graphics.FillRectangle(brush, p.X - 1, p.Y - 1, 2, 2);
            foreach (Figure f in figures)
                for (int i = 0; i < f.edges.Count; i++)
                    bitmap_graphics.DrawLine(pen, f.edges[i].p1, f.edges[i].p2);
            // круги
            foreach (Circle circle in circles)
                circle.draw(bitmap_graphics);
            // эллипсы
            foreach (Ellipse ellipse in ellipses)
                ellipse.draw(bitmap_graphics);
            // затравка
            if (there_is_zatravka)
            {
                brush = new SolidBrush(FillingColorButton.BackColor);
                bitmap_graphics.FillRectangle(brush, zatravka_point.X, zatravka_point.Y, 4, 4);
            }
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
            closed = false;
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
            circles = new List<Circle>();
            ellipses = new List<Ellipse>();
            fig = new Figure();
            Brush brush = new SolidBrush(Form1.DefaultBackColor);
            bitmap_graphics.FillRectangle(brush, 0, 0, picture.Width, picture.Height);

            closed = true;
            PictureBox.Invalidate();
            PointsListBox.Items.Clear();
        }

        private void MakeCircleButton_Click(object sender, EventArgs e)
        {
            int ox, oy, r;
            if (int.TryParse(OxTextBox.Text, out ox) == false)
            {
                MessageBox.Show("Problem with ox. The value should be integer");
                return;
            }
            if (int.TryParse(OyTextBox.Text, out oy) == false)
            {
                MessageBox.Show("Problem with oy. The value should be integer");
                return;
            }
            if (int.TryParse(RTextBox.Text, out r) == false)
            {
                MessageBox.Show("Problem with r. The value should be integer");
                return;
            }
            Circle circle = new Circle(ox, oy, r, LineColorButton.BackColor, LineColorButton.BackColor);
            circle.controller(Method.Bresenham, false);
            circles.Add(circle);
            PictureBox.Invalidate();
        }

        private void MakeEllipseButton_Click(object sender, EventArgs e)
        {
            int ox, oy, rx, ry;
            if (int.TryParse(OxTextBox.Text, out ox) == false)
            {
                MessageBox.Show("Problem with ox. The value should be integer");
                return;
            }
            if (int.TryParse(OyTextBox.Text, out oy) == false)
            {
                MessageBox.Show("Problem with oy. The value should be integer");
                return;
            }
            if (int.TryParse(RxTextBox.Text, out rx) == false)
            {
                MessageBox.Show("Problem with rx. The value should be integer");
                return;
            }
            if (int.TryParse(RyTextBox.Text, out ry) == false)
            {
                MessageBox.Show("Problem with ry. The value should be integer");
                return;
            }
            Ellipse ellipse = new Ellipse(ox, oy, rx, ry, LineColorButton.BackColor, LineColorButton.BackColor);
            ellipse.controller(Method.Bresenham, false);
            ellipses.Add(ellipse);
            PictureBox.Invalidate();
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            temp = new Figure();
            temp.tops.Add(new Point(e.X, e.Y));
            drawing = true;
            PictureBox.Invalidate();
        }
        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                temp.tops.Add(new Point(e.X, e.Y));
                temp.edges.Add(new Edge(temp.tops[temp.tops.Count - 2], temp.tops[temp.tops.Count - 1]));
                PictureBox.Invalidate();
            }
        }
        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                temp.edges.Add(new Edge(temp.tops[temp.tops.Count - 1], temp.tops[0]));
                drawing = false;
                figures.Add(temp);
                temp = null;
            }
        }

        private void LineColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.Color = LineColorButton.BackColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
                LineColorButton.BackColor = MyDialog.Color;
        }

        private void FillingColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.Color = FillingColorButton.BackColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
                FillingColorButton.BackColor = MyDialog.Color;
        }

        private void AddZatravka_Click(object sender, EventArgs e)
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
            zatravka_point = new Point(x, y);
            there_is_zatravka = true;
            PictureBox.Invalidate();
        }

        private void PictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            zatravka_point = new Point(e.X, e.Y);
            there_is_zatravka = true;
            PictureBox.Invalidate();
        }
        private void draw_pixel(int x, int y, Color color) 
        {
            //Brush brush = new SolidBrush(color);
            picture.SetPixel(x, y, color);
            //bitmap_graphics.FillRectangle(brush, x, y, 1, 1);
            pixels.Add(new Pixel(x, y, color));
            //picture.Save("img.jpg", ImageFormat.Jpeg);
            //PictureBox.Invalidate();
        }
        bool compare_colors (Color color1, Color color2) 
        {
            if (color1.A == color2.A && color1.R == color2.R && color1.G == color2.G && color1.B == color2.B)
                return true;
            return false;
        }
        private void line_by_line_filling_with_zatravka() 
        {
            int i = 0;
            picture.Save("img.jpg", ImageFormat.Jpeg);

            Stack<Point> stack = new Stack<Point>();
            stack.Push(zatravka_point);
            while (stack.Count > 0) 
            {
                Point seed = stack.Pop();
                int x = seed.X;
                int y = seed.Y;
                draw_pixel(x, y, FillingColorButton.BackColor);
                int temp_x = x;
                int temp_y = y;
                // right
                x++;
                while (x < PictureBox.Width &&
                    picture.GetPixel(x, y).ToArgb() != FillingColorButton.BackColor.ToArgb() &&
                    picture.GetPixel(x, y).ToArgb() != LineColorButton.BackColor.ToArgb())
                {
                    // может быть проблема в названии надо сравнить по элементно

                    //picture.Save("img.jpg", ImageFormat.Jpeg);
                    Color c = picture.GetPixel(x, y);
                    //if (c != Color.FromArgb(0, 0, 0, 0))
                        //i++;
                    draw_pixel(x, y, FillingColorButton.BackColor);
                    //picture.Save("img.jpg", ImageFormat.Jpeg);
                    x++;
                }
                int xr = x - 1;
                // left
                x = temp_x - 1;
                while (x > 0 &&
                    picture.GetPixel(x, y).ToArgb() != FillingColorButton.BackColor.ToArgb() &&
                    picture.GetPixel(x, y).ToArgb() != LineColorButton.BackColor.ToArgb())
                {
                    draw_pixel(x, y, FillingColorButton.BackColor);
                    x--;
                }
                int xl = x + 1;

                
                bool flag;
                x = xl;
                if (temp_y < PictureBox.Height) 
                {
                    // along top boarder
                    y = temp_y + 1;
                    while (x <= xr) 
                    {
                        flag = false;
                        Color c = picture.GetPixel(200, 100);
                        while (x <= xr &&
                               picture.GetPixel(x, y).ToArgb() != FillingColorButton.BackColor.ToArgb() &&
                               picture.GetPixel(x, y).ToArgb() != LineColorButton.BackColor.ToArgb())
                        {
                            //picture.Save("img.jpg", ImageFormat.Jpeg);
                            flag = true;
                            x++;
                        }
                        if (flag)
                        {
                            if (x == xr &&
                                picture.GetPixel(x, y).ToArgb() != FillingColorButton.BackColor.ToArgb() &&
                                picture.GetPixel(x, y).ToArgb() != LineColorButton.BackColor.ToArgb())
                            {
                                if (y < PictureBox.Height)
                                    stack.Push(new Point(x, y));
                            }
                            else
                            {
                                if (y < PictureBox.Height)
                                    stack.Push(new Point(x - 1, y));
                            }
                            flag = false;
                        }
                        int x_in = x;
                        while (x < xr && (picture.GetPixel(x, y).ToArgb() == FillingColorButton.BackColor.ToArgb() ||
                                          picture.GetPixel(x, y).ToArgb() == LineColorButton.BackColor.ToArgb()))
                            x++;
                        if (x == x_in)
                            x++;
                    }

                    // along lower boarder
                    x = xl;
                    y = temp_y - 1;
                    while(x <= xr) 
                    {
                        flag = false;
                        while (x <= xr &&
                               picture.GetPixel(x, y).ToArgb() != FillingColorButton.BackColor.ToArgb() &&
                               picture.GetPixel(x, y).ToArgb() != LineColorButton.BackColor.ToArgb())
                        {
                            flag = true;
                            x++;
                        }
                        if (flag)
                        {
                            if (x == xr &&
                                picture.GetPixel(x, y).ToArgb() != FillingColorButton.BackColor.ToArgb() &&
                                picture.GetPixel(x, y).ToArgb() != LineColorButton.BackColor.ToArgb())
                            {
                                if (y > 0)
                                    stack.Push(new Point(x, y));
                            }
                            else
                            {
                                if (y > 0)
                                    stack.Push(new Point(x - 1, y));
                            }
                            flag = false;
                        }
                        int x_in = x;
                        while (x < xr && (picture.GetPixel(x, y).ToArgb() == FillingColorButton.BackColor.ToArgb() ||
                                          picture.GetPixel(x, y).ToArgb() == LineColorButton.BackColor.ToArgb()))
                            x++;
                        if (x == x_in)
                            x++;
                    }
                }
                PictureBox.Invalidate();
            }
        }

        private void ColorThePictureButton_Click(object sender, EventArgs e)
        {
            if (closed == false)
            {
                MessageBox.Show("All figures must be closed.");
                return; 
            }
            line_by_line_filling_with_zatravka();
            PictureBox.Invalidate();
        }
    }
    class Figure 
    {
        public List <Point> tops;
        public List <Edge> edges;
        public Figure() { edges = new List<Edge>(); tops = new List<Point>(); }
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
    class Pixel
    {
        public int x;
        public int y;
        public Color color;
        public Pixel(int x, int y, Color color) 
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }
    }
}