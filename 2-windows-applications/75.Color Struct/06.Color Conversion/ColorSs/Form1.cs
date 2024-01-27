using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorSs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Color c = Color.Red;
            int i = c.ToArgb();//This will convert the color into decimal format.
            Color b = Color.FromArgb(i);//here we convert the decimal color into color format.
            button1.BackColor = b;

        }
    }
}
//This will returns the color in the byte format;