﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorSs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Color c = Color.FromKnownColor(KnownColor.Bisque);
            MessageBox.Show(c.ToArgb().ToString("X"));

        }
    }
}
//This will returns the color in the byte format;