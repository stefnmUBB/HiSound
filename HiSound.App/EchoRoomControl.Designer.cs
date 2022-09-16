namespace HiSound.App
{
    partial class EchoRoomControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Body = new System.Windows.Forms.SplitContainer();
            this.Workspace = new System.Windows.Forms.SplitContainer();
            this.ToolsPanel = new System.Windows.Forms.Panel();
            this.CaptureButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.PContainer = new System.Windows.Forms.Panel();
            this.Canvas = new System.Windows.Forms.Panel();
            this.SBCorner = new System.Windows.Forms.Panel();
            this.WVSB = new System.Windows.Forms.VScrollBar();
            this.WHSB = new System.Windows.Forms.HScrollBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RemoveButton = new System.Windows.Forms.PictureBox();
            this.CollapseButton = new System.Windows.Forms.PictureBox();
            this.PropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TemplatesList = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SourceAddButton = new System.Windows.Forms.Button();
            this.WallAddButton = new System.Windows.Forms.Button();
            this.SourcesLabel = new System.Windows.Forms.Label();
            this.WallsLabel = new System.Windows.Forms.Label();
            this.SourcesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.WallsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PeriodTrackBar = new System.Windows.Forms.TrackBar();
            this.PeriodLabel = new System.Windows.Forms.Label();
            this.ZoomTrackBar = new System.Windows.Forms.TrackBar();
            this.ZoomLabel = new System.Windows.Forms.Label();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SourceChose = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.arcSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circularSourcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parallelBeamSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Body)).BeginInit();
            this.Body.Panel1.SuspendLayout();
            this.Body.Panel2.SuspendLayout();
            this.Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Workspace)).BeginInit();
            this.Workspace.Panel1.SuspendLayout();
            this.Workspace.Panel2.SuspendLayout();
            this.Workspace.SuspendLayout();
            this.ToolsPanel.SuspendLayout();
            this.PContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CollapseButton)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomTrackBar)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.SourceChose.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 25;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.Body.IsSplitterFixed = true;
            this.Body.Location = new System.Drawing.Point(0, 0);
            this.Body.Name = "Body";
            this.Body.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Body.Panel1
            // 
            this.Body.Panel1.Controls.Add(this.Workspace);
            // 
            // Body.Panel2
            // 
            this.Body.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Body.Panel2.Controls.Add(this.tabControl1);
            this.Body.Size = new System.Drawing.Size(800, 478);
            this.Body.SplitterDistance = 328;
            this.Body.TabIndex = 0;
            // 
            // Workspace
            // 
            this.Workspace.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Workspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Workspace.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.Workspace.Location = new System.Drawing.Point(0, 0);
            this.Workspace.Name = "Workspace";
            // 
            // Workspace.Panel1
            // 
            this.Workspace.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Workspace.Panel1.Controls.Add(this.ToolsPanel);
            this.Workspace.Panel1.Controls.Add(this.PContainer);
            this.Workspace.Panel1MinSize = 500;
            // 
            // Workspace.Panel2
            // 
            this.Workspace.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Workspace.Panel2.Controls.Add(this.panel2);
            this.Workspace.Panel2.Controls.Add(this.PropertyGrid);
            this.Workspace.Panel2MinSize = 150;
            this.Workspace.Size = new System.Drawing.Size(800, 328);
            this.Workspace.SplitterDistance = 640;
            this.Workspace.TabIndex = 0;
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ToolsPanel.Controls.Add(this.CaptureButton);
            this.ToolsPanel.Controls.Add(this.StartButton);
            this.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolsPanel.Location = new System.Drawing.Point(0, 304);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Size = new System.Drawing.Size(640, 24);
            this.ToolsPanel.TabIndex = 5;
            // 
            // CaptureButton
            // 
            this.CaptureButton.BackgroundImage = global::HiSound.App.Properties.Resources.img_icon;
            this.CaptureButton.FlatAppearance.BorderSize = 0;
            this.CaptureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CaptureButton.Location = new System.Drawing.Point(44, 3);
            this.CaptureButton.Name = "CaptureButton";
            this.CaptureButton.Size = new System.Drawing.Size(20, 20);
            this.CaptureButton.TabIndex = 1;
            this.CaptureButton.UseVisualStyleBackColor = true;
            this.CaptureButton.Click += new System.EventHandler(this.CaptureButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackgroundImage = global::HiSound.App.Properties.Resources.run_icon;
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Location = new System.Drawing.Point(18, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(20, 20);
            this.StartButton.TabIndex = 0;
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PContainer
            // 
            this.PContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PContainer.Controls.Add(this.Canvas);
            this.PContainer.Controls.Add(this.SBCorner);
            this.PContainer.Controls.Add(this.WVSB);
            this.PContainer.Controls.Add(this.WHSB);
            this.PContainer.Location = new System.Drawing.Point(16, 0);
            this.PContainer.Name = "PContainer";
            this.PContainer.Size = new System.Drawing.Size(608, 303);
            this.PContainer.TabIndex = 4;
            // 
            // Canvas
            // 
            this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Canvas.Location = new System.Drawing.Point(0, 0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(589, 284);
            this.Canvas.TabIndex = 3;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            // 
            // SBCorner
            // 
            this.SBCorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SBCorner.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SBCorner.Location = new System.Drawing.Point(589, 284);
            this.SBCorner.Name = "SBCorner";
            this.SBCorner.Size = new System.Drawing.Size(15, 15);
            this.SBCorner.TabIndex = 0;
            // 
            // WVSB
            // 
            this.WVSB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WVSB.Location = new System.Drawing.Point(589, 0);
            this.WVSB.Name = "WVSB";
            this.WVSB.Size = new System.Drawing.Size(15, 284);
            this.WVSB.TabIndex = 0;
            this.WVSB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.WVSB_Scroll);
            // 
            // WHSB
            // 
            this.WHSB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WHSB.Location = new System.Drawing.Point(0, 284);
            this.WHSB.Name = "WHSB";
            this.WHSB.Size = new System.Drawing.Size(589, 15);
            this.WHSB.TabIndex = 1;
            this.WHSB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.WHSB_Scroll);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.RemoveButton);
            this.panel2.Controls.Add(this.CollapseButton);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 26);
            this.panel2.TabIndex = 1;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Image = global::HiSound.App.Properties.Resources.remove_icon;
            this.RemoveButton.Location = new System.Drawing.Point(129, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(20, 20);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.TabStop = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // CollapseButton
            // 
            this.CollapseButton.Image = global::HiSound.App.Properties.Resources.right_arrow_circle;
            this.CollapseButton.Location = new System.Drawing.Point(3, 3);
            this.CollapseButton.Name = "CollapseButton";
            this.CollapseButton.Size = new System.Drawing.Size(20, 20);
            this.CollapseButton.TabIndex = 0;
            this.CollapseButton.TabStop = false;
            this.CollapseButton.Click += new System.EventHandler(this.CollapseButton_Click);
            this.CollapseButton.MouseLeave += new System.EventHandler(this.CollapseButton_MouseLeave);
            this.CollapseButton.MouseHover += new System.EventHandler(this.CollapseButton_MouseHover);
            // 
            // PropertyGrid
            // 
            this.PropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PropertyGrid.BackColor = System.Drawing.SystemColors.Info;
            this.PropertyGrid.CommandsBackColor = System.Drawing.SystemColors.Info;
            this.PropertyGrid.HelpBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PropertyGrid.HelpBorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.PropertyGrid.Location = new System.Drawing.Point(0, 3);
            this.PropertyGrid.Name = "PropertyGrid";
            this.PropertyGrid.Size = new System.Drawing.Size(152, 325);
            this.PropertyGrid.TabIndex = 0;
            this.PropertyGrid.ViewBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PropertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PropertyGrid_PropertyValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 146);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.TemplatesList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 120);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Templates";
            // 
            // TemplatesList
            // 
            this.TemplatesList.AutoScroll = true;
            this.TemplatesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TemplatesList.Location = new System.Drawing.Point(3, 3);
            this.TemplatesList.Name = "TemplatesList";
            this.TemplatesList.Size = new System.Drawing.Size(786, 114);
            this.TemplatesList.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SourceAddButton);
            this.tabPage2.Controls.Add(this.WallAddButton);
            this.tabPage2.Controls.Add(this.SourcesLabel);
            this.tabPage2.Controls.Add(this.WallsLabel);
            this.tabPage2.Controls.Add(this.SourcesPanel);
            this.tabPage2.Controls.Add(this.WallsPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 120);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Elements";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SourceAddButton
            // 
            this.SourceAddButton.FlatAppearance.BorderSize = 0;
            this.SourceAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SourceAddButton.Image = global::HiSound.App.Properties.Resources.add_button;
            this.SourceAddButton.Location = new System.Drawing.Point(63, 57);
            this.SourceAddButton.Name = "SourceAddButton";
            this.SourceAddButton.Size = new System.Drawing.Size(20, 20);
            this.SourceAddButton.TabIndex = 5;
            this.SourceAddButton.UseVisualStyleBackColor = true;
            this.SourceAddButton.Click += new System.EventHandler(this.SourceAddButton_Click);
            // 
            // WallAddButton
            // 
            this.WallAddButton.FlatAppearance.BorderSize = 0;
            this.WallAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WallAddButton.Image = global::HiSound.App.Properties.Resources.add_button;
            this.WallAddButton.Location = new System.Drawing.Point(63, 2);
            this.WallAddButton.Name = "WallAddButton";
            this.WallAddButton.Size = new System.Drawing.Size(20, 20);
            this.WallAddButton.TabIndex = 4;
            this.WallAddButton.UseVisualStyleBackColor = true;
            this.WallAddButton.Click += new System.EventHandler(this.WallAddButton_Click);
            // 
            // SourcesLabel
            // 
            this.SourcesLabel.AutoSize = true;
            this.SourcesLabel.Location = new System.Drawing.Point(11, 61);
            this.SourcesLabel.Name = "SourcesLabel";
            this.SourcesLabel.Size = new System.Drawing.Size(46, 13);
            this.SourcesLabel.TabIndex = 3;
            this.SourcesLabel.Text = "Sources";
            // 
            // WallsLabel
            // 
            this.WallsLabel.AutoSize = true;
            this.WallsLabel.Location = new System.Drawing.Point(24, 6);
            this.WallsLabel.Name = "WallsLabel";
            this.WallsLabel.Size = new System.Drawing.Size(33, 13);
            this.WallsLabel.TabIndex = 2;
            this.WallsLabel.Text = "Walls";
            // 
            // SourcesPanel
            // 
            this.SourcesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SourcesPanel.Location = new System.Drawing.Point(97, 61);
            this.SourcesPanel.Name = "SourcesPanel";
            this.SourcesPanel.Size = new System.Drawing.Size(689, 49);
            this.SourcesPanel.TabIndex = 1;
            // 
            // WallsPanel
            // 
            this.WallsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WallsPanel.Location = new System.Drawing.Point(97, 6);
            this.WallsPanel.Name = "WallsPanel";
            this.WallsPanel.Size = new System.Drawing.Size(689, 49);
            this.WallsPanel.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 120);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Options";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.PeriodTrackBar);
            this.panel1.Controls.Add(this.PeriodLabel);
            this.panel1.Controls.Add(this.ZoomTrackBar);
            this.panel1.Controls.Add(this.ZoomLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 114);
            this.panel1.TabIndex = 0;
            // 
            // PeriodTrackBar
            // 
            this.PeriodTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PeriodTrackBar.BackColor = System.Drawing.Color.White;
            this.PeriodTrackBar.Location = new System.Drawing.Point(43, 10);
            this.PeriodTrackBar.Maximum = 50;
            this.PeriodTrackBar.Minimum = 10;
            this.PeriodTrackBar.Name = "PeriodTrackBar";
            this.PeriodTrackBar.Size = new System.Drawing.Size(729, 45);
            this.PeriodTrackBar.TabIndex = 3;
            this.PeriodTrackBar.Value = 25;
            this.PeriodTrackBar.Scroll += new System.EventHandler(this.PeriodTrackBar_Scroll);
            // 
            // PeriodLabel
            // 
            this.PeriodLabel.AutoSize = true;
            this.PeriodLabel.Location = new System.Drawing.Point(3, 10);
            this.PeriodLabel.Name = "PeriodLabel";
            this.PeriodLabel.Size = new System.Drawing.Size(37, 13);
            this.PeriodLabel.TabIndex = 2;
            this.PeriodLabel.Text = "Period";
            // 
            // ZoomTrackBar
            // 
            this.ZoomTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZoomTrackBar.BackColor = System.Drawing.Color.White;
            this.ZoomTrackBar.Location = new System.Drawing.Point(43, 57);
            this.ZoomTrackBar.Maximum = 30;
            this.ZoomTrackBar.Minimum = 5;
            this.ZoomTrackBar.Name = "ZoomTrackBar";
            this.ZoomTrackBar.Size = new System.Drawing.Size(729, 45);
            this.ZoomTrackBar.TabIndex = 1;
            this.ZoomTrackBar.Value = 10;
            this.ZoomTrackBar.ValueChanged += new System.EventHandler(this.ZoomTrackBar_ValueChanged);
            // 
            // ZoomLabel
            // 
            this.ZoomLabel.AutoSize = true;
            this.ZoomLabel.Location = new System.Drawing.Point(3, 57);
            this.ZoomLabel.Name = "ZoomLabel";
            this.ZoomLabel.Size = new System.Drawing.Size(34, 13);
            this.ZoomLabel.TabIndex = 0;
            this.ZoomLabel.Text = "Zoom";
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel3});
            this.StatusStrip.Location = new System.Drawing.Point(0, 478);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(800, 22);
            this.StatusStrip.TabIndex = 1;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(261, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(261, 17);
            this.toolStripStatusLabel4.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(261, 17);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // SourceChose
            // 
            this.SourceChose.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SourceChose.DropShadowEnabled = false;
            this.SourceChose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arcSourceToolStripMenuItem,
            this.circularSourcToolStripMenuItem,
            this.parallelBeamSourceToolStripMenuItem});
            this.SourceChose.Name = "SourceChose";
            this.SourceChose.Size = new System.Drawing.Size(185, 70);
            // 
            // arcSourceToolStripMenuItem
            // 
            this.arcSourceToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.arcSourceToolStripMenuItem.Name = "arcSourceToolStripMenuItem";
            this.arcSourceToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.arcSourceToolStripMenuItem.Text = "Arc Source";
            this.arcSourceToolStripMenuItem.Click += new System.EventHandler(this.arcSourceToolStripMenuItem_Click);
            // 
            // circularSourcToolStripMenuItem
            // 
            this.circularSourcToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.circularSourcToolStripMenuItem.Name = "circularSourcToolStripMenuItem";
            this.circularSourcToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.circularSourcToolStripMenuItem.Text = "Circular Source";
            this.circularSourcToolStripMenuItem.Click += new System.EventHandler(this.circularSourcToolStripMenuItem_Click);
            // 
            // parallelBeamSourceToolStripMenuItem
            // 
            this.parallelBeamSourceToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.parallelBeamSourceToolStripMenuItem.Name = "parallelBeamSourceToolStripMenuItem";
            this.parallelBeamSourceToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.parallelBeamSourceToolStripMenuItem.Text = "Parallel Beam Source";
            this.parallelBeamSourceToolStripMenuItem.Click += new System.EventHandler(this.parallelBeamSourceToolStripMenuItem_Click);
            // 
            // EchoRoomControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.Body);
            this.Controls.Add(this.StatusStrip);
            this.Name = "EchoRoomControl";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.EchoRoomControl_Load);
            this.Body.Panel1.ResumeLayout(false);
            this.Body.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Body)).EndInit();
            this.Body.ResumeLayout(false);
            this.Workspace.Panel1.ResumeLayout(false);
            this.Workspace.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Workspace)).EndInit();
            this.Workspace.ResumeLayout(false);
            this.ToolsPanel.ResumeLayout(false);
            this.PContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RemoveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CollapseButton)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomTrackBar)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.SourceChose.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.SplitContainer Body;
        private System.Windows.Forms.SplitContainer Workspace;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label SourcesLabel;
        private System.Windows.Forms.Label WallsLabel;
        private System.Windows.Forms.FlowLayoutPanel SourcesPanel;
        private System.Windows.Forms.FlowLayoutPanel WallsPanel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar PeriodTrackBar;
        private System.Windows.Forms.Label PeriodLabel;
        private System.Windows.Forms.TrackBar ZoomTrackBar;
        private System.Windows.Forms.Label ZoomLabel;
        private System.Windows.Forms.PropertyGrid PropertyGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox CollapseButton;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.PictureBox RemoveButton;
        private System.Windows.Forms.Button SourceAddButton;
        private System.Windows.Forms.Button WallAddButton;
        private System.Windows.Forms.ContextMenuStrip SourceChose;
        private System.Windows.Forms.ToolStripMenuItem arcSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circularSourcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parallelBeamSourceToolStripMenuItem;
        private System.Windows.Forms.Panel ToolsPanel;
        private System.Windows.Forms.Button CaptureButton;
        private System.Windows.Forms.FlowLayoutPanel TemplatesList;
        private System.Windows.Forms.Panel PContainer;
        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.Panel SBCorner;
        private System.Windows.Forms.VScrollBar WVSB;
        private System.Windows.Forms.HScrollBar WHSB;
    }
}
