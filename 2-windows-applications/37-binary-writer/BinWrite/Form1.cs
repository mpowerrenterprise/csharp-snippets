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

namespace BinWrite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();

            if (o.ShowDialog() == DialogResult.OK) {

                path = o.FileName;
                button2.Enabled = true;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            BinaryWriter bw = new BinaryWriter(File.OpenWrite(path));
            bw.Write("C");//C will be written
            bw.Dispose();
        }
    }
}
