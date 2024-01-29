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

namespace Streamreader
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
                textBox1.Text = sr.ReadToEnd();
                sr.Dispose();//we need to close the streamReader after reading.
                
            }
            
        }
    }
}


//using System.IO; is the important class.
//StreamReader is the class for reading.