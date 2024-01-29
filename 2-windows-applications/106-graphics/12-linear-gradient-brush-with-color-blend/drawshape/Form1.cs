using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

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


            LinearGradientBrush lgb = new LinearGradientBrush(new Point(20,20),new Point(70,20),Color.Red,Color.Blue);
            Graphics g = panel1.CreateGraphics();
            ColorBlend cb = new ColorBlend();
            cb.Colors = new Color[]{Color.Black,Color.Blue,Color.SkyBlue,Color.White };//Colors for the Gradeint.
            cb.Positions = new float[] { 0, .33f , .66f, 1f };//Position for Colors.
            lgb.InterpolationColors = cb;
            g.FillRectangle(lgb,20,20,50,50);
            


            
        }
    }
}
