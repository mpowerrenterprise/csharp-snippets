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
            Pen pen = new Pen(Color.Green,3);// 3 is the thick of the pen tool.
            Graphics g = panel1.CreateGraphics();
            g.DrawRectangle(pen,20, 20, 50, 50);

            //unlike brash pen only draw the outline.

        }
    }
}
