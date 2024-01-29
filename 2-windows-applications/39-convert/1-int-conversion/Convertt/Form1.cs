using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int myInt= Convert.ToInt32(textBox1.Text);//By default textBoxes are string type.We convert the values that we get from the textBox into int32.                                         
           int total = myInt + 5;
            MessageBox.Show(total.ToString());//if we want to print out anything that is in the MSG box we have to convert into the String data type.

        }
    }
}
