using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gotoAndRegin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int a = 0; a <= 1000; a++) {//It will not run 1000 times
                                             //when the first time the loop run it will goto the MyCode label

                goto myCode;
            }

            myCode: {//This is called a label code.


                MessageBox.Show("Jumped to this label");
                
            }
           
        }
    }
}
