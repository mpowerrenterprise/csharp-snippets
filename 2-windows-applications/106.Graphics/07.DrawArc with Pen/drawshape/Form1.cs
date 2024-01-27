using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawshape
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
             

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red,2);
            Graphics g = panel1.CreateGraphics();
            g.DrawArc(pen,20, 20, 100, 100, 0, 360);
            
            //360 is the full with of the arc/
            //20 20 are the coordinates.
            //100 100 are the width and height.
            //0 is the starting angle 
            //180 is the sweepAngle.

           

        }
    }
}
