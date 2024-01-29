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

namespace saveFileia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "TextFile |*.txt| Java File |*.java";
            sd.Title = "Save files";//This is the title.
            sd.FileName = "Guna";//Default text.

            if (sd.ShowDialog() == DialogResult.OK) {

                string path = sd.FileName;
                BinaryWriter bw = new BinaryWriter(File.Create(path));
                bw.Write("Example Text");
                bw.Dispose();
                
            }
        }
    }
}
