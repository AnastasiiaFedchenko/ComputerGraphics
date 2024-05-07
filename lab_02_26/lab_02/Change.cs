using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    public class Change
    {
        int ox1, oy1; // center of rotation
        double degrees; // the angle of rotation
        int dx, dy; // offsets for x and y
        int ox2, oy2; // center of the scaling
        double kx, ky; // scaling factors
        public Change(int ox1, int oy1, double degrees, int dx, int dy, int ox2, int oy2, double kx, double ky)
        {
            this.ox1 = ox1;
            this.oy1 = oy1;
            this.degrees = degrees;
            this.dx = dx;
            this.dy = dy;
            this.ox2 = ox2;
            this.oy2 = oy2;
            this.kx = kx;
            this.ky = ky;
        }
        public int Ox1 { get { return ox1; } set { ox1 = value; } }
        public int Oy1 { get { return oy1; } set { oy1 = value; } }
        public double Degrees { get { return degrees; } set { degrees = value; } }
        public int Dx { get { return dx; } set { dx = value; } }
        public int Dy { get { return dy; } set { dy = value; } }
        public int Ox2 { get { return ox2; } set { ox2 = value; } }
        public int Oy2 { get { return oy2; } set { oy2 = value; } }
        public double Kx { get { return kx; } set { kx = value; } }
        public double Ky { get { return ky; } set { ky = value; } }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

}
