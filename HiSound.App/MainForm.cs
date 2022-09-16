using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiSound.App.Components;

namespace HiSound.App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        bool editall = true;

        private void MainForm_Load(object sender, EventArgs e)
        {
        }                                          

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!editall) return;
            controlPanelToolStripMenuItem.Checked = toolsToolStripMenuItem.Checked = allToolStripMenuItem.Checked;
        }

        private void controlPanelToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            echoRoomControl1.ViewControlPanel = !controlPanelToolStripMenuItem.Checked;
            editall = false;
            if (!controlPanelToolStripMenuItem.Checked) allToolStripMenuItem.Checked = false;
            if (controlPanelToolStripMenuItem.Checked && toolsToolStripMenuItem.Checked)
                allToolStripMenuItem.Checked = true;
            editall = true;
        }

        private void toolsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            echoRoomControl1.ViewToolsPanel = toolsToolStripMenuItem.Checked;
            editall = false;
            if (!toolsToolStripMenuItem.Checked) allToolStripMenuItem.Checked = false;
            if (controlPanelToolStripMenuItem.Checked && toolsToolStripMenuItem.Checked)
                allToolStripMenuItem.Checked = true;
            editall = true;
        }

        string lastfilename = "";

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {            
            if(lastfilename!="")
            {
                echoRoomControl1.EchoRoomSystem.Save(lastfilename);
            }            
            else if(FSaver.ShowDialog()==DialogResult.OK)
            {
                echoRoomControl1.EchoRoomSystem.Save(FSaver.FileName);
                lastfilename = FSaver.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FLoader.ShowDialog() == DialogResult.OK)
            {
                echoRoomControl1.EchoRoomSystem = EchoRoomSystem.Load(FLoader.FileName);
                lastfilename = FLoader.FileName;
                echoRoomControl1.Invalidate();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FSaver.ShowDialog() == DialogResult.OK)
            {
                echoRoomControl1.EchoRoomSystem.Save(FSaver.FileName);
                lastfilename = FSaver.FileName;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastfilename = "";
            echoRoomControl1.EchoRoomSystem = new EchoRoomSystem();
            echoRoomControl1.Invalidate();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }
    }
}
