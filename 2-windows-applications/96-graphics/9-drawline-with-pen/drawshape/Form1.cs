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
            Pen pen = new Pen(Color.Red,2);
            Graphics g = panel1.CreateGraphics();
            g.DrawLine(pen,new Point(20,20),new Point(100,100));
            //starting and ending points.
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
