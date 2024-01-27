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
            SolidBrush so = new SolidBrush(Color.Green); // i have created a solidBrush with green color.
            Graphics g = panel1.CreateGraphics();  // we have created an graphics in the panel.
            g.FillRectangle(so, 20, 20, 50, 50); //20 20 is the coordiates 50 50 is the width and height.

        }
    }
}
