using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_01
{
    public partial class AboutPoint : Form
    {
        public AboutPoint()
        {
            InitializeComponent();
        }

        public AboutPoint(Shape point, Shape O, int OX, int OY, double Kx, double Ky)
        {
            InitializeComponent();
            this.Location = new Point((int)((point.X - O.X) * Kx) + OX, OY - (int)((point.Y - O.Y) * Ky) + 66);
            if (point.COLOR == Color.Red || point.COLOR == Color.Salmon)
                label4.Text = "Первое";
            else if (point.COLOR == Color.Blue || point.COLOR == Color.Aqua)
                label4.Text = "Второе";
            else label4.Text = "Ортоцентр";
            label5.Text = string.Format("{0:f3}", point.X);
            label6.Text = string.Format("{0:f3}", point.Y);

        }
    }
}
