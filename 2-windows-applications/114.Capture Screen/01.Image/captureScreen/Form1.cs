using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace captureScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            Graphics g = Graphics.FromImage(bit);
            g.CopyFromScreen(Point.Empty,Point.Empty ,Screen.PrimaryScreen.WorkingArea.Size);
            //PrimaryScreen is the screen without the taskbar
            //Point.empty means the starting and the ending points
            pictureBox1.Image = bit;
        }
    }
}
