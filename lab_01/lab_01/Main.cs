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
            bool res = false;
            foreach (Shape i in tops)
            {
                if (Math.Abs(i.X - point.X) < 0.00001 && Math.Abs(i.Y - point.Y) < 0.00001)
                    res = true;
            }
            return res;
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

        private void Main_Paint(object sender, PaintEventArgs e)
        {
            /*if (tops.Count > 1)
                find_new_Kx_Ky(tops);*/
            Graphics g = e.Graphics;
            Pen pen = new Pen(LineColor, (float)(5 / 4.0));
            g.DrawLine(pen, new Point(OX, 2000), new Point(OX, 0));
            g.DrawLine(pen, new Point(2000, OY), new Point(0, OY));
            label4.Text = (O.X).ToString();
            label2.Text = (O.Y).ToString();
            label1.Text = ((this.ClientSize.Width - 100) / Kx + O.X).ToString();
            label3.Text = ((this.ClientSize.Height - menuStrip1.Size.Height - 100) / Ky + O.Y).ToString();
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
    }
}