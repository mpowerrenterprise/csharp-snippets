﻿using System;
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
            Point[] points = { new Point(0, 20), new Point(0, 0), new Point(20, 0) };
            g.FillPolygon(so, points);

            //We can draw any shape in Polygon we must use Point.

        }
    }
}
