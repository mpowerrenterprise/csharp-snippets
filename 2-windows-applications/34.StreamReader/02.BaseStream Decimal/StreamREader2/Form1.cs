using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StreamREader2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();


            if (ofd.ShowDialog() == DialogResult.OK) {

                StreamReader sr = new StreamReader(ofd.FileName);
                textBox1.Text = sr.BaseStream.ReadByte().ToString();
                
                //This will convert the string into decimal.
                //BaseStream only reads 1 char.

                 
                
            }
        }
    }
}
