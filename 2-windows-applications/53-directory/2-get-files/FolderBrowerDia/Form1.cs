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


namespace FolderBrowerDia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();

          
            fbd.Description = "Select a path";//Description.

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                //We get all files in the selected path and store in the files array.
                string[] files = Directory.GetFiles(fbd.SelectedPath);

                //Then we loop thorugh all files by using a for loop.
                foreach (string fNames in files) {

                    MessageBox.Show(fNames);
                }

            }

        }
    }
}
