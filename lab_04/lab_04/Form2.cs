using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace lab_04
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void measure_time(string series_name, Method method)
        {
            Stopwatch stopWatch = new Stopwatch();
            //TimeSpan ts;
            Circle circle;
            //DateTime timer1;
            //TimeSpan res;
            for (int r = 1; r < 1000; r += 20)
            {
                circle = new Circle(0, 0, r, Color.Black, Color.White);
                //timer1 = DateTime.Now;
                stopWatch.Start();
                for (int c = 0; c < 100; c++)
                    circle.controller(method, false);
                stopWatch.Stop();
                //ts = stopWatch.Elapsed;
                chart1.Series[series_name].Points.AddXY(r, (double)stopWatch.ElapsedMilliseconds / 100);
            }
        }

        private void make_chart()
        {

            string series1_name = "Канонический";
            string series2_name = "Параметрический";
            string series3_name = "Брезенхем";
            chart1.Series[series1_name].Points.Clear();
            chart1.Series[series2_name].Points.Clear();
            chart1.Series[series3_name].Points.Clear();

            if (CanonicCheckBox.Checked)
                measure_time(series1_name, Method.Canonic);
            if (ParametricCheckBox.Checked)
                measure_time(series2_name, Method.Parametric);
            if (BresenhamCheckBox.Checked)
                measure_time(series3_name, Method.Bresenham);
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
