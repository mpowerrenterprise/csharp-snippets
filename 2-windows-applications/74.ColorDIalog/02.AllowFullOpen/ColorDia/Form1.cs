using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorDia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd=new ColorDialog();
            cd.AllowFullOpen = false;//User can't create custom colors.
            
            if (cd.ShowDialog() == DialogResult.OK) {

                button1.BackColor = cd.Color;

            }

        }
    }
}
