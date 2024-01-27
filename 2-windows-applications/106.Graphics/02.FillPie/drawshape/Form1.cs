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
            Graphics g = panel1.CreateGraphics();
            g.FillPie(so,20, 20, 50, 50, 0, 270);
            //20 20 are the cooridates.
            //50 50 are the width and height
            //pie is 360 deg.
            //0 is the starting angle means if we give 90 that will rotate 90 deg.
            //180 is sweep angle.




        }
    }
}
