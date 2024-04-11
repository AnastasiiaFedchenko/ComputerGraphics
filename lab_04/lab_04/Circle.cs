using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace lab_04
{
    public class Circle
    {
        int ox;
        int oy;
        int r;
        Color line_color;
        Color background_color;
        List<line> lines;
        public Circle(int ox, int oy, int r, Color line_color, Color background_color)
        {
            this.ox = ox;
            this.oy = oy;
            this.r = r;
            this.line_color = line_color;
            this.background_color = background_color;
            lines = new List<line>();
        }

        public Color Background_color
        {
            get { return background_color; }
        }

        public void draw(Graphics g, int offset_x, int offset_y, int k)
        {
            for (int i = 0; i < lines.Count; i++)
                lines[i].draw(g, offset_x, offset_y, k);
        }
        public void draw_ordinary(Graphics g, int offset_x, int offset_y, int k)
        {
            Pen pen = new Pen(line_color);
            pen.Width = k;
            g.DrawEllipse(pen, (ox - r) * k + offset_x, offset_y - (oy + r) * k, 2 * r * k, 2 * r * k);
        }

        public void controller(Method method, bool just_time_measure)
        {
            if (method == Method.Canonic)
                canonic(just_time_measure);
            else if (method == Method.Parametric)
                parametric(just_time_measure);
            else if (method == Method.Bresenham)
                bresenham(just_time_measure);
        }

        private void add_pixel(int x, int y, Color color) 
        {
            lines.Add(new line(x, y, x + 1, y, color));
        }

        private void add_simetric_pixels(int x, int y, Color color) 
        {
            add_pixel(y - oy + ox, x - ox + oy, color);
            add_pixel(-y + oy + ox, x - ox + oy, color);
            add_pixel(y - oy + ox, -x + ox + oy, color);
            add_pixel(-y + oy + ox, -x + ox + oy, color);

            add_pixel(x, y, color);
            add_pixel(x, -y + 2 * oy, color);
            add_pixel(-x + 2 * ox, y, color);
            add_pixel(-x + 2 * ox, -y + 2 * oy, color);
        }
        private void canonic(bool just_time_measure) 
        {
            int border = (int)Math.Round(ox + (r / Math.Sqrt(2)));
            int y;
            for (int x  = ox; x <= border; x++) 
            {
                y = oy + (int)Math.Sqrt(Math.Pow(r, 2) - Math.Pow((x - ox), 2));
                if (!just_time_measure)
                    add_simetric_pixels(x, y, line_color);
            }
        }

        private void parametric(bool just_time_measure) 
        {
            double step = 1 / (double)r;
            double i = 0;
            int x, y;
            double border = ((Math.PI / 4) + step);
            while (i < border) 
            {
                x = (int)(ox + r * Math.Cos(i));
                y = (int)(oy + r * Math.Sin(i));

                if (!just_time_measure)
                    add_simetric_pixels(x, y, line_color);
                i += step;
            }
        }

        private void bresenham(bool just_time_measure) 
        {
            int x, y;
            x = 0;
            y = r;
            if (!just_time_measure)
                add_simetric_pixels(x + ox, y + oy, line_color);
            int delta = 2 * ( 1 - r);
            int d;
            while (y >= x) 
            {
                d = 2 * (delta + y) - 1;
                x += 1;

                if (d >= 0)
                {
                    y -= 1;
                    delta += 2 * (x - y + 1);
                }
                else
                    delta += 2 * x + 1;
                if (!just_time_measure)
                    add_simetric_pixels(x + ox, y + oy, line_color);
            }
        }
    }
}
