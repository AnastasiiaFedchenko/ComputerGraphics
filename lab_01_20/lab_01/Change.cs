using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01
{
    abstract public class Change
    {
        static public Form1 form;
    }
    public class MovePoint : Change
    {
        int dx, dy, iPoint;
        public MovePoint(int dx, int dy, int iPoint)
        {
            this.dx = dx;
            this.dy = dy;
            this.iPoint = iPoint;
        }
        public int IPoint
        {
            get { return iPoint; }
        }

        public int DX
        {
            set { this.dx = value; }
            get { return this.dx; }
        }
        public int DY
        {
            set { this.dy = value; }
            get { return this.dy; }
        }
    }
    public class MovePoints : Change
    {
        List<MovePoint> Points;
        public MovePoints(List<MovePoint> Points)
        {
            this.Points = new List<MovePoint>();
            for (int i = 0; i < Points.Count; i++)
            {
                this.Points.Add(Points[i]);
            }
        }
    }

}
