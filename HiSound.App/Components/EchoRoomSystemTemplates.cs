using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HiSound.App.Components
{
    public partial class EchoRoomSystem
    {
        public static EchoRoomSystem Triangle = new EchoRoomSystem("Triangle")
        {
            Walls = new List<Polygon>()
            {               
                Polygon.Regular(200,200,3,100,(float)Math.PI/2)
            },
            Sources=new List<Source>()
            {
                new CircularSource(new Point(200,200)) {Color=Color.HotPink, Accuracy=1, ParticleLifeSpanLossRate=1, Speed=1}
            },
            Tag="Regular Polygons:"
        };

        public static EchoRoomSystem Square = new EchoRoomSystem("Square")
        {
            Walls = new List<Polygon>()
            {                
                Polygon.Regular(200,200,4,100,(float)Math.PI/2)
            },
            Sources = new List<Source>()
            {
                new CircularSource(new Point(200,200)) {Color=Color.HotPink, Accuracy=1, ParticleLifeSpanLossRate=1, Speed=1}
            }
        };

        public static EchoRoomSystem Trapeze = new EchoRoomSystem("Trapeze")
        {
            Walls = new List<Polygon>()
            {
                new Polygon(new Point[]
                    {
                        new Point(271,129),
                        new Point(129,129),
                        new Point(70,271),
                        new Point(330,271)
                    })
            },
            Sources = new List<Source>()
            {
                new CircularSource(new Point(200,200)) {Color=Color.HotPink, Accuracy=1, ParticleLifeSpanLossRate=1, Speed=1}
            }
        };

        public static EchoRoomSystem Pentagon = new EchoRoomSystem("Pentagon")
        {
            Walls = new List<Polygon>()
            {
               Polygon.Regular(200,200,5,100,(float)Math.PI/2)
            },
            Sources = new List<Source>()
            {
                new CircularSource(new Point(200,200)) {Color=Color.HotPink, Accuracy=1, ParticleLifeSpanLossRate=1, Speed=1}
            }            
        };

        public static EchoRoomSystem Hexagon = new EchoRoomSystem("Hexagon")
        {
            Walls = new List<Polygon>()
            {
                Polygon.Regular(200,200,6,100,(float)Math.PI/2)
            },
            Sources = new List<Source>()
            {
                new CircularSource(new Point(200,200)) {Color=Color.HotPink, Accuracy=1, ParticleLifeSpanLossRate=1, Speed=1}
            },            
        };

        public static EchoRoomSystem Octogon = new EchoRoomSystem("Octogon")
        {
            Walls = new List<Polygon>()
            {
                Polygon.Regular(200,200,8,100,(float)Math.PI/2)
            },
            Sources = new List<Source>()
            {
                new CircularSource(new Point(200,200)) {Color=Color.HotPink, Accuracy=1, ParticleLifeSpanLossRate=1, Speed=1}
            },
            Tag="<br>"
        };

        public static EchoRoomSystem ParallelBeamDemo = new EchoRoomSystem("Parallel Beam")
        {
            Walls = new List<Polygon>()
                {
                    new Polygon(new Point[]
                    {
                        new Point(200,200),
                        new Point(200,400),
                        new Point(190,400),
                        new Point(190,200)
                    }),
                    new Polygon(new Point[]
                    {
                        new Point(100,200),
                        new Point(100,400),
                        new Point(90,400),
                        new Point(90,200)
                    })
                },
            Sources = new List<Source>()
                {
                    new ParallelBeamSource(new Point(150,250))
                    {
                        Accuracy=1,
                        ParticleLifeSpanLossRate=1,
                        Speed=1,
                        Color=Color.Blue,
                        Orientation=1
                    }
                },
            Tag = "Source type:"
        };

        public static EchoRoomSystem ArcSourceDemo = new EchoRoomSystem("Arc Source Demo")
        {
            Walls = new List<Polygon>()
                {
                    new Polygon(new Point[]
                    {
                        new Point(200,200),
                        new Point(200,400),
                        new Point(190,400),
                        new Point(190,200)
                    }),
                    new Polygon(new Point[]
                    {
                        new Point(100,200),
                        new Point(100,400),
                        new Point(90,400),
                        new Point(90,200)
                    })
                },
            Sources = new List<Source>()
                {
                    new ArcSource(new Point(150,250))
                    {
                        Accuracy=1,
                        ParticleLifeSpanLossRate=1,
                        Speed=1,
                        Color=Color.Purple,
                        Orientation=1,
                        Range=1
                    }
                },
            Tag = "<br>"
        };

        public static EchoRoomSystem ComplexSystem1 = new EchoRoomSystem("ComplexSystem1")
        {
            Walls = new List<Polygon>()
                {
                    Polygon.Rectangle(0, 0, 350, 350),
                    Polygon.Rectangle(50, 50, 100, 100),
                    Polygon.Rectangle(200, 50, 100, 100),
                    Polygon.Rectangle(50, 200, 100, 100),
                    Polygon.Rectangle(200, 200, 100, 100)
                },
            Sources = new List<Source>()
                {
                    new CircularSource(new Point(175, 175)) { Accuracy = 1f, ParticleLifeSpanLossRate = 1, Speed=1, Color = Color.Red }
                },
            Tag = "Complex systems:"
        };

        public static EchoRoomSystem ComplexSystem2 = new EchoRoomSystem("ComplexSystem2")
        {
            Walls = new List<Polygon>()
            {
                Polygon.Regular(200,200,6,100,(float)Math.PI/2),
                Polygon.Regular(200,200,6,50,(float)Math.PI/2)
            },
            Sources = new List<Source>()
                {
                    new CircularSource(new Point(200,135))
                    {
                        Accuracy=1,
                        ParticleLifeSpanLossRate=3,
                        Speed=1,
                        Color=Color.Purple
                    },
                    new CircularSource(new Point(257,230))
                    {
                        Accuracy=1,
                        ParticleLifeSpanLossRate=3,
                        Speed=1,
                        Color=Color.GreenYellow
                    },
                    new CircularSource(new Point(143,230))
                    {
                        Accuracy=1,
                        ParticleLifeSpanLossRate=3,
                        Speed=1,
                        Color=Color.Turquoise
                    }
                }
        };

        public static EchoRoomSystem Copy(EchoRoomSystem ers)
        {
            return new EchoRoomSystem(ers.Name)
            {
                Walls=ers.Walls,
                Sources=ers.Sources
            };
        }
    }
}
