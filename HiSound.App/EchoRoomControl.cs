using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiSound.App.Components;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;

namespace HiSound.App
{
    public partial class EchoRoomControl: UserControl
    {
        private EchoRoomSystem _EchoRoomSystem = new EchoRoomSystem();
        public EchoRoomSystem EchoRoomSystem
        {
            get => _EchoRoomSystem;
            set
            {
                _EchoRoomSystem = value;
                UpdateWallsPanel();
                UpdateSourcesPanel();
                Workspace.Panel2Collapsed = true;
            }
        }
        bool relZoom = true;
        public EchoRoomControl()
        {            
            InitializeComponent();                                                                 
            UpdateSourcesPanel();
            UpdateWallsPanel();
            Canvas.MouseWheel += delegate (object o, MouseEventArgs e)
              {
                  Zoom += Math.Sign(e.Delta)*0.1f;
                  if (Zoom > 3) Zoom = 3f;
                  if (Zoom < 0.5f) Zoom = 0.5f;
                  relZoom = false;
                  ZoomTrackBar.Value = (int)(Zoom*10);
                  relZoom = true;
                  Invalidate();
              };

            var templateslist = typeof(EchoRoomSystem).GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(x => x.FieldType == typeof(EchoRoomSystem)).ToList();
            foreach(var t in templateslist)
            {
                var ers = (EchoRoomSystem)t.GetValue(null);
                var bmp = ers.ToBitmap(0.7f,5);
                var sz = Math.Max(bmp.Width,bmp.Height);
                var img = new Bitmap(sz, sz);
                Graphics.FromImage(img).DrawImageUnscaled(bmp,
                    new Point((sz-bmp.Width)/2,(sz-bmp.Height)/2));
                string caption = "";
                foreach(var s in ers.Sources)
                {
                    var ty = s.GetType();
                    caption += 
                        ty == typeof(CircularSource) ? "C " : 
                        ty == typeof(ArcSource) ? "A " : 
                        ty == typeof(ParallelBeamSource) ? "P " : "U ";
                }
                var finalbmp = new Bitmap(50, 50);
                Graphics.FromImage(finalbmp).DrawImage(img, 0, 0, 50, 50);
                Graphics.FromImage(finalbmp).DrawString(caption, Font, Brushes.Red, Point.Empty);
                var pic = new PictureBox();
                pic.Size = new Size(50, 50);                
                pic.Image = finalbmp;
                pic.Tag = ers;
                pic.Click += delegate (object o, EventArgs e)
                  {                      
                      EchoRoomSystem = EchoRoomSystem.Copy(pic.Tag as EchoRoomSystem);
                      Invalidate();
                  };
                if(ers.Tag!=null && (string)ers.Tag!="<br>")
                {
                    var label = new Label();
                    label.Text = (string)ers.Tag;
                    if(TemplatesList.Controls.Count>1)
                        TemplatesList.SetFlowBreak(TemplatesList.Controls[TemplatesList.Controls.Count - 1],true);
                    TemplatesList.Controls.Add(label);
                    //TemplatesList.SetFlowBreak(label, true);
                }
                TemplatesList.Controls.Add(pic);
                if (ers.Tag != null && (string)ers.Tag == "<br>") TemplatesList.SetFlowBreak(pic,true);
            }
        }

        public void Start()
        {
            Timer.Start();
        }

        int t = 0;

        private int _Period = 25;
        public int Period
        {
            get => _Period;
            set
            {
                _Period = value;
                //for (int i = 0; i < EchoRoomSystem.Sources.Count; i++)
                  //  EchoRoomSystem.Sources[i].Accuracy = value / 50f;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            t++;
            if(t>=Period)
            {
                t = 0;
                EchoRoomSystem.TriggerSources();
            }
            EchoRoomSystem.Render();            
            Canvas.Invalidate();
        }             
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        Bitmap _Image=new Bitmap(1,1);
        Bitmap Image
        {
            get => _Image;
            set
            {
                _Image = value;
                if (value.Height <= Canvas.Height)
                {
                    WVSB.Enabled = false;                    
                }
                else
                {
                    WVSB.Enabled = true;
                    WVSB.Minimum = Canvas.Height - value.Height-10;
                    WVSB.Maximum = -Canvas.Height + value.Height+10;
                    if (!vsdefined)
                    {
                        WVSB.Value = 0;
                        vsdefined = true;
                    }                  
                }

                if (value.Width <= Canvas.Width)
                {
                    WHSB.Enabled = false;
                }
                else
                {
                    WHSB.Enabled = true;
                    WHSB.Minimum = Canvas.Width - value.Width-10;
                    WHSB.Maximum = -Canvas.Width + value.Width+10;
                    if (!hsdefined)
                    {
                        WHSB.Value = 0;
                        hsdefined = true;
                    }
                }
            }
        }

        bool vsdefined = false, hsdefined=false;

        public float Zoom { get; set; } = 1;

        private void ZoomTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (!relZoom) return;
            Zoom = ZoomTrackBar.Value * 0.1f;
            if(!Timer.Enabled) Canvas.Invalidate();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!Timer.Enabled)
            {
                Workspace.Panel2Collapsed = true;
                StartButton.BackgroundImage = Properties.Resources.pause_icon;
                Timer.Start();                
            }
            else
            {
                Timer.Stop();
                StartButton.BackgroundImage = Properties.Resources.run_icon;
            }
        }

        private void WVSB_Scroll(object sender, ScrollEventArgs e)
        {
            if(!Timer.Enabled) Canvas.Invalidate();
        }

        private void WHSB_Scroll(object sender, ScrollEventArgs e)
        {
            if(!Timer.Enabled) Canvas.Invalidate();
        }

