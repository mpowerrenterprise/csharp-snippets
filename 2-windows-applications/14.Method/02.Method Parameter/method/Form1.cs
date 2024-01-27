using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            displayMethod("click");

        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
           
            displayMethod("mouseover");
        }

        void displayMethod(string name) {


            MessageBox.Show("The action is "+name);

        }

        
    }
}
//method takes parameters values.
