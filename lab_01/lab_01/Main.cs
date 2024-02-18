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
        //List<DelPoint> DeletingPoints = new List<DelPoint>();
        int DX, DY;
        int OX, OY; // íà÷àëî êîîðäèíàò
        public Main()
        {
            InitializeComponent();
            toolStripComboBox1.SelectedIndex = 0;
            f4 = new AddPointForm();
            f4.NP += NewPointHasBeenAdded;
            OX = (int)(this.ClientSize.Width / 2);
            OY = (int)(this.ClientSize.Height / 2);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void îáÀâòîðåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 = new AboutAuthor();
            f2.Owner = this;
            f2.Visible = true;
        }
        private void îÏðîãðàììåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3 = new AboutProgram();
            f3.Owner = this;
            f3.Visible = true;
        }
        private void äîáàâèòüÒî÷êóÂÏåðâîåÌíîæåñòâîToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            ThePointsDragAndDropping.Clear();
            //Redo.Clear();
            if (e.Button == MouseButtons.Right)//óäàëåíèå òî÷êè
            {

                bool found = false;
                for (int i = tops.Count - 1; i >= 0 && found == false; i--)
                {
                    if (tops[i].IsInside(e.Location.X, e.Location.Y))
                    {
                        found = true;
                        //Undo.Add(new DelPoint(tops[i], i));
                        tops.RemoveAt(i);
                    }
                }
            }
            else
            {
                bool Inside = false;
                for (int i = 0; i < tops.Count; i++)//ïåðåìåùåíèå òî÷åê
                {
                    if (tops[i].IsInside(e.Location.X, e.Location.Y))
                    {
                        Inside = true;
                        is_drag_and_dropping = true;
                        tops[i].DragAndDropped = true;
                        tops[i].OffsetX = tops[i].X - e.Location.X;
                        tops[i].OffsetY = tops[i].Y - e.Location.Y;
                        DX = e.Location.X;
                        DY = e.Location.Y;
                        ThePointsDragAndDropping.Add(new MovePoint(0, 0, i));

                    }
                }
                if (Inside == false)
                {
                    Color color_now = (toolStripComboBox1.SelectedIndex == 0) ? Color.Red : Color.Blue;
                    tops.Add(new Shape(e.Location.X, e.Location.Y, color_now));
                }
            }
            this.Invalidate();
        }
        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (Shape i in tops)
                {
                    if (i.DragAndDropped)
                    {
                        i.X = e.Location.X + i.OffsetX;
                        i.Y = e.Location.Y + i.OffsetY;
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
                /*if (ThePointsDragAndDropping.Count() == 1)
                {
                    Undo.Add(ThePointsDragAndDropping[0]);
                    button4.Enabled = true;
                }
                else
                {
                    Undo.Add(new MovePoints(ThePointsDragAndDropping));
                    button4.Enabled = true;
                }*/
            }
            /*if (!(Undo[Undo.Count - 1] is DelPoints || (Undo[Undo.Count - 1] is DelPoint && Undo[Undo.Count - 1].IsConnected == true)))
            {
                JarvisAlgorithm(tops);
                DeletingPoints.Clear();
                for (int i = 0; i < tops.Count; i++)
                {
                    if (tops[i].InTheShell == false)
                    {
                        DeletingPoints.Add(new DelPoint(tops[i], i, true));
                    }
                }
                if (DeletingPoints.Count == 1)
                {
                    Undo.Add(DeletingPoints[0]);
                }
                if (DeletingPoints.Count > 1)
                {
                    Undo.Add(new DelPoints(DeletingPoints));
                }
            }*/

            foreach (Shape i in tops)
                i.DragAndDropped = false;
            /*for (int i = 0; i < tops.Count; i++)
            {
                if (!tops[i].InTheShell)
                {
                    tops.RemoveAt(i);
                    i--;
                }
            }*/
            is_drag_and_dropping = false;
            this.Invalidate();
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {
            //Pen pen = new Pen(LineColor, (float)(5 / 4.0));
            Graphics g = e.Graphics;
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
                i.draw(g);
            }

        }

        public void NewPointHasBeenAdded(object sender, Shape e)
        {
            e.DragAndDropped = false;
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
                if (tops[i].IsInside(e.Location.X, e.Location.Y))
                {
                    f5 = new AboutPoint(tops[i]);
                    f5.Owner = this;
                    f5.Visible = true;
                }
            }
        }
    }
}