using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiSound.App
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            Bitmap _image;            
            try
            {
                _image = new Icon(Icon, 50, 59).ToBitmap();
            }
            catch (ArgumentOutOfRangeException)
            {
                _image = Bitmap.FromHicon(new Icon(Icon, new Size(50, 50)).Handle);
            }
            pictureBox1.Image = _image;
        }
    }
}
