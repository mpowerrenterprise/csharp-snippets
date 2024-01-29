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

                StreamReader sr = new StreamReader(openfileDia.FileName);
                char c = (char)sr.Peek();//we convert the peek value into char.
                char c1 = (char)sr.Peek(); //Peek does not change it's position.
                char c2=(char)sr.Read(); //We convert the read value into char.
                char c3 = (char)sr.Read();//Read does change it's position after it's reading.




                MessageBox.Show(c+" "+c1+" "+c2+" " +c3);


            }
            
        }
    }
}
