using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using HiSound.App.Components;

namespace HiSound.App.Extensions
{
    public static class PointExtensions
    {
        public static float Distance(PointF p1,PointF p2)
        {
            float x = p1.X - p2.X, y = p1.Y - p2.Y;
            return (float)Math.Sqrt(x*x+y*y);
        }
        
        public static bool IsOnTheLine(this PointF p,PointF p1,PointF p2) => new VectorF(p1, p2).Cross(new VectorF(p1, p)) == 0;       
        public static bool IsOnTheSegment(this PointF p,PointF p1,PointF p2) => Math.Abs(Distance(p1, p2) - Distance(p1, p) - Distance(p, p2))<0.2f;        


        public static void Add(this PointF p, PointF q)
        {
            p.X += q.X;
            p.Y += q.Y;
        }

        public static PointF Mul(this Point p,float f)
        {
            return new PointF(p.X * f, p.Y * f);
        }

        public static float SquaredLength(this PointF p) => p.X * p.X + p.Y * p.Y;
    }
}
