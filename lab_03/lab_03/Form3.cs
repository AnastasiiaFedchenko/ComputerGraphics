using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace lab_03
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        void measure_steps(string series_name, Method method)
        {
            //spectrum = new List<Line>();
            Line l;
            int length = 100;
            int x, y;
            int steps = 0;
            for (int d = 0; d < 90; d += 1)
            {
                x = (int)(Math.Sin((Math.PI / 180) * d) * length);
                y = (int)(Math.Cos((Math.PI / 180) * d) * length);
                l = new Line(0, 0, x, y, Color.Black, Color.White);
                steps = l.controller(method, true);
                chart1.Series[series_name].Points.AddXY(d, steps);
            }
        }

        private void make_chart()
        {
            
            string series1_name = "ЦДА";
            string series2_name = "Брезенхем float";
            string series3_name = "Брезенхем int";
            string series4_name = "Брезенхем сглаженный";
            string series5_name = "Ву";
            chart1.Series[series1_name].Points.Clear();
            chart1.Series[series2_name].Points.Clear();
            chart1.Series[series3_name].Points.Clear();
            chart1.Series[series4_name].Points.Clear();
            chart1.Series[series5_name].Points.Clear();

            if (DDACheckBox.Checked)
                measure_steps(series1_name, Method.DDA);
            if (BfCheckBox.Checked)
                measure_steps(series2_name, Method.B_float);
            if (BiCheckBox.Checked)
                measure_steps(series3_name, Method.B_int);
            if (BsCheckBox.Checked)
                measure_steps(series4_name, Method.B_smooth);
            if (WuCheckBox.Checked)
                measure_steps(series5_name, Method.Wu);
            chart1.Show();

            this.ClientSize = chart1.Size;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            make_chart();
        }

        private void DDACheckBox_CheckedChanged(object sender, EventArgs e)
        {
            make_chart();
        }

        private void BfCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            make_chart();
        }

        private void BiCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            make_chart();
        }

        private void BsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            make_chart();
        }

        private void WuCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            make_chart();
        }
    }
}
