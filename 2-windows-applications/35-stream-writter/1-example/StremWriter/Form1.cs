﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StremWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path;

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK) {

                path = ofd.FileName;
                button2.Enabled = true;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            StreamWriter sw = new StreamWriter(File.OpenWrite(path));
            sw.Write(textBox1.Text);//we can also use writeLine()
            sw.Dispose();//closed.

        }

    }
}
