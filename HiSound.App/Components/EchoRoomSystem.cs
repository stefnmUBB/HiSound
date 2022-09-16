using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using HiSound.App.Extensions;
using System.Windows.Forms;
using System.IO;

namespace HiSound.App.Components
{
    public partial class EchoRoomSystem
    {
        public object Tag = null;
        public List<Polygon> Walls=new List<Polygon>();
        public List<Particle> Particles=new List<Particle>();
        public List<Source> Sources=new List<Source>();
        public string Name;

        public EchoRoomSystem(string name="") { Name = name; }
    
        public void TriggerSource(int index)
        {            
            Particles.AddRange(Sources[index].Trigger());     
        }    
        
        public void TriggerSources()
        {
            int cnt = Sources.Count;
            for (int i = 0; i < cnt; i++) if(Sources[i].Active) TriggerSource(i);
        }       

        public void Render()
        {
            List<int> remind = new List<int>();
            int k = 0;
            foreach (Particle p in Particles)
            {                
                if (!p.Render())                
                    remind.Add(k);                
                k++;
            }
            k = 0;
            foreach (int i in remind) Particles.RemoveAt(i-(k++));
            remind.Clear();
            k = 0;
            foreach (Particle p in Particles)
            {
                bool ok = false;
                foreach (var wall in Walls)
                {
                    var sz = wall.Points.Count;
                    for (int i = 0; i < sz - 1 && !ok; i++)
                    {
                        if (PointF.Subtract(p.Position, new Size(wall.Points[i])).SquaredLength() < 4f ||
                           PointF.Subtract(p.Position, new Size(wall.Points[i])).SquaredLength() < 4f)
                            remind.Add(k);                        
                        ok = p.IntersectsSegment(wall.Points[i],wall.Points[i+1],true);
                    }
                    if (!ok && sz > 1) 
                        ok = p.IntersectsSegment(wall.Points[0], wall.Points[sz - 1], true);
                    if (ok) continue;
                }
                k++;               
            }
            k = 0;
            foreach (int i in remind)
            {
                Particles.RemoveAt(i - k);
                k++;
            }
        }

        public void Draw(Graphics g,Pen pen,Point Relative=default(Point), float Zoom=1)
        {            
            foreach (var wall in Walls)
                wall.Draw(g, pen, Relative,Zoom);
            foreach (var p in Particles)
                g.DrawEllipse(new Pen(Color.FromArgb((byte)p.lifespan,
                    p.Source==null?pen.Color:p.Source.Color),pen.Width),
                    (Relative.X+p.Position.X-0.5f)*Zoom,(Relative.Y+p.Position.Y-0.5f)*Zoom,1,1);
        }

        public Bitmap ToBitmap(float Zoom=1, float wallthickness=1)
        {                       
            if(Walls.Count==0)
            {
                if (Sources.Count == 0) return new Bitmap(100, 100);
                Point S = new Point(0, 0);
                int mnx=int.MaxValue, mxx=int.MinValue;
                int mny=int.MaxValue, mxy=int.MinValue;
                foreach(var src in Sources)
                {
                    S.X += src.Position.X;
                    S.Y += src.Position.Y;
                    mnx = Math.Min(mnx, src.Position.X);
                    mxx = Math.Max(mxx, src.Position.X);
                    mny = Math.Min(mny, src.Position.Y);
                    mxy = Math.Max(mxy, src.Position.Y);
                }
                S.X /= Sources.Count;
                S.Y /= Sources.Count;               
                Bitmap b;               
                b = new Bitmap(
                    Math.Max(100,(int)((mxx-mnx)*Zoom)),
                    Math.Max(100,(int)((mxy-mny)*Zoom)));                               
                Draw(Graphics.FromImage(b), new Pen(Color.Black,wallthickness), new Point(-mnx/2,-mny/2), Zoom);
                return b;
            }
            Point Mn=new Point(int.MaxValue,int.MaxValue), Mx=new Point(int.MinValue,int.MinValue);
            int nr0 = 0;
            foreach(var w in Walls)
            {
                if (w.Points.Count == 0) nr0++;
                var mn = w.GetMinXY();
                var mx = w.GetMaxXY();
                Mn.X = Math.Min(Mn.X, mn.X);
                Mn.Y = Math.Min(Mn.Y, mn.Y);
                Mx.X = Math.Max(Mx.X, mx.X);
                Mx.Y = Math.Max(Mx.Y, mx.Y);               
            }   
            if(nr0==Walls.Count)
            {
                Point S = new Point(0, 0);
                foreach (var src in Sources)
                {
                    S.X += src.Position.X;
                    S.Y += src.Position.Y;
                }
                S.X /= Sources.Count;
                S.Y /= Sources.Count;
                Bitmap b = new Bitmap(2 * S.X, 2 * S.Y);
                Draw(Graphics.FromImage(b), new Pen(Color.Black, wallthickness), new Point(0, 0), Zoom);
                return b;
            }
            Rectangle rect = new Rectangle((int)(Mn.X*Zoom),(int)(Mn.Y*Zoom),(int)((Mx.X-Mn.X)*Zoom),(int)((Mx.Y-Mn.Y)*Zoom));           
            Bitmap bmp = new Bitmap(Math.Max(100,rect.Width+10),Math.Max(100,rect.Height+10));
            Point rel = new Point(-Mn.X,-Mn.Y);
            Draw(Graphics.FromImage(bmp), new Pen(Color.Black, wallthickness), rel,Zoom);
            return bmp;
        }

