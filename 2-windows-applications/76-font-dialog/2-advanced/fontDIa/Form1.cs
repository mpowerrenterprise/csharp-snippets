using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fontDIa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FontDialog fd = new FontDialog();
            fd.MinSize = 10;//The minimum size of font size avaliable is 10.
            fd.MaxSize = 20;//The maximum size of font size avaliable is 20.
            fd.ShowColor = true;//Color is avaliable
            fd.ShowHelp = true;
            fd.HelpRequest += Fd_HelpRequest;

            if (fd.ShowDialog()==DialogResult.OK) {

                richTextBox1.Font = fd.Font;
                richTextBox1.ForeColor = fd.Color;//we must write this.
            }

        }

        private void Fd_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("You can select any color that you want.");
        }
    }
}
