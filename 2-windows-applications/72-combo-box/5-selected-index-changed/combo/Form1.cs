﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//This will run when the user select diffrent items.
        {

            MessageBox.Show("Test");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
