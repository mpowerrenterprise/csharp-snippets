using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using properName;

namespace proper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Myclass mc = new Myclass("Guna");
            mc.Name = "joker";
            MessageBox.Show(mc.Name);//I got this value from a getter.


        }
    }
}
