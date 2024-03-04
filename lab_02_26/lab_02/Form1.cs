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
            g.DrawEllipse(new Pen(Color.Black, 5), (this.ClientSize.Width - toolStrip1.Width) / 2 + toolStrip1.Width + w1/2 - 5, this.ClientSize.Height / 2 + h1/2 - 5, 5, 5);
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
                MessageBox.Show("Абсцисса центра вращения должна быть целым числом");
                return;
            }
            if (int.TryParse(Oy1TextBox.Text, out Oy1) == false)
            {
                MessageBox.Show("Ордината центра вращения должна быть целым числом");
                return;
            }
            if (double.TryParse(degreeTextBox.Text, out degrees) == false) 
            {
                MessageBox.Show("Угол поворота должен быть вещественным числом");
                return;
            }

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
            
            if (int.TryParse(Ox2TextBox.Text, out Ox2) == false)
            {
                MessageBox.Show("Абсцисса центра масштабирования должна быть целым числом");
                return;
            }
            if (int.TryParse(Oy2TextBox.Text, out Oy2) == false)
            {
                MessageBox.Show("Ордината центра масштабирования должна быть целым числом");
                return;
            }
            if (double.TryParse(kxTextBox.Text,out kx) == false) 
            {
                MessageBox.Show("Коэффициент масштабирования по x должен быть вещественным числом");
                return;
            }
            if (double.TryParse(kyTextBox.Text, out ky) == false)
            {
                MessageBox.Show("Коэффициент масштабирования по y должен быть вещественным числом");
                return;
            }

            Ox1 = Ox1 + (this.ClientSize.Width - toolStrip1.Width) / 2 + toolStrip1.Width;
            Oy1 = Oy1 + this.ClientSize.Height / 2;
            Ox2 = Ox2 + (this.ClientSize.Width - toolStrip1.Width) / 2 + toolStrip1.Width;
            Oy2 = Oy2 + this.ClientSize.Height / 2;
            degrees = (Math.PI / 180) * degrees;

            for (int i = 0; i < shapes.Count(); i++)
            {
                shapes[i].renew(Ox1, Oy1, degrees, dx, dy, Ox2, Oy2, kx, ky);
            }
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

            this.Invalidate();
        }
    }
}