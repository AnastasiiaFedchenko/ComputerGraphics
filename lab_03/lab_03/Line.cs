using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_03
{
    public enum Method
    {
        DDA,
        B_float,
        B_int,
        B_smooth,
        Wu,
        Lib
    };
    public class point
    {
        Point p;
        Color color;
        public point(int x, int y, Color color)
        {
            this.p.X = x;
            this.p.Y = y;
            this.color = color;
        }
        public int X { get { return p.X; } set { p.X = value; } }
        public int Y { get { return p.Y; } set { p.Y = value; } }
        public Color Color { get { return color; } }
    }
    public class Line
    {
        int xs;
        int ys;
        int xf;
        int yf;
        Color line_color;
        Color background_color;
        List<point> points;
        //public delegate void method(ref int amount_of_steps, bool step_mode);
        //public delegate int Method(bool step_mode);
        public Line(int xs, int ys, int xf, int yf, Color line_color, Color background_color)
        {
            this.xs = xs;
            this.ys = ys;
            this.xf = xf;
            this.yf = yf;
            this.line_color = line_color;
            this.background_color = background_color;
            points = new List<point>();
        }

        public Color Background_color
        {
            get { return background_color; }
        }

        private void swap(ref int a, ref int b)
        {
            int temp = a; 
            a = b; 
            b = temp;
        }

        public void draw(Graphics g, int offset_x, int offset_y, int k)
        {
            Brush brush; 
            int temp_x, temp_y;
            for (int i = 0; i < points.Count; i++)
            {
                brush = new SolidBrush(points[i].Color);
                temp_x = (points[i].X * k) + offset_x; 
                temp_y = offset_y - (points[i].Y * k);
                g.FillRectangle(brush, temp_x - k, temp_y - k, k, k);
            }
        }
        public void draw_ordinary(Graphics g, int offset_x, int offset_y, int k)
        {
            Pen pen = new Pen(line_color);
            pen.Width = k;
            g.DrawLine(pen, (xs * k) + offset_x, offset_y - (ys * k), (xf * k) + offset_x, offset_y - (yf * k));
        }

        public int controller(Method method, bool step_mode) 
        {
            int res;
            if (method == Method.DDA)
                res = DDA(step_mode);
            else if (method == Method.B_float)
                res = bresenham_float(step_mode);
            else if (method == Method.B_int)
                res = bresenham_integer(step_mode);
            else if (method == Method.B_smooth)
                res = bresenham_without_gradation(step_mode);
            else if (method == Method.Wu)
                res = WU(step_mode);
            else
                res = 0;
            return res;
        }

        int sign(int a)
        {
            return (a >= 0) ? 1 : -1;
        }
        private int bresenham_float(bool step_mode) 
        {
            int amount_of_steps = 0;
            bool exchanged = false;
            if (xs == xf && ys == yf)
                points.Append(new point(xs, ys, line_color));
            else 
            {
                int dx = (xf - xs);
                int dy = (yf - ys);
                int sx = sign(dx);
                int sy = sign(dy);

                dx = Math.Abs(dx);
                dy = Math.Abs(dy);

                if (dy > dx) 
                {
                    swap(ref dx, ref dy);
                    exchanged = true;
                }
                double tan = ((double)dy) / dx;
                double e = tan - 0.5;
                int x = xs;
                int y = ys;

                int xb = xs;
                int yb = ys;
                amount_of_steps = 0;

                while(x != xf || y != yf) 
                {
                    points.Add(new point(x, y, line_color));
                    if (e >= 0)
                    {
                        if (exchanged)
                            x += sx;
                        else
                            y += sy;
                        e -= 1;
                    }
                    if (e <= 0) 
                    {
                        if (!exchanged)
                            x += sx;
                        else 
                            y += sy;
                        e += tan;
                    }
                    if (step_mode)
                    {
                        if (xb != x &&  yb != y)
                            amount_of_steps++;
                        xb = x;
                        yb = y;
                    }
                }
            }
            return amount_of_steps;
        }
        private int bresenham_integer(bool step_mode)
        {
            int amount_of_steps = 0;
            bool exchanged = false;
            if (xs == xf && ys == yf)
                points.Append(new point(xs, ys, line_color));
            else
            {
                int dx = (xf - xs);
                int dy = (yf - ys);
                int sx = sign(dx);
                int sy = sign(dy);

                dx = Math.Abs(dx);
                dy = Math.Abs(dy);

                if (dy > dx)
                {
                    swap(ref dx, ref dy);
                    exchanged = true;
                }
                double e = 2 * dy - dx;
                int x = xs;
                int y = ys;

                int xb = xs;
                int yb = ys;
                amount_of_steps = 0;

                while (x != xf || y != yf)
                {
                    points.Add(new point(x, y, line_color));
                    if (e >= 0)
                    {
                        if (exchanged)
                            x += sx;
                        else
                            y += sy;
                        e -= 2 * dx; // отличие 1
                    }
                    if (e <= 0)
                    {
                        if (!exchanged)
                            x += sx;
                        else
                            y += sy;
                        e += 2 * dy; // отличие 2
                    }
                    if (step_mode)
                    {
                        if (xb != x && yb != y)
                            amount_of_steps++;
                        xb = x;
                        yb = y;
                    }
                }
            }
            return amount_of_steps;
        }

        private List<Color> color_spectrum(int intensity) 
        {
            int r_line = line_color.R;
            int g_line = line_color.G;
            int b_line = line_color.B;
            int r_back = background_color.R;
            int g_back = background_color.G;
            int b_back = background_color.B;
            double r_step = (r_back - r_line) / intensity;
            double g_step = (g_back - g_line) / intensity;
            double b_step = (b_back - b_line) / intensity;
            List <Color> gradient = new List<Color>();
            int temp_r, temp_g, temp_b;
            for (int i = 0; i < intensity; i++) 
            {
                temp_r = (int)Math.Round(r_line + (r_step * i));
                temp_g = (int)Math.Round(g_line + (g_step * i));
                temp_b = (int)Math.Round(b_line + (b_step * i));

                gradient.Add(Color.FromArgb(temp_r, temp_g, temp_b));
            }
            gradient.Reverse();
            return gradient;
        }

        private int bresenham_without_gradation(bool step_mode) 
        {
            int intensity = 100;
            int amount_of_steps = 0;
            List<Color> gradient = color_spectrum(intensity);
            bool exchanged = false;
            int dx = (xf - xs);
            int dy = (yf - ys);
            int sx = sign(dx);
            int sy = sign(dy);

            dx = Math.Abs(dx);
            dy = Math.Abs(dy);
            if (dy > dx)
            {
                swap(ref dx, ref dy);
                exchanged = true;
            }
            double tan = ((double)dy) / dx * intensity;
            double e = intensity / 2; // начальная интенсивность
            double w = intensity - tan; // пороговое значение
            int x = xs;
            int y = ys;

            int xb = xs;
            int yb = ys;
            while(x != xf || y != yf) 
            {
                int intensity_in_point = (int)Math.Round(e) - 1;
                if (intensity_in_point < 0)
                    intensity_in_point = 0;
                else if (intensity_in_point >= 100)
                    intensity_in_point = 99;
                points.Add(new point(x, y, gradient[intensity_in_point]));
                if (e < w)
                {
                    if (!exchanged)
                        x += sx;
                    else
                        y += sy;
                    e += tan;
                }
                else
                {
                    x += sx;
                    y += sy;
                    e -= w;
                }
                if (step_mode) 
                {
                    if (xb != x && yb != y)
                        amount_of_steps++;
                    xb = x;
                    yb = y;
                }
            }
            return amount_of_steps;
        }

        private int DDA(bool step_mode) 
        {
            int amount_of_steps = 0;
            if (xs == xf && ys == yf)
                points.Add(new point(xs, ys, line_color));
            else
            {
                double dx = Math.Abs(xf - xs);
                double dy = Math.Abs(yf - ys);

                double length = (dx >= dy) ? dx : dy;

                dx = (xf - xs) / length;
                dy = (yf - ys) / length;

                double x = xs;
                double y = ys;
                for (int i = 0; i < length + 1; i++)
                {
                    if (!step_mode)
                        points.Add(new point((int)x, (int)y, line_color));
                    else if (Math.Round(x + dx) != Math.Round(x) &&
                        Math.Round(y + dy) != Math.Round(y))
                        amount_of_steps += 1;
                    x += dx;
                    y += dy;
                }
            }
            return amount_of_steps;
        }

        private int WU(bool step_mode)
        {
            int intensity = 100;
            int amount_of_steps = 0;
            List<Color> gradient = color_spectrum(intensity);
            if (xs == xf && ys == yf)
                points.Add(new point(xs, ys, gradient[99]));
            int dx = (xf - xs);
            int dy = (yf - ys);
            int sx = sign(dx);
            int sy = sign(dy);

            dx = Math.Abs(dx);
            dy = Math.Abs(dy);

            bool exchanged = false;
            if (dx < dy)
            {
                exchanged = true;
                swap(ref dx, ref dy);
                swap(ref sx, ref sy);
            }
            int x = (exchanged) ? ys : xs;
            double y = (exchanged) ? xs: ys;

            if (dx == 0 && dy == 0)
            {
                points.Add(new point(x, (int)y, line_color));
                amount_of_steps++;
            }
            double m = (double)dy / dx;
            int i = 0;
            int temp_x, temp_y;
            while(i < (dx + 1))
            {
                temp_x = x;
                temp_y = (int)Math.Round(y);
                if (exchanged)
                {
                    points.Add(new point(temp_y, temp_x, gradient[(int)((1 - Math.Abs(y -temp_y)) * 100) - 1]));
                    points.Add(new point(temp_y + 1, temp_x, gradient[(int)(Math.Abs(y - temp_y) * 100)]));
                }
                else
                {
                    points.Add(new point(temp_x, temp_y, gradient[(int)((1 - Math.Abs(y - temp_y)) * 100) - 1]));
                    points.Add(new point(temp_x, temp_y + 1, gradient[(int)(Math.Abs(y - temp_y) * 100)]));
                }
                if (Math.Round(y + m) > Math.Round(y))
                    amount_of_steps++;
                x += sx;
                y += sy * m;
                i++;
            }
            return amount_of_steps;
        }
    }
}
