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
            
            GraphicsPath gp = new GraphicsPath();
            Point[] Points = {new Point(20,20),new Point(20,70),new Point(70,20)};//points array for polygon.
            gp.AddPolygon(Points);// added a Polygon
            PathGradientBrush pgb = new PathGradientBrush(gp);
            pgb.CenterColor = Color.White;//                 This is the Center Color.
            pgb.SurroundColors = new Color[] { Color.Black };//This is the SurroundColors;
            Graphics g = panel1.CreateGraphics();
            g.FillPolygon(pgb, Points);
            
        }
    }
}
