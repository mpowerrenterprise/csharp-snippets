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

            SolidBrush so = new SolidBrush(Color.Blue);
            Graphics g =panel1.CreateGraphics();
            FontFamily ff = new FontFamily("Arial");//we have created a fontFamliy.
            System.Drawing.Font font = new System.Drawing.Font(ff, 50, FontStyle.Bold);
            g.DrawString("Guna", font,so,new PointF(20,20));

            
        }
    }
}
