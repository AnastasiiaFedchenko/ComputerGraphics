using System.Drawing;
using System.Windows.Forms;

namespace lab_02
{
    public partial class Form1 : Form
    {
        List<Shape> shapes = new List<Shape>();
        Point A, B, C, D, E;
        int h, w1, h1, w2, h2, r1, r2, r3;
        public Form1()
        {
            InitializeComponent();
            toolStripComboBox1.SelectedIndex = 0;
            toolStrip1.ImageScalingSize = new Size(40, 40);
            start_position();
            this.Invalidate();
        }

        private void start_position()
        {
            shapes.Clear();
            w1 = 1000;
            h1 = 500;
            A = new Point((this.ClientSize.Width - toolStrip1.Width) / 2 - (w1 / 2) + toolStrip1.Width,
                this.ClientSize.Height / 2 - (h1 / 2));
            B = new Point(A.X + w1 / 2, A.Y - 300);
            h = 300;
            w2 = 300;
            h2 = 100;
            C = new Point(A.X + w1 / 2, A.Y - (2 * h) / 3 + h2);
            D = new Point(A.X + w1 / 4, A.Y + h1 / 4);
            r1 = 75;
            E = new Point(A.X + (w1 * 3) / 4, A.Y + h1 / 2);
            r2 = 100;
            r3 = 200;

            shapes.Add(new Polygon(A.X, A.Y, w1, h1, Color.Pink)); // wall
            shapes.Add(new Polygon(A, new Point(A.X + w1, A.Y), B, Color.Violet)); // roof
            shapes.Add(new Polygon(C.X - w2 / 2, C.Y - 50, w2, h2, Color.LightSkyBlue)); // top window
            shapes.Add(new Cross(C, w2 / 2, h2 / 2, Color.Blue));
            shapes.Add(new Ellipse(D, r1, r1, Color.LightSkyBlue)); // left window
            shapes.Add(new Cross(D, r1, r1, Color.Blue));
            shapes.Add(new Ellipse(E, r2, r3, Color.LightSkyBlue)); // right window
            shapes.Add(new Cross(E, r2, r3, Color.Blue));
            shapes.Add(new Rhomb(E, r2, r3, Color.Blue));
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Shape i in shapes)
            {
                i.draw(g);
            }
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            int dx;
            int dy;
            if (int.TryParse(dxTextBox.Text, out dx) == false)
            {
                MessageBox.Show("dx должно быть целым числом");
                return;
            }
            if (int.TryParse(dyTextBox.Text, out dy) == false)
            {
                MessageBox.Show("dy должно быть целым числом");
                return;
            }
            for (int i = 0; i < shapes.Count(); i++)
            {
                shapes[i].renew(dx, dy);
            }
            this.Invalidate();
        }
    }
}