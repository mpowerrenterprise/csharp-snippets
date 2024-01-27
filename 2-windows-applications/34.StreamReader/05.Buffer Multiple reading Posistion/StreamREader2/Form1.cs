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

            OpenFileDialog openfileDia = new OpenFileDialog();

            if (openfileDia.ShowDialog() == DialogResult.OK) {

                StreamReader stream = new StreamReader(openfileDia.FileName);
                stream.BaseStream.Position = 4;//This is the position where to start read.
                byte[] buffer = new byte[3];
                stream.BaseStream.Read(buffer,0,3);

                foreach (byte item in buffer)
                {
                    textBox1.Text += item.ToString("X") + " ";
                    stream.Dispose();
                    
                    
                }


            }
            
        }
    }
}