        public void Save(string path)
        {
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
                {
                    writer.Write(Name);
                    writer.Write(Walls.Count);
                    foreach (var w in Walls)
                    {
                        writer.Write(w.Points.Count);
                        foreach (var p in w.Points)
                        {
                            writer.Write(p.X);
                            writer.Write(p.Y);
                        }
                    }
                    writer.Write(Sources.Count);
                    foreach (var s in Sources)
                    {
                        var ty = s.GetType();
                        char tc =
                            ty == typeof(ArcSource) ? 'A' :
                            ty == typeof(CircularSource) ? 'C' :
                            ty == typeof(ParallelBeamSource) ? 'P' : 'C';
                        writer.Write(tc);
                        writer.Write(s.Position.X);
                        writer.Write(s.Position.Y);
                        writer.Write(s.Accuracy);
                        writer.Write(s.Active);
                        writer.Write(s.Color.A);
                        writer.Write(s.Color.R);
                        writer.Write(s.Color.G);
                        writer.Write(s.Color.B);
                        writer.Write(s.ParticleLifeSpanLossRate);
                        writer.Write(s.Speed);
                        if (tc == 'A')
                        {
                            writer.Write(((ArcSource)s).Orientation);
                            writer.Write(((ArcSource)s).Range);
                        }
                        if (tc == 'P')
                        {
                            writer.Write(((ParallelBeamSource)s).Orientation);
                        }
                    }
                    writer.Close();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Something went wrong.");
            }
        }

        public static EchoRoomSystem Load(string path)
        {
            var ers = new EchoRoomSystem();
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    ers.Name=reader.ReadString();
                    int cnt = reader.ReadInt32();
                    for(int i=0;i<cnt;i++)
                    {
                        int pcnt = reader.ReadInt32();
                        var pts = new Point[pcnt];
                        for (int j = 0; j < pcnt; j++)
                            pts[j] = new Point(reader.ReadInt32(),reader.ReadInt32());
                        ers.Walls.Add(new Polygon(pts));
                    }
                    cnt = reader.ReadInt32();
                    for(int i=0;i<cnt;i++)
                    {
                        char c = reader.ReadChar();
                        Source s;
                        Point p = new Point(reader.ReadInt32(), reader.ReadInt32());
                        switch (c)
                        {
                            case 'A' : s = new ArcSource(p);  break;
                            case 'C' : s = new CircularSource(p);  break;
                            case 'P' : s = new ParallelBeamSource(p);  break;
                            default: s = new CircularSource(p); break;
                        }
                        s.Accuracy = reader.ReadSingle();
                        s.Active = reader.ReadBoolean();
                        s.Color = Color.FromArgb(reader.ReadByte(),reader.ReadByte(),reader.ReadByte(),reader.ReadByte());
                        s.ParticleLifeSpanLossRate = reader.ReadSingle();
                        s.Speed = reader.ReadSingle();
                        if (c == 'A')
                        {
                            ((ArcSource)s).Orientation = reader.ReadSingle();
                            ((ArcSource)s).Range = reader.ReadSingle();
                        }
                        if (c == 'P')
                        {
                            ((ParallelBeamSource)s).Orientation = reader.ReadSingle();
                        }
                        ers.Sources.Add(s);
                    }
                    reader.Close();
                    return ers;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Something went wrong.");
                return new EchoRoomSystem();
            }
        }
    }
}
