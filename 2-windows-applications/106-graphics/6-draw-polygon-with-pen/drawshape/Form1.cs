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
            Pen pen = new Pen(Color.Red,4);// 4 is the thick of the pen tool.
            Graphics g = panel1.CreateGraphics();
            Point[] ponts = { new Point(0, 20), new Point(0, 0), new Point(20, 0) };
            g.DrawPolygon(pen,ponts);

            //unlike brash pen only draw the outline.
            //if we use pen need to use the word Draw.
            //But in brash we must use Fill.

        }
    }
}
