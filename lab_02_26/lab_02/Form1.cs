using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_02
{
    public partial class Form1 : Form
    {
        List<Shape> shapes = new List<Shape>();
        List<Change> changes = new List<Change>();
        int pointer = -1;
        Point A, B, C, D, E;
        int h, w1, h1, w2, h2, r1, r2, r3;
        public Form1()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(2147, 1400);
            start_position();
            this.Invalidate();
        }

        private void start_position()
        {
            shapes.Clear();
            w1 = 500;
            h1 = 250;
            A = new Point((this.ClientSize.Width - toolStrip1.Width) / 2 - (w1 / 2) + toolStrip1.Width,
                this.ClientSize.Height / 2 - (h1 / 2));
            B = new Point(A.X + w1 / 2, A.Y - 150);
            h = 150;
            w2 = 150;
            h2 = 50;
            C = new Point(A.X + w1 / 2, A.Y - (2 * h) / 3 + h2);
            D = new Point(A.X + w1 / 4, A.Y + h1 / 4);
            r1 = 37;
            E = new Point(A.X + (w1 * 3) / 4, A.Y + h1 / 2);
            r2 = 50;
            r3 = 100;

            shapes.Add(new Polygon(A.X, A.Y, w1, h1, Color.Pink)); // wall
            shapes.Add(new Polygon(A, new Point(A.X + w1, A.Y), B, Color.Violet)); // roof
            shapes.Add(new Polygon(C.X - w2 / 2, C.Y - 25, w2, h2, Color.LightSkyBlue)); // top window
            shapes.Add(new Cross(C, w2 / 2, h2 / 2, Color.Blue));
            shapes.Add(new Ellipse(D, r1, r1, Color.LightSkyBlue)); // left window
            shapes.Add(new Cross(D, r1, r1, Color.Blue));
            shapes.Add(new Ellipse(E, r2, r3, Color.LightSkyBlue)); // right window
            shapes.Add(new Cross(E, r2, r3, Color.Blue));
            shapes.Add(new Rhomb(E, r2, r3, Color.Blue));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Shape i in shapes)
            {
                i.draw(g);
            }
            if (pointer >= 0)
            {
                if (changes[pointer].Kx != 1 || changes[pointer].Ky != 1)
                    g.DrawEllipse(new Pen(Color.Red, 5), changes[pointer].Ox2 - 5, changes[pointer].Oy2 - 5, 5, 5);
                if (changes[pointer].Degrees != 0)
                    g.DrawEllipse(new Pen(Color.Blue, 5), changes[pointer].Ox1 - 5, changes[pointer].Oy1 - 5, 5, 5);
            }
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            int Ox1, Oy1; // center of rotation
            double degrees; // the angle of rotation
            int dx, dy; // offsets for x and y
            int Ox2, Oy2; // center of the scaling
            double kx, ky; // scaling factors
            if (int.TryParse(Ox1TextBox.Text, out Ox1) == false)
            {
                MessageBox.Show("                                                 ");
                return;
            }
            if (int.TryParse(Oy1TextBox.Text, out Oy1) == false)
            {
                MessageBox.Show("                                                 ");
                return;
            }
            if (double.TryParse(degreeTextBox.Text, out degrees) == false)
            {
                MessageBox.Show("                                             ");
                return;
            }

            if (int.TryParse(dxTextBox.Text, out dx) == false)
            {
                MessageBox.Show("dx                         ");
                return;
            }
            if (int.TryParse(dyTextBox.Text, out dy) == false)
            {
                MessageBox.Show("dy                         ");
                return;
            }

            if (int.TryParse(Ox2TextBox.Text, out Ox2) == false)
            {
                MessageBox.Show("                                                        ");
                return;
            }
            if (int.TryParse(Oy2TextBox.Text, out Oy2) == false)
            {
                MessageBox.Show("                                                        ");
                return;
            }
            if (double.TryParse(kxTextBox.Text, out kx) == false)
            {
                MessageBox.Show("                               x                                ");
                return;
            }
            if (double.TryParse(kyTextBox.Text, out ky) == false)
            {
                MessageBox.Show("                               y                                ");
                return;
            }

            Ox1 = Ox1 + (this.ClientSize.Width - toolStrip1.Width) / 2 + toolStrip1.Width;
            Oy1 = -Oy1 + this.ClientSize.Height / 2;
            Ox2 = Ox2 + (this.ClientSize.Width - toolStrip1.Width) / 2 + toolStrip1.Width;
            Oy2 = -Oy2 + this.ClientSize.Height / 2;
            degrees = (Math.PI / 180) * degrees;
            Change new_change = new Change(Ox1, Oy1, degrees, dx, dy, Ox2, Oy2, kx, ky);
            for (int i = 0; i < shapes.Count(); i++)
            {
                shapes[i].renew(new_change, false);
            }
            if (pointer < (changes.Count - 1))
            {
                for (int i = changes.Count - 1; i > pointer; i--)
                    changes.RemoveAt(i);
                RedoButton.Enabled = false;
            }
            changes.Add(new_change);
            pointer++;
            UndoButton.Enabled = true;
            this.Invalidate();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            start_position();
            Ox1TextBox.Text = "0";
            Oy1TextBox.Text = "0";
            degreeTextBox.Text = "0";
            dxTextBox.Text = "0";
            dyTextBox.Text = "0";
            Ox2TextBox.Text = "0";
            Oy2TextBox.Text = "0";
            kxTextBox.Text = "1";
            kyTextBox.Text = "1";
            changes.Clear();
            pointer = -1;
            UndoButton.Enabled = false;
            RedoButton.Enabled = false;

            this.Invalidate();
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (changes.Count > 0 && pointer >= 0)
            {
                Change reverse = (Change)changes[pointer].Clone();
                reverse.Degrees = -reverse.Degrees;
                reverse.Dx = -reverse.Dx;
                reverse.Dy = -reverse.Dy;
                reverse.Kx = 1 / reverse.Kx;
                reverse.Ky = 1 / reverse.Ky;
                for (int i = 0; i < shapes.Count(); i++)
                {
                    shapes[i].renew(reverse, true);
                }
                pointer--;
                if (pointer == -1)
                    UndoButton.Enabled = false;
                if (pointer < (changes.Count() - 1))
                    RedoButton.Enabled = true;
                else
                    RedoButton.Enabled = false;
                this.Invalidate();
            }
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            if (changes.Count > 0 && (pointer + 1) < changes.Count)
            {
                pointer++;
                for (int i = 0; i < shapes.Count(); i++)
                {
                    shapes[i].renew(changes[pointer], false);
                }
                if (pointer >= (changes.Count - 1))
                    RedoButton.Enabled = false;
                UndoButton.Enabled = true;
            }
            this.Invalidate();
        }

    }
}
