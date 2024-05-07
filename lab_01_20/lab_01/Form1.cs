using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_01
{
    public partial class Form1 : Form
    {
        AboutAuthor f2;
        AboutProgram f3;
        AddPointForm f4;
        AboutPoint f5;
        public Color LineColor;
        public List<Shape> tops = new List<Shape>();
        List<Shape> res_red = new List<Shape>();
        List<Shape> res_blue = new List<Shape>();
        bool is_drag_and_dropping;
        List<MovePoint> ThePointsDragAndDropping = new List<MovePoint>();
        int DX, DY;
        Shape O;
        int OX, OY;               
        double Kx;                             
        double Ky;
        public Form1()
        {
            InitializeComponent();
            SetComboBox.SelectedIndex = 0;
            f4 = new AddPointForm();
            f4.NP += NewPointHasBeenAdded;
            OX = 100;
            OY = (int)(this.ClientSize.Height - 100);
            O = new Shape(0, 0, Color.Purple);
            Kx = 100;
            Ky = 100;
            LineColor = Color.Black;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
        }
        private void AboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 = new AboutAuthor();
            f2.Owner = this;
            f2.Visible = true;
        }
        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3 = new AboutProgram();
            f3.Owner = this;
            f3.Visible = true;
        }
        private void AddPointToolStripMenuItem_Click(object sender, EventArgs e)
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
            for (int i = 0; result == false && i < tops.Count(); i++)
            {
                if (Math.Abs(tops[i].X - point.X) < 0.00001 && Math.Abs(tops[i].Y - point.Y) < 0.00001)
                    result = true;
            }
            for (int i = 0; result == false && i < res_red.Count(); i++)
            {
                if (Math.Abs(res_red[i].X - point.X) < 0.00001 && Math.Abs(res_red[i].Y - point.Y) < 0.00001)
                    result = true;
            }
            for (int i = 0; result == false && i < res_blue.Count(); i++)
            {
                if (Math.Abs(res_blue[i].X - point.X) < 0.00001 && Math.Abs(res_blue[i].Y - point.Y) < 0.00001)
                    result = true;
            }
            return result;
        }

        int to_pixels_X(Shape point)
        {
            return OX + (int)((point.X - O.X) * Kx);
        }

        int to_pixels_Y(Shape point)
        {
            return OY - (int)((point.Y - O.Y) * Ky);
        }

        double to_original_X(int x)
        {
            return (x - OX) / Kx + O.X;
        }

        double to_original_Y(int y)
        {
            return (OY - y) / Ky + O.Y;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ThePointsDragAndDropping.Clear();
            if (e.Button == MouseButtons.Right)//              
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
                for (int i = 0; i < tops.Count; i++)//                 
                {
                    if (tops[i].IsInside(e.Location.X, e.Location.Y, O, OX, OY, Kx, Ky))
                    {
                        Inside = true;
                        is_drag_and_dropping = true;
                        tops[i].DragAndDropped = true;
                        tops[i].OffsetX = to_pixels_X(tops[i]) - e.Location.X;
                        tops[i].OffsetY = to_pixels_Y(tops[i]) - e.Location.Y;
                        DX = e.Location.X;
                        DY = e.Location.Y;
                        ThePointsDragAndDropping.Add(new MovePoint(0, 0, i));

                    }
                }
                if (res_red.Count == 4 && res_red[3].IsInside(e.Location.X, e.Location.Y, O, OX, OY, Kx, Ky))
                    Inside = true;
                if (res_blue.Count == 4 && res_blue[3].IsInside(e.Location.X, e.Location.Y, O, OX, OY, Kx, Ky))
                    Inside = true;
                if (Inside == false) //                       
                {
                    Color color_now = (SetComboBox.SelectedIndex == 0) ? Color.Red : Color.Blue;
                    Shape new_point = new Shape(to_original_X(e.Location.X), to_original_Y(e.Location.Y), color_now);
                    if (does_this_point_already_exist(new_point))
                        MessageBox.Show("                                            .");
                    else
                        tops.Add(new_point);
                }
            }
            this.Invalidate();
        }

        private Shape lowest_and_smallest(List<Shape> arr)
        {
            Shape result = new Shape(arr[0].X, arr[0].Y, Color.Purple);
            foreach (Shape i in arr)
            {
                if (i.X < result.X)
                    result.X = i.X;
                if (i.Y < result.Y)
                    result.Y = i.Y;
            }
            return result;
        }
        private Shape highest_and_biggest(List<Shape> arr)
        {
            Shape result = new Shape(arr[0].X, arr[0].Y, Color.Purple);
            foreach (Shape i in arr)
            {
                if (i.X > result.X)
                    result.X = i.X;
                if (i.Y > result.Y)
                    result.Y = i.Y;
            }
            return result;
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

        private void Form1_MouseMove(object sender, MouseEventArgs e)
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
        private void Form1_MouseUp(object sender, MouseEventArgs e)
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

        void Draw_line_from_shape(Graphics g, Pen pen, Shape A, Shape B)
        {
            g.DrawLine(pen,
                    new Point(to_pixels_X(A), to_pixels_Y(A)),
                    new Point(to_pixels_X(B), to_pixels_Y(B)));
        }

        void Draw_result_of_calculation(Graphics g)
        {
            Pen pen = new Pen(LineColor, (float)(5));
            for (int i = 0; i < 3; i++)
            {
                for (int j = i; j < 3; j++)
                {
                    pen.Color = Color.Red;
                    Draw_line_from_shape(g, pen, res_red[i], res_red[j]);
                    pen.Color = Color.Blue;
                    Draw_line_from_shape(g, pen, res_blue[i], res_blue[j]);
                }
            }
            Shape orth1 = res_red[3];
            Shape orth2 = res_blue[3];
            pen.Width = (float)(5 / 4.0);
            for (int i = 0; i < 3; i++)
            {
                pen.Color = Color.DarkRed;
                Draw_line_from_shape(g, pen, orth1, res_red[i]);
                pen.Color = Color.DarkBlue;
                Draw_line_from_shape(g, pen, orth2, res_blue[i]);
            }
            pen.Width = (float)(5);
            pen.Color = Color.Purple;
            Draw_line_from_shape(g, pen, orth1, orth2);
            orth1.COLOR = Color.DarkRed;
            orth1.draw(g, to_pixels_X(orth1), to_pixels_Y(orth1));
            orth2.COLOR = Color.DarkBlue;
            orth2.draw(g, to_pixels_X(orth2), to_pixels_Y(orth2));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //g.ScaleTransform(0.2f, 0.2f);
            if ((res_red.Count + res_blue.Count) == 8)
                Draw_result_of_calculation(g);
            Pen pen = new Pen(LineColor, (float)(5 / 4.0));
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
                i.draw(g, to_pixels_X(i), to_pixels_Y(i));
            }

        }

        public void NewPointHasBeenAdded(object sender, Shape e)
        {
            e.DragAndDropped = false;
            if (does_this_point_already_exist(e))
                MessageBox.Show("This point already exists.");
            else
                tops.Add(e);
            this.Invalidate();
        }

        private void SetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetComboBox.Enabled = false;
            SetComboBox.Enabled = true;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
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
            if (res_red.Count() == 4 && res_red[3].IsInside(e.Location.X, e.Location.Y, O, OX, OY, Kx, Ky))
            {
                f5 = new AboutPoint(res_red[3], O, OX, OY, Kx, Ky);
                f5.Owner = this;
                f5.Visible = true;
            }
            if (res_blue.Count() == 4 && res_blue[3].IsInside(e.Location.X, e.Location.Y, O, OX, OY, Kx, Ky))
            {
                f5 = new AboutPoint(res_blue[3], O, OX, OY, Kx, Ky);
                f5.Owner = this;
                f5.Visible = true;
            }
        }

        private void PlusStripMenuItem_Click(object sender, EventArgs e)
        {
            Kx = Kx + 5;
            Ky = Ky + 5;
            this.Invalidate();
        }

        private void MinusStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Kx - 5) < 0 || (Ky - 5) < 0)
                MessageBox.Show("Cannot make it that small.");
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

        private void AutoFocusToolStripMenuItem_Click(object sender, EventArgs e)
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

        private Shape Find_orthocenter(Shape A, Shape B, Shape C)
        {
            double a1 = C.X - B.X;
            double b1 = C.Y - B.Y;
            double c1 = (C.X - B.X) * A.X + (C.Y - B.Y) * A.Y;
            double a2 = C.X - A.X;
            double b2 = C.Y - A.Y;
            double c2 = (C.X - A.X) * B.X + (C.Y - A.Y) * B.Y;
            return Kramer(a1, b1, c1, a2, b2, c2);
        }

        private double To_degrees(double a)
        {
            return (a * 180.0) / Math.PI;
        }
        private double Find_angle(Shape A, Shape B)
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
                res = To_degrees(Math.Atan(tan));
                if (!(((A.X > B.X) && (A.Y > B.Y)) || ((A.X < B.X) && (A.Y < B.Y))))
                    res = 180.0 - res;
            }
            return res;
        }

        private void CalculateToolStripMenuItem_Click(object sender, EventArgs e)
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
                MessageBox.Show("Not enough points.");
                return;
            }
            else if (red.Count == 3 && Math.Abs(((red[2].X - red[0].X) / (red[1].X - red[0].X)) -
                    ((red[2].Y - red[0].Y) / (red[1].Y - red[0].Y))) < 0.01)
            {
                MessageBox.Show("All red points are on the same line.");
                return;
            }
            else if (blue.Count == 3 && Math.Abs(((blue[2].X - blue[0].X) / (blue[1].X - blue[0].X)) -
                    ((blue[2].Y - blue[0].Y) / (blue[1].Y - blue[0].Y))) < 0.01)
            {
                MessageBox.Show("All blue points are on the same line.");
                return;
            }

            for (int i1 = 0; i1 < (red.Count - 2); i1++)
            {
                for (int i2 = i1 + 1; i2 < (red.Count - 1); i2++)
                {
                    for (int i3 = i2 + 1; i3 < red.Count; i3++)
                    {
                        Shape orthocenter1 = Find_orthocenter(red[i1], red[i2], red[i3]);
                        for (int j1 = 0; j1 < (blue.Count - 2); j1++)
                        {
                            for (int j2 = j1 + 1; j2 < (blue.Count - 1); j2++)
                            {
                                for (int j3 = j2 + 1; j3 < blue.Count; j3++)
                                {
                                    Shape orthocenter2 = Find_orthocenter(blue[j1], blue[j2], blue[j3]);
                                    double angle = Find_angle(orthocenter1, orthocenter2);
                                    if (angle < min_angle)
                                    {
                                        min_angle = angle;
                                        res_red.Clear();
                                        res_blue.Clear();
                                        res_red.Add(red[i1]); res_red.Add(red[i2]); res_red.Add(red[i3]);
                                        res_blue.Add(blue[j1]); res_blue.Add(blue[j2]); res_blue.Add(blue[j3]);
                                        res_red.Add(orthocenter1);
                                        res_blue.Add(orthocenter2);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            List<Shape> temp = new List<Shape>();
            temp.AddRange(res_red);
            temp.AddRange(res_blue);
            find_new_Kx_Ky(temp);
            this.Invalidate();
            MessageBox.Show(string.Format("The angle with OX is {0:f2} ", min_angle));
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            res_red.Clear();
            res_blue.Clear();
            this.Invalidate();
        }
    }
}
