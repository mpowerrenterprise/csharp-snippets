using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitwse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            short myShort = ~3;//Invert Not opearator.
            MessageBox.Show(Convert.ToString(myShort, 2));//2 means converts into binary.

            //3 == 011==100
           //By default it will add 14 zeros before the answer
           //The 14 zeros will be 1 because it is not operator.
           //11 will be zero.

            
        }
    }
}
