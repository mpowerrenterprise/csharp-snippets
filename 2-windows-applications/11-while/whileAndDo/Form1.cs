﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whileAndDo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] names = { "guna", "joker", "hacker", "maker", "doer" };

            int f = 0;

            while (f < names.Length) {

                MessageBox.Show(names[f]);
                f++;
            }

                

        }
    }
}
