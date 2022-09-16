using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HiSound.App.Components
{
    public class ParallelBeamSource : Source
    {
        public ParallelBeamSource(Point position) : base(position) { }

        public float Orientation { get; set; } = 0;
        public float Range = 30;
        public override List<Particle> Trigger()
        {
            var l = new List<Particle>();
            float step = 0.05f + (1 - Accuracy) * 0.4f;
            var cos = (float)Math.Cos(Orientation+Math.PI/2);
            var sin = (float)Math.Sin(Orientation+Math.PI/2);
            for (float a = -Range; a < Range; a += step)
            {
                var pos = new PointF(Position.X+a*cos,Position.Y+a*sin);
                l.Add(new Particle(pos, Orientation) { LifespanLossRate = ParticleLifeSpanLossRate, Source=this });
            }
            return l;
        }
    }
}
