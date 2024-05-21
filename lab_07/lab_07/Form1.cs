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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_07
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
        int xa, ya, xb, yb;
        bool closed;
        bool result;
        public Form1()
        {
            InitializeComponent();
            picture = new Bitmap(PictureBox.Width, PictureBox.Width);
            bitmap_graphics = Graphics.FromImage(picture);
            lines = new List<Line>();
            //frame = new List<Line>();
            closed = false;
            result = false;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // добавляем точки отсекателя
            {
                if (frame == null)
                {
                    frame = new Frame();
                    xa = e.X;
                    ya = e.Y;
                }
                else if (closed == false)
                {
                    xb = e.X;
                    yb = e.Y;
                    frame.left = Math.Min(xa, xb);
                    frame.right = Math.Max(xa, xb);
                    frame.up = Math.Min(ya, yb);
                    frame.down = Math.Max(ya, yb);
                    closed = true;
                }

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
            /*if (frame != null)
            {
                if (frame.Count() == 0 && edge_now != null)
                    bitmap_graphics.FillEllipse(brush, edge_now.X1 - 1, edge_now.Y1 - 1, 2, 2);
                foreach (Line line in frame)
                    bitmap_graphics.DrawLine(pen, line.X1, line.Y1, line.X2, line.Y2);
            }*/
            if (frame != null && closed == false)
                bitmap_graphics.FillRectangle(brush, xa - 1, ya - 1, 2, 2);
            else if (frame != null && closed == true)
                bitmap_graphics.DrawRectangle(pen, frame.left, frame.up, 
                                                    frame.right - frame.left, frame.down - frame.up);
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
            int x1, y1, x2, y2;
            if (int.TryParse(XlhTextBox.Text, out x1) == false)
            {
                MessageBox.Show("Problem with xlh. The value should be integer");
                return;
            }
            if (int.TryParse(YlhTextBox.Text, out y1) == false)
            {
                MessageBox.Show("Problem with ylh. The value should be integer");
                return;
            }
            if (int.TryParse(XrlTextBox.Text, out x2) == false)
            {
                MessageBox.Show("Problem with xrl. The value should be integer");
                return;
            }
            if (int.TryParse(YrlTextBox.Text, out y2) == false)
            {
                MessageBox.Show("Problem with yrl. The value should be integer");
                return;
            }
            frame = new Frame();
            frame.left = x1;
            frame.up = y1;
            frame.right = x2;
            frame.down = y2;
            PictureBox.Invalidate();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            frame = null;
            //edge_now = null;
            lines = new List<Line>();
            line_now = null;
            closed = false;
            result = false;
            bitmap_graphics.FillRectangle(new SolidBrush(Form1.DefaultBackColor),
                0, 0, PictureBox.Width, PictureBox.Height);
            PictureBox.Invalidate();
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
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

        // Проверяет, используя коды двух точек, пересечение бесконечной стороны и линии
        bool Intersect(int T1, int T2, int side)
        {
            int coord = (int)Math.Pow(2, 3 - side);

            if ((T1 & coord) != (T2 & coord))
                return true;
            else
                return false;
        }
        void CohenSutherland(float x1, float y1, float x2, float y2)
        {
            Pen pen = new Pen(ResultColorButton.BackColor, 3);
            int orientation_flag = 0; // общего
            float slope = 1; // наклон

            if (x2 - x1 == 0)
                orientation_flag = -1; // вертикальный
            else
            {
                slope = (y2 - y1) / (x2 - x1);
                if (slope == 0)
                    orientation_flag = 1; // горизонтальный
            }

            for (int i = 0; i < 4; i++)
            {
                // Находим коды
                int res1 = frame.GetPositioning(x1, y1);
                int res2 = frame.GetPositioning(x2, y2);

                int visible = frame.IsVisible(x1, y1, x2, y2);
                if (visible == 1) // Тривиальная видимость
                {
                    
                    bitmap_graphics.DrawLine(pen, x1, y1, x2, y2);
                    return;
                }
                else if (visible == 0) // Тривиальная невидимость
                    return;

                // Проверяем пересечение отрезка и стороны окна
                //Console.WriteLine("Sum:" + SumA.ToString() + SumB.ToString());
                if (!Intersect(res1, res2, i))
                {
                    //Console.WriteLine("not intersecting" + i.ToString());
                    continue;
                }

                // Если точка а внутри стороны
                if ((res1 & (int)Math.Pow(2, 3 - i)) == 0)
                {
                    //Console.WriteLine("A inside");
                    Swap(ref x1, ref x2);
                    Swap(ref y1, ref y2);
                }

                // Поиск пересечений отрезка со стороной
                if (orientation_flag != -1) // не вертикальный
                {
                    if (i < 2) // если рассматриваем левую или правую сторону отсекателя
                    {
                        y1 = (int)(slope * (frame[i] - x1) + y1);
                        x1 = frame[i];
                        continue;
                    }
                    else
                        if (slope == 0)
                        x1 = (int)((frame[i] - y1) + x1);
                    else
                        x1 = (int)((1 / slope) * (frame[i] - y1) + x1);
                }
                y1 = frame[i];
            }
            bitmap_graphics.DrawLine(pen, x1, y1, x2, y2);
        }
        private void CutOff_Click(object sender, EventArgs e)
        {
            //bitmap_graphics.FillRectangle(new SolidBrush(Form1.DefaultBackColor),
                                         // 0, 0, PictureBox.Width, PictureBox.Height);
            for (int i = 0; i < lines.Count(); i++)
            {
                CohenSutherland(lines[i].X1, lines[i].Y1, lines[i].X2, lines[i].Y2);
            }
            result = true;
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

    }
    class Frame
    {
        public float left = 0;
        public float right = 0;
        public float up = 0;
        public float down = 0;
        public int GetPositioning(float x, float y)
        {
            int res = 0;
            if (x < left)
                res += 8;
            if (x > right)
                res += 4;
            if (y > down)
                res += 2;
            if (y < up)
                res += 1;
            return res;
        }
        public int IsVisible(float x1, float y1, float x2, float y2)
        {
            int res1 = GetPositioning(x1, y1);
            int res2 = GetPositioning(x2, y2);
            int visibility = -1;
            if (res1 == 0 && res2 == 0)
                visibility = 1; // all visible
            else
            {
                // checking the trivial invisibility of a segment
                if ((res1 & res2) != 0)
                    visibility = 0;
            }
            return visibility;
        }
        public float this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return left;
                    case 1:
                        return right;
                    case 2:
                        return down;
                    case 3:
                        return up;
                    default:
                        return -1;
                }
            }
        }
    }
}
