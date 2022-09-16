using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HiSound.App.Components
{
    public class VectorF
    {
        public float X, Y;
        public VectorF(float x = 0, float y = 0)
        {
            X = x; Y = y;
        }

        public VectorF(PointF p) : this(p.X, p.Y) { }

        public VectorF(PointF p1, PointF p2) : this(p2.X - p1.X, p2.Y - p1.Y) { }

        public float Dot(VectorF v) => X * v.X + Y * v.Y;

        public float Cross(VectorF v) => X * v.Y - Y * v.X;

        public float Length { get => (float)Math.Sqrt(X * X + Y * Y); }

        public static float Angle(VectorF v1, VectorF v2)
        {
            var a=(float)Math.Atan2(v1.Cross(v2), v1.Dot(v2));
            return a >= 0 ? a : (float)(2*Math.PI + a); 
        }

        public static implicit operator PointF(VectorF v) => new PointF(v.X, v.Y);

        public VectorF Add(VectorF v) => new VectorF(X+v.X,Y+v.Y);

        public VectorF Norm => Length==0 ? new VectorF(0,0) : new VectorF(X/Length,Y/Length);

        public override string ToString()
        {
            return "("+X+","+Y+")";
        }
    }
}
