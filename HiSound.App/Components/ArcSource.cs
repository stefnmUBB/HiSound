using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HiSound.App.Components
{
    public class ArcSource : Source
    {
        public ArcSource(Point position) : base(position) { }

        public float Orientation { get; set; } = 0;
        public float Range { get; set; } = 1;

        public override List<Particle> Trigger()
        {
            var l = new List<Particle>();
            float step = 0.01f + (1 - Accuracy) * 0.2f;
            var start = Orientation - Range / 2;
            var stop = Orientation + Range / 2;
            for (float a = start; a < stop; a += step)
                l.Add(new Particle(Position, a) { LifespanLossRate = ParticleLifeSpanLossRate, Source=this });
            return l;
        }
    }
}
