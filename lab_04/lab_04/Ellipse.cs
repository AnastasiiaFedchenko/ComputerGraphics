using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace lab_04
{
    public class Ellipse
    {
        int ox;
        int oy;
        int rx;
        int ry;
        Color line_color;
        Color background_color;
        List<line> lines;
        public Ellipse(int ox, int oy, int rx, int ry, Color line_color, Color background_color)
        {
            this.ox = ox;
            this.oy = oy;
            this.rx = rx;
            this.ry = ry;
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
            g.DrawEllipse(pen, (ox - rx) * k + offset_x, offset_y - (oy + ry) * k, 2 * rx * k, 2 * ry * k);
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
            add_pixel(x, y, color);
            add_pixel(x, -y + 2 * oy, color);
            add_pixel(-x + 2 * ox, y, color);
            add_pixel(-x + 2 * ox, -y + 2 * oy, color);
        }
        private void canonic(bool just_time_measure) 
        {
            int border_x = (int)Math.Round(ox + (rx / Math.Sqrt(1 + (ry * ry) / (rx * rx))));
            int border_y = (int)Math.Round(oy + (ry / Math.Sqrt(1 + (rx * rx) / (ry * ry))));
            int x, y;
            for (x  = ox; x <= border_x; x++) 
            {
                y = oy + (int)(Math.Sqrt(rx * rx * ry * ry - (x - ox) * (x - ox) * ry * ry) / rx);
                if (!just_time_measure)
                    add_simetric_pixels(x, y, line_color);
            }
            for (y = oy; y <= border_y; y++)
            {
                x = ox + (int)(Math.Sqrt(rx * rx * ry * ry - (y - oy) * (y - oy) * rx * rx) / ry);
                if (!just_time_measure)
                    add_simetric_pixels(x, y, line_color);
            }
        }

        private void parametric(bool just_time_measure) 
        {
            double step;
            if (rx > ry)
                step = 1 / (double)rx;
            else
                step = 1 / (double)ry;
            double i = 0;
            int x, y;
            double border = ((Math.PI / 2) + step);
            while (i < border) 
            {
                x = (int)(ox + rx * Math.Cos(i));
                y = (int)(oy + ry * Math.Sin(i));

                if (!just_time_measure)
                    add_simetric_pixels(x, y, line_color);
                i += step;
            }
        }

        private void bresenham(bool just_time_measure) 
        {
            int x, y;
            x = 0;
            y = ry;
            if (!just_time_measure)
                add_simetric_pixels(x + ox, y + oy, line_color);
            double delta = ry * ry - rx * rx * (2 * ry + 1);
            double d;
            while (y >= 0) 
            {
                if (delta < 0)
                {
                    d = 2 * delta + rx * rx * (2 * y + 2);
                    x += 1;
                    if (d < 0)
                        delta += ry * ry * (2 * x + 1);
                    else
                    {
                        y -= 1;
                        delta += ry * ry * (2 * x + 1) + rx * rx * (1 - 2 * y);
                    }
                }
                else if (delta > 0)
                {
                    d = 2 * delta + ry * ry * (2 - 2 * x);
                    y -= 1;
                    if (d > 0)
                        delta += rx * rx * (1 - 2 * y);
                    else
                    {
                        x += 1;
                        delta += ry * ry * (2 * x + 1) + rx * rx * (1 - 2 * y);
                    }
                }
                else
                {
                    y -= 1;
                    x += 1;
                    delta += ry * (2 * x * 1) + rx * rx * (1 - 2 * y);
                }
                if (!just_time_measure)
                    add_simetric_pixels(x + ox, y + oy, line_color);
            }
        }
    }
}
