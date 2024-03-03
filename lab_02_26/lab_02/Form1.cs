using System.Windows.Forms;

namespace lab_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripComboBox1.SelectedIndex = 0;
            toolStrip1.ImageScalingSize = new Size(40, 40);
            this.Invalidate();
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
            SolidBrush brush = new SolidBrush(Color.Pink);
            Rectangle rect1 = new Rectangle((this.ClientSize.Width - toolStrip1.Width) / 2 - (1000 / 2), this.ClientSize.Height / 2 - (500 / 2), 1000, 500);
            g.FillRectangle(brush, rect1.Left + toolStrip1.Width, rect1.Top, rect1.Width, rect1.Height);

            brush.Color = Color.Violet;
            Point p1 = new Point(rect1.Left + toolStrip1.Width, rect1.Top);
            Point p2 = new Point(rect1.Left + toolStrip1.Width + rect1.Width, rect1.Top);
            Point p3 = new Point(rect1.Left + toolStrip1.Width + rect1.Width / 2, rect1.Top - 300);
            Point[] roof = { p1, p2, p3 };
            g.FillPolygon(brush, roof);

            brush.Color = Color.Azure;
            Rectangle rect2 = new Rectangle(rect1.Left + rect1.Width / 2 - 300 / 2, rect1.Top - (2 * 300) / 3, 300, 100);
            g.FillRectangle(brush, rect2.Left + toolStrip1.Width, rect2.Top, rect2.Width, rect2.Height);

            brush.Color = Color.Coral;

            //g.FillEllipse(brush, (this.ClientSize.Width - toolStrip1.Width) / 2 + toolStrip1.Width - 50, this.ClientSize.Height / 2 - 50, 50, 50);
        }
    }
}