using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using HiSound.App.Extensions;

namespace HiSound.App.Components
{
    public class Particle
    {
        public PointF Position;
        public VectorF Direction;        
        public float lifespan = 255;       
        public float LifespanLossRate { get; set; } = 0.5f;
        public Particle(PointF position, VectorF direction)
        {
            Position = position;
            Direction = direction.Norm;
        }

        public Particle(PointF position,float angle) : this(position,new VectorF((float)Math.Cos(angle), (float)Math.Sin(angle))) { }

        public bool IntersectsSegment(Point p1,Point p2,bool changeDirection=false)
        {
            if(Position.IsOnTheSegment(p1,p2))
            {
                if(changeDirection)
                {
                    var a = VectorF.Angle(new Vector(p2.X-p1.X,p2.Y-p1.Y),Direction);
                    var s = VectorF.Angle(new Vector(1,0),new Vector(p2.X-p1.X,p2.Y-p1.Y));                  
                    a = 2 * (float)Math.PI - a;
                    a += s;                 
                    Direction = new VectorF((float)Math.Cos(a),(float)Math.Sin(a));
                }
                return true;
            }
            return false;
        }

        public Source Source { get; set; }

        public bool Render()
        {
            var speed = Source==null ? 1f : Source.Speed;
            Position.X += Direction.X*speed;
            Position.Y += Direction.Y*speed;
            lifespan-=LifespanLossRate;
            return lifespan > 0;
        }
    }
}
