﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifStae
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "guna" && checkBox1.Checked!=false) {


                MessageBox.Show("Oh Fine");

            }
            else
            {


                MessageBox.Show("Someting wrong");

            }
          
            
        }
    }
}
