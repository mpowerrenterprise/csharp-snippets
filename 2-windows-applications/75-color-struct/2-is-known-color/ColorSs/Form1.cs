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

            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK) {

                Color c = cd.Color;

                if (c.IsKnownColor) {

                    MessageBox.Show(c.Name);
                }

            }

        }
    }
}
//IsNamedColor vs IsKnownColor
//IsKnownColor is colors which are used by windows such as scroll bar color and more.
