using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace lab_01
{
    public partial class Main : Form
    {
        AboutAuthor f2;
        AboutProgram f3;
        AddPointForm f4;
        AboutPoint f5;
        public Color LineColor;
        public List<Shape> tops = new List<Shape>();
        List<Shape> res_red = new List<Shape>();
        List<Shape> res_blue = new List<Shape>();
        List<Shape> res = new List<Shape>();
        bool is_drag_and_dropping;
        List<MovePoint> ThePointsDragAndDropping = new List<MovePoint>();
        int DX, DY;
        Shape O;
        int OX, OY; // начало координат
        double Kx; // коэффициент масштабирования 
        double Ky;
        public Main()
        {
            InitializeComponent();
            toolStripComboBox1.SelectedIndex = 0;
            f4 = new AddPointForm();
            f4.NP += NewPointHasBeenAdded;
            OX = 100;
            OY = (int)(this.ClientSize.Height - 100);
            O = new Shape(0, 0, Color.Purple);
            Kx = 100; // единичный отрезок
            Ky = 100;
            LineColor = Color.Black;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 = new AboutAuthor();
            f2.Owner = this;
            f2.Visible = true;
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3 = new AboutProgram();
            f3.Owner = this;
            f3.Visible = true;
        }
        private void добавитьТочкуВПервоеМножествоToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (f4.IsDisposed)
            {
                f4 = new AddPointForm();
                f4.Owner = this;
                f4.NP += NewPointHasBeenAdded;
            }
            f4.Visible = true;
            f4.Activate();
        }

        private bool does_this_point_already_exist(Shape point)
        {
            bool result = false;
            foreach (Shape i in tops)
            {
                if (Math.Abs(i.X - point.X) < 0.00001 && Math.Abs(i.Y - point.Y) < 0.00001)
                    result = true;
            }
            foreach (Shape i in res)
            {
                if (Math.Abs(i.X - point.X) < 0.00001 && Math.Abs(i.Y - point.Y) < 0.00001)
                    result = true;
            }
            return result;
        }
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            ThePointsDragAndDropping.Clear();
            if (e.Button == MouseButtons.Right)//удаление точки
            {

                bool found = false;
                for (int i = tops.Count - 1; i >= 0 && found == false; i--)
                {
                    if (tops[i].IsInside(e.Location.X, e.Location.Y, O, OX, OY, Kx, Ky))
                    {
                        found = true;
                        tops.RemoveAt(i);
                    }
                }
            }
            else
            {
                bool Inside = false;
                for (int i = 0; i < tops.Count; i++)//перемещение точек
                {
                    if (tops[i].IsInside(e.Location.X, e.Location.Y, O, OX, OY, Kx, Ky))
                    {
                        Inside = true;
                        is_drag_and_dropping = true;
                        tops[i].DragAndDropped = true;
                        tops[i].OffsetX = (int)((tops[i].X - O.X) * Kx) + OX - e.Location.X;
                        tops[i].OffsetY = OY - (int)((tops[i].Y - O.Y) * Ky) - e.Location.Y;
                        DX = e.Location.X;
                        DY = e.Location.Y;
                        ThePointsDragAndDropping.Add(new MovePoint(0, 0, i));

                    }
                }
                if (Inside == false)
                {
                    Color color_now = (toolStripComboBox1.SelectedIndex == 0) ? Color.Red : Color.Blue;
                    Shape new_point = new Shape((e.Location.X - OX) / Kx + O.X, (OY - e.Location.Y) / Ky + O.Y, color_now);
                    if (does_this_point_already_exist(new_point))
                        MessageBox.Show("Точка со схожими координатами уже существует.");
                    else
                        tops.Add(new_point);
                }
            }
            this.Invalidate();
        }

        private Shape lowest_and_smallest(List<Shape> arr)
        {
            Shape res = new Shape(arr[0].X, arr[0].Y, Color.Purple);
            foreach (Shape i in arr)
            {
                if (i.X < res.X)
                    res.X = i.X;
                if (i.Y < res.Y)
                    res.Y = i.Y;
            }
            return res;
        }
        private Shape highest_and_biggest(List<Shape> arr)
        {
            Shape res = new Shape(arr[0].X, arr[0].Y, Color.Purple);
            foreach (Shape i in arr)
            {
                if (i.X > res.X)
                    res.X = i.X;
                if (i.Y > res.Y)
                    res.Y = i.Y;
            }
            return res;
        }

        private void find_new_Kx_Ky(List<Shape> arr)
        {
            Shape ls = lowest_and_smallest(arr);
            Shape hb = highest_and_biggest(arr);
            if (ls.X != hb.X)
                Kx = (this.ClientSize.Width - 100) / Math.Abs(hb.X - ls.X);
            if (ls.Y != hb.Y)
                Ky = (this.ClientSize.Height - menuStrip1.Height - 100) / Math.Abs(hb.Y - ls.Y);
            O.X = ls.X;
            O.Y = ls.Y;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (Shape i in tops)
                {
                    if (i.DragAndDropped)
                    {
                        i.X = (e.Location.X - OX + i.OffsetX) / Kx + O.X;
                        i.Y = (OY - e.Location.Y + i.OffsetY) / Ky + O.Y;
                    }
                }
                this.Refresh();
            }
        }
        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            if (ThePointsDragAndDropping.Count() > 0)
            {
                DX = e.Location.X - DX;
                DY = e.Location.Y - DY;
                for (int i = 0; i < ThePointsDragAndDropping.Count; i++)
                {
                    ThePointsDragAndDropping[i].DX = DX;
                    ThePointsDragAndDropping[i].DY = DY;
                }
            }

            foreach (Shape i in tops)
                i.DragAndDropped = false;
            is_drag_and_dropping = false;
            this.Invalidate();
        }

        void draw_line_from_shape(Graphics g, Pen pen, Shape A, Shape B)
        {
            g.DrawLine(pen,
                    new Point(OX + (int)((A.X - O.X) * Kx), OY - (int)((A.Y - O.Y) * Ky)),
                    new Point(OX + (int)((B.X - O.X) * Kx), OY - (int)((B.Y - O.Y) * Ky)));
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(LineColor, (float)(5));
            if (res.Count == 8)
            {
                //find_new_Kx_Ky(res);
                pen.Color = Color.Red;
                draw_line_from_shape(g, pen, res_red[0], res_red[1]);
                draw_line_from_shape(g, pen, res_red[0], res_red[2]);
                draw_line_from_shape(g, pen, res_red[1], res_red[2]);
                pen.Color = Color.Blue;
                draw_line_from_shape(g, pen, res_blue[0], res_blue[1]);
                draw_line_from_shape(g, pen, res_blue[0], res_blue[2]);
                draw_line_from_shape(g, pen, res_blue[1], res_blue[2]);
                Shape orth1 = res[6];
                Shape orth2 = res[7];
                pen.Width = (float)(5 / 4.0);
                pen.Color = Color.DarkRed;
                draw_line_from_shape(g, pen, orth1, res_red[0]);
                draw_line_from_shape(g, pen, orth1, res_red[1]);
                draw_line_from_shape(g, pen, orth1, res_red[2]);
                pen.Color = Color.DarkBlue;
                draw_line_from_shape(g, pen, orth2, res_blue[0]);
                draw_line_from_shape(g, pen, orth2, res_blue[1]);
                draw_line_from_shape(g, pen, orth2, res_blue[2]);
                orth1.COLOR = Color.DarkRed;
                orth1.draw(g, O, OX, OY, Kx, Ky);
                orth2.COLOR = Color.DarkBlue;
                orth2.draw(g, O, OX, OY, Kx, Ky);
                pen.Width = (float)(5);
                pen.Color = Color.Purple;
                draw_line_from_shape(g, pen, orth1, orth2);

            }
            pen = new Pen(LineColor, (float)(5 / 4.0));
            g.DrawLine(pen, new Point(OX, 2000), new Point(OX, 0));
            g.DrawLine(pen, new Point(2000, OY), new Point(0, OY));
            label4.Text = string.Format("{0:f3}", O.X);
            label2.Text = string.Format("{0:f3}", O.Y);
            label1.Text = string.Format("{0:f3}", ((this.ClientSize.Width - 100) / Kx + O.X));
            label3.Text = string.Format("{0:f3}", ((this.ClientSize.Height - menuStrip1.Size.Height - 100) / Ky + O.Y));
            foreach (Shape i in tops)
            {
                if (i.DragAndDropped == true)
                {
                    if (i.COLOR == Color.Red)
                        i.COLOR = Color.Salmon;
                    else if (i.COLOR == Color.Blue)
                        i.COLOR = Color.Aqua;
                }
                else
                {
                    if (i.COLOR == Color.Salmon)
                        i.COLOR = Color.Red;
                    else if (i.COLOR == Color.Aqua)
                        i.COLOR = Color.Blue;
                }
                i.draw(g, O, OX, OY, Kx, Ky);
            }

        }

        public void NewPointHasBeenAdded(object sender, Shape e)
        {
            e.DragAndDropped = false;
            if (does_this_point_already_exist(e))
                MessageBox.Show("Точка со схожими координатами уже существует.");
            else
                tops.Add(e);
            this.Invalidate();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripComboBox1.Enabled = false;
            toolStripComboBox1.Enabled = true;
        }

        private void Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tops.Count; i++)
            {
                if (tops[i].IsInside(e.Location.X, e.Location.Y, O, OX, OY, Kx, Ky))
                {
                    f5 = new AboutPoint(tops[i], O, OX, OY, Kx, Ky);
                    f5.Owner = this;
                    f5.Visible = true;
                }
            }
            for (int i = 6; i < res.Count; i++)
            {
                if (res[i].IsInside(e.Location.X, e.Location.Y, O, OX, OY, Kx, Ky))
                {
                    f5 = new AboutPoint(res[i], O, OX, OY, Kx, Ky);
                    f5.Owner = this;
                    f5.Visible = true;
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Kx = Kx + 5;
            Ky = Ky + 5;
            this.Invalidate();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if ((Kx - 5) < 0 || (Ky - 5) < 0)
                MessageBox.Show("Дальше уменьшение невозможно.");
            else if ((Kx - 5) < 1 || (Ky - 5) < 1)
            {
                Kx = Kx - 0.1;
                Ky = Ky - 0.1;
            }
            else
            {
                Kx = Kx - 5;
                Ky = Ky - 5;
            }
            this.Invalidate();
        }

        private void autoFocusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tops.Count > 1)
                find_new_Kx_Ky(tops);
            this.Invalidate();
        }

        private Shape Kramer(double a1, double b1, double c1, double a2, double b2, double c2)
        {
            Shape res;
            double opred, opred_x, opred_y;
            opred = a1 * b2 - a2 * b1;
            opred_x = c1 * b2 - c2 * b1;
            opred_y = a1 * c2 - a2 * c1;
            res = new Shape(opred_x / opred, opred_y / opred, Color.Black);
            return res;
        }

        private Shape find_orthocenter(Shape A, Shape B, Shape C)
        {
            double a1 = C.X - B.X;
            double b1 = C.Y - B.Y;
            double c1 = (C.X - B.X) * A.X + (C.Y - B.Y) * A.Y;
            double a2 = C.X - A.X;
            double b2 = C.Y - A.Y;
            double c2 = (C.X - A.X) * B.X + (C.Y - A.Y) * B.Y;
            return Kramer(a1, b1, c1, a2, b2, c2);
        }

        private double to_degrees(double a)
        {
            return (a * 180.0) / Math.PI;
        }
        private double find_angle(Shape A, Shape B)
        {
            double res;
            if (A.Y == B.Y)
                res = 0;
            else if (A.X == B.X)
                res = 90.0;
            else
            {
                double tan = (Math.Max(A.Y, B.Y) - Math.Min(A.Y, B.Y)) /
                    (Math.Max(A.X, B.X) - Math.Min(A.X, B.X));
                res = to_degrees(Math.Atan(tan));
                if (!(((A.X > B.X) && (A.Y > B.Y)) || ((A.X < B.X) && (A.Y < B.Y))))
                    res = 180.0 - res;
            }
            return res;
        }

        private void посчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Shape> red = new List<Shape>();
            List<Shape> blue = new List<Shape>();

            double min_angle = 200;
            foreach (Shape i in tops)
                if (i.COLOR == Color.Red || i.COLOR == Color.Salmon)
                    red.Add(i);
                else
                    blue.Add(i);
            if (red.Count < 3 || blue.Count < 3) 
            {
                MessageBox.Show("Для проведения подсчётов требуется\n" +
                    "не менее трёх элементов в каждом множестве.");
                return;
            }
            else if (red.Count == 3 && Math.Abs(((red[2].X - red[0].X) / (red[1].X - red[0].X)) - 
                    ((red[2].Y - red[0].Y) / (red[1].Y - red[0].Y))) < 0.01) 
            {
                    MessageBox.Show("Все точки в первом множестве лежат на одной прямой.\n" +
                        "Нельзя построить треугольник.");
                    return;
            }
            else if (blue.Count == 3 && Math.Abs(((blue[2].X - blue[0].X) / (blue[1].X - blue[0].X)) -
                    ((blue[2].Y - blue[0].Y) / (blue[1].Y - blue[0].Y))) < 0.01)
            {
                MessageBox.Show("Все точки во втором множестве лежат на одной прямой.\n" +
                    "Нельзя построить треугольник.");
                return;
            }

            for (int i1 = 0; i1 < (red.Count - 2); i1++)
            {
                for (int i2 = i1 + 1; i2 < (red.Count - 1); i2++)
                {
                    for (int i3 = i2 + 1; i3 < red.Count; i3++)
                    {
                        Shape orthocenter1 = find_orthocenter(red[i1], red[i2], red[i3]);
                        for (int j1 = 0; j1 < (blue.Count - 2); j1++)
                        {
                            for (int j2 = j1 + 1; j2 < (blue.Count - 1); j2++)
                            {
                                for (int j3 = j2 + 1; j3 < blue.Count; j3++)
                                {
                                    Shape orthocenter2 = find_orthocenter(blue[j1], blue[j2], blue[j3]);
                                    double angle = find_angle(orthocenter1, orthocenter2);
                                    if (angle < min_angle)
                                    {
                                        min_angle = angle;
                                        res_red.Clear();
                                        res_blue.Clear();
                                        res.Clear();
                                        res_red.Add(red[i1]); res_red.Add(red[i2]); res_red.Add(red[i3]);
                                        res_blue.Add(blue[j1]); res_blue.Add(blue[j2]); res_blue.Add(blue[j3]);
                                        res.Add(red[i1]); res.Add(red[i2]); res.Add(red[i3]);
                                        res.Add(blue[j1]); res.Add(blue[j2]); res.Add(blue[j3]);
                                        res.Add(orthocenter1);
                                        res.Add(orthocenter2);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            find_new_Kx_Ky(res);
            this.Invalidate();
            MessageBox.Show(string.Format("Угол с осью OX = {0:f2}°", min_angle));
        }

        private void сбросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            res.Clear();
            res_red.Clear();
            res_blue.Clear();
            this.Invalidate();
        }
    }
}