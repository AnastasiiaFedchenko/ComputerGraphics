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

namespace lab_09
{
    public partial class Form1 : Form
    {
        List<PointF> figure = null;
        bool figure_closed = false;
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
            figure = new List<PointF>();
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
                if (figure == null)
                    figure = new List<PointF>();  
                figure.Add(new PointF(e.X, e.Y));
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
                if (figure != null)
                {
                    bitmap_graphics.FillRectangle(new SolidBrush(Form1.DefaultBackColor),
                                          0, 0, PictureBox.Width, PictureBox.Height);
                    if (figure.Count() == 1)
                        bitmap_graphics.FillRectangle(brush, figure[0].X - 1, figure[0].Y - 1, 2, 2);
                    for (int i = 1; i < figure.Count(); i++) 
                        bitmap_graphics.DrawLine(pen, figure[i - 1], figure[i]);
                    if (figure_closed == true)
                        bitmap_graphics.DrawLine(pen, figure[figure.Count() - 1], figure[0]);
                }
                //if (line_now != null)
                    //bitmap_graphics.FillRectangle(brush, line_now.X1 - 1, line_now.Y1 - 1, 2, 2);
            }
            brush = new SolidBrush(FrameColorButton.BackColor);
            pen = new Pen(FrameColorButton.BackColor, 3);
            if (frame != null)
            {
                if (frame.Count() == 1)
                    bitmap_graphics.FillRectangle(brush, frame.GetPoint(0).X - 1, frame.GetPoint(0).Y - 1, 2, 2);
                for (int i = 1; i < frame.Count(); i++)
                    bitmap_graphics.DrawLine(pen, frame.GetPoint(i - 1), frame.GetPoint(i));
                if (frame.IsFinished() == true)
                    bitmap_graphics.DrawLine(pen, frame.GetPoint(-1), frame.GetPoint(0));
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
            int x, y;
            if (int.TryParse(XsTextBox.Text, out x) == false)
            {
                MessageBox.Show("Problem with xs. The value should be integer");
                return;
            }
            if (int.TryParse(YsTextBox.Text, out y) == false)
            {
                MessageBox.Show("Problem with ys. The value should be integer");
                return;
            }
            figure.Add(new PointF(x, y));
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
            figure = new List<PointF>();
            //line_now = null;
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

            List<PointF> tmp = frame.CutSutherlandHodgman(figure);

            //if (checkBoxFill.Checked)
                //g.FillPolygon(Brushes.Blue, tmp.ToArray());
            bitmap_graphics.DrawPolygon(pen_res, tmp.ToArray());

            /*for (int i = 0; i < lines.Count(); i++)
            {
                //tmp = frame.CutCyrusBeck(lines[i]);
                //bitmap_graphics.DrawLine(pen_res, tmp.X1, tmp.Y1, tmp.X2, tmp.Y2);
            }*/
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

        private void CloseFigureButton_Click(object sender, EventArgs e)
        {
            figure_closed = true;
            PictureBox.Invalidate();
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
        private List<PointF> W;
        private List<Vector> normal;
        private bool finished_input = false;
        private int walk_direction = 0;

        public Frame()
        {
            W = new List<PointF>();
            normal = new List<Vector>();
        }

        public void AddPoint(PointF dot)
        {
            W.Add(dot);
        }
        public void AddPoint(float x, float y)
        {
            W.Add(new PointF(x, y));
        }

        public int Count() { return W.Count(); }

        public void Clear()
        {
            W.Clear();
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
            return true ? (W.Count == 0) : false;
        }

        // Получение вершины по индексу
        public PointF GetPoint(int index)
        {
            if (index < 0)
                return W[W.Count + index]; // Вершина с конца
            else
                return W[index % W.Count];
        }

        // Проверка выпуклости; возвращает направление обхода
        private int ConvexityCheck()
        {
            if (W.Count < 3)
                return 0;

            Vector a = new Vector(W[1].X, W[1].Y, W[0].X, W[0].Y);
            Vector b = new Vector();
            Vector res = new Vector();

            int sign = 0;

            for (int i = 0; i < W.Count; i++)
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

            for (int i = 0; i < W.Count; i++)
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
        // Алгоритм Сазерленда-Ходжмана для отсечения полигонов
        public List<PointF> CutSutherlandHodgman(List<PointF> P)
        {
            List<PointF> Q = new List<PointF>();
            P.Add(P[0]);

            PointF S = new PointF();
            PointF I = new PointF();

            double Dsk, Wsk, t;

            for (int i = 0; i < W.Count; i++) // по всем сторонам отсекателя
            {
                if (Vector.VisiblePoint(P[0].X, P[0].Y, W[i].X, W[i].Y, normal[i]))
                    Q.Add(P[0]);
                for (int j = 1; j < P.Count(); j++) // по всем сторонам многоугольника
                {
                    Vector D = new Vector(P[j].X, P[j].Y, P[j - 1].X, P[j - 1].Y); // Вектор нашего отрезка
                    Dsk = Vector.ScalarMultiplication(D, normal[i]); //показывает угол и с какой стороны угол

                    if (Dsk != 0) // Провека, что не точка и не парралельно
                    {
                        Vector WV = new Vector(P[j - 1].X, P[j - 1].Y, W[i].X, W[i].Y); //вектор соединяющий  начало отрезка и вершину многоугольника                                                                      
                        Wsk = Vector.ScalarMultiplication(WV, normal[i]);
                        t = -Wsk / Dsk;
                        if (t >= 0 && t <= 1)  // заменить проверку на проверку знаков видимости точек
                        {
                            I = new Line(P[j - 1].X, P[j - 1].Y, P[j].X, P[j].Y).GetDot((float)t);//точка пересечения
                            Q.Add(I);
                        }
                    }

                    if (Vector.VisiblePoint(P[j].X, P[j].Y, W[i].X, W[i].Y, normal[i]))
                        Q.Add(P[j]);
                }

                Q.Add(Q[0]);
                P.Clear();
                P.AddRange(Q);


                Q.Clear();
            }

            return P;
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
        public static bool VisiblePoint(float x0, float y0, float x1, float y1, Vector norm)
        {
            Vector v1 = new Vector(x0, y0, x1, y1);
            float mult = ScalarMultiplication(v1, norm);
            return mult > 0;
        }
    }
}
