using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HiSound.App.Components
{
    public class CircularSource : Source
    {
        public CircularSource(Point position) : base(position) { }

        public override List<Particle> Trigger()
        {
            var l = new List<Particle>();
            float step = 0.01f + (1 - Accuracy) * 0.2f;
            for (float a = 0; a < (float)2 * Math.PI; a += step)
                l.Add(new Particle(Position, a) { LifespanLossRate = ParticleLifeSpanLossRate, Source=this });
            return l;
        }
    }
}
