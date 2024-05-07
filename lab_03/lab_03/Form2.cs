using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_03
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // public static T ManagedCombine<T>(delegate* managed<T, T, T> combinator, T left, T right) =>
        // combinator(left, right);
        double measure_time(Method method)
        {
            int n = 1000;
            Random rnd = new Random();
            List<Line> lines = new List<Line>();
            for (int i = 0; i < n; i++)
                lines.Add(new Line(rnd.Next(-500, 500), rnd.Next(-500, 500),
                    rnd.Next(-500, 500), rnd.Next(-500, 500), Color.Black, Color.White));

            DateTime timer1 = DateTime.Now;
            for (int i = 0; i < n; i++)
                lines[i].controller(method, false);

            TimeSpan res = DateTime.Now - timer1;
            return (double)res.TotalMilliseconds / n;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string series1_name = "ЦДА";
            string series2_name = "Брезенхем float";
            string series3_name = "Брезенхем int";
            string series4_name = "Брезенхем сглаженный";
            string series5_name = "Ву";
            chart1.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            chart1.Series[series1_name].Points.AddY(measure_time(Method.DDA));
            chart1.Series[series2_name].Points.AddY(measure_time(Method.B_float));
            chart1.Series[series3_name].Points.AddY(measure_time(Method.B_int));
            chart1.Series[series4_name].Points.AddY(measure_time(Method.B_smooth));
            chart1.Series[series5_name].Points.AddY(measure_time(Method.Wu));
            chart1.Show();

            this.ClientSize = chart1.Size;
        }
    }
}
