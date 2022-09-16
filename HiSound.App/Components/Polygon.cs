using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using HiSound.App.Extensions;

namespace HiSound.App.Components
{
    public class Polygon
    {
        public Polygon(Point[] pts)
        {
            Points = new List<Point>();
            Points.AddRange(pts);
        }
        public List<Point> Points { get; set; }

        public void Draw(Graphics g,Pen pen,Point Relative=default(Point), float Zoom=1)
        {
            var sz = Points.Count;
            for (int i = 0; i < sz - 1; i++)
                g.DrawLine(pen, Point.Add(Relative,new Size(Points[i])).Mul(Zoom), Point.Add(Relative,new Size(Points[i + 1])).Mul(Zoom));
            if(sz>1)
                g.DrawLine(pen,Point.Add(Relative,new Size(Points[0])).Mul(Zoom), Point.Add(Relative,new Size(Points[sz - 1])).Mul(Zoom));
        }

        public Rectangle GetBoundsRect()
        {
            Point mn = GetMinXY(), mx = GetMaxXY();
            return new Rectangle(mn.X,mn.Y,mx.X-mn.X,mx.Y-mn.Y);
        }

        public Point GetMaxXY()
        {
            int sz = Points.Count;
            int mxX = int.MinValue,mxY=int.MinValue;
            for (int i = 0; i < sz; i++)
            {               
                mxX = Math.Max(mxX, Points[i].X);                
                mxY = Math.Max(mxY, Points[i].Y);
            }
            return new Point(mxX,mxY);
        }

        public Point GetMinXY()
        {
            int sz = Points.Count;
            int mnX = int.MaxValue, mnY = int.MaxValue;
            for (int i = 0; i < sz; i++)
            {                
                mnX = Math.Min(mnX, Points[i].X);
                mnY = Math.Min(mnY, Points[i].Y);
            }           
            return new Point(mnX, mnY);
        }

        public static Polygon Rectangle(int x, int y, int width, int height)
            => new Polygon(new Point[] 
            {
                new Point(x,y),
                new Point(x+width,y),
                new Point(x+width,y+height),
                new Point(x,y+height)
            });        

        public static Polygon Regular(int x,int y,int no,int r,float angle)
        {
            var pts = new Point[no];
            float a = -angle,f=(float)(2*Math.PI/no);
            for(int i=0;i<no;i++)
            {
                int nx = (int)(r * Math.Cos(a));
                int ny = (int)(r * Math.Sin(a));
                a += f;
                pts[i] = new Point(x + nx, y + ny);
            }
            return new Polygon(pts);
        }
    }
}
