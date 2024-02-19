using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace lab_01
{
    public partial class AboutPoint : Form
    {
        public AboutPoint()
        {
            InitializeComponent();
        }

        public AboutPoint(Shape point, int OX, int OY, double K)
        {
            InitializeComponent();
            this.Location = new Point((int)(point.X * K) + OX, OY - (int)(point.Y * K) + 66);
            label4.Text = (point.COLOR == Color.Red || point.COLOR == Color.Salmon) ? "Первое" : "Второе";
            label5.Text = point.X.ToString();
            label6.Text = point.Y.ToString();

        }

        private void AboutPoint_Load(object sender, EventArgs e)
        {

        }
    }
}
