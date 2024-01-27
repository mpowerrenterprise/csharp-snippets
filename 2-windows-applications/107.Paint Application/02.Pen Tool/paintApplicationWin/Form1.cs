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
            prevX = null;
            prevY = null;
        }

        int? prevX = null;//int? can be stroed null value.
        int? prevY = null;
        
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (canPaint) {//when the mouse is pressing down it would be true.

                Pen pen = new Pen(Color.Black, float.Parse(toolStripTextBox1.Text));//I have converted the size to float.
                g.DrawLine(pen,new Point(prevX ?? e.X, prevY ?? e.Y), new Point(e.X, e.Y));
                //if prevX or prevY has previous Coordiates that will start from there. and end at the current Coorinates.
                //or start from the current Coodinates.
                prevX = e.X;//after stop drawing here the coordinate will be stored
                prevY = e.Y;
                
            }
        }
    }
}


