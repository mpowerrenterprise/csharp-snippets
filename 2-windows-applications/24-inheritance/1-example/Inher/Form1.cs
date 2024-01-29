using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InherName;

namespace Inher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Tringle t1 = new Tringle();
            t1.width = 5;
            t1.height = 2;
            t1.style = "isosceles";

            Tringle t2 = new Tringle();
            t2.width = 3;
            t2.height = 4;
            t2.style = "right";

            MessageBox.Show("Info for t1: ");
            t1.showDim();
            t1.showStyle();
            MessageBox.Show("Area for t1 " + t1.Area());

            MessageBox.Show("Info for t2: ");
            t2.showDim();
            t2.showStyle();
            MessageBox.Show("Area for t2 " + t2.Area());

        }
    }
}
