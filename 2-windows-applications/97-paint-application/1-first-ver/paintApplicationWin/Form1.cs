using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paintApplicationWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();//we need to this all over the place.
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        bool canPaint = false;
        Graphics g;

        private void panel1_MouseDown(object sender, MouseEventArgs e)//When the user mouse is pressing down.
        {

            canPaint = true;//Set  to true.
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)//When the mouse is up
        {
            canPaint = false;//Set to false.
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (canPaint) {//when the mouse is pressing down it would be true.

                SolidBrush so = new SolidBrush(Color.Black);
                g.FillEllipse(so, e.X, e.Y, Convert.ToInt32(toolStripTextBox1.Text),Convert.ToInt32(toolStripTextBox1.Text));

                //e.Y and e.Y are the coordinates.That will change dynamically.
                //Then we convert the value form the toolStripTextBox1 to int.That is the size.



            }
        }
    }
}


//This is program draw a cricle everytime when the mouse is down 