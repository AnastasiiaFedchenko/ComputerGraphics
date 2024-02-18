using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lab_01.Shape;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_01
{
    public partial class AddPointForm : Form
    {
        public event NewPointCanBeAdded NP;
        public AddPointForm()
        {
            InitializeComponent();
        }

        private void AddPointForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y;
            if (int.TryParse(textBox1.Text, out x) && int.TryParse(textBox2.Text, out y))
            {
                Color color_now = radioButton1.Checked ? Color.Red : Color.Blue;
                Shape new_point = new Shape(x, y, color_now);
                NP(this, new_point);
            }
            else if (!int.TryParse(textBox1.Text, out x) && int.TryParse(textBox2.Text, out y))
            {
                MessageBox.Show("Введённое значение x \nне соответствует формату вещественных чисел." +
                    "\nВвод осуществляется через запятую.");
                return;
            }
            else if (int.TryParse(textBox1.Text, out x) && !int.TryParse(textBox2.Text, out y))
            {
                MessageBox.Show("Введённое значение y \nне соответствует формату вещественных чисел." +
                    "\nВвод осуществляется через запятую.");
                return;
            }
            else
            {
                MessageBox.Show("Введённые значения x и y \nне соответствуют формату вещественных чисел." +
                    "\nВвод осуществляется через запятую.");
                return;
            }
        }
    }
}
