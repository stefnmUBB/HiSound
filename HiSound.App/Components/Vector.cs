using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HiSound.App.Components
{
    public class Vector
    {
        public int X, Y;
        public Vector(int x=0,int y=0)
        {
            X = x; Y = y;
        }

        public Vector(Point p) : this(p.X,p.Y) { }
        
        public Vector(Point p1,Point p2) : this(p2.X-p1.X,p2.Y-p1.Y) { }

        public VectorF Norm => new VectorF(X / Length, Y / Length);

        public int Dot(Vector v) => X * v.X + Y * v.Y;

        public int Cross(Vector v) => X * v.Y - Y * v.X;

        public float Length { get => (float)Math.Sqrt(X*X+Y*Y); }

        public static float Angle(Vector v1,Vector v2)
        {            
            return (float)Math.Atan2(v1.Dot(v2),v1.Cross(v2));
        }

        public static implicit operator Point(Vector v) => new Point(v.X,v.Y);
        public static implicit operator VectorF(Vector v) => new VectorF(v.X,v.Y);

        public VectorF Add(VectorF v) => new VectorF(X + v.X, Y + v.Y);
        public Vector Add(Vector v) => new Vector(X + v.X, Y + v.Y);
    }
}
