using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Substrin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string myStr = "My name is guna";
            string myNewStr = myStr.Substring(0, myStr.IndexOf(' '));//0 to space.
            MessageBox.Show(myNewStr);
        


        }
    }
}