        private void PeriodTrackBar_Scroll(object sender, EventArgs e)
        {
            Period = PeriodTrackBar.Value;
            PropertyGrid.Invalidate();
        }    

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            var bmp = EchoRoomSystem.ToBitmap(Zoom);
            Image = new Bitmap(bmp);                      
            e.Graphics.DrawImageUnscaled(Image, new Point(
                (Canvas.Width - Image.Width) / 2 - WHSB.Value/2, 
                (Canvas.Height-Image.Height) / 2 - WVSB.Value/2));
        }

        private void UpdateSourcesPanel()
        {
            SourcesPanel.Controls.Clear();
            for (int i = 0; i < EchoRoomSystem.Sources.Count; i++) 
            {
                var item = new Button();
                item.Text = i.ToString();
                item.FlatStyle = FlatStyle.Flat;
                item.FlatAppearance.BorderColor = EchoRoomSystem.Sources[i].Color;
                var tt = new ToolTip();
                tt.SetToolTip(item, EchoRoomSystem.Sources[i].GetType().Name+" "+EchoRoomSystem.Sources[i].Position.ToString());
                int j = i;
                item.Click += delegate (object s, EventArgs e)
                  {                      
                      Workspace.Panel2Collapsed = false;
                      Timer.Enabled = false;
                      StartButton.BackgroundImage = Properties.Resources.run_icon;
                      PropertyGrid.SelectedObject = EchoRoomSystem.Sources[j];
                  };
                SourcesPanel.Controls.Add(item);

            }
        }

        private void CollapseButton_MouseHover(object sender, EventArgs e)
        {
            CollapseButton.BackColor = Color.FromArgb(100,100,100,100);
        }

        private void CollapseButton_MouseLeave(object sender, EventArgs e)
        {
            CollapseButton.BackColor = Color.Transparent;
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            Workspace.Panel2Collapsed = true;           
        }

        private void PropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {           
            if (PropertyGrid.SelectedObject.GetType().IsSubclassOf(typeof(Source)))
            {
                UpdateSourcesPanel();
            } else if (PropertyGrid.SelectedObject.GetType().Name=="Polygon" ||
                PropertyGrid.SelectedObject.GetType().IsSubclassOf(typeof(Polygon)))
            {
                UpdateWallsPanel();
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {          
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {            
            var obj = PropertyGrid.SelectedObject;
            if (obj == null) return;
            if (obj.GetType().IsSubclassOf(typeof(Source)))
            {
                EchoRoomSystem.Sources.Remove((Source)obj);
                UpdateSourcesPanel();
            }
            else if (obj.GetType().Name == "Polygon" ||
              PropertyGrid.SelectedObject.GetType().IsSubclassOf(typeof(Polygon)))
            {
                EchoRoomSystem.Walls.Remove((Polygon)obj);
                UpdateWallsPanel();            
            }
            PropertyGrid.SelectedObject = null;
            Workspace.Panel2Collapsed = true;            
        }

        private void WallAddButton_Click(object sender, EventArgs e)
        {
            EchoRoomSystem.Walls.Add(new Polygon(new Point[] { }));
            UpdateWallsPanel();
        }

        private void SourceAddButton_Click(object sender, EventArgs e)
        {
            SourceChose.Show(SourceAddButton,new Point(SourceAddButton.Width,0));
        }        
        private void CaptureButton_Click(object sender, EventArgs e)
        {
            string AppRoot = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var path = Path.Combine(AppRoot, "Captures");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            var bmp = new Bitmap(Canvas.Width, Canvas.Height);
            Canvas.DrawToBitmap(bmp,new Rectangle(0,0,Canvas.Width,Canvas.Height));
            bmp.Save(Path.Combine(path,DateTime.Now.Ticks.ToString()+".png"));
        }

        private void circularSourcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EchoRoomSystem.Sources.Add(new CircularSource(Point.Empty) { Active = false });
            UpdateSourcesPanel();
        }

        private void arcSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EchoRoomSystem.Sources.Add(new ArcSource(Point.Empty) { Active = false });
            UpdateSourcesPanel();
        }

        private void parallelBeamSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EchoRoomSystem.Sources.Add(new ParallelBeamSource(Point.Empty) { Active = false });
            UpdateSourcesPanel();
        }

        private void UpdateWallsPanel()
        {
            WallsPanel.Controls.Clear();
            for (int i = 0; i < EchoRoomSystem.Walls.Count; i++)
            {
                var item = new Button();
                item.Text = i.ToString();
                item.FlatStyle = FlatStyle.Flat;
                var tt = new ToolTip();
                //tt.SetToolTip(item, EchoRoomSystem.Sources[i].GetType().Name + " " + EchoRoomSystem.Sources[i].Position.ToString());
                int j = i;
                item.Click += delegate (object s, EventArgs e)
                {
                    Workspace.Panel2Collapsed = false;
                    Timer.Enabled = false;
                    StartButton.BackgroundImage = Properties.Resources.run_icon;
                    PropertyGrid.SelectedObject = EchoRoomSystem.Walls[j];
                };
                WallsPanel.Controls.Add(item);
            }
        }

        public bool ViewControlPanel
        {
            get => Body.Panel2Collapsed;
            set
            {
                Body.Panel2Collapsed = value;
                StatusStrip.Visible = !value;
            }
        }

        private void EchoRoomControl_Load(object sender, EventArgs e)
        {
            Workspace.Panel2Collapsed = true;
        }

        public bool ViewToolsPanel{ get => ToolsPanel.Visible; set => ToolsPanel.Visible = value; }
    }
}
