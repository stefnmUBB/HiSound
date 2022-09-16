using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Design;
using System.ComponentModel;
using System.Windows.Forms;

namespace HiSound.App.Components
{
    public class Source
    {
        [Description("Double click to change value.")]
        public bool Active { get; set; } = true;
        public Point Position;

        public Size Position_
        {
            get => new Size(Position.X,Position.Y);
            set => Position = new Point(value.Width, value.Height);
        }
        private float _Accuracy = 1;
        public float ParticleLifeSpanLossRate { get; set; } = 1f;
        public float Accuracy
        {
            get => _Accuracy;
            set => _Accuracy = value > 1 ? 1 : value < 0 ? 0 : value;
        }

        public Color Color { get; set; } = Color.Black;

        public float Speed { get; set; } = 1f;

        //public 
        public Source(Point position) { Position = position; }

        public virtual List<Particle> Trigger()
        {
            return new List<Particle>();
        }
    }  
}
