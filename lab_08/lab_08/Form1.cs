using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace lab_08
{
    public partial class Form1 : Form
    {
        List<Line> lines = null;
        Line line_now = null;
        //List<Line> frame = null;
        //Line edge_now = null;

        Graphics bitmap_graphics;
        Bitmap picture;
        Frame frame = null;
        //bool closed;
        bool result;
        public Form1()
        {
            InitializeComponent();
            picture = new Bitmap(PictureBox.Width, PictureBox.Width);
            bitmap_graphics = Graphics.FromImage(picture);
            lines = new List<Line>();
            result = false;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // добавляем точки отсекателя
            {
                if (frame == null)
                    frame = new Frame();
                if (frame.IsFinished())
                    return;
                frame.AddPoint(e.X, e.Y);
            }
            else if (e.Button == MouseButtons.Right) // добавляем отрезок
            {
                if (line_now == null)
                {
                    line_now = new Line();
                    line_now.X1 = e.X;
                    line_now.Y1 = e.Y;
                }
                else
                {
                    line_now.X2 = e.X;
                    line_now.Y2 = e.Y;
                    lines.Add(line_now);
                    line_now = null;
                }
            }
            result = false;
            PictureBox.Invalidate();
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(LineColorButton.BackColor);
            Pen pen = new Pen(LineColorButton.BackColor, 3);
            
            if (!result)
            { 
                if (lines != null)
                {
                    bitmap_graphics.FillRectangle(new SolidBrush(Form1.DefaultBackColor),
                                          0, 0, PictureBox.Width, PictureBox.Height);
                    foreach (Line line in lines) 
                        bitmap_graphics.DrawLine(pen, line.X1, line.Y1, line.X2, line.Y2);
                }
                if (line_now != null)
                    bitmap_graphics.FillRectangle(brush, line_now.X1 - 1, line_now.Y1 - 1, 2, 2);
            }
            brush = new SolidBrush(FrameColorButton.BackColor);
            pen = new Pen(FrameColorButton.BackColor, 3);
            if (frame != null)
            {
                if (frame.Count() == 1)
                    bitmap_graphics.FillRectangle(brush, frame.GetPoint(0).X - 1, frame.GetPoint(0).Y - 1, 2, 2);
                for (int i = 1; i < frame.Count(); i++)
                    bitmap_graphics.DrawLine(pen, frame.GetPoint(i - 1), frame.GetPoint(i));
            }
            g.DrawImage(picture, 0, 0);
        }

        /*private void Close_Click(object sender, EventArgs e)
        {
            if (frame != null) 
            {
                edge_now.X2 = frame[0].X1;
                edge_now.Y2 = frame[0].Y1;
                frame.Add(edge_now);
                edge_now = null;
                closed = true;
            }
            PictureBox.Invalidate();
        }*/

        private void BuildLineButton_Click(object sender, EventArgs e)
        {
            int x1, y1, x2, y2;
            if (int.TryParse(XsTextBox.Text, out x1) == false)
            {
                MessageBox.Show("Problem with xs. The value should be integer");
                return;
            }
            if (int.TryParse(YsTextBox.Text, out y1) == false)
            {
                MessageBox.Show("Problem with ys. The value should be integer");
                return;
            }
            if (int.TryParse(XfTextBox.Text, out x2) == false)
            {
                MessageBox.Show("Problem with xf. The value should be integer");
                return;
            }
            if (int.TryParse(YfTextBox.Text, out y2) == false)
            {
                MessageBox.Show("Problem with yf. The value should be integer");
                return;
            }
            lines.Add(new Line(x1, y1, x2, y2));
            result = false;
            PictureBox.Invalidate();
        }

        private void BuildFrame_Click(object sender, EventArgs e)
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
            if (frame == null)
                frame = new Frame();
            frame.AddPoint(x, y);
            PictureBox.Invalidate();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            frame = null;
            //edge_now = null;
            lines = null;
            line_now = null;
            result = false;
            PictureBox.Invalidate();
        }

        private void CutOff_Click(object sender, EventArgs e)
        {
            frame.Finish();
            Pen pen_cut = new Pen(FrameColorButton.BackColor, 3);
            Pen pen_res = new Pen(ResultColorButton.BackColor, 3);
            bitmap_graphics.DrawLine(pen_cut, frame.GetPoint(0), frame.GetPoint(-1));
            if (!frame.IsConvex())
            {
                MessageBox.Show("Многоугольник не выпуклый.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Line tmp;
            for (int i = 0; i < lines.Count(); i++)
            {
                tmp = frame.CutCyrusBeck(lines[i]);
                bitmap_graphics.DrawLine(pen_res, tmp.X1, tmp.Y1, tmp.X2, tmp.Y2);
            }
            result = true;
            PictureBox.Invalidate();
        }

        private void LineColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.Color = LineColorButton.BackColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
                LineColorButton.BackColor = MyDialog.Color;
        }

        private void FrameColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.Color = FrameColorButton.BackColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
                FrameColorButton.BackColor = MyDialog.Color;
        }

        private void ResultColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.Color = ResultColorButton.BackColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
                ResultColorButton.BackColor = MyDialog.Color;
        }
    }
    public class Line
    {
        float x1, y1, x2, y2;
        public Line()
        {
            this.x1 = 0;
            this.y1 = 0;
            this.x2 = 0;
            this.y2 = 0;
        }
        public Line(float x1, float y1, float x2, float y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public float X1 { get { return x1; } set { x1 = value; } }
        public float Y1 { get { return y1; } set { y1 = value; } }
        public float X2 { get { return x2; } set { x2 = value; } }
        public float Y2 { get { return y2; } set { y2 = value; } }

        private float GetCoordX(float t)
        {
            return x1 + (x2 - x1) * t;
        }
        private float GetCoordY(float t)
        {
            return y1 + (y2 - y1) * t;
        }
        public PointF GetDot(float t)
        {
            return new PointF(GetCoordX(t), GetCoordY(t));
        }

    }
    class Frame
    {
        private List<Vector> normal;
        private List<PointF> points;
        private bool finished_input = false;
        private int walk_direction = 0;

        public Frame()
        {
            points = new List<PointF>();
            normal = new List<Vector>();
        }

        public void AddPoint(PointF dot)
        {
            points.Add(dot);
        }
        public void AddPoint(float x, float y)
        {
            points.Add(new PointF(x, y));
        }

        public int Count() { return points.Count(); }

        public void Clear()
        {
            points.Clear();
            normal.Clear();
            finished_input = false;
            walk_direction = 0;
        }

        // Закончен ввод отсекателя
        public void Finish()
        {
            finished_input = true;
            walk_direction = ConvexityCheck();
            FindNormalVectors(walk_direction);
        }

        public bool IsFinished()
        {
            return finished_input;
        }

        public bool IsEmpty()
        {
            return true ? (points.Count == 0) : false;
        }

        // Получение вершины по индексу
        public PointF GetPoint(int index)
        {
            if (index < 0)
                return points[points.Count + index]; // Вершина с конца
            else
                return points[index % points.Count];
        }

        // Проверка выпуклости; возвращает направление обхода
        private int ConvexityCheck()
        {
            if (points.Count < 3)
                return 0;

            Vector a = new Vector(points[1].X, points[1].Y, points[0].X, points[0].Y);
            Vector b = new Vector();
            Vector res = new Vector();

            int sign = 0;

            for (int i = 0; i < points.Count; i++)
            {
                b = new Vector(GetPoint(i + 1).X, GetPoint(i + 1).Y, GetPoint(i).X, GetPoint(i).Y);
                Vector.VectorMultiplication(a, b, ref res);

                if (sign == 0)
                    sign = Math.Sign(res.z);
                else if ((sign != Math.Sign(res.z)) && (res.z != 0))
                    return 0;

                a = b;
            }

            if (sign == 0) // Вырождается в линию
                return 0;

            return sign;
        }

        public bool IsConvex()
        {
            if (walk_direction == 0)
                return false;
            return true;
        }

        // Нахождение векторов нормали для отсекателя
        private void FindNormalVectors(int direction)
        {
            Vector b;
            float tmp;
            normal.Clear();

            for (int i = 0; i < points.Count; i++)
            {
                b = new Vector(GetPoint(i + 1).X, GetPoint(i + 1).Y, GetPoint(i).X, GetPoint(i).Y);

                tmp = b.x;
                b.x = b.y;
                b.y = tmp;

                if (direction == -1)
                    b.y *= -1;
                else
                    b.x *= -1;
                normal.Add(b);
            }
        }

        // Алгоритм Кируса-Бека по отсечению отрезка
        public Line CutCyrusBeck(Line l)
        {

            float t_down = 0, t_up = 1;
            float t_tmp;

            Vector D = new Vector(l.X2, l.Y2, l.X1, l.Y1);
            Vector w;

            float D_sc;
            float W_sc;

            for (int i = 0; i < points.Count; i++)
            {
                w = new Vector(l.X1, l.Y1, points[i].X, points[i].Y);
                D_sc = Vector.ScalarMultiplication(D, normal[i]);
                W_sc = Vector.ScalarMultiplication(w, normal[i]);

                if (D_sc == 0) // отрезок выродился в точку / D и сторона парралельны
                {
                    if (W_sc < 0)
                        return new Line();
                    // точка видима относительно текущей границы
                }
                else
                {
                    t_tmp = -1 * (W_sc / D_sc);
                    if (D_sc > 0) // поиск нижнего предела
                    {
                        if (t_tmp > 1)
                            return new Line();
                        t_down = Math.Max(t_down, t_tmp);
                    }
                    else // поиск верхнего предела
                    {
                        if (t_tmp < 0)
                            return new Line();
                        t_up = Math.Min(t_up, t_tmp);
                    }
                }
            }
            if (t_down > t_up)
                return new Line();
            return new Line(l.GetDot(t_down).X, l.GetDot(t_down).Y, l.GetDot(t_up).X, l.GetDot(t_up).Y);
        }
    }
    class Vector
    {
        public float x;
        public float y;
        public float z;

        public Vector()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }
        public Vector(float a, float b, float c)
        {
            this.x = a;
            this.y = b;
            this.z = c;
        }

        public Vector(float xe, float ye, float xs, float ys)
        {
            this.x = xe - xs;
            this.y = ye - ys;
            this.z = 0;
        }

        public static void VectorMultiplication(Vector a, Vector b, ref Vector res)
        {
            res.x = a.y * b.z - a.z * b.y;
            res.y = a.z * b.x - a.x * b.z;
            res.z = a.x * b.y - a.y * b.x;
        }

        public static float ScalarMultiplication(Vector a, Vector b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }
    }
}
