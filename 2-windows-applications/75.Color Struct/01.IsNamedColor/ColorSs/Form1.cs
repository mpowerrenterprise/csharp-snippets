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

                if (c.IsNamedColor) {

                    MessageBox.Show(c.Name);
                }

            }

        }
    }
}
//The IsNamedColor returns weather the color has name or not.
