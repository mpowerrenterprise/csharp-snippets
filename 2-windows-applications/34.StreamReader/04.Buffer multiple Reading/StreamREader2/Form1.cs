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
                byte[] buffer = new byte[3];//We have created a byte array.
                stream.BaseStream.Read(buffer,0,3);//We Store the value in the buffer array.

                foreach (byte item in buffer)//we loop the buffer array.
                {

                    textBox1.Text += item.ToString("X") + " ";
                    stream.Dispose();
                    //we convert them into HexDecimal.
                    //If we don't put X that will automatically converts into decimal.


                }


            }
            
        }
    }
}
